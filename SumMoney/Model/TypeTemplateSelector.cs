using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SumMoney.Model
{
    public class TypeTemplateSelector : DataTemplateSelector
    {

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item == null) return null;

            DataGridModel data = item as DataGridModel;

            if (data.Type == "Important")
                return Application.Current.FindResource("TypeOrange") as DataTemplate;
            else if (data.Type == "Paid")
                return Application.Current.FindResource("TypeSilver") as DataTemplate;
            else
                return Application.Current.FindResource("TypeGreen") as DataTemplate;
        }
    }
}
