   M S B A M L   `   `   `  ����D  @Timesheet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Timesheet.ViewsTimesheet.Views  5      O,clr-namespace:Timesheet.ViewModel.DesignTimeTimesheet.ViewModel.DesignTime  5      '    !Timesheet.Views.ViewTimesheetView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /viewsclr-namespace:Timesheet.Views     5      C
designTime,clr-namespace:Timesheet.ViewModel.DesignTime     5      .��5      �   � RowDefinitions  5   
   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   �� 5      $
��Auto �6   6,   .+�5   
   �� $��0��6   $��Months��6   $��10,5,0,5q�6.   6B   �� 5   
   $��0��6   $��	70 5 10 0q�6f   $	��200��6y    �� SelectedItem 6    �� *SelectedMonth+��6G   �� *Months+6y   &   System.Windows.Controls.DataGrid  5   
   -   5        $��TimesheetsGrid��5      
������    AutoGenerateColumns .     
IsReadOnly . $
��Auto��5      $��Hidden=�5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5      $��10q�5         SelectionMode$ Single=�5         AlternatingRowBackground
 �����$��1��5!      $��0��5"      $��Stretch=�5#      ��5      �� *
timesheets+   Columns 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn   Header$
 Date��6Y   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6)   �� *EnteredDate+
 �� StringFormat$
 d��6Y     5'      $ Projects��6I   	 6)   �� *ProjectName+6I     5(      $
 Task��6B   	 6)   �� *Task+6B     5)      $ Hours Worked��6I   	 6)   �� *HoursWorked+6I   5+      �� 5-   
   $��2��6   $��Right=�6   $��
20 0 20 20q�6:   $	��100��6N   $��Export��6Z   50      51      