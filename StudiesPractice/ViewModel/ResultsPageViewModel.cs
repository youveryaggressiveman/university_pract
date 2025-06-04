using HandyControl.Controls;
using StudiesPractice.Core;
using StudiesPractice.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesPractice.ViewModel
{
    public class ResultsPageViewModel: BaseViewModel
    {
        private readonly FileManager _fileManager;

        private ObservableCollection<MatrixModel> _matrixList;
        public ObservableCollection<MatrixModel> MatrixList
        {
            get => _matrixList;
            set
            {
                _matrixList = value;
                OnPropertyChanged(nameof(MatrixList));
            }
        }

        public ResultsPageViewModel()
        {
            _fileManager = new();

            MatrixList = new();

            LoadData();
        }

        private async void LoadData()
        {
            try
            {
                var matrixList = await _fileManager.ReadFile("Results");

                if (!string.IsNullOrEmpty(matrixList))
                {
                    var splitedData = matrixList.Split("\r\n");
                    splitedData = splitedData.Take(splitedData.Length - 1).ToArray();

                    foreach (var matrix in splitedData)
                    {
                        var splitedMatrix = matrix.Split(", ");

                        var splitedNumber = splitedMatrix[1].Split("$");
                        splitedNumber = splitedNumber.Take(splitedNumber.Length - 1).ToArray();

                        var fullMatrix = new MatrixModel()
                        {
                            Size = splitedMatrix[0],
                            NumberList = new(),
                            Result = decimal.Parse(splitedMatrix[2])
                        };

                        foreach (var value in splitedNumber)
                        {
                            fullMatrix.NumberList.Add(new MatrixCell()
                            {
                                Value = value,
                            });
                        }

                        MatrixList.Add(fullMatrix);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Error("При загрузке данных произошла ошибка.");
            }
        }
    }
}
