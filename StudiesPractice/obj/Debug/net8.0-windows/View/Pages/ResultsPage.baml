   M S B A M L   `   `   `  ����J  FStudiesPractice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:StudiesPractice.View.PagesStudiesPractice.View.Pages  5      O,clr-namespace:StudiesPractice.Core.ConverterStudiesPractice.Core.Converter  5      ,    &StudiesPractice.View.Pages.ResultsPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:StudiesPractice.View.Pages     5      B	converter,clr-namespace:StudiesPractice.Core.Converter     5        N� Title$  ResultsPage��5
       � 	Resources 5      8   2StudiesPractice.Core.Converter.MatrixSizeConverter   MatrixSizeConverter��%   &	          5   
   6(   5      .��5      � .+�5   
   �� $
��Auto=�6   .��5      �� $��20q�6>   ��6   �� *
MatrixList+��5      �� 5      .R�5      �  � Orientation$ 
Horizontal=�6$    � 	ItemWidth$
 Auto��5   $    � 
ItemHeight$
 Auto��5   $   $
��Left=�5   $   5      ��5      �� 5      .R�5      �� 
�������$��1q�68   $��10q�6L    �� Padding$ 10q�6X    �� CornerRadius$ 5��5   !   $
��Left=�5      ._�5      � $��Center=�6#   $��Center=�6@    � RowDefinitions 5   "   �� 5    &   $
��Auto �64   �� 5!   &   $
��Auto �64   .+�5$   "   � $��0��6'   $��5q�64    � ColumnDefinitions 5%   &   �� 5&   *   $
��Auto �6;   �� 5'   *   $��* �6;   �� 5(   *   $
��Auto �6;   .+�5+   &   (� $��0��6.   	 (� Stretch$
	 Fill=�6>   $��Stretch=�6M   $��5q�6i   .��5,   *   F� 
���   �$��2��6>   )���Ѐ��     �     -1 �����  ��	6R   5-   '   �� 5/   &   $��1��63   $��Center=�6f   ��6C   �� *
NumberList+��50   *   �� 51   .   .R�52   2   A� 
 A� Columns
 6>   �� *Size+ �� 	Converter# [  53   /   ��55   *   �� 56   .   .R�57   2   �� 
�������$��1q�6L   $��3q�6`   $ 5q�6k   $��50��6w   $��30��6�   $ 3��6�   ._�58   6   �� $��Center=�59   ,   $��Center=�5:   ,   $��14(�5;   ,   ��58   @   �� *Value+5;   ,   5<   3   5=   /   5?   '   (� 5A   &   $��2��6.   $
	 Fill=�6>   $��Stretch=�6M   $��5q�6i   .��5B   *   F� 
���   �$��2��6>   )����        Ӏ��  -1���  �� ��	6R   5C   '   5D   #   �� 5F   "   $��1��6,   $
��Bold"�5H      $��14(�5I      $��Center=�5J      $��0,10,0,0q�5K      ��5G      �� *Result+ �� StringFormat$ Результат: {0}��5K      5L      5M      5N      5P      5Q      5R      5S      