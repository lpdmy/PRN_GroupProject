   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp  5   	       WpfApp.CustomerWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WpfApp     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $	��645��5
   	   $	��875��5   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency$
 True��5   	    � 
ResizeMode$ NoResize=�5   	   $��18(�5   	   
������    MaterialDesignFont#���   5   	   .��5      � $��20q�6    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6      ShadowDepth$ 1Q�5         Opacity$	 0.4Q�5      .+�5   
   �� -   5        $	��Top=�5      $��Right=�5      $��	0 13 14 0q�5       J� Opacity$	 0.3Q�5      
������ 
������ 	 K� ZIndex$	 1��5       .��5"      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 Close=�6&   $��20��5#   &   $��20��5$   &   ���	#FF3366995%   &   5&      �� 5(   
   -   5         ��Name$ RightSection��5(      $��1��5)       �� CornerRadius$ 10 10 10 10��5*      ._�5+      #  MaterialDesignThemes.Wpf.Card  .��5,      �� 3  -MaterialDesignThemes.Wpf.NavigationRailAssist   ShowSelectionBackground$
 True��6    J� SnapsToDevicePixels$
 True��5-       * &MaterialDesignNavigationRailTabControl#��[ 5.       �� TabStripPlacement$
 Left=�5/      .@�51      �� ��52      �� 53      $
��auto��6)   $
��auto��54   )   .+�55   "     $��24��6:   $��24��56   :   $��Center=�57   :   $
 Noodles=�58   :   �� 59   "   $��Center=�6,   $��	All Foods��5:   ,   5;      .��5=      �� $��16q�6%   .+�5>      �� $��Choose your favorite food��6(   $��Center=�5?   (   $��Center=�5@   (   $��24(�5A   (   $
��Bold"�5B   (    �� TextAlignment$ Center=�5C   (   $
��0 20q�5D   (   $
��Wrap=�5E   (   $��Segoe UI)�5F   (   ��5G   "   �� 5H   &    �� 
StartPoint$	 0,0&�6:    �� EndPoint$	 1,1&�5I   :   .��5J   *   �  � Color$ 	#FF6699CC��67    � Offset$ 0Q�5K   7   � 5L   *   $ 	#FF336699��67   $ 1Q�5M   7   5N   '   5P      �� 5Q       �� Orientation$ 
Horizontal=�6)   $��Center=�5R   )   .+�5S   "   �� -   5        $��cboCategory��5S   +   $
��Left=�5T   +   $	��256��5U   +   $��14(�5V   +   $��50��5W   +   $��20q�5X   +   )  #MaterialDesignThemes.Wpf.HintAssist   
HelperText$ Choose food category��5Y   +      Hint$ Food category��5Z   +    " MaterialDesignOutlinedComboBox#��[ 5[   +   5]   #   �� 5^   "   .+�5_   &   �� $y�Hidden=�6/   �� 5`   &   -   5        $��txtSearchInput��5d   .   $	��Top=�5`   .   $	��300��5a   .   $��14(�5b   .   $��50��5c   .   $ Search key word��5e   .   $ Search��5f   .    ! MaterialDesignOutlinedTextBox#��[ 5g   .   .��6e   5h   '   5j   #   �� 5k   "   -   5        $��10q�5k   )    / +MaterialDesignFloatingActionMiniLightButton#��[ 5m   )    � ToolTip$1 +MaterialDesignFloatingActionMiniLightButton��5n   )   {�5l   )   �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType
 Window.��5p   &     $
 Magnify=�6>   5q   #   �� 5r   "   -   5        $��10q�5r   )   #��[ 5t   )   $1 +MaterialDesignFloatingActionMiniLightButton��5u   )   {�5s   )   �� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window.��5w   &     $
 Close=�6>   5x   #   5y      � 5{      .+�5|   "   �� $	��430��6/   .��5}   &   �� -   5        $��dtgProducts��5}   3   $��10q�5~   3   ��5   *   �� 5�   .   .R�5�   2   �  � Orientation$ 
Horizontal=�6<   ��5�   <   �� *ActualWidth+ ��  ScrollViewer5�   3   5�   /   ��5�   *   �� 5�   .   .R�5�   2     $	��200��6F   $��10q�5�   F   $��0 0 0 10q�5�   F   .��5�   6   �  � RowDefinitions 5�   :   �� 5�   >   $	��140 �6L   �� 5�   >   $��* �6L   �� 5�   >   $
��Auto �6L   .+�5�   :   �� $��0��6@   $��UniformToFill=�5�   @   ��5�   @   �� *	ImagePath+5�   @   �� 5�   :   $��1��6E   $��8,24,8,0q�5�   E   .+�5�   >   �� $
��Bold"�6H   ��5�   H   �� *ProductName+�� 5�   >   
�������$
��Left=�5�   E   $	��100��5�   E   $��0q�5�   E   $ 10��5�   E   $��25��5�   E   $��5q�5�   E   ._�5�   B   �� $��Center=�6L   $��Center=�5�   L   $��	Fast food��5�   L   $	��0 5q�5�   L   $��12(�5�   L   5�   ?   �� 5�   >   $��Center=�6H   $
��Wrap=�5�   H   $	��0 5q�5�   H   $��50��5�   H   $��14(�5�   H   ��5�   H   �� *Description+5�   H   �� 5�   >   $��Center=�6H   $��Right=�5�   H   $
��Wrap=�5�   H   $
��0 10q�5�   H   $��14(�5�   H   ��5�   H   �� *Price+ �� StringFormat$ {0:C}��5�   H   �� 5�   >   $ 
Horizontal=�6I   $��Center=�5�   I   .+�5�   B   ,  &MaterialDesignThemes.Wpf.NumericUpDown    Name$ numericUpDown��6_      Value$ 1��5�   _       IncreaseContent  5�   F   �� 5�   J    # MaterialDesign.Brush.Foreground#���  6Q   $��1q�5�   Q   $ 20��5�   Q   ._�5�   N     $
 ArrowUp=�6f   5�   K   !   DecreaseContent! 5�   F   �� 5�   J   #���  6Q   $��1q�5�   Q   $ 20��5�   Q   ._�5�   N     $
 	ArrowDown=�6f   5�   K   5�   C   �� 5�   B   -	   5        $
 Icon��5�   I   ��5�   I   0  *MaterialDesignThemes.Wpf.PackIconExtension  *Cart+{�5�   I   �� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window��5�   I   �� *DataContext.AddToCartCommand+ �� *FindAncestor+
 Window��5�   I   �� *DataContext.SelectedProduct+5�   I   5�   ?   5�   ;   5�   7   5�   3   5�   /   5�   '   5�   #   5�      5�      5�      �� 5�      ��5�      �� 5�      $
��auto��6)   $
��auto��5�   )   .+�5�   "     $��24��6:   $��24��5�   :   $��Center=�5�   :   $
 	CartCheck=�5�   :   �� 5�   "   $��Center=�6,   $��	Your cart��5�   ,   5�      .��5�      �� $��16q�6%   .+�5�      �� $��	Your cart��6(   $��Center=�5�   (   $��Center=�5�   (   $��24(�5�   (   $
��Bold"�5�   (   $ Center=�5�   (   $
��0 20q�5�   (   $
��Wrap=�5�   (   $��Segoe UI)�5�   (   ��5�   "   �� 5�   &   $	 0,0&�6:   $	 1,1&�5�   :   .��5�   *   � $ 	#FF008080��67   $ 0Q�5�   7   � 5�   *   $ 	#FF20B2AA��67   $ 1Q�5�   7   5�   '   5�      �� 5�      $	��500��6+   .��5�   "   �� .+�5�   &   &   System.Windows.Controls.DataGrid  -
   5        $��dtg_currentOrder��5�   /   "   SelectionMode$" Extended=�5  /   #   SelectionUnit$# FullRow=�5  /   $   CanUserDeleteRows$
$ True��5  /   %   CanUserAddRows$
% True��5  /   &   
IsReadOnly$
& True��5  /   '   AutoGenerateColumns$' False��5  /   ��5   /   �� *CurrentOrder.OrderProducts+(   Columns( 5  *   0	  *System.Windows.Controls.DataGridTextColumn	  5  .   ,
  &System.Windows.Controls.DataGridColumn) 
  Header$) #��6A   1  +System.Windows.Controls.DataGridBoundColumn*   Binding* 5	  A   �� *Product.ProductId+	  5
  .   $) Product Name��6A   * 5  A   �� *Product.ProductName+4  .System.Windows.Controls.DataGridTemplateColumn  5  .   $) Product��6E   +   CellTemplate+ 5  2   �� 5  6   .R�5  :   �� $��50��5  @   $��50��5  @   ��5  @   �� *Product.ImagePath+5  @   5  7   5  /   	  5  .   $) Product Price��6A   * 5  A   �� *Product.Price+	  5  .   $) Quantity��6A   * 5  A   �� *
Quantity+	  5  .   $) Total Price��6A   * 5  A   �� *
TotalPrice+  5  .   $) Actions��6E   + 5  2   �� 5  6   .R�5  :   �� -   5        $��Delete��5  A   $��Center=�5!  A   $��Center=�5"  A   $��5q�5#  A   ��5  A   �� *'%DataContext.DeleteOrderProductCommand+ ��  DataGrid��5   A   �� 5$  A   5%  7   5'  /   5*  '   �� 5+  &   $��Right=�60   $��
0 20 280 0q�5,  0   $��15(�5-  0   Total Price: �� 5.  ;   -   5        , �Name$, runTotalPrice��5.  ?   5/  '   �� 51  &   $��10q�61   $��Center=�52  1   $ 
Horizontal=�53  1   .+�54  *   �� -   5        $	��150��54  1   $��10q�55  1   ���	#FF008080
�������.��58  D   Confirm Order6S   �� 59  *   -   5        $	��150��59  1   ���	#FF20B2AA
�������.��5<  K   Cancel Order6Y   5=  '   5>  #   5?     5A     5B     �� 5C     ��5D     �� 5E     $
��auto��6)   $
��auto��5F  )   .+�5G  "     $��24��6:   $��24��5H  :   $��Center=�5I  :   $
 History=�5J  :   �� 5K  "   $��Center=�6,   $��History��5L  ,   5M     .��5O     �� $��16q�6%   .+�5P     �� $��History Order��6(   $��Center=�5Q  (   $��Center=�5R  (   $��24(�5S  (   $
��Bold"�5T  (   $ Center=�5U  (   $
��0 20q�5V  (   $
��Wrap=�5W  (   $��Segoe UI)�5X  (   ��5Y  "   �� 5Z  &   $	 0,0&�6:   $	 1,1&�5[  :   .��5\  *   � $ 	#FF008080��67   $ 0Q�5]  7   � 5_  *   $ 	#FF20B2AA��67   $ 1Q�5`  7   5b  '   5d     �� 5e     $	��500��6+   .��5f  "     -   5        $��dtg_historyOrder��5f  +   $" Extended=�5g  '   $# FullRow=�5h  '   $
$ True��5i  '   $
% True��5j  '   $
& True��5k  '   $' False��5l  '   ( 5m  "   	  5n  &   $) #��69   * 5o  9   �� *	OrderId+	  5p  &   $) 
Order Date��69   * 5q  9   �� *	OrderDate+	  5r  &   $) Total Price��69   * 5s  9   �� *
TotalPrice+	  5t  &   $) Order Status��69   * 5u  9   �� *OrderStatus+  5v  &   $) Actions��6=   + 5w  *   �� 5x  .   .R�5y  2   �� -   5        $��View details��5y  9   $��Center=�5|  9   $��Center=�5}  9   $��5q�5~  9   ��5z  9   �� *'%DataContext.DeleteOrderProductCommand+ ��  DataGrid��5{  9   �� 5  9   5�  /   5�  '   5�     5�     5�     5�     �� 5�     ��5�     �� 5�     $
��auto��6)   $
��auto��5�  )   .+�5�  "     $��24��6:   $��24��5�  :   $��Center=�5�  :   $
 AccountCircle=�5�  :   �� 5�  "   $��Center=�6,   $��Account��5�  ,   5�     .��5�     �� $��16q�6%   .+�5�     �� $��Your account information��6(   $��Center=�5�  (   $��Center=�5�  (   $��24(�5�  (   $
��Bold"�5�  (   $ Center=�5�  (   $
��0 20q�5�  (   $
��Wrap=�5�  (   $��Segoe UI)�5�  (   ��5�  "   �� 5�  &   $	 0,0&�6:   $	 1,1&�5�  :   .��5�  *   � $ 	#FF008080��67   $ 0Q�5�  7   � 5�  *   $ 	#FF20B2AA��67   $ 1Q�5�  7   5�  '   5�     � 5�     $��10 10q�6#   $	��700��5�  #   $
��Left=�5�  #   - � ColumnDefinitions- 5�  "   �� 5�  &   $��1* �67   6D   �� 5�  &   $��3* �67   6D    5�  "   �� 5�  &   66   �� 5�  &   66   �� 5�  &   66   .+�5�  "   �� $
��0 10q�6,   $��
Montserrat)�5�  ,   $��0��5�  ,   $��0��5�  ,   	UserName:5�  #   �� 5�  "   -   5        $��txtUserName��5�  +   $��DemiBold"�5�  ,   $
��0 10q�5�  ,   $��
Montserrat)�5�  ,   $��0��5�  ,   $��1��5�  ,   �� 5�  "   $
��0 10q�6,   $��
Montserrat)�5�  ,   $��1��5�  ,   $��0��5�  ,   Email:5�  #   �� 5�  "   -   5        $��txtEmail��5�  ,   $��DemiBold"�5�  ,   $
��0 10q�5�  ,   $��
Montserrat)�5�  ,   $��1��5�  ,   $��1��5�  ,   �� 5�  "   $
��0 10q�6,   $��
Montserrat)�5�  ,   $��0��5�  ,   $��2��5�  ,   	Password:5�  #   �� 5�  "   -   5        $��txtPassword��5�  ,   $��DemiBold"�5�  ,   $
��0 10q�5�  ,   $��
Montserrat)�5�  ,   $��1��5�  ,   $��2��5�  ,   5�     �� 5�     $��Center=�6)   $ 
Horizontal=�6F   .+�5�  "   �� -   5        $	��150��5�  )   
�������.��5�  *   Update Info67   �� 5�  "   -   5        $	��150��5�  )   $
��10 0q�5�  )   ���	#FF20B2AA
�������.��5�  *   Change Password6;   �� 5�  "   -   5        $	��150��5�  )   
�������
��� E��.��5�  >   	Log out5�  #   5�     5�     5�     5�     5�     5�     5�     5�     