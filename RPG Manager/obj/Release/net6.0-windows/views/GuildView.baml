   M S B A M L   `   `   `  ���� F  BRPG Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:RPG_Manager.viewsRPG_Manager.views  !    RPG_Manager.views.GuildView   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:RPG_Manager.views       � WindowState$  	Maximized=� � WindowStyle$
 None=�   defaultStyle#��[   � Title$ 	GuildView��$
��1080��$
��1920��.��� -    �Name$ mainGrid��.+��� -    ��Name$ 
background��$'��!/assets/Guild/main_background.png��$
��Fill=��� -   $ titleBackground��$
��Fill=�$	��938��$��80��$
��Left=�$	��Top=�$��0,25,0,0q�$(��"/assets/Guild/title_background.png���� -    ��Name$ 
titleLabel��$,��&Gildia Poszukiwaczy Przygód w Zgierzu�����	#FFC1C1C1$��36(�$��
183,35,0,0q�$
��Left=�$	��Top=��� -   $ 	goldImage��$��231,993,1631,31q�$'��!/assets/Item Categories/zloto.png���� -    ��Name$ goldTextBox��$�� ��$��301,998,1395,36q�$��10,0,0,0q�$��Center=�$��25(�$
��Bold"����	#CCFFFFFF�� -   $ upgradesTitleLabel��$��Obecne Ulepszenia:��$��1432,308,166,732q����	#FFC1C1C1$��22(��� -   $ descTitleLabel��$��Opis Ulepszenia:��$��896,405,702,635q����	#FFC1C1C1$��22(��� -	    ��Name$ upgradesScrollBar��$��1432,348,86,36q����	#7F000000$
��Auto=�.���� -
    ��Name$ upgradesStackPanel���� -   	 ��Name$	 furnitureDescriptionBox��$��896,724,535,36q����	#7F000000$��WrapWithOverflow=�
 �� Padding$
 15q�� -   $ furnitureImageGrid��$��896,496,535,356q����	#7F000000�� -   $"	 furnitureDescriptionTitleBox��$��896,445,535,584q����	#7F000000$��WrapWithOverflow=�$
 15q�