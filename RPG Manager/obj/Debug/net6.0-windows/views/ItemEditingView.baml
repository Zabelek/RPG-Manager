   M S B A M L   `   `   `  ����F  BRPG Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:RPG_Manager.viewsRPG_Manager.views  5   	   '    !RPG_Manager.views.ItemEditingView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:RPG_Manager.views     5   	     � WindowStyle$
  None=�5         defaultStyle#��[  5	   	    � WindowStartupLocation$ Manual=�5
   	    � Left$	 785��5   	   
 � Top$	 200��6    � 
ResizeMode$ NoResize=�5   	    � Title$ ItemEditingView��5   	   $	��450��6!   $	��600��6.   .��5      � .+�5   
   �� $��Nazwa:��6   $	��100��6!   $��30��6-   $
��Left=�69   $	��Top=�6T   $��	20,20,0,0q�6l   ���	#FFB3B3B36   �� 5   
   -   5         ��Name$ itemNameTextBox��5      $	��450��6+   $��30��67   $
��Left=�6C   $	��Top=�6^   $��
125,20,0,0q�6v   ���	#CCFFFFFF6�   �� 5   
   $��
Kategoria:��6   $	��100��6&   $��30��62   $
��Left=�6>   $	��Top=�6Y   $��	20,60,0,0q�6q   ���	#FFB3B3B36�   �� 5   
   -   5         ��Name$ itemCategoryComboBox��5      $	��450��61   $��30��6=   $
��Left=�6I   $	��Top=�6d   $��
125,60,0,0q�6|   �� 5   
   $��Opis:��6   $	��100��6    $��30��6,   $
��Left=�68   $	��Top=�6S   $��
20,100,0,0q�6k   ���	#FFB3B3B36   �� 5   
   -   5        $ itemDescriptionTextBox��5      $	��450��62   $	��250��6>   $
��Left=�6K   $	��Top=�6f   $��125,100,0,0q�6~   ���	#CCFFFFFF �� TextWrapping$ WrapWithOverflow=�6�   �� 5   
   $��Nazwa pliku:��6   $	��130��6'   $��30��63   $
��Left=�6?   $	��Top=�6Z   $��
20,360,0,0q�6r   ���	#FFB3B3B36�   �� 5   
   -   5        $ imagePathTextBox��5      $	��420��6,   $��30��68   $
��Left=�6D   $	��Top=�6_   $��155,360,0,0q�6w   ���	#CCFFFFFF6�   �� 5   
   -   5        	 ��Name$	 okButton��5        boxButtonStyle#��[ 6#   $��OK��6K   $	��100��6X   $��30��6d   $
��Left=�6p   $	��Top=�6�   $��336,410,0,0q�6�   6�   �� 5   
   -   5        $	 cancelButton��5      #��[ 6'   $��Anuluj��6O   $	��100��6`   $��30��6l   $
��Left=�6x   $	��Top=�6�   $��174,410,0,0q�6�   6�   5      5      