   M S B A M L   `   `   `  ����
  WpfApp    WpfApp.MessageBoxCustom   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  MessageBoxWindow��5   	   $	��220��5   	   $	��500��5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�5   	   
������� � 
ResizeMode$ 	CanResize=�5   	    � Topmost$
 True��5   	    � ShowInTaskbar$ False��5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��10(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��197* �6   �� 5      $
��295* �6   	 � RowDefinitions	 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5    
   #  MaterialDesignThemes.Wpf.Card  -   5        
  Name$
 
cardHeader��5       $��0��5!      $��10q�5"      $��0q�5#        PrimaryHueDarkBrush#���  5$       ! PrimaryHueDarkForegroundBrush#���  5%      $y�Visible=�5&      $��2��5'      .��5(      �� .+�5)      �� -   5         ��Name$ txtTitle��5)      $��Center=�5*      $��Stretch=�5+         MaterialDesignTitleTextBlock#���  5,      $��20(�5-      Message Title69   5.      5/      �� 50   
   $��Right=�6   $��0,5,5,0q�51      $	��Top=�52      $��1��53      .+�54      �� -   5         ��Name$ btnClose��54      $��35��56      $��35��57      
�������#���  59       * &MaterialDesignFloatingActionDarkButton#��[ 5:      .��5;      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6*   5<      5=      � 5>   
   $��1��6   $��2��5?      .+�5@      � $��20q�6   	 5A      �� 5B      $
��auto �6$   �� 5C      $
��auto �6$   �� 5D      $��* �6$   .+�5G      � $��0��6   	 5H      �� 5I      $
��auto �6(   �� 5J      $��* �6(   .+�5M      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffects 5N      ;  5MaterialDesignThemes.Wpf.Transitions.TransitionEffect  5O         Kind$ FadeIn=�6>     5P      $ SlideInFromBottom=�6>   .��5R      �� -   5         ��Name$ 
txtMessage��5R   "   $��Center=�5S   "    �� 
IsReadOnly$
 True��5T   "   $��0��5U   "   $��5q�5V   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$  ��5W   "   $��18(�5X   "    % !MaterialDesignFloatingHintTextBox#��[ 5Y   "   5Z      5\      � 5]      $��1��6   $��0,20,0,5q�5^       5_      �� 5`      $��* �6+   �� 5a      $
��auto �6+   �� 5b      $
��auto �6+   �� 5c      $��* �6+   .+�5f      �� -   5        $ btnOk��5f      $��1��5h        MaterialDesignRaisedButton#��[ 5i      $��5q�5j      $	��100��5k      $��OK��5l       � ToolTip$ Ok��5m      �� 5n      -   5        $ 	btnCancel��5n      $��2��5p      #��[ 5q      $��5q�5r      $	��100��5s      $��Cancel��5t      $ Cancel��5u      �� 5v      -   5        $ btnYes��5v      $��1��5x      #��[ 5y      $��5q�5z      $	��100��5{      $	��Yes��5|      $	 Yes��5}      �� 5~      -   5        $ btnNo��5~      $��2��5�      #��[ 5�      $��5q�5�      $	��100��5�      $��No��5�      $ No��5�      5�      5�      5�      5�      5�      