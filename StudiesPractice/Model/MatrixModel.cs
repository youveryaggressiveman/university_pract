using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesPractice.Model
{
    public class MatrixModel
    {
        public string Size { get; set; }
        public ObservableCollection<MatrixCell> NumberList { get; set; }
        public decimal Result {  get; set; }
    }
}
