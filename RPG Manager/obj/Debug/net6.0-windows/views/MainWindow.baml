   M S B A M L   `   `   `  ����F  BRPG Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:RPG_ManagerRPG_Manager  5   	       RPG_Manager.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:RPG_Manager     5   	     � WindowState$  	Maximized=�5   	    � WindowStyle$
 None=�5	   	      defaultStyle#��[  5
   	    � Title$ RPG Manager��5   	   $
��1080��6   $
��1920��6+   .��5      � -   5         �Name$ mainGrid��5      .+�5   
   �� -   5         ��Name$ backgroundImage��5      $!��/assets/background/main.png��6)   $
��Fill=�6N   �� 5   
   $!��/assets/background/fade.png��6   $
��Fill=�65    J� OpacityMask �	#ff000000 � Triggers 5      :� 5       :� RoutedEvent$ Loaded��6   .[�5      �� .��5      ��  g� Duration$ 00:00:11D�6%   	 �� TargetProperty$	 Opacity�69   .��5      W� 
 W� From
 16.   	 W� To 067   5      5      5      5      �� 5   
   -   5        $ mainButtonsShadow��5      $*��$/assets/menu/main_buttons_shadow.png��6+   $
��Left=�6Y    �	#B20000006t   �� 5   
   -   5         ��Name$ heroesViewButton��5        menuButtonStyle#��[ 6+   $
��Left=�6U   $��	20,10,0,0q�6p   $	��Top=�6�   $��60��6�   $��60��6�   .��5      �� $!��/assets/menu/icons/hero.png��6   5      �� 5   
   -   5        $ guildViewButton��5      #��[ 6*   $
��Left=�6T   $��	20,90,0,0q�6o   $	��Top=�6�   $��60��6�   $��60��6�   .��5      �� $"��/assets/menu/icons/guild.png��6   5      �� 5    
   -   5        $ creatorsViewButton��5       #��[ 6-   $
��Left=�6W   $��
20,170,0,0q�6r   $	��Top=�6�   $��60��6�   $��60��6�   .��5!      �� $"��/assets/menu/icons/anvil.png��6   5"      �� 5#   
   -   5        $ 
exitButton��5#      #��[ 6%   $
��Left=�6O   $��20,1000,0,0q�6j   $	��Top=�6   $��60��6�   $��60��6�   .��5$      �� $!��/assets/Menu/Icons/door.png��6   5%      �� 5&   
   -   5        $ 
saveButton��5&      #��[ 6%   $
��Left=�6O   $��
20,930,0,0q�6j   $	��Top=�6~   $��60��6�   $��60��6�   .��5'      �� $!��/assets/Menu/Icons/save.png��6   5(      �� 5)   
   -	   5        $ dialogShadow��5)      $!��/assets/background/fade.png��6&   $
��Fill=�6K    �	#D2000000 5*      :� 5+      $ Loaded��6   .[�5,      �� .��5-      �� $ 00:00:01D�6%   $	 Opacity�69   .��5.      W� 
 06.    167   5/      50      51      53      54      55      