   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp  5   	   !    WpfApp.ChangePasswordWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WpfApp     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	��400��5	   	   $	��400��5
   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency$
 True��5   	   
������  � 
ResizeMode$ NoResize=�5   	   $��18(�5   	      MaterialDesignFont#���   5   	   .��5      � $��20q�6    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6      ShadowDepth$ 1Q�5         Opacity$	 0.4Q�5      .+�5   
   �� -   5        $	��Top=�5      $��Right=�5      $��	0 13 14 0q�5       J� Opacity$	 0.3Q�5      
���   �
������ 	 K� ZIndex$	 1��5!      
������ .��5#      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 Close=�6&   $��20��5$   &   $��20��5%   &   5&      �� 5'   
   -   5         ��Name$ RightSection��5'      $��1��5(       �� CornerRadius$ 20 20 20 20��5)      
����� �$��1q�5+      
�������._�5-      � .+�5/      �� $��16q�6   .+�50      �� $��Change Password��6    $��Center=�51       $��Center=�52       $��24(�53       $
��Bold"�54        �� TextAlignment$ Center=�55       $
��0 20q�56       $
��Wrap=�57       $��Segoe UI)�58       ��59      �� 5:       �� 
StartPoint$	 0,0&�62    �� EndPoint$	 1,1&�5;   2   .��5<   "   �  � Color$ 	#FF6699CC��6/    � Offset$ 0Q�5=   /   � 5>   "   $ 	#FF336699��6/   $ 1Q�5?   /   5@      5B      � 5E      $��10 20q�6#   $	��300��5F   #   $
��Left=�5G   #    � ColumnDefinitions 5H   "   �� 5I   &   $��1* �67   6D   �� 5J   &   $
��1.5* �67   6F    � RowDefinitions 5L   "   �� 5M   &   66   �� 5N   &   66   �� 5O   &   66   .+�5R   "   �� $
��0 10q�6,   $��
Montserrat)�5S   ,   $��14(�5T   ,   $��0��5U   ,   $��0��5V   ,   Old password:5X   #   G� 5Z      -   5        $��txtOldPassword��5[   *   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Old Password��5\   *   $��0 0 0 10q�5]   *   $��14(�5^   *   $��0��5_   *   $��1��5`   *   .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton$
 True��5b   *    / +MaterialDesignFloatingHintRevealPasswordBox#��[ 5c   *   0  *MaterialDesignThemes.Wpf.PasswordBoxAssist   Password 5a   *   �� *	Password2+ �� Mode$ TwoWay=�5c   *   �� 5e      $
��0 10q�6$   $��
Montserrat)�5f   ,   $��14(�5g   ,   $��1��5h   ,   $��0��5i   ,   New password:5k   #   G� 5l      -   5        $��txtNewPassword��5l   &   $ New Password��5m   &   $��0 0 0 10q�5n   &   $��14(�5o   &   $��1��5p   &   $��1��5q   &   $
 True��5s   &   #��[ 5t   &    5r   &   �� *	Password2+$ TwoWay=�5t   &   �� 5u      $
��0 10q�6$   $��
Montserrat)�5v   $   $��14(�5w   $   $��2��5x   $   $��0��5y   $   
Confirm:5{      G� 5|      -   5        $��txtConfirmPassword��5|   &   $ Confirm password��5}   &   $��0 0 0 10q�5~   &   $��14(�5   &   $��2��5�   &   $��1��5�   &   $
 True��5�   &   #��[ 5�   &    5�   &   �� *	Password2+$ TwoWay=�5�   &   5�      �� 5�       �� Orientation$ 
Horizontal=�6!   $��Center=�6:   .+�5�      �� -   5        $	��100��5�   !   $
��10 0q�5�   !   ���	#FF6699CC
�������$��10(�5�   !   .��5�   7   	Confirm6@   �� 5�      -   5        $	��100��5�   !   ���	#FF6699CC
�������$
��10 0q�5�   !   $��10(�5�   !   .��5�   5   Cancel6=   5�      5�      5�      5�      5�      5�      