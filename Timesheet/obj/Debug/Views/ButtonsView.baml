   M S B A M L   `   `   `  ����D  @Timesheet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Timesheet.ViewsTimesheet.Views  5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5	      !    Timesheet.Views.ButtonsView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /viewsclr-namespace:Timesheet.Views     5      ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5	      .��5      �   � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   	   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+   .+�5   
   �� $��0��6   $��0��6   $��3��6.   $��2q�6B   
�������6o   �� 5!   
   $��0��6   $��1��6!   $��Add Timesheet��6.   ��6F   �� *AddTimesheetCommand+��5"      �� 5#       �� 
TargetType" ��6   .�5$      ��  �� Property � �� �� Value
 �����63    �� Triggers 5%      �� 5&       �� Binding 6&   �� *SelectedTab+ �� Value AddTimesheetView6F   .a�5'      ��  � ��
 �����6;   5(      5*      5,      �� 5-   
   $��1��6   $��1��6!   $��View Timesheet��6.   ��6G   �� *ViewTimesheetCommand+��5.      �� 5/      " ��6   .�50      ��  � ��
 �����63    51      �� 52       6&   �� *SelectedTab+ ViewTimesheetView6F   .a�53      ��  � ��
 �����6;   54      56      58      �� 59   
   $��2��6   $��1��6!   $��Project Admin��6.   ��6F   �� *ProjectAdminCommand+��5:      �� 5;      " ��6   .�5<      ��  � ��
 �����63    5=      �� 5>       6&   �� *SelectedTab+ ProjectAdminView6F   .a�5?      ��  � ��
 �����6;   5@      5B      5D      5F      5G      