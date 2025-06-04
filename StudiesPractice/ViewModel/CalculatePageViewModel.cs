
using StudiesPractice.Command;
using StudiesPractice.Core;
using StudiesPractice.Core.Storage;
using StudiesPractice.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace StudiesPractice.ViewModel
{
    public class CalculatePageViewModel: BaseViewModel
    {
        private readonly MatrixCalculate _matrixCalculate;
        private readonly FileManager _fileManger;

        private ObservableCollection<string> _sizeList;
        public ObservableCollection<string> SizeList
        {
            get => _sizeList;
            set
            {
                _sizeList = value;
                OnPropertyChanged(nameof(SizeList));
            }
        }

        private string _selectedSize;
        public string SelectedSize
        {
            get => _selectedSize;
            set
            {
                _selectedSize = value;
                OnPropertyChanged(nameof(SelectedSize));

                if (_selectedSize != null)
                {
                    UpdateMatrix();
                }
            }
        }

        private MatrixModel _matrix;
        public MatrixModel Matrix
        {
            get => _matrix;
            set
            {
                _matrix = value;
                OnPropertyChanged(nameof(Matrix));
            }
        }

        public ICommand Calculate { get; }
        public ICommand Save { get; }

        public CalculatePageViewModel()
        {
            _matrixCalculate = new();
            _fileManger = new();

            SizeList = new();
            Matrix = new();

            LocalStorageSingleton.LocalStorage.ForEach(SizeList.Add);

            Calculate = new DelegateCommand(CalculateCommand);
            Save = new DelegateCommand(SaveCommand);
        }

        private async void SaveCommand(object obj)
        {
            if (Matrix.NumberList == null || Matrix.NumberList.All(cell => string.IsNullOrEmpty(cell.Value)))
            {
                MessageBox.Show("Заполните или расчитайте данные корректно.", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Matrix.Result == 0)
            {
                var result = MessageBox.Show(
                    "Результат вычислений равен 0. Вы уверены, что хотите сохранить этот результат?",
                    "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question
                );

                if (result != MessageBoxResult.Yes)
                    return;
            }

            var data = $"{Matrix.Size}, ";
            foreach (var value in Matrix.NumberList)
            {
                data += $"{value.Value}$";
            }
            data += $", {Matrix.Result}";

            try
            {
                await _fileManger.WriteFile("Results", data);
            }
            catch (Exception)
            {
                MessageBox.Show("При сохранении данных произошла ошибка.", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void UpdateMatrix()
        {
            if (string.IsNullOrEmpty(SelectedSize)) return;

            var parts = SelectedSize.Split('x');
            int size = int.Parse(parts[0]);

            Matrix.Size = SelectedSize;
            Matrix.Result = 0;

            Matrix.NumberList = new ObservableCollection<MatrixCell>(Enumerable.Range(0, size * size)
              .Select(matrixCell => new MatrixCell()));

            OnPropertyChanged(nameof(Matrix));

            GC.Collect();
        }

        private void CalculateCommand(object obj)
        {
            if (Matrix?.NumberList == null || string.IsNullOrEmpty(Matrix.Size))
                return;

            var parts = Matrix.Size.Split('x');
            int size = int.Parse(parts[0]);

            decimal[,] matrix2D = new decimal[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    var cell = Matrix.NumberList[i * size + j];
                    if (decimal.TryParse(cell.Value, out var val))
                    {
                        matrix2D[i, j] = val;
                    }
                    else
                    {
                        matrix2D[i, j] = 0;
                    }
                }
            }

            Matrix.Result = _matrixCalculate.CalculateDeterminant(matrix2D);
            OnPropertyChanged(nameof(Matrix));
        }
    }
}
