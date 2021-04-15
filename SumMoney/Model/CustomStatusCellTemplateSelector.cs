using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SumMoney.Model
{
    public class CustomStatusCellTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item == null) return null;

            DataGridModel data = item as DataGridModel;

            if (data.Status == "Pandong")
                return Application.Current.FindResource("StatusRed") as DataTemplate;
            else if (data.Status == "Paid")
                return Application.Current.FindResource("StatusOrange") as DataTemplate;
            else
                return Application.Current.FindResource("StatusSilver") as DataTemplate;
        }
    }
}
