   M S B A M L   `   `   `  ���� F  BRPG Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:RPG_ManagerRPG_Manager      RPG_Manager.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:RPG_Manager       � WindowState$  	Maximized=� � WindowStyle$
 None=�   defaultStyle#��[   � Title$ RPG Manager��$
��1080��$
��1920��.��� -    �Name$ mainGrid��.+��� -    ��Name$ backgroundImage��$!��/assets/background/main.png��$
��Fill=��� $!��/assets/background/fade.png��$
��Fill=� J� OpacityMask �	#ff000000 � Triggers :�  :� RoutedEvent$ Loaded��.[��� .����  g� Duration$ 00:00:11D�	 �� TargetProperty$	 Opacity�.��W� 
 W� From
 1	 W� To 0�� -   $ mainButtonsShadow��$*��$/assets/menu/main_buttons_shadow.png��$
��Left=� �	#B2000000�� -    ��Name$ heroesViewButton��  menuButtonStyle#��[ $
��Left=�$��	20,10,0,0q�$	��Top=�$��60��$��60��.���� $!��/assets/menu/icons/hero.png���� -   $ guildViewButton��#��[ $
��Left=�$��	20,90,0,0q�$	��Top=�$��60��$��60��.���� $"��/assets/menu/icons/guild.png���� -   $ creatorsViewButton��#��[ $
��Left=�$��
20,170,0,0q�$	��Top=�$��60��$��60��.���� $"��/assets/menu/icons/anvil.png���� -   $ 
exitButton��#��[ $
��Left=�$��20,1000,0,0q�$	��Top=�$��60��$��60��.���� $!��/assets/Menu/Icons/door.png���� -   $ 
saveButton��#��[ $
��Left=�$��
20,930,0,0q�$	��Top=�$��60��$��60��.���� $!��/assets/Menu/Icons/save.png���� -	   $ dialogShadow��$!��/assets/background/fade.png��$
��Fill=� �	#D2000000 :� $ Loaded��.[��� .���� $ 00:00:01D�$	 Opacity�.��W� 
 0 1