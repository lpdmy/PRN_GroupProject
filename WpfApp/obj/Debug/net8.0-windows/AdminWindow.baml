   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp  5   	       WpfApp.AdminWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WpfApp     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $	��800��5
   	   $
��1200��5   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency$
 True��5   	    � 
ResizeMode$ NoResize=�5   	   $��18(�5   	   
������    MaterialDesignFont#���   5   	   .��5      � $��20q�6    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6      ShadowDepth$ 1Q�5         Opacity$	 0.4Q�5      .+�5   
   �� -   5        $	��Top=�5      $��Right=�5      $��	0 13 14 0q�5       J� Opacity$	 0.3Q�5      
������ 
���   �
������ 	 K� ZIndex$	 1��5!      .��5#      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 Close=�6&   $��20��5$   &   $��20��5%   &   
���   �5&   &   5'      �� 5)   
   -   5         ��Name$ RightSection��5)      $��1��5*       �� CornerRadius$ 10 10 10 10��5+      ._�5,      #  MaterialDesignThemes.Wpf.Card  .��5-      �� 3  -MaterialDesignThemes.Wpf.NavigationRailAssist   ShowSelectionBackground$
 True��6    J� SnapsToDevicePixels$
 True��5.       * &MaterialDesignNavigationRailTabControl#��[ 5/       �� TabStripPlacement$
 Left=�50      .@�52      �� ��53      �� 54      $
��auto��6)   $
��auto��55   )   .+�56   "     $��24��6:   $��24��57   :   $��Center=�58   :   $
 AccountGroup=�59   :   �� 5:   "   $��Center=�6,   $��Customer��5;   ,   5=      .��5?      �� $��16q�6%   .+�5@      ��  �� Orientation$ 
Horizontal=�6)   .+�5A   "   �� $��Manage Customer��6,   $��Center=�5B   ,   $��Center=�5C   ,   $��24(�5D   ,   $
��Bold"�5E   ,    �� TextAlignment$ Center=�5F   ,   $
��0 20q�5G   ,   $
��Wrap=�5H   ,   $��Segoe UI)�5I   ,   5J      &   System.Windows.Controls.DataGrid  5M      -   5        $��dtg_allCustomer��5M   '      SelectionMode$ Extended=�5N   '      SelectionUnit$ FullRow=�5O   '      CanUserDeleteRows$
 True��5P   '      CanUserAddRows$
 True��5Q   '      
IsReadOnly$
 True��5R   '      AutoGenerateColumns$ False��5S   '      Columns 5T   "   0  *System.Windows.Controls.DataGridTextColumn  5U   &   ,  &System.Windows.Controls.DataGridColumn   Header$ Customer ID��69   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5V   9   �� *
CustomerId+  5W   &   $ 	User Name��69    5X   9   �� *
UserName+  5Y   &   $ Email��69    5Z   9   �� *Email+  5[   &   $ Password��69    5\   9   �� *
Password+4	  .System.Windows.Controls.DataGridCheckBoxColumn	  5^   &   $ Is Disabled��6=    5_   =   �� *
IsDisabled+4
  .System.Windows.Controls.DataGridTemplateColumn
  5a   &   $ Actions��6=    
  CellTemplate 5b   *   �� 5c   .   .R�5d   2   �� -   5        $��Change status��5d   9   $��Center=�5g   9   $��Center=�5h   9   $��5q�5i   9   ��5e   9   �� * DataContext.DisableUserCommand+ �� RelativeSource ��  �� AncestorType DataGrid��5f   9   �� 5j   9   5k   /   5m   '   5p      5r      5s      �� 5t      ��5u      �� 5v      $
��auto��6)   $
��auto��5w   )   .+�5x   "     $��24��6:   $��24��5y   :   $��Center=�5z   :   $
 	CartCheck=�5{   :   �� 5|   "   $��Center=�6,   $��Order��5}   ,   5~      .��5�      �� $��16q�6%   .+�5�      �� $ 
Horizontal=�6)   .+�5�   "   �� $��Manage Order��6,   $��Center=�5�   ,   $��Center=�5�   ,   $��24(�5�   ,   $
��Bold"�5�   ,   $ Center=�5�   ,   $
��0 20q�5�   ,   $
��Wrap=�5�   ,   $��Segoe UI)�5�   ,   5�        5�      -   5        $��dtgAllOrders��5�   '   $ Extended=�5�   '   $ FullRow=�5�   '   $
 True��5�   '   $
 True��5�   '   $
 True��5�   '   $ False��5�   '    5�   "     5�   &   $ #��69    5�   9   �� *	OrderId+  5�   &   $ 
Order Date��69    5�   9   �� *	OrderDate+  5�   &   $ Total Price��69    5�   9   �� *
TotalPrice+  5�   &   $ Order Status��69    5�   9   �� *OrderStatus+  5�   &   $ Customer��69    5�   9   �� *Customer.UserName+
  5�   &   $ Actions��6=    5�   *   �� 5�   .   .R�5�   2   �� -   5        $��View details��5�   9   $��Center=�5�   9   $��Center=�5�   9   $��5q�5�   9   ��5�   9   �� *'%DataContext.DeleteOrderProductCommand+ ��  DataGrid��5�   9   �� 5�   9   5�   /   5�   '   
  5�   &    5�   *   �� 5�   .   .R�5�   2   �� -   5        $��Update Status��5�   9   $��Center=�5�   9   $��Center=�5�   9   $��5q�5�   9   ��5�   9   �� *'%DataContext.DeleteOrderProductCommand+ ��  DataGrid��5�   9   �� 5�   9   5�   /   5�   '   5�      5�      5�      �� 5�      ��5�      �� 5�      $
��auto��6)   $
��auto��5�   )   .+�5�   "     $��24��6:   $��24��5�   :   $��Center=�5�   :   $
 	FoodApple=�5�   :   �� 5�   "   $��Center=�6,   $��Product��5�   ,   5�      .��5�      �� $��16q�6%   .+�5�      �� $ 
Horizontal=�6)   .+�5�   "   �� $��Manage Product��6,   $��Center=�5�   ,   $��Center=�5�   ,   $��24(�5�   ,   $
��Bold"�5�   ,   $ Center=�5�   ,   $
��0 20q�5�   ,   $
��Wrap=�5�   ,   $��Segoe UI)�5�   ,   �� 5�   "   -	   5        $
��20 0q�5�   )    / +MaterialDesignFloatingActionMiniLightButton#��[ 5�   )    � ToolTip$1 +MaterialDesignFloatingActionMiniLightButton��5�   )   {�5�   )   �� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window.��5�   &     $	
 Add=�6>   5�   #   5�        5�      -
   5        $��dtg_allProduct��5�   '   $ Extended=�5�   '   $ FullRow=�5�   '   $
 True��5�   '   $
 True��5�   '   $
 True��5�   '   $ False��5�   '    5�   "     5�   &   $ 
Product ID��69    5�   9   �� *	ProductId+  5�   &   $ Product Name��69    5�   9   �� *ProductName+  5�   &   $ Description��69    5�   9   �� *Description+  5�   &   $ Price��69    5�   9   �� *Price+  5�   &   $ Category��69    5�   9   �� *Category.CategoryName+
  5�   &   $ Image��6=    5�   *   �� 5�   .   .R�5�   2   �� $��50��5�   8   $��50��5�   8   ��5�   8   �� *	ImagePath+5�   8   5�   /   5�   '   
  5  &   $ Actions��6=    5  *   �� 5  .   .R�5  2   �� -   5        $��Update��5  9   $��Center=�5  9   $��Center=�5  9   $��5q�5	  9   ��5  9   �� *'%DataContext.DeleteOrderProductCommand+ ��  DataGrid��5  9   �� 5
  9   5  /   5  '   
  5  &    5  *   �� 5  .   .R�5  2   �� -   5        $��Delete��5  9   $��Center=�5  9   $��Center=�5  9   $��5q�5  9   ��5  9   �� *'%DataContext.DeleteOrderProductCommand+ ��  DataGrid��5  9   �� 5  9   5  /   5  '   5     5     5      �� 5!     ��5"     �� 5#     $
��auto��6)   $
��auto��5$  )   .+�5%  "     $��24��6:   $��24��5&  :   $��Center=�5'  :   $
 FormatListBulletedType=�5(  :   �� 5)  "   $��Center=�6,   $��Category��5*  ,   5+     .��5-     �� $��16q�6%   .+�5.     �� $ 
Horizontal=�6)   .+�5/  "   �� $��Manage Category��6,   $��Center=�50  ,   $��Center=�51  ,   $��24(�52  ,   $
��Bold"�53  ,   $ Center=�54  ,   $
��0 20q�55  ,   $
��Wrap=�56  ,   $��Segoe UI)�57  ,   �� 58  "   -   5        $
��20 0q�58  )   #��[ 5:  )   $1 +MaterialDesignFloatingActionMiniLightButton��5;  )   {�59  )   �� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window.��5=  &     $	
 Add=�6>   5>  #   5?       5@     -   5        $��dtg_allCategories��5@  '   $ Extended=�5B  '   $ FullRow=�5C  '   $
 True��5D  '   $
 True��5E  '   $
 True��5F  '   $ False��5G  '   ��5A  '   �� *CurrentOrder.OrderProducts+ 5H  "     5I  &   $ Category ID��69    5J  9   �� *
CategoryId+  5K  &   $ Category Name��69    5L  9   �� *CategoryName+
  5N  &   $ Actions��6=    5O  *   �� 5P  .   .R�5Q  2   �� -   5        $��Update��5Q  9   $��Center=�5T  9   $��Center=�5U  9   $��5q�5W  9   ��5R  9   �� *'%DataContext.DeleteOrderProductCommand+ ��  DataGrid��5S  9   �� 5W  9   5X  /   5Z  '   
  5[  &    5\  *   �� 5]  .   .R�5^  2   �� -   5        $��Delete��5^  9   $��Center=�5a  9   $��Center=�5b  9   $��5q�5d  9   ��5_  9   �� *'%DataContext.DeleteOrderProductCommand+ ��  DataGrid��5`  9   �� 5d  9   5e  /   5g  '   5j     5m     5n     �� 5o     ��5p     �� 5q     -   5        $��80��5r  %   $��70��5s  %   
������ 
������ .��5v  "   �� $
��auto��6-   $
��auto��5w  -   .+�5x  &     $��24��6>   $��24��5y  >   $��Center=�5z  >   $
 Logout=�5{  >   �� 5|  &   $��Center=�60   $��Log out��5}  0   5~  #   5     .��5�     �� $��16q�6%   5�     5�     5�     5�     5�     5�     