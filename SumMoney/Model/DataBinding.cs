using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMoney.Model
{
    public class DataBinding : INPropertyChanged
    {
        #region Data
        private double PastDoe_, Schedules_, Pending_, Paid_, Available_, Essential_, Important_, Discretionary_, Sum1_, Sum2_;
        private string Quater_;
        private int QuaterValue_;

        public double PastDoe
        {
            get { return PastDoe_; }
            set { if (value != PastDoe_) { PastDoe_ = value; OnPropertyChanged("PastDoe"); } }
        }
        
        public double Schedules
        {
            get { return Schedules_; }
            set { if (value != Schedules_) { Schedules_ = value; OnPropertyChanged("Schedules"); } }
        }
 
        public double Pending
        {
            get { return Pending_; }
            set { if (value != Pending_) { Pending_ = value; OnPropertyChanged("Pending"); } }
        }
        
        public double Paid
        {
            get { return Paid_; }
            set { if (value != Paid_) { Paid_ = value; OnPropertyChanged("Paid"); } }
        }
       
        public double Available
        {
            get { return Available_; }
            set { if (value != Available_) { Available_ = value; OnPropertyChanged("Available"); } }
        }
       
        public double Essential
        {
            get { return Essential_; }
            set { if (value != Essential_) { Essential_ = value; OnPropertyChanged("Essential"); } }
        }
        
        public double Important
        {
            get { return Important_; }
            set { if (value != Important_) { Important_ = value; OnPropertyChanged("Important"); } }
        }

        public double Discretionary
        {
            get { return Discretionary_; }
            set { if (value != Discretionary_) { Discretionary_ = value; OnPropertyChanged("Discretionary"); } }
        }
        
        public double Sum1
        {
            get { return Sum1_; }
            set { if (value != Sum1_) { Sum1_ = value; OnPropertyChanged("Sum1"); } }
        }

        public double Sum2
        {
            get { return Sum2_; }
            set { if (value != Sum2_) { Sum2_ = value; OnPropertyChanged("Sum2"); } }
        }
       
        public string Quater
        {
            get { return Quater_; }
            set { if (value != Quater_) { Quater_ = value; OnPropertyChanged("Quater"); } }
        }

        public int QuaterValue
        {
            get { return QuaterValue_; }
            set { if (value != QuaterValue_) { QuaterValue_ = value; OnPropertyChanged("QuaterValue"); } }
        }
        #endregion
    }
}
