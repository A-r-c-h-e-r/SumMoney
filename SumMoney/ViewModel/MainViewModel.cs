using SumMoney.Model;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Utility;
using Syncfusion.Windows.Tools.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace SumMoney.ViewModel
{
    public class MainViewModel : INPropertyChanged
    {

        #region Readonly
        private static readonly string[] NameButtonsMenu = { "Account", "Calendar", "Expenses", "Income", "Overview", "Settings" };
        public static string[] NameTokenButtonAdv { get; set; } = { "Income", "Expenses", "Expenses-internal", "Debt", "Taxes", "Regular texes" };
        public static string[] NameTagsButtonAdv { get; set; } = { "Expenses-External", "Expenses-Detail", "Income-Detail"};
        public static string BackgroundActive = "#6ACB73", BackgroundNotActive = "#E1E5EE";
        private static Random random = new Random();
        #endregion

        #region Data
        public static SourcePagesMenu SourcePagesMenu_ { get; set; }
        public static List<ModelChart>[] Chart { get; set; }
        public static List<VisibilityObj> visibilityObj { get; set; }
        public static List<BackgroundButton> ObjBackground_ { get; set; }
        public static List<DataGridModel> DataGridModel_ { get; set; }
        public static DataBinding DataBinding_ { get; set; }

        private static string SearchText_ { get; set; }
        public static string SearchText
        {
            get { return SearchText_; }
            set { if (SearchText_ != value) { SearchText_ = value; } }
        }

        private static List<string> Inquiry_;
        public static List<string> Inquiry
        {
            get { return Inquiry_; }
            set { Inquiry_ = value; }
        }

        private static List<ModelCategory> dropDownItems;
        public static List<ModelCategory> DropDownItems
        {
            get { return dropDownItems; }
            set { dropDownItems = value; }
        }
        #endregion

        #region Events
        private Command ClickButtonPage_;
        public Command ClickButtonPage =>
            ClickButtonPage_ ??= new Command(obj => { CommandPageSource(obj); });

        private Command ButtonAdvCloseMouseUp_;
        public Command ButtonAdvCloseMouseUp =>
            ButtonAdvCloseMouseUp_ ??= new Command(obj => { CommandButtonAdvCloseMouseUp(obj); });

        private Command SetBorderColor_;
        public Command SetBorderColor =>
            SetBorderColor_ ??= new Command(obj => { CommandSetBorderColor(obj); });

        private Command ClickButtonSearch_;
        public Command ClickButtonSearch =>
            ClickButtonSearch_ ??= new Command(obj => { AddInquiry(); });

        private Command AddTokenButtonAdvMouseUp_;
        public Command AddTokenButtonAdvMouseUp =>
            AddTokenButtonAdvMouseUp_ ??= new Command(obj => { CommandAddTokenButtonAdvMouseUp(); });

        private Command ImageButton_;
        public Command ImageButton =>
            ImageButton_ ??= new Command(obj => { CommandImageButton(obj); });

        #endregion

        #region Constructor
        static MainViewModel()
        {
            SourcePagesMenu_ = new SourcePagesMenu { Source = "Menu/Expenses.xaml" };
            Inquiry = new List<string>();
            Chart = new List<ModelChart>[4];
            SetRandomArrayChart();

            visibilityObj = new List<VisibilityObj>();
            SetVisibilityObj(6);

            InitializationNewObjBackground();

            InitializationNewDataBinding_();

            DropDownItems = new List<ModelCategory>();
            DropDownItems.Add(new ModelCategory { Name = "First" });
            DropDownItems.Add(new ModelCategory { Name = "Second" });
            DropDownItems.Add(new ModelCategory { Name = "Third" });

            DataGridModel_ = new List<DataGridModel>();
            InitializationDataGridModel();
        }
        #endregion


        #region Methods

        private static void InitializationDataGridModel()
        {
            DataGridModel_.Add(new DataGridModel("Quide Books", "Airfare", "Important", "Conie Masu", "Getsj Lsud","Pandong", GetRandomDouble(random, 0, 999.99), GetRandomDouble(random, 0, 999.99), GetRandomDouble(random, 0, 999.99), "12-11-2021"));
            DataGridModel_.Add(new DataGridModel("Quide Books", "Airfare", "Discretionary", "Nukura Masdd", "Nukura Esds", "Paid", GetRandomDouble(random, 0, 999.99), GetRandomDouble(random, 0, 999.99), GetRandomDouble(random, 0, 999.99), "12-6-2021"));
            DataGridModel_.Add(new DataGridModel("Quide Books", "Airfare", "Paid", "Ussd Opdks", "Datu Addew", "Planned",  GetRandomDouble(random, 0, 999.99), GetRandomDouble(random, 0, 999.99), GetRandomDouble(random, 0, 999.99), "12-11-2021"));
            DataGridModel_.Add(new DataGridModel("Quide Books", "Airfare", "Paid", "Osjsd Ojekn", "Datu Addew", "Liss", GetRandomDouble(random, 0, 999.99), GetRandomDouble(random, 0, 999.99), GetRandomDouble(random, 0, 999.99), "12-12-2021"));
            DataGridModel_.Add(new DataGridModel("Quide Books", "Airfare", "Discretionary", "Pisoj Lsdsd", "Jslpkl Addew", "Paid",GetRandomDouble(random, 0, 999.99), GetRandomDouble(random, 0, 999.99), GetRandomDouble(random, 0, 999.99), "12-13-2021"));
            DataGridModel_.Add(new DataGridModel("Quide Books", "Airfare", "Paid", "Dssdfe Iyuss", "Datu Addew", "Pandong", GetRandomDouble(random, 0, 999.99), GetRandomDouble(random, 0, 999.99), GetRandomDouble(random, 0, 999.99), "12-17-2021"));
            DataGridModel_.Add(new DataGridModel("Quide Books", "Airfare", "Important", "Klujsd Pskd", "Llkl Gsjd", "Paid", GetRandomDouble(random, 0, 999.99), GetRandomDouble(random, 0, 999.99), GetRandomDouble(random, 0, 999.99), "12-12-2021"));
            DataGridModel_.Add(new DataGridModel("Quide Books", "Airfare", "Paid", "Pklsd Uhdl", "Datu Addew", "Planned", GetRandomDouble(random, 0, 999.99), GetRandomDouble(random, 0, 999.99), GetRandomDouble(random, 0, 999.99), "12-11-2021"));
            DataGridModel_.Add(new DataGridModel("Quide Books", "Airfare", "Important", "Dhjhc Ojds", "Datu Osj", "Planned", GetRandomDouble(random, 0, 999.99), GetRandomDouble(random, 0, 999.99), GetRandomDouble(random, 0, 999.99), "12-11-2021"));
            DataGridModel_.Add(new DataGridModel("Quide Books", "Airfare", "Important", "Datu Cete", "Sddf Addew", "Paid", GetRandomDouble(random, 0, 999.99), GetRandomDouble(random, 0, 999.99), GetRandomDouble(random, 0, 999.99), "12-07-2021"));
            DataGridModel_.Add(new DataGridModel("Quide Books", "Airfare", "Important", "Pksa Pod", "Datu Addew", "Planned",GetRandomDouble(random, 0, 999.99), GetRandomDouble(random, 0, 999.99), GetRandomDouble(random, 0, 999.99), "12-01-2021"));
            DataGridModel_.Add(new DataGridModel("Quide Books", "Airfare", "Paid", "Ojlsd Cete", "Khjksd Kjsd", "Pandong", GetRandomDouble(random, 0, 999.99), GetRandomDouble(random, 0, 999.99), GetRandomDouble(random, 0, 999.99), "12-01-2021"));

            for (int i = 0; i < 12; i++)
            {
                DataGridModel_[i].Created = "Created: 11-11-19"; DataGridModel_[i].LastChange = "LastChange: 20-09-15"; 
                DataGridModel_[i].Tag = "Tag: Income"; DataGridModel_[i].Resourses = "Resourses: Resourses1"; DataGridModel_[i].Note = "Note: Empty";
            }
        }

        private static void InitializationNewObjBackground()
        {
            ObjBackground_ = new List<BackgroundButton>
            {
                new BackgroundButton { ObgBackground = (SolidColorBrush) new BrushConverter().ConvertFrom(BackgroundActive) },
                new BackgroundButton { ObgBackground = (SolidColorBrush) new BrushConverter().ConvertFrom(BackgroundNotActive) },
                new BackgroundButton { ObgBackground = (SolidColorBrush)new BrushConverter().ConvertFrom(BackgroundNotActive) },
                new BackgroundButton { ObgBackground = (SolidColorBrush)new BrushConverter().ConvertFrom(BackgroundNotActive) }
            };
        }

        private static void InitializationNewDataBinding_()
        {
            DataBinding_ = new DataBinding()
            {
                PastDoe = GetRandomDouble(random, 0, 99.99),
                Schedules = GetRandomDouble(random, 0, 99.99),
                Pending = GetRandomDouble(random, 0, 99.99),
                Paid = GetRandomDouble(random, 0, 999.99),
                Available = GetRandomDouble(random, 0, 999.99),
                Essential = GetRandomDouble(random, 0, 99999.99),
                Important = GetRandomDouble(random, 0, 99999.99),
                Discretionary = GetRandomDouble(random, 0, 99999.99),
                QuaterValue = 1
            };
            DataBinding_.Sum1 = DataBinding_.Schedules + DataBinding_.PastDoe + DataBinding_.Pending;
            DataBinding_.Sum2 = DataBinding_.Important + DataBinding_.Essential + DataBinding_.Discretionary;
            DataBinding_.Quater = "Quater - " + DataBinding_.QuaterValue.ToString();
        }

        private static void SetVisibilityObj(int count)
        {
            for (int i = 0; i < count; i++)
                visibilityObj.Add(new VisibilityObj { Visibility_ = Visibility.Visible });
        }

        private static double GetRandomDouble(Random random, double min, double max) { return Math.Round(min + (random.NextDouble() * (max - min)), 2); }

        private static void SetRandomArrayChart()
        {
            for (int i = 0; i < Chart.Length; i++)
            {
                Random random = new Random();
                Chart[i] = new List<ModelChart>();
                for (int j = 0; j < 13; j++)
                {
                    ModelChart modelChart = new ModelChart { Date = $"Month {j}", Value = random.Next(90, 180) };
                    Chart[i].Add(modelChart);
                }
            }
        }

        private static bool ValidationNameButtons(string data)
        {
            foreach (string name in NameButtonsMenu)
                if (name == data) return true;
            return false;
        }

        private static int GetIndexNameTokenButtonAdv(string data)
        {
            for (int i = 0; i < NameTokenButtonAdv.Length; i++)
                if (data == NameTokenButtonAdv[i]) return i;
            return -1;
        }

        #endregion

        #region MethodsEvent 
        private static void CommandPageSource(object ButtonMenu)
        {   
            if (ValidationNameButtons((string)(ButtonMenu as Button).Content))
                SourcePagesMenu_.Source = $"Menu/{(string)(ButtonMenu as Button).Content}.xaml";
        }

        private static void AddInquiry() =>
           Inquiry.Add(SearchText ?? null);

        private void CommandButtonAdvCloseMouseUp(object sender)
        {
            if (GetIndexNameTokenButtonAdv((sender as Label).Content.ToString()) != -1)
                visibilityObj[GetIndexNameTokenButtonAdv((sender as Label).Content.ToString())].Visibility_ = Visibility.Collapsed;
        }

        private void CommandAddTokenButtonAdvMouseUp()
        {
            for (int i = 0; i < visibilityObj.Count; i++)
                if (visibilityObj[i].Visibility_ == Visibility.Collapsed) { visibilityObj[i].Visibility_ = Visibility.Visible; return; }
        }

        private void CommandSetBorderColor(object sender)
        {
            for (int i = 0; i < 4; i++) ObjBackground_[i].ObgBackground = (SolidColorBrush)new BrushConverter().ConvertFrom(BackgroundNotActive);
            ObjBackground_[Grid.GetColumn(sender as Border)].ObgBackground = (SolidColorBrush)new BrushConverter().ConvertFrom(BackgroundActive);
        }

        private void CommandImageButton(object sender)
        {
            if ((sender as Image).Name == "SecondRightImage") { DataBinding_.QuaterValue += 1; DataBinding_.Quater = "Quater - " + DataBinding_.QuaterValue.ToString(); }
            else { if (DataBinding_.QuaterValue > 0) { DataBinding_.QuaterValue -= 1; DataBinding_.Quater = "Quater - " + DataBinding_.QuaterValue.ToString(); } }
        }

        #endregion
    }
}
