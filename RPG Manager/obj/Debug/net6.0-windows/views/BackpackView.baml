   M S B A M L   `   `   `  ����F  BRPG Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:RPG_Manager.viewsRPG_Manager.views  5   	   $    RPG_Manager.views.BackpackView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:RPG_Manager.views     5   	     � WindowStyle$
  None=�5   	      defaultStyle#��[  5	   	    � WindowStartupLocation$ Manual=�5
   	    � Left$	 260��5   	   
 � Top$	 150��6    � 
ResizeMode$ NoResize=�5   	    � Title$ BackpackView��5   	   $	��750��6   $
��1400��6+   .��5      � .+�5   
   �� $*��$/assets/menu/backpack_background.png��6   $��Right=�6>   $	��Top=�6Z   $
��Fill=�6r   �� 5   
   -   5         ��Name$ previewImage��5      $-��'/assets/Random Placeholders/Hero/26.png��6&   $	��290��6W   $	��298��6c   $��Right=�6p   $	��Top=�6�   $��	0,66,72,0q�6�   $
��Fill=�6�   �� 5   
   $(��"/assets/menu/item_image_shadow.png��6   $	��290��6<   $	��298��6H   $��Right=�6U   $	��Top=�6q   $��	0,66,72,0q�6�   $
��Fill=�6�   �� 5   
   $&�� /assets/menu/backpack_border.png��6   $
��Fill=�6:   �� 5   
   -   5         ��Name$ itemtitleLabel��5      $��Nazwa Przedmiotu��6(   ���	#FFB3B3B3$	��385��6Z   $��40��6f   $��Right=�6r   $	��Top=�6�   $��
0,380,20,0q�6�   �� 5   
   $��/assets/menu/divider.png��6   $	��390��62   $��30��6>   $��Right=�6J   $	��Top=�6f   $��
0,410,20,0q�6~   �� 5   
   -   5         ��Name$ descriptionTextBlock��5      $��Opis Przedmiotu��62   $��Right=�6I   $	��Top=�6e   $��
0,435,40,0q�6}   $	��350��6�   $	��250��6�   $��14(�6�   $��WrapWithOverflow=�6�   �� 5   
   -   5        $ 
titleLabel��5      $��Plecak:��6$   $	��700��66   $��50��6B   ���	#FFC1C1C1$��30(�6e   $
��Left=�6s   $	��Top=�6�   $��	40,15,0,0q�6�   �� 5   
   $	��945��6   $	��585��6#   $
��Left=�60   $	��Top=�6K   $��	20,70,0,0q�6c   $
��Auto=�6v   .��5      � -   5        	 �Name$	 	itemsGrid��5      
 � ColumnDefinitions
 5      �� 5      $	��30* �6'   �� 5      $	��30* �6'   �� 5      $	��30* �6'   �� 5      $	��30* �6'   �� 5      $��3* �6'    � RowDefinitions 5       �� 5!      $	��120 �6$   5#      5$      �� 5%   
   -   5          boxButtonStyle#��[ 5%      $��OK��69   $	��100��6F   $��45��6R   $��Center=�6^   $��Bottom=�6{   $��0,0,0,15q�6�   6�   �� 5&   
   -   5         ��Name$ equipButton��5&      #��[ 6&   $��Wyposaż��6N   $	��115��6`   $��45��6l   $��Right=�6x   $��Bottom=�6�   $��
0,0,290,15q�6�   6�   �� 5'   
   -   5        $ damageButton��5'      #��[ 6'   $��Napraw��6O   $	��115��6`   $��45��6l   $��Right=�6x   $��Bottom=�6�   $��
0,0,155,15q�6�   6�   �� 5(   
   -	   5        $ 
editButton��5(      #��[ 6%   $��Edytuj��6M   $	��115��6^   $��45��6j   $��Right=�6v   $��Bottom=�6�   $��	0,0,20,15q�6�   6�   �� 5)   
   $��60��6   $��60��6   $
��Left=�6'   $	��Top=�6B   $'��!/assets/Item Categories/zloto.png��6Z   $��
28,673,0,0q�6�   �� 5*   
   -
   5         ��Name$ goldTextBox��5*      $
��1000��6'   $	��200��63   $��47��6?   $
��Left=�6K   $	��Top=�6f   $��100,677,0,0q�6~   $��24(�6�   $
��Bold"�6�   ���	#CC000000���	#FFCCCCCC$��Center=�6�   $��5q�6  ���	#4C9898986  �� 5+   
   -   5        $ goldModTextBox��5+      $��0��6*   $��70��63   $��47��6>   $
��Left=�6J   $	��Top=�6e   $��340,677,0,0q�6}   $��24(�6�   $
��Bold"�6�   ���	#CC000000���	#FFCCCCCC$��Center=�6�   $��5q�6  ���	#4C9898986  �� 5,   
   -   5        #��[ 5,      $��+��69   $��35��6E   $��35��6P   $
��Left=�6\   $��Bottom=�6w   $��
420,0,0,32q�6�   6�   5-      5.      