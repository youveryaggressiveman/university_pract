   M S B A M L   `   `   `  ����J  FStudiesPractice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:StudiesPractice.View.PagesStudiesPractice.View.Pages  5      O,clr-namespace:StudiesPractice.Core.ConverterStudiesPractice.Core.Converter  5      .    (StudiesPractice.View.Pages.CalculatePage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:StudiesPractice.View.Pages     5      B	converter,clr-namespace:StudiesPractice.Core.Converter     5        N� Title$  CalculatePage��5
       � 	Resources 5      8   2StudiesPractice.Core.Converter.MatrixSizeConverter   MatrixSizeConverter��%   &	          5   
   6(   5      .��5      �  � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      �� 5      $	��100 �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $
��Left=�5      $��Center=�5      $
��15 0q�5      .+�5      �� $>��8Выберите размерность матрицы: ��6   $��Center=�5      $��Center=�5      $��18(�5      �� 5      $��Center=�5      $��Center=�5      $��Center=�5       $��15(�5!      $
��Bold"�5"        ComboBoxExtend#��[ 5#      $��Center=�5$      $	��200��5%      $��20q�5&      ��5      �� *
SizeList+ �� SelectedItem 5      �� *SelectedSize+5&      5'      � 5(   
   $��1��6   $��15q�6    � ColumnDefinitions 5)      �� 5*      $
��Auto �6#   �� 5+      $��* �6#   �� 5,      $
��Auto �6#   .+�5.      (� $��0��6    (� Stretch$
 Fill=�6&   $��Stretch=�65   .��5/      F� 
���   �$��2��6&   )���Ѐ��     �     -1 �����  ��	6:   50      �� 51      $��1��6   $
��Auto=�52      $
��Auto=�53      .��54      �� ��6   �� *Matrix.NumberList+��55      �� 56      .R�57      A�  A� Columns 6*   �� *SelectedSize+ �� 	Converter# [  58      ��5:      �� 5;      .R�5<      �� 	 ��Name$	 valueTextBox��5>   !   -   5        $��5q�5=   !   $��16(�5A   !   $��Center=�5B   !   $��Center=�5C   !   $��60��5D   !   $��40��6,   ��5<   &   �� *Value+
 �� Mode$
 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5D   ,   5E      5G      5H      (� 5I      $��2��6   $
 Fill=�6&   $��Stretch=�65   .��5J      F� 
���   �$��2��6&   )����        Ӏ��  -1���  �� ��	6:   5K      5L      � 5M   
   $��2��6    5N      �� 5O      �� 5P      .+�5R      �� $��Center=�6   $��Center=�5S      $��18(�5T      �� 5U      $.�(Результат вычислений:��6    �� 5V      $
��Bold"�65   �6   �� *Matrix.Result+65   5W      �� 5X      $ 
Horizontal=�6   $��1��5Y      $��Center=�5Z      $��Center=�5[      .+�5\      �� $	��150��6   $��Center=�5]   
   $��Center=�5^   
   $��20q�5_        
ButtonInfo#��[ 5a   
   $��Сохранить��5b   
   ��5`   
   �� *Save+5b   
   �� 5c      $	��150��6   $��Center=�5d      $��20q�5e      $��Center=�5f        ButtonDanger#��[ 5h      $��Расчитать��5i      ��5g      �� *	Calculate+5i      5j      5k      5l      5m      