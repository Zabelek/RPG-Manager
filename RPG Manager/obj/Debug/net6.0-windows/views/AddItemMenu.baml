   M S B A M L   `   `   `  ����F  BRPG Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:RPG_Manager.viewsRPG_Manager.views  5   	   #    RPG_Manager.views.AddItemMenu   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:RPG_Manager.views     5   	     � WindowStyle$
  None=�5   	      defaultStyle#��[  5	   	    � WindowStartupLocation$ Manual=�5
   	    � Left$	 785��5   	   
 � Top$	 200��6    � 
ResizeMode$ NoResize=�5   	    � Title$ AddItemMenu��5   	   $	��550��6   $	��350��6*   .��5      � .+�5   
   �� $��Dodawanie Przedmiotu��6   $��Center=�6/   $	��Top=�6L   ���	#FFB3B3B36d   �� 5   
   -   5         ��Name$ 	searchBar��5      $	��Top=�6%   $��20��6=   $	��300��6I   $��Center=�6U   $��0,35,0,0q�6r   ���	#CCFFFFFF6�   �� 5   
   $	��300��6   $	��330��6#   $	��Top=�60   $��0,60,0,0q�6H   $
��Auto=�6Z   ���	#FF2F2F2F.��5      �� -   5         ��Name$ itemsStackPanel��5      5      �� 5   
   $��Szybkie Tworzenie��6   $��Center=�6,   $��Bottom=�6I   ���	#FFB3B3B3$��	0,0,0,110q�6{   �� 5   
   -   5        $ addItemTextBox��5      $	��230��6*   $��25��66   $��Bottom=�6B   $��	0,0,25,85q�6]   $��Right=�6p   ���	#CCFFFFFF6�   �� 5   
   $��Nazwa��6   $
��Left=�6    $��Bottom=�6;   ���	#FFB3B3B3$��	25,0,0,85q�6m   $��14(�6�   �� 5   
   $��	Kategoria��6   $
��Left=�6$   $��Bottom=�6?   ���	#FFB3B3B3$��	10,0,0,49q�6q   $��14(�6�   �� 5   
   -   5         ��Name$ addItemCombvoBox��5      $	��230��6-   $��25��69   $��Bottom=�6E   $��	0,0,25,50q�6`   $��Right=�6s   �� 5   
   -   5          boxButtonStyle#��[ 5      $��Stwórz��69   $	��130��6J   $��30��6V   $��Bottom=�6b   $��Center=�6}   $��0,0,0,10q�6�   6�   5      5      