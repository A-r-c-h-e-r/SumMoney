using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SumMoney.Model
{
    public class BackgroundButton : INPropertyChanged
    {
        #region Data
        private SolidColorBrush ObgBackground_;
        public SolidColorBrush ObgBackground
        {
            get { return ObgBackground_; }
            set { if (value != ObgBackground_) { ObgBackground_ = value; OnPropertyChanged("ObgBackground"); } }
        }
        #endregion
    }
}
