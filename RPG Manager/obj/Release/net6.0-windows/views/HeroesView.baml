   M S B A M L   `   `   `  ���� F  BRPG Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:RPG_Manager.viewsRPG_Manager.views  "    RPG_Manager.views.HeroesView   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:RPG_Manager.views        defaultStyle#��[    � Title$  
HeroesView��$
��1080��$
��1920��.��� .+��� -    ��Name$ shadow��$!��/assets/background/fade.png��$
��Fill=� J� OpacityMask �	#B2000000 � Triggers :�  :� RoutedEvent$ Loaded��.[��� .����  g� Duration$ 00:00:7D� �� TargetProperty$ Opacity�.��W�  W� From 0	 W� To 1�� -   $ 	heroImage��$,��&/assets/Random Placeholders/Hero/1.png��$	��305��$	��305��$
��Left=�$	��Top=�$��
87,116,0,0q�$
��Fill=��� -   $ heroImageShadow��$(��"/assets/menu/hero_image_shadow.png��$	��305��$	��305��$
��Left=�$	��Top=�$��
87,116,0,0q�$
��Fill=��� -   $ healthBarZero��$#��/assets/menu/health_bar_0.png��$
��Left=�$	��Top=�$��
83,447,0,0q�$��33��$	��486��$
��Fill=��� -   $ healthBarFull��$#��/assets/menu/health_bar_1.png��$
��Left=�$	��Top=�$��
83,447,0,0q�$��33��$	��486��$
��Fill=��� -   $ healthBarShadow��$(��"/assets/menu/health_bar_shadow.png��$
��Left=�$	��Top=�$��
83,447,0,0q�$��33��$	��486��$
��Fill=��� -   $ 
heroBorder��$"��/assets/Menu/hero_border.png��$
��Left=�$	��Top=�$��0,0,0,0q�$
��1080��$	��650���� -   	 ��Name$	 heroComboBox��$
��Left=�$��	85,60,0,0q�$	��Top=�$	��485��$��35�����	#99AFAFAF���	#00ACACAC �	#99000000$
��Bold"�$��10,4,0,0q�$��22(��� -	   $ strengthIcon��$%��/assets/menu/icons/strength.png��$
��Left=�$	��Top=�$��
75,502,0,0q�$��50��$��50�� �	#CC000000�� -
   $ dextrityIcon��$%��/assets/menu/icons/dextrity.png��$
��Left=�$	��Top=�$��150,502,0,0q�$��50��$��50�� �	#CC000000�� -   $ enduranceIcon��$#��/assets/menu/icons/health.png��$
��Left=�$	��Top=�$��225,502,0,0q�$��50��$��50�� �	#CC000000�� -   $ charismaIcon��$%��/assets/menu/icons/charisma.png��$
��Left=�$	��Top=�$��300,502,0,0q�$��50��$��50�� �	#CC000000�� -   $ intelligenceIcon��$)��#/assets/menu/icons/intelligence.png��$
��Left=�$	��Top=�$��375,502,0,0q�$��50��$��50�� �	#CC000000�� -   $ 	magicIcon��$"��/assets/menu/icons/magic.png��$
��Left=�$	��Top=�$��450,502,0,0q�$��50��$��50�� �	#CC000000�� -   $ perceptionIcon��$'��!/assets/menu/icons/perception.png��$
��Left=�$	��Top=�$��525,502,0,0q�$��50��$��50�� �	#CC000000�� -   
 ��Name$
 	raceLabel��$��Rasa:��$
��Left=�$��410,105,0,0q�$	��Top=����	#FFD4D4D4$��14(��� -   $
 raceLabelContent��$
��Rasa��$
��Left=�$��410,123,0,0q�$	��Top=����	#FFD4D4D4�� -   $
 ageLabel��$��Wiek:��$
��Left=�$��410,147,0,0q�$	��Top=����	#FFD4D4D4$��14(��� -   $
 ageLabelContent��$
��Wiek��$
��Left=�$��410,165,0,0q�$	��Top=����	#FFD4D4D4�� -   $
 weightLabel��$��Waga:��$
��Left=�$��500,148,0,0q�$	��Top=����	#FFD4D4D4$��14(��� -   $
 weightLabelContent��$
��Waga��$
��Left=�$��500,165,0,0q�$	��Top=����	#FFD4D4D4�� -    ��Name$ healthLabel��  menuButtonStyle#��[ $��100/100��$
��Left=�$��
83,447,0,0q�$	��Top=����	#FFD4D4D4$	��485��$��Center=�$��Center=�$��30��$
��Bold"�$��22(��� -   $
 strengthLabel��$��1��$
��Left=�$��
75,550,0,0q�$	��Top=����	#FFD4D4D4$��50��$��Center=�$��53��$��36(��� -   $
 dextrityLabel��$��1��$
��Left=�$��150,550,0,0q�$	��Top=����	#FFD4D4D4$��50��$��Center=�$��53��$��36(��� -   $
 endurancehLabel��$��1��$
��Left=�$��225,550,0,0q�$	��Top=����	#FFD4D4D4$��50��$��Center=�$��53��$��36(��� -   $
 charismaLabel��$��1��$
��Left=�$��300,550,0,0q�$	��Top=����	#FFD4D4D4$��50��$��Center=�$��53��$��36(��� -   $
 intelligenceLabel��$��1��$
��Left=�$��375,550,0,0q�$	��Top=����	#FFD4D4D4$��50��$��Center=�$��53��$��36(��� -   $
 
magicLabel��$��1��$
��Left=�$��450,550,0,0q�$	��Top=����	#FFD4D4D4$��50��$��Center=�$��53��$��36(��� -   $
 perceptionLabel��$��1��$
��Left=�$��525,550,0,0q�$	��Top=����	#FFD4D4D4$��50��$��Center=�$��53��$��36(��� -   $ statsdivider��$��
57,596,0,0q�$��/assets/menu/divider.png��$
��Left=�$	��Top=�$	��535��$��40���� -   $ professionsDivider��$��
57,850,0,0q�$��/assets/menu/divider.png��$
��Left=�$	��Top=�$	��535��$��40���� -     ��Name$ professionScroll��$	��520��$
��Left=�$	��Top=�$	��220��$��
65,630,0,0q�$
��Auto=�.���� -!    ��Name$ professionsStackPanel���� -"   $ abilitiesScroll��$	��300��$
��Left=�$	��Top=�$	��140��$��
70,880,0,0q�$
��Auto=�.���� -#   $ abilitiesStackPanel���� -$    ��Name$ 
notesPanel��$
��Left=�$��370,880,0,0q� �� TextWrapping$
 Wrap=�$��TextBox��$	��Top=�$	��200��$	��140��$
��Bold"����	#CCFFFFFF$��2q� �� AcceptsReturn$
 True���� -%   $ backpackButton��#��[ $
��Left=�$��400,351,0,0q�$	��Top=�$��45��$��65��.���� $%��/assets/menu/icons/backpack.png��$��2,0,2,0q��� -&   $ heteronomiconButton��#��[ $
��Left=�$��458,351,0,0q�$	��Top=�$��45��$��65��.���� $*��$/assets/menu/icons/heteronomicon.png��$��2,0,2,0q��� -'   $ perksButton��#��[ $
��Left=�$��516,351,0,0q�$	��Top=�$��45��$��65��.���� $"��/assets/menu/icons/perks.png��$��2,0,2,0q�