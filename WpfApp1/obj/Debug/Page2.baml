   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.Page2   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  Page2��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��4 �6   �� 5      $	��10* �6   �� 5      $
��100* �6   �� 5      $	��10* �6    � ColumnDefinitions 5   
   �� 5      $
��100* �6   .+�5   
   �� -   5         ��Name$ 	textBlock��5      $
��Wrap=�6'   $��20(�6;   $��	TextBlock��6I   $��0 0 0 0q�6Z   $��Center=�6k   $��Center=�6�   $��0��6�   $��0��6�   $��1��6�   $��1��6�   �� 5   
   $
��Wrap=�6   $��20(�6(   $3��-Что вы сегодня ели \ пили?��66   $��0 0 0 0q�6X   $��Center=�6i   $��Center=�6�   $��2��6�   $��0��6�   $��1��6�   $��1��6�   �� 5   
   -   5         ��Name$ listBox��5      $��0 0 0 0q�6$   $
��Left=�65   $��3��6W   $��0��6d   $��1��6t   $��1��6�   ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   $��Center=�6:   .+�5      �� $��40��6=   $��40��6H   $��5q�6T   ��6    �� *	ImagePath+6T   �� 5      $��5q�6]   $��Center=�6h   $��Center=�6�   ��6#   �� *Name+ d� 	IsChecked 6<   �� *
IsSelected+6�   5      5      5!      �� 5"   
   -   5         ��Name$
 Save��5"   %   $��Сохранить��6   $��0 0 0 0q�63   $��Stretch=�6D   $��Stretch=�6b   $��4��6~   $��1��6�   $��1��6�   $��1��6�   $��0q�6�   6�   5#      5$      