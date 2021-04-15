using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMoney.Model
{
    public class SourcePagesMenu : INPropertyChanged
    {
        #region DataSourcePages
        private string Source_ { get; set; }
        public string Source
        {
            get { return Source_; }
            set
            {
                if (Source_ != value)
                {
                    Source_ = value; OnPropertyChanged("Source");
                }
            }
        }
        #endregion
    }
}
