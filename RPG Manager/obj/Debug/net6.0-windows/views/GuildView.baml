   M S B A M L   `   `   `  ����F  BRPG Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:RPG_Manager.viewsRPG_Manager.views  5   	   !    RPG_Manager.views.GuildView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:RPG_Manager.views     5   	     � WindowState$  	Maximized=�5   	    � WindowStyle$
 None=�5	   	      defaultStyle#��[  5
   	    � Title$ 	GuildView��5   	   $
��1080��6   $
��1920��6)   .��5      � -   5         �Name$ mainGrid��5      .+�5   
   �� -   5         ��Name$ 
background��5      $'��!/assets/Guild/main_background.png��6$   $
��Fill=�6O   �� 5   
   -   5        $ titleBackground��5      $
��Fill=�6)   $	��938��68   $��80��6D   $
��Left=�6P   $	��Top=�6k   $��0,25,0,0q�6�   $(��"/assets/Guild/title_background.png��6�   �� 5   
   -   5         ��Name$ 
titleLabel��5      $,��&Gildia Poszukiwaczy Przygód w Zgierzu��6$   ���	#FFC1C1C1$��36(�6k   $��
183,35,0,0q�6y   $
��Left=�6�   $	��Top=�6�   �� 5   
   -   5        $ 	goldImage��5      $��231,993,1631,31q�6#   $'��!/assets/Item Categories/zloto.png��6<   �� 5   
   -   5         ��Name$ goldTextBox��5      $�� ��6'   $��301,998,1395,36q�6/   $��10,0,0,0q�6H   $��Center=�6[   $��25(�6}   $
��Bold"�6�   ���	#CCFFFFFF6�   �� 5   
   -   5        $ upgradesTitleLabel��5      $��Obecne Ulepszenia:��6,   $��1432,308,166,732q�6I   ���	#FFC1C1C1$��22(�6z   �� 5   
   -   5        $ descTitleLabel��5      $��Opis Ulepszenia:��6(   $��896,405,702,635q�6C   ���	#FFC1C1C1$��22(�6s   �� 5   
   -	   5         ��Name$ upgradesScrollBar��5      $��1432,348,86,36q�62   ���	#7F000000$
��Auto=�6a   .��5      �� -
   5         ��Name$ upgradesStackPanel��5      5      5      �� 5   
   -   5        	 ��Name$	 furnitureDescriptionBox��5      $��896,724,535,36q�65   ���	#7F000000$��WrapWithOverflow=�6d   
 �� Padding$
 15q�6�   � 5   
   -   5        $ furnitureImageGrid��5      $��896,496,535,356q�6,   ���	#7F0000006E   �� 5   
   -   5        $"	 furnitureDescriptionTitleBox��5      $��896,445,535,584q�6:   ���	#7F000000$��WrapWithOverflow=�6j   $
 15q�6�   5      5      