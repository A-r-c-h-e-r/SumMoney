using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SumMoney.View.Menu
{
    public partial class Expenses : Page
    {
        public Expenses() { InitializeComponent(); }


        private double MouseX, MouseY;
        private void DragButton_PreviewMouseUp(object sender, MouseButtonEventArgs e) => e.MouseDevice.Capture(null);

        private void DragButton_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            MouseX = e.GetPosition(this).X; MouseY = e.GetPosition(this).Y;
        }

        private void DragButtonForm_SizeChanged(object sender, SizeChangedEventArgs e) =>
            DragButtonForm.Margin = new Thickness(0);

        private void DragButton_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                e.MouseDevice.Capture(DragButton);
                Thickness Margin = DragButtonForm.Margin;
                double TempX = e.GetPosition(this).X, TempY = e.GetPosition(this).Y;
              
                if (MouseX > TempX) { Margin.Left += (TempX - MouseX); Margin.Right -= (TempX - MouseX); }
                else { Margin.Left -= (MouseX - TempX); Margin.Right -= (TempX - MouseX); }

                if (MouseY > TempY) { Margin.Top += (TempY - MouseY);  Margin.Bottom -= (TempY - MouseY);}
                else { Margin.Top -= (MouseY - TempY); Margin.Bottom -= (TempY - MouseY); }

                bool CheckToDrag = true;
                double WorkWidth_ = ActualWidth - 80, WorkHeight_ = ActualHeight - 70;

                if (Margin.Left > 0) { Margin.Left = 0; CheckToDrag = false; }
                if (Margin.Top > 0) { Margin.Top = 0; CheckToDrag = false; }
                if (Margin.Right > WorkWidth_) { Margin.Right = WorkWidth_; CheckToDrag = false; }
                if (Margin.Bottom > WorkHeight_) { Margin.Bottom = WorkHeight_; CheckToDrag = false; }

                if (CheckToDrag == true) { DragButtonForm.Margin = Margin; MouseX = TempX; MouseY = TempY; }
            }
        }
    }
}
