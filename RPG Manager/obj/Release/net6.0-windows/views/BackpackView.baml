   M S B A M L   `   `   `  ���� F  BRPG Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:RPG_Manager.viewsRPG_Manager.views  $    RPG_Manager.views.BackpackView   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:RPG_Manager.views       � WindowStyle$
  None=�   defaultStyle#��[   � WindowStartupLocation$ Manual=� � Left$	 260��
 � Top$	 150�� � 
ResizeMode$ NoResize=� � Title$ BackpackView��$	��750��$
��1400��.��� .+��� $*��$/assets/menu/backpack_background.png��$��Right=�$	��Top=�$
��Fill=��� -    ��Name$ previewImage��$-��'/assets/Random Placeholders/Hero/26.png��$	��290��$	��298��$��Right=�$	��Top=�$��	0,66,72,0q�$
��Fill=��� $(��"/assets/menu/item_image_shadow.png��$	��290��$	��298��$��Right=�$	��Top=�$��	0,66,72,0q�$
��Fill=��� $&�� /assets/menu/backpack_border.png��$
��Fill=��� -    ��Name$ itemtitleLabel��$��Nazwa Przedmiotu�����	#FFB3B3B3$	��385��$��40��$��Right=�$	��Top=�$��
0,380,20,0q��� $��/assets/menu/divider.png��$	��390��$��30��$��Right=�$	��Top=�$��
0,410,20,0q��� -    ��Name$ descriptionTextBlock��$��Opis Przedmiotu��$��Right=�$	��Top=�$��
0,435,40,0q�$	��350��$	��250��$��14(�$��WrapWithOverflow=��� -   $ 
titleLabel��$��Plecak:��$	��700��$��50�����	#FFC1C1C1$��30(�$
��Left=�$	��Top=�$��	40,15,0,0q��� $	��945��$	��585��$
��Left=�$	��Top=�$��	20,70,0,0q�$
��Auto=�.��� -   	 �Name$	 	itemsGrid��
 � ColumnDefinitions
 �� $	��30* ��� $	��30* ��� $	��30* ��� $	��30* ��� $��3* � � RowDefinitions �� $	��120 ��� -     boxButtonStyle#��[ $��OK��$	��100��$��45��$��Center=�$��Bottom=�$��0,0,0,15q��� -    ��Name$ equipButton��#��[ $��Wyposaż��$	��115��$��45��$��Right=�$��Bottom=�$��
0,0,290,15q��� -   $ damageButton��#��[ $��Napraw��$	��115��$��45��$��Right=�$��Bottom=�$��
0,0,155,15q��� -	   $ 
editButton��#��[ $��Edytuj��$	��115��$��45��$��Right=�$��Bottom=�$��	0,0,20,15q��� $��60��$��60��$
��Left=�$	��Top=�$'��!/assets/Item Categories/zloto.png��$��
28,673,0,0q��� -
    ��Name$ goldTextBox��$
��1000��$	��200��$��47��$
��Left=�$	��Top=�$��100,677,0,0q�$��24(�$
��Bold"����	#CC000000���	#FFCCCCCC$��Center=�$��5q����	#4C989898�� -   $ goldModTextBox��$��0��$��70��$��47��$
��Left=�$	��Top=�$��340,677,0,0q�$��24(�$
��Bold"����	#CC000000���	#FFCCCCCC$��Center=�$��5q����	#4C989898�� -   #��[ $��+��$��35��$��35��$
��Left=�$��Bottom=�$��
420,0,0,32q�