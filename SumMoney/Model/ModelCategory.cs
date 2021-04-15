using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMoney.Model
{
    public class ModelCategory : INPropertyChanged
    {
        private string Name_;
        public string Name
        {
            get { return Name_; }
            set { if (value != Name_) { Name_ = value; OnPropertyChanged("Name"); } }
        }
    }
}
