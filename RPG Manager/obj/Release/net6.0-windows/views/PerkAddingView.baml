   M S B A M L   `   `   `  ���� F  BRPG Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:RPG_Manager.viewsRPG_Manager.views  &     RPG_Manager.views.PerkAddingView   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:RPG_Manager.views       � WindowStyle$
  None=�   defaultStyle#��[   � WindowStartupLocation$ Manual=� � Left$	 560��
 � Top$	 250�� � 
ResizeMode$ NoResize=� � Title$ PerkAddingView��$	��650��$	��800��.��� .+��� -    ��Name$ cancelButton��  boxButtonStyle#��[ $��Anuluj��$	��100��$��40��$��Center=�$��Bottom=�$��0,0,0,10q��� $��Dodaj Umiejętność:��$	��300��$��40��$
��Left=�$	��Top=�$��20,5,0,0q����	#FFB3B3B3$��24(��� $��Dodaj Talent:��$	��300��$��40��$
��Left=�$	��Top=�$��	420,5,0,0q����	#FFB3B3B3$��24(��� -    ��Name$ professionsFilter��$	��360��$��25��$
��Left=�$	��Top=�$��	20,50,0,0q����	#CCFFFFFF�� -   $ abilitiesFilter��$	��360��$��25��$
��Left=�$	��Top=�$��
420,50,0,0q����	#CCFFFFFF�� $	��360��$	��350��$
��Left=�$	��Top=�$��	20,80,0,0q�.���� -    ��Name$ professionsGrid���� $	��360��$	��265��$
��Left=�$	��Top=�$��
420,80,0,0q�.���� -   $ abilitiesGrid���� -   $ professionsNameTextBox��$	��360��$��25��$
��Left=�$	��Top=�$��
20,450,0,0q����	#CCFFFFFF$
��Bold"��� -   $ abilitiesNameTextBox��$	��360��$��25��$
��Left=�$	��Top=�$��420,360,0,0q����	#CCFFFFFF$
��Bold"��� -   $ abilitiesDescriptionBox��$	��360��$	��125��$
��Left=�$	��Top=�$��420,400,0,0q����	#CCFFFFFF$��14(�	 �� TextWrapping$	 WrapWithOverflow=�$
��Bold"��� -	   
 ��Name$
 professionsStatsComboBox��$	��360��$��35��$
��Left=�$	��Top=�$��
20,490,0,0q�$
��Bold"�����  �� EndPoint$	 0,1&�.���  � Color$ 	#FFF0F0F0��� $ 	#CCE5E5E5�� � Offset$ 1Q��� -
   $ addAbilitiesButton��#��[ $��Dodaj��$	��160��$��35��$
��Left=�$	��Top=�$��420,540,0,0q��� -   $ addProfessionsButton��#��[ $��Dodaj��$	��160��$��35��$
��Left=�$	��Top=�$��
20,538,0,0q��� -   $ removeProfessionsButton��#��[ $��Usuń��$	��160��$��35��$
��Left=�$	��Top=�$��220,540,0,0q��� -   $ removeAbilitiesButton��#��[ $��Usuń��$	��160��$��35��$
��Left=�$	��Top=�$��620,540,0,0q�