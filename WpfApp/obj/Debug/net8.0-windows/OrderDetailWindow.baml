   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp  5   	       WpfApp.OrderDetailWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WpfApp     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $	��500��5
   	   $	��600��5   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency$
 True��5   	   
������  � 
ResizeMode$ NoResize=�5   	   $��18(�5   	      MaterialDesignFont#���   5   	   .��5   
   � $��20q�6    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      ShadowDepth$ 1Q�5   #      Opacity$	 0.4Q�5   #   .+�5      �� -   5        $	��Top=�5      $��Right=�5      $��	0 13 14 0q�5       J� Opacity$	 0.3Q�5      
���   �
������ 	 K� ZIndex$	 1��5#      
������ .��5%      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 Close=�6*   $��20��5&   *   $��20��5'   *   5(      �� 5)   
   -   5         ��Name$ RightSection��5)      $��1��5*       �� CornerRadius$ 20 20 20 20��5+      
����� �$��1q�5-      
�������._�5/      � .+�51      �� $��16q�6   .+�52      �� $��Your order detail��6   $��Center=�53      $��Center=�54      $��24(�55      $
��Bold"�56       �� TextAlignment$ Center=�57      $
��0 20q�58      $
��Wrap=�59      $��Segoe UI)�5:      ��5;      �� 5<       �� 
StartPoint$	 0,0&�6.    �� EndPoint$	 1,1&�5=   .   .��5>      �  � Color$ 	#FF6699CC��6+    � Offset$ 0Q�5?   +   � 5@      $ 	#FF336699��6+   $ 1Q�5A   +   5B      5D      �� 5E      $	��500��6   .��5F      �� .+�5G      &   System.Windows.Controls.DataGrid  -   5        $��dtg_currentOrder��5G   #      SelectionMode$ Extended=�5I   #      SelectionUnit$ FullRow=�5J   #      CanUserDeleteRows$
 True��5K   #      CanUserAddRows$
 True��5L   #      
IsReadOnly$
 True��5M   #      AutoGenerateColumns$ False��5N   #   ��5H   #   �� *OrderProducts+   Columns 5O      0  *System.Windows.Controls.DataGridTextColumn  5P   "   ,  &System.Windows.Controls.DataGridColumn   Header$ #��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5Q   5   �� *Product.ProductId+  5R   "   $ Product Name��65    5S   5   �� *Product.ProductName+  5T   "   $ Product Price��65    5U   5   �� *Product.Price+  5V   "   $ Quantity��65    5W   5   �� *
Quantity+5Z      � 5[      $��10 20q�6#   $	��500��62   $
��Left=�6>    � ColumnDefinitions 5\   "   �� 5]   &   $��1* �67   6D   �� 5^   &   $��3* �67   6D    � RowDefinitions 5`   "   �� 5a   &   66   �� 5b   &   66   �� 5c   &   66   .+�5f   "   �� $	��0 5q�6,   $��
Montserrat)�5g   ,   $��14(�5h   ,   $��0��5i   ,   $��0��5j   ,   Total Price: �� 5k   5   $�$��69   $��10(�6B    �� BaselineAlignment$ Center=�6P   5l   #   �� 5m   "   -   5        $��runTotalPrice��5r   ,   $��DemiBold"�5m   ,   $��14(�5n   ,   $	��0 5q�5p   ,   $��
Montserrat)�5q   ,   $��0��5t   ,   $��1��5u   ,   ��5s   ,   �� *
TotalPrice+5u   ,   �� 5v   "   $	��0 5q�6,   $��
Montserrat)�5x   ,   $��14(�5y   ,   $��1��5z   ,   $��0��5{   ,   	Status:5}   #   �� 5~   "   $��DemiBold"�6,   $	��0 5q�5   ,   $��14(�5�   ,   $��
Montserrat)�5�   ,   $��1��5�   ,   $��1��5�   ,   ��5�   &   �� *OrderStatus+5�   ,   �� 5�   "   $	��0 5q�6,   $��
Montserrat)�5�   ,   $��14(�5�   ,   $��0��5�   ,   $��2��5�   ,   
OrderDate:5�   #   �� 5�   "   $��DemiBold"�6,   $	��0 5q�5�   ,   $��14(�5�   ,   $��
Montserrat)�5�   ,   $��1��5�   ,   $��2��5�   ,   ��5�   &   �� *	OrderDate+5�   ,   5�      5�      5�      5�      5�      5�      5�      5�      