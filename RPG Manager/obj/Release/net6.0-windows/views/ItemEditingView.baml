   M S B A M L   `   `   `  ���� F  BRPG Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:RPG_Manager.viewsRPG_Manager.views  '    !RPG_Manager.views.ItemEditingView   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:RPG_Manager.views       � WindowStyle$
  None=�   defaultStyle#��[   � WindowStartupLocation$ Manual=� � Left$	 785��
 � Top$	 200�� � 
ResizeMode$ NoResize=� � Title$ ItemEditingView��$	��450��$	��600��.��� .+��� $��Nazwa:��$	��100��$��30��$
��Left=�$	��Top=�$��	20,20,0,0q����	#FFB3B3B3�� -    ��Name$ itemNameTextBox��$	��450��$��30��$
��Left=�$	��Top=�$��
125,20,0,0q����	#CCFFFFFF�� $��
Kategoria:��$	��100��$��30��$
��Left=�$	��Top=�$��	20,60,0,0q����	#FFB3B3B3�� -    ��Name$ itemCategoryComboBox��$	��450��$��30��$
��Left=�$	��Top=�$��
125,60,0,0q��� $��Opis:��$	��100��$��30��$
��Left=�$	��Top=�$��
20,100,0,0q����	#FFB3B3B3�� -   $ itemDescriptionTextBox��$	��450��$	��250��$
��Left=�$	��Top=�$��125,100,0,0q����	#CCFFFFFF �� TextWrapping$ WrapWithOverflow=��� $��Nazwa pliku:��$	��130��$��30��$
��Left=�$	��Top=�$��
20,360,0,0q����	#FFB3B3B3�� -   $ imagePathTextBox��$	��420��$��30��$
��Left=�$	��Top=�$��155,360,0,0q����	#CCFFFFFF�� -   	 ��Name$	 okButton��  boxButtonStyle#��[ $��OK��$	��100��$��30��$
��Left=�$	��Top=�$��336,410,0,0q��� -   $	 cancelButton��#��[ $��Anuluj��$	��100��$��30��$
��Left=�$	��Top=�$��174,410,0,0q�