   M S B A M L   `   `   `  ���� H  DHappyBirthday, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:HappyBirthday.ViewHappyBirthday.View  %    HappyBirthday.View.UserListView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     2local clr-namespace:HappyBirthday.View     .��� .+��� $��0��
������ $
��Auto=�.��&   System.Windows.Controls.DataGrid  -      Name$  ProcessesDataGrid��   HorizontalGridLinesBrush
 �����
������    RowBackground �	#5FFFFFFF   CanUserSortColumns .    
IsReadOnly .    AutoGenerateColumns .     AlternatingRowBackground
 �P������ *ProcessesList+ �� Mode$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=�	 �� SelectedItem	 �� *SelectedProcess+$ OneWayToSource=�$ PropertyChanged=�
   Columns
 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$
 Name�  $ ID�� �� $ Id�  $ Active�� �� $ IsActive�  $ 	CPU usage�� �� $	 Cpu�  $ Memory usage�� �� $ Memory�  $ Threads count�� �� $ NumOfThreads�  $
 User�� �� $ UserName�  $
 Path�� �� $
 Path�  $ Active since�� �� $ LaunchDateTime�   RowDetailsTemplate �� .R��� $��0q�
������� �� Padding$ 10q�._��  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��0�����#5F68F2$
��Wrap=����	#15ffffff$��Italic$� �� TextAlignment$
 Left=�$��16(�$��10q�$��Modules��  $  ProcessModules��$��1�� .  .  . ���� $ Modules�$ OneWay=�$ PropertyChanged=��� $��2�����#5F68F2$
��Wrap=����	#15ffffff$��Italic$�$
 Left=�$��16(�$��10q�$��Threads��  $  ProcessThreads��$��3�� .  .  . ���� $ Threads�$ OneWay=�$ PropertyChanged=�