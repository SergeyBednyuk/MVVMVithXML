   M S B A M L   `   `   `  ����H  DMVVM_With_XML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:MVVM_With_XML.ViewModelMVVM_With_XML.ViewModel  5      '    !MVVM_With_XML.View.EditWindowView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:MVVM_With_XML.ViewModel     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  EditWindowView��5      $	��300��5	      $	��300��5
       � 	Resources 5       �� 
TargetType �� Property �� Value��%T   '��       �� 5   
   " ��6   .�5      ��  � ��$
 10,5q�6'   5      5       � DataContext 5      +   %MVVM_With_XML.ViewModel.EditViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��2��6    �� Orientation$ Vertical=�6)   .+�5       �� $��5q�5!      $��Id��5"      	 �� TextAlignment$	 Center=�5#      �� 5$      ��6   �� *CurrentStudent.Id+5%      �� 5&   
   $��1��5'      $��0��5(      $ Vertical=�5)      .+�5*      �� $��5q�5+      $��
First Name��5,      $	 Center=�5-      �� 5.      ��6   �� *CurrentStudent.FirstName+5/      �� 50   
   $��1��51      $��1��52      $ Vertical=�53      .+�54      �� $��5q�55      $��	Last Name��56      $	 Center=�57      �� 58      ��6   �� *CurrentStudent.LastName+59      �� 5:   
   $��2��5;      $��0��5<      $ Vertical=�5=      .+�5>      �� $��5q�5?      $	��Age��5@      $	 Center=�5A      �� 5B      ��6   �� *CurrentStudent.Age+5C      �� 5D   
   $��2��5E      $��1��5F      $ Vertical=�5G      .+�5H      �� $��5q�5I      $��Gender��5J      $	 Center=�5K      �� 5L      ��6   �� *CurrentStudent.Gender+5M      �� 5N   
   $��3��5O      $��2��5P      $��50,20q�5Q      $
��Edit��5S      ��5R      �� *Edit+5S      5T      5U      