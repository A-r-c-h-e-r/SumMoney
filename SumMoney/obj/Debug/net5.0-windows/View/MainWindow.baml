   M S B A M L   `   `   `  ����C  ?SumMoney, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SumMoney.ViewModelSumMoney.ViewModel  5   >       SumMoney.View.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   l hSyncfusion.SfTextInputLayout.WPF, Version=19.1500.0.55, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89` \Syncfusion.Tools.Wpf, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b ^Syncfusion.SfChart.WPF, Version=19.1500.0.55, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a	 ]Syncfusion.SfGrid.WPF, Version=19.1500.0.56, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a
 ]Syncfusion.Shared.WPF, Version=19.1500.0.56, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b ^Syncfusion.SfInput.Wpf, Version=19.1500.0.55, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89<
syncfusion!http://schemas.syncfusion.com/wpf    	 
  5   	   :	viewmodel clr-namespace:SumMoney.ViewModel    	 
  6>   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   h dMicrosoft.Expression.Interactions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  6N   -   5          �Name$  MainWindow_��5
   	    � Title$ SumMoney��5	   	   $	��800��5   	   $	��800��6   $	��300��5   	   $	��400��6    � DataContext 5      &    SumMoney.ViewModel.MainViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��35 �6   �� 5      $��* �6   .+�5   
   �� $��1��6   ._�5      �  � ColumnDefinitions 5      �� 5      $
��Auto �6'   �� 5      $��* �6'   .+�5"      �� $��1��6      DarkMainColor#���   6)   ._�5$       �   � NavigationUIVisibility$ Hidden=�6T     � Source 6   �� *SourcePagesMenu_.Source+ �� Mode$ TwoWay=�6T   5&      �� 5)      $��0��6     	ColorMain#���  6)   $��30��6R     MenuAnimation#���  6]   ._�5+      �� .+�5,      1 
 +Syncfusion.Windows.Tools.Controls.ButtonAdv  $
��Left=�6/      Label$ Overview��6J   $	��125��6[   $��30��6g   
������ 	   	SmallIcon$T	 Npack://application:,,,/Resources/Images/MainWindowImages/Menu/OverviewLogo.png��6�   $��0,10,0,0q�6�     StyleButtonMenu#���  6�     5-      $
��Left=�6/   $ Income��6J   $	��125��6Y   $��30��6e   
������ $R	 Lpack://application:,,,/Resources/Images/MainWindowImages/Menu/IncomeLogo.png��6�   #���  6�     5.      $
��Left=�6/   $ Expenses��6J   $	��125��6[   $��30��6g   
������ $T	 Npack://application:,,,/Resources/Images/MainWindowImages/Menu/ExpensesLogo.png��6�   #���  6�     5/      $
��Left=�6/   $ Calendar��6J   $	��125��6[   $��30��6g   
������ $T	 Npack://application:,,,/Resources/Images/MainWindowImages/Menu/CalendarLogo.png��6�   #���  6�     50      $
��Left=�6/   $ Account��6J   $	��125��6Z   $��30��6f   
������ $S	 Mpack://application:,,,/Resources/Images/MainWindowImages/Menu/AccountLogo.png��6�   #���  6�     51      $
��Left=�6/   $ Settings��6J   $	��125��6[   $��30��6g   
������ $T	 Npack://application:,,,/Resources/Images/MainWindowImages/Menu/SettingsLogo.png��6�   #���  6�   52      53      54      55      �� 58   
   -   5        
 ��Name$
 Header��58      $��0��6!   
�������$��0,1,0,1q�59   &   #���  5:      ._�5;      � .+�5<      �� $P��Jpack://application:,,,/Resources/Images/MainWindowImages/Info/TextLogo.png��6   $��95��6l   $
��Left=�6w   $��5, 0,0,0q�6�    �� BitmapScalingMode$ HighQuality=�6�   �� 5=       �� Orientation$ 
Horizontal=�6   $��Right=�66   .+�5>           SizeMode$ Small=�6,   $��25��6=   $��25��6H   
������ $R	 Lpack://application:,,,/Resources/Images/MainWindowImages/Header/BellLogo.png��6m   $��0,0,10,0q�6�     StyleButtonTopPanel#���  6�     5?      $ Small=�6,   $��25��6=   $��25��6H   
������ $T	 Npack://application:,,,/Resources/Images/MainWindowImages/Header/SearchLogo.png��6m   $��0,0,10,0q�6�   #���  6�     5@      $ Small=�6,   $��25��6=   $��25��6H   ���	#7744C33E$T	 Npack://application:,,,/Resources/Images/MainWindowImages/Header/PersonLogo.png��6k   $��0,0,15,0q�6�   #���  6�   5A      5B      5C      5D      5E      