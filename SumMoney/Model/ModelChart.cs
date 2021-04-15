using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMoney.Model
{
    public class ModelChart : INPropertyChanged
    {
        #region Data
        private string Date_;
        public string Date
        {
            get { return Date_; }
            set { if (value != Date_) { Date_ = value; OnPropertyChanged("Date"); } }
        }

        private int Value_;
        public int Value
        {
            get { return Value_; }
            set { if (value != Value_) { Value_ = value; OnPropertyChanged("Value"); } }
        }
        #endregion
    }
}
