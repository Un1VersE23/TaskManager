   M S B A M L   `   `   `  ����H  DHappyBirthday, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:HappyBirthday.ViewHappyBirthday.View  5      %    HappyBirthday.View.UserListView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:HappyBirthday.View     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $	��13* �6   6+   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $��2* �6    6-   �� 5      $��2* �6   6,   �� 5      $��2* �6   6,   �� 5      $��2* �6   6,   .+�5   
   �� $��4��6   
������ $
��Auto=�6D   $��1��6i   .��5      &   System.Windows.Controls.DataGrid  -   5          Name$ ProcessesDataGrid��5         HorizontalGridLinesBrush
 �����
������    RowBackground �	#5FFFFFFF   CanUserSortColumns .    
IsReadOnly .    AutoGenerateColumns .     AlternatingRowBackground
 �P����5      �� *ProcessesList+	 �� Mode$	 OneWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=� �� SelectedItem 5      �� *SelectedProcess+$	 OneWayToSource=�$
 PropertyChanged=�   Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   ��  �� Path$
 Name�  5#      $ ID��6)    65   �� $ Id�  5$      $ Active��6)    69   �� $ IsActive�  5%      $ 	CPU usage��6)    6<   �� $	 Cpu�  5&      $ Memory usage��6)    6?   �� $ Memory�  5'      $ Threads count��6)    6@   �� $ NumOfThreads�  5(      $
 User��6)    67   �� $ UserName�  5)      $
 Path��6)    67   �� $
 Path�  5*      $ Active since��6)    6?   �� $ LaunchDateTime�   RowDetailsTemplate 5,      �� 5-      .R�5.      �� $��0q�6!   
������� �� Padding$ 10q�6L   ._�5/      �   50   "   �� 51   &   $
��Auto �64   �� 52   &   $
��Auto �64   �� 53   &   $
��Auto �64   �� 54   &   $
��Auto �64   .+�57   "   �� $��0��6,   
���   �$
��Wrap=�58   ,   ���	#15ffffff$��Centure Ghotic)�6W    �� TextAlignment$
 Left=�59   ,   $��16(�6A   $��10q�6O   $��Modules��6[     5;   "   $ ProcessModules��6+   $��1��6C    .  .  . ��5>   +   �� $ Modules�$	 OneWay=�$
 PropertyChanged=�5?   #   �� 5A   "   $��2��6,   
���   �$
��Wrap=�5B   ,   ���	#15ffffff$��Centure Ghotic)�6W   $
 Left=�5C   ,   $��16(�6A   $��10q�6O   $��Threads��6[     5E   "   $ ProcessThreads��6+   $��3��6C    .  .  . ��5H   +   �� $ Threads�$	 OneWay=�$
 PropertyChanged=�5I   #   5J      5K      5L      5O      5Q      �� 5R   
   $��Exit Process��6   $��2��6(   $��3��65   $��Centure Ghotic)�6E   $��17(�6a   $	��150��6o   $��Right=�6{   $��35��6�   ��6�   �� *ExitProcessCommand+$	 OneWay=��� 5S   
   $
��Sort��6   $��2��6    $��1��6-   $��Centure Ghotic)�6=   $��17(�6Y   $	��150��6g   $��Center=�6s   $��35��6�   ��6�   �� *SortCommand+�� 5T   
   $
��Left=�6   $��2��6/   $	��150��6<   $��Centure Ghotic)�6`   $��17(�6|   $��35��6�    �� Text 6H   �� *SortBy+.@�5U      �� None6   �� 5V      Name6   �� 5W      Id6   �� 5X      Active6    �� 5Y      CPU6   �� 5Z      RAM6   �� 5[      	Threads6!   �� 5\      User6   �� 5]      
Start date6$   5_      �� 5`   
   $��Open folder��6   $��2��6'   $��2��64   $��Centure Ghotic)�6D   $��17(�6`   $	��150��6n   $��Center=�6z   $��35��6�   ��6�   �� *OpenFolderCommand+5a      5b      