   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp  5   	   $    WpfApp.UpdateOrderStatusWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WpfApp     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $	��320��5	   	   $	��400��5
   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency$
 True��5   	   
������  � 
ResizeMode$ NoResize=�5   	   $��18(�5   	      MaterialDesignFont#���   5   	   .��5      � $��20q�6    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6      ShadowDepth$ 1Q�5         Opacity$	 0.4Q�5      .+�5   
   �� -   5        $	��Top=�5      $��Right=�5      $��	0 13 14 0q�5       J� Opacity$	 0.3Q�5      
���   �
������ 	 K� ZIndex$	 1��5"      
������ .��5$      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 Close=�6&   $��20��5%   &   $��20��5&   &   5'      �� 5(   
   -   5         ��Name$ RightSection��5(      $��1��5)       �� CornerRadius$ 20 20 20 20��5*      
����� �$��1q�5,      
�������._�5.      � .+�50      �� $��16q�6   .+�51      �� $��Update Order Status��6    $��Center=�52       $��Center=�53       $��24(�54       $
��Bold"�55        �� TextAlignment$ Center=�56       $
��0 20q�57       $
��Wrap=�58       $��Segoe UI)�59       ��5:      �� 5;       �� 
StartPoint$	 0,0&�62    �� EndPoint$	 1,1&�5<   2   .��5=   "   �  � Color$ 	#FF6699CC��6/    � Offset$ 0Q�5>   /   � 5?   "   $ 	#FF336699��6/   $ 1Q�5@   /   5A      5C      � 5F      $��10 20q�6   $	��300��5G      $
��Left=�5H       � ColumnDefinitions 5I      �� 5J      $��1* �6/   6<   �� 5K      $
��1.5* �6/   6>    � RowDefinitions 5M      �� 5N      6.   �� 5O      6.   �� 5P      6.   .+�5S      �� $
��0 10q�6$   $��
Montserrat)�5T   $   $��14(�5U   $   $��0��5V   $   $��0��5W   $   	Order ID:5Y      �� 5[      -   5        $��
txtOrderId��5[   $   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Old Password��5\   &   $
��0 10q�5]   &   $��14(�5^   &   $��0��5_   &   $��1��5`   &   .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton$
 True��5b   &   0  *MaterialDesignThemes.Wpf.PasswordBoxAssist   Password 5a   &   �� *	Password2+ �� Mode$ TwoWay=�5b   &   �� 5e      $
��0 10q�6$   $��
Montserrat)�5f   $   $��14(�5g   $   $��1��5h   $   $��0��5i   $   	Status:5k      �� 5l      -   5        $��	cboStatus��5q   #   $ Select Status��5l   #   $��0 0 0 5q�5m   #   $��14(�5n   #   $��1��5o   #   $��1��5p   #   5r      5t      �� 5u       �� Orientation$ 
Horizontal=�6!   $��Center=�5v   !   .+�5w      �� -   5        $	��100��5w   !   $
��10 0q�5x   !   ���	#FF6699CC
�������$��10(�5{   !   .��5|   7   	Confirm6@   �� 5}      -   5        $	��100��5}   !   ���	#FF6699CC
�������$
��10 0q�5�   !   $��10(�5�   !   .��5�   5   Cancel6=   5�      5�      5�      5�      5�      5�      