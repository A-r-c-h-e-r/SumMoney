using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SumMoney.Model
{
    public class CustomDueDateCellTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item == null) return null;

            DataGridModel data = item as DataGridModel;

            if (data.DueDate == "12-11-2021")
                return Application.Current.FindResource("DueDateBlack") as DataTemplate;

            else
                return Application.Current.FindResource("DueDateRed") as DataTemplate;
        }
    }
}
