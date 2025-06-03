using StudiesPractice.Command;
using StudiesPractice.Core;
using StudiesPractice.View.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudiesPractice.ViewModel
{
    public class MainWindowViewModel: BaseViewModel
    {
        public ICommand Check { get; }
        public ICommand Calculate { get; }

        public MainWindowViewModel()
        {
            Check = new DelegateCommand(CheckCommand);
            Calculate = new DelegateCommand(CalculateCommand);
        }

        private void CalculateCommand(object obj)
        {
            FrameManager.SetSource(new CalculatePage());
        }

        private void CheckCommand(object obj)
        {
            FrameManager.SetSource(new ResultsPage());
        }
    }
}
