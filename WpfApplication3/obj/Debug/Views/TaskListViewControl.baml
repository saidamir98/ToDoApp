   M S B A M L   `   `   `  ����  WpfApplication3/    )WpfApplication3.Views.TaskListViewControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      ��    WordOrangeBrush#��[  6   ._�5	   
   � ��5
      �� 5        j� TileMode$
  Tile=�6    �� ImageSource$ /Images/background.jpg��6-    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $��* �6    �� 5      $
��Auto �6    .+�5      �� $��0��6     WordTransparentBlueBrush#��[ 6"   $��5 5 5 5q�6Y   ._�5      �  � ColumnDefinitions 5      �� 5      $��* �6+   �� 5      $
��Auto �6+   .+�5      �� #��[ 6   $��0��6U   
 � Tag$+ %Insert your new task content here ...��6e     FontSizeLarge#��[ 5        LatoRegular#��[ 6H     ForegroundVeryDarkBrush#��[ 6r   ��5      �� *NewTask.Content+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5      $��1��6     WordGreenBrush#��[ 6-   $��50(�6Z     
IconButton#��[ 6h   $��0 0 0 5q�6�     FontAwesomeTickIcon#��[ 6�   ��6�   �� *_AddNewTaskCommand+5      5      �� 5!      $��1��6   $
��Auto=�6(   $
��Auto=�6K   .��5"      �� $��Center=�6   $��Center=�68   .+�5$      �� $��1��6#   ��60   �� *Tasks+��5%      �� 5&      .R�5'   "   $�  $� Orientation$ Vertical=�69   5(      ��5+      �� 5,      .R�5-   "   �  5.   &   �� 5/   *   $��* �6;   .+�52   &   �� $��0��61    �� Orientation$ 
Horizontal=�6A   .+�53   *   �� $	��100(�61     WordRedBrush#��[ 6@   #��[ 6k    	 FontAwesomeTimesIcon#��[	 6�   ��6�   �� * DataContext._DeleteTaskCommand+	 �� RelativeSource	 �� 
 �� Mode$
 FindAncestor=� �� AncestorType$ ItemsControlL���6@  �� *Id+�� 54   *   $	��100(�61   #��[ 6@   #��[ 6m    
 FontAwesomeEditIcon#��[
 6�   ��6�   �� *DataContext._EditTaskCommand+	 �� $
 FindAncestor=�$ ItemsControlL���6?  �� *Id+�� 55   *    J� OpacityMask �	#EA888888  ForegroundLightBrush#��[ 6I    �� CornerRadius$ 10��6|    �� Padding$ 5 5 5 5q�6�   $��5 5 5 0q�6�   ._�56   .   �  57   2   �� 58   6   $��* �6G   .+�5:   2   �� $��0��6<   #��[ 6r   #��[ 6�   #��[ 6�   ��6L   �� *	Content+$ TwoWay=�6�   5;   /   5<   +   5=   '   �� 5?   &   #��[ 6N   $ 10��6y   $ 5 5 5 5q�6�   $��5 5 5 0q�6�   y�6-   �� *	IsEditing+._�5@   *   �� $��0��65   $ 
Horizontal=�6f   y�6E   �� *	IsEditing+.+�5A   .   �� $	��100(�65   #��[ 6D   #��[ 6h   ��6�   �� *DataContext._EditTaskCommand+	 �� $
 FindAncestor=�$ ItemsControlL���6  �� *Id+�� 5B   .   $��0��66   #��[ 6m   $+ %Insert your new task content here ...��6�   #��[ 6�   #��[ 6�   #��[ 6$  ��6F   �� *	Content+$ TwoWay=�6$  5C   +   5D   '   5F   #   5G      5I      5J      5K      �� 5N      $��2��6   #��[ 6"   $ 10��6Y   $��5 5 5 5q�6k   ._�5O      �  5P      �� 5Q      $��* �6+   �� 5R      $
��Auto �6+   .+�5T      �� $��1��6     DeleteButton#��[ 6-   $��
Delete All��6S   ��6h   �� *_DeleteAllTaskCommand+5U      5V      5X      5Y      5Z      