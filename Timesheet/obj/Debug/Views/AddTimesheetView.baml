   M S B A M L   `   `   `  ����D  @Timesheet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Timesheet.ViewsTimesheet.Views  5      O,clr-namespace:Timesheet.ViewModel.DesignTimeTimesheet.ViewModel.DesignTime  5      &     Timesheet.Views.AddTimesheetView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      /viewsclr-namespace:Timesheet.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      B	timesheet,clr-namespace:Timesheet.ViewModel.DesignTime     5      T PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5      .��5      � .+�5   
   � -   5        $��Spinner��5      
�������y�6   �� *
Projects+   VisibleWhenNullConverter  �� 	Converter#  [  .+�5      )  #MahApps.Metro.Controls.ProgressRing  
���   �   IsActive . 5      5      � 5   
   -   5        $��TimesheetGrid��5      y�6$   �� *
Projects+  VisibleWhenNotNullConverter#  [ .+�5      �  � RowDefinitions 5      �� 5      $
��Auto �6$   64   �� 5      $
��Auto �6$   64   �� 5      $
��Auto �6$   64   �� 5      $
��Auto �6$   64   �� 5      $��* �6$   61    � ColumnDefinitions 5       �� 5!      $
��Auto �6'   66   �� 5"      $��* �6'   63   .+�5%      �� $��0��6   $��0��6(   $��	Task Date��65   $��20 20 20 10q�6I   (  "System.Windows.Controls.DatePicker  5&      $��1��6   $��0��6-   $��40 20 40 10q�6i      SelectedDate 6:   �� *Timesheet.EnteredDate+6i   �� 5(      $��0��6   $��1��6(   $��
Task Hours��65   $��20 10q�6J   �� 5)      $��1��6   $��1��6*   $��40 10 90 10q�6^   ��67   �� *Timesheet.HoursWorked+6^   �� 5+      $��0��6   $��2��6(   $��Project��65   $��20 10q�6G   �� 5,      $��1��6   $��2��6+   $��40 10q�6�    �� SelectedItem 68   �� *SelectedProject+��6a   �� *
Projects+6�   �� 5.      $��0��6   $��3��6(   $
��Task��65   $��20 10q�6D   �� 5/      $��1��6   $��3��6*   $��40 10 40 10q�6W   ��67   �� *Timesheet.Task+6n   �� 51      $��1��6   $��4��6)   $
��Save��66   $	��100��6E   $��40��6Q   $��212 60 0 40q�6]   ��6r   �� *SaveCommand+53      54      55      56      