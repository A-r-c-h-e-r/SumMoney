using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SumMoney.Model
{
    public class VisibilityObj : INPropertyChanged
    {
        #region Data
        private Visibility visibility_;
        public Visibility Visibility_
        {
            get { return visibility_; }
            set { if (value != visibility_) { visibility_ = value; OnPropertyChanged("Visibility_"); } }
        }
        #endregion
    }
}
