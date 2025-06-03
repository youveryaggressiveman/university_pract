using StudiesPractice.Command;
using StudiesPractice.Core;
using StudiesPractice.Core.Storage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudiesPractice.ViewModel
{
    public class CalculatePageViewModel: BaseViewModel
    {
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
            }
        }

        private decimal _result;
        public decimal Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        public ICommand Calculate { get; }

        public CalculatePageViewModel()
        {
            _fileManger = new();

            SizeList = new();

            LocalStorageSingleton.LocalStorage.ForEach(SizeList.Add);

            Calculate = new DelegateCommand(CalculateCommand);
        }

        private void CalculateCommand(object obj)
        {
            
        }
    }
}
