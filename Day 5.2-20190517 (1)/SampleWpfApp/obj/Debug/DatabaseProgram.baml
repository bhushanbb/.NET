   M S B A M L   `   `   `  ����G  CSampleWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SampleWpfAppSampleWpfApp  5   	   "    SampleWpfApp.DatabaseProgram   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:SampleWpfApp     5   	   -   5          � Title$  DatabaseProgram��5   	   $	��450��6!   $	��800��6.   .��5	      � -   5        $��
grdContent��5	       � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��2q�6   $��0��6    $��0��60   .+�5      �� .��6   List of Employees with us...62   �� 5      -   5        $��lstNames��5       �� DisplayMemberPath$ EmpName��6g   ��6&   ��  �� ElementName$ 
grdContent�� �� Path$ DataContext�6g   5      � 5   
   $��1��6   $��0��6    � DataContext 6,   �� $ lstNames��$ SelectedItem� 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5!      $
��Auto �6    .+�5#      �� $��Center=�6   $��2��61   $��40(�6E   .��6S   Details of the Employee6l   �� 5$      $��Right=�6   $��0��60   $��1��6@   .��6M   Enter the ID6[   �� 5%      $��Right=�6   $��0��60   $��2��6@   .��6M   Enter the Name6]   �� 5&      $��Right=�6   $��0��61   $��3��6A   .��6N   Enter the Address6a   �� 5'      $��Right=�6   $��0��60   $��4��6@   .��6M   Enter the Salary6_   �� 5(      -   5        $��txtID��5(   ^   $��1��62   $��1��6B   $	��200��6O   ��6   �� $ EmpID�6^   �� 5)      -   5        $��txtName��5)   `   $��1��64   $��2��6D   $	��200��6Q   ��6   �� $ EmpName�6`   �� 5*      -   5        $��
txtAddress��5*   c   $��1��67   $��3��6G   $	��200��6T   ��6   �� $ 
EmpAddress�6c   �� 5+      -   5        $��	txtSalary��5+   b   $��1��66   $��4��6F   $	��200��6S   ��6   �� $ 	EmpSalary�6b   �� 5,      $��Center=�6    �� Orientation$ 
Horizontal=�66   $��2q�6O   $��5��6Z   $��2��6g   .+�5-      �� .��6   Update6!   �� 5.      .��6   Delete6!   5/      50      51      52      