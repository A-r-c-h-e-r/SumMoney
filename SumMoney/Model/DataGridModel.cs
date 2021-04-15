using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMoney.Model
{
    public class DataGridModel :INPropertyChanged
    {
        private string ExpenseTile_, Category_, Type_, Payee_, Account_, Status_, DueDate_;
        private static string Created_, LastChange_, Tag_, Resourses_, Note_;
        private double PaidYTD_, LastPaid_, AmountPaid_;

        #region Data double
        public double PaidYTD
        {
            get { return PaidYTD_; }
            set { if (value != PaidYTD_) { PaidYTD_ = value; OnPropertyChanged("PaidYTD"); } }
        }

        public double LastPaid
        {
            get { return LastPaid_; }
            set { if (value != LastPaid_) { LastPaid_ = value; OnPropertyChanged("LastPaid"); } }
        }

        public double AmountPaid
        {
            get { return AmountPaid_; }
            set { if (value != AmountPaid_) { AmountPaid_ = value; OnPropertyChanged("AmountPaid"); } }
        }
        #endregion

        #region Data string
        public string ExpenseTile
        {
            get { return ExpenseTile_; }
            set { if (value != ExpenseTile_) { ExpenseTile_ = value; OnPropertyChanged("ExpenseTile"); } }
        }

        public string Category
        {
            get { return Category_; }
            set { if (value != Category_) { Category_ = value; OnPropertyChanged("Category"); } }
        }
        public string Type
        {
            get { return Type_; }
            set { if (value != Type_) { Type_ = value; OnPropertyChanged("Type"); } }
        }
        public string Payee
        {
            get { return Payee_; }
            set { if (value != Payee_) { Payee_ = value; OnPropertyChanged("Payee"); } }
        }
        public string Account
        {
            get { return Account_; }
            set { if (value != Account_) { Account_ = value; OnPropertyChanged("Account"); } }
        }
        public string Status
        {
            get { return Status_; }
            set { if (value != Status_) { Status_ = value; OnPropertyChanged("Status"); } }
        }
        public string DueDate
        {
            get { return DueDate_; }
            set { if (value != DueDate_) { DueDate_ = value; OnPropertyChanged("DueDate"); } }
        }

        public string Created
        {
            get { return Created_; }
            set { if (value != Created_) { Created_ = value; OnPropertyChanged("Created"); } }
        }
        public string LastChange
        {
            get { return LastChange_; }
            set { if (value != LastChange_) { LastChange_ = value; OnPropertyChanged("LastChange"); } }
        }
        public string Tag
        {
            get { return Tag_; }
            set { if (value != Tag_) { Tag_ = value; OnPropertyChanged("Tag_"); } }
        }
        public string Resourses
        {
            get { return Resourses_; }
            set { if (value != Resourses_) { Resourses_ = value; OnPropertyChanged("Resourses_"); } }
        }
        public string Note
        {
            get { return Note_; }
            set { if (value != Note_) { Note_ = value; OnPropertyChanged("Note"); } }
        }
        #endregion

        #region Construct
        public DataGridModel(string ExpenseTile, string Category, string Type, string Payee, string Account, string Status, double PaidYTD, double LastPaid, double AmountPaid, string DueDate)
        {
            this.ExpenseTile = ExpenseTile;
            this.Category = Category;
            this.Type = Type;
            this.Account = Account;
            this.Payee = Payee;
            this.Status = Status;
            this.DueDate = DueDate;
            this.PaidYTD = PaidYTD;
            this.LastPaid = LastPaid;
            this.AmountPaid = AmountPaid;
        }
        #endregion
    }
}
