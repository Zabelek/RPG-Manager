   M S B A M L   `   `   `  ����F  BRPG Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:RPG_Manager.viewsRPG_Manager.views  5   	   &     RPG_Manager.views.PerkAddingView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:RPG_Manager.views     5   	     � WindowStyle$
  None=�5         defaultStyle#��[  5	   	    � WindowStartupLocation$ Manual=�5
   	    � Left$	 560��5   	   
 � Top$	 250��6    � 
ResizeMode$ NoResize=�5   	    � Title$ PerkAddingView��5   	   $	��650��6    $	��800��6-   .��5      � .+�5   
   �� -   5         ��Name$ cancelButton��5        boxButtonStyle#��[ 6'   $��Anuluj��6O   $	��100��6{   $��40��6�   $��Center=�6�   $��Bottom=�6�   $��0,0,0,10q�6�   �� 5   
   $��Dodaj Umiejętność:��6   $	��300��6-   $��40��69   $
��Left=�6E   $	��Top=�6`   $��20,5,0,0q�6x   ���	#FFB3B3B3$��24(�6�   �� 5   
   $��Dodaj Talent:��6   $	��300��6(   $��40��64   $
��Left=�6@   $	��Top=�6[   $��	420,5,0,0q�6s   ���	#FFB3B3B3$��24(�6�   �� 5   
   -   5         ��Name$ professionsFilter��5      $	��360��6-   $��25��69   $
��Left=�6E   $	��Top=�6`   $��	20,50,0,0q�6x   ���	#CCFFFFFF6�   �� 5   
   -   5        $ abilitiesFilter��5      $	��360��6+   $��25��67   $
��Left=�6C   $	��Top=�6^   $��
420,50,0,0q�6v   ���	#CCFFFFFF6�   �� 5   
   $	��360��6   $	��350��6#   $
��Left=�60   $	��Top=�6K   $��	20,80,0,0q�6c   .��5      �� -   5         ��Name$ professionsGrid��5      5      5      �� 5   
   $	��360��6   $	��265��6#   $
��Left=�60   $	��Top=�6K   $��
420,80,0,0q�6c   .��5      �� -   5        $ abilitiesGrid��5      5      5      �� 5   
   -   5        $ professionsNameTextBox��5      $	��360��62   $��25��6>   $
��Left=�6J   $	��Top=�6e   $��
20,450,0,0q�6}   ���	#CCFFFFFF$
��Bold"�6�   �� 5   
   -   5        $ abilitiesNameTextBox��5      $	��360��60   $��25��6<   $
��Left=�6H   $	��Top=�6c   $��420,360,0,0q�6{   ���	#CCFFFFFF$
��Bold"�6�   �� 5   
   -   5        $ abilitiesDescriptionBox��5      $	��360��63   $	��125��6?   $
��Left=�6L   $	��Top=�6g   $��420,400,0,0q�6   ���	#CCFFFFFF$��14(�6�   	 �� TextWrapping$	 WrapWithOverflow=�6�   $
��Bold"�6�   �� 5   
   -	   5        
 ��Name$
 professionsStatsComboBox��5      $	��360��65   $��35��6A   $
��Left=�6M   $	��Top=�6h   $��
20,490,0,0q�6�   $
��Bold"�6�   ��5       �� 5!       �� EndPoint$	 0,1&�6&   .��5"      �  � Color$ 	#FFF0F0F0��6#   � 5#      $ 	#CCE5E5E5��6#    � Offset$ 1Q�65   5$      5&      �� 5'   
   -
   5        $ addAbilitiesButton��5'      #��[ 6-   $��Dodaj��6U   $	��160��6e   $��35��6q   $
��Left=�6}   $	��Top=�6�   $��420,540,0,0q�6�   6�   �� 5(   
   -   5        $ addProfessionsButton��5(      #��[ 6/   $��Dodaj��6W   $	��160��6g   $��35��6s   $
��Left=�6   $	��Top=�6�   $��
20,538,0,0q�6�   6�   �� 5)   
   -   5        $ removeProfessionsButton��5)      #��[ 62   $��Usuń��6Z   $	��160��6i   $��35��6u   $
��Left=�6�   $	��Top=�6�   $��220,540,0,0q�6�   6�   �� 5*   
   -   5        $ removeAbilitiesButton��5*      #��[ 60   $��Usuń��6X   $	��160��6g   $��35��6s   $
��Left=�6   $	��Top=�6�   $��620,540,0,0q�6�   6�   5+      5,      