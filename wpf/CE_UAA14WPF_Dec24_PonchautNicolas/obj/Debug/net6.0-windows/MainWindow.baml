   M S B A M L   `   `   `  ����\  XCE_UAA14WPF_Dec24_PonchautNicolas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:CE_UAA14WPF_Dec24_PonchautNicolas!CE_UAA14WPF_Dec24_PonchautNicolas  5   	   2    ,CE_UAA14WPF_Dec24_PonchautNicolas.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:CE_UAA14WPF_Dec24_PonchautNicolas     5   	     � Title$  
MainWindow��5   	   $
��1000��6   $
��1200��6*   $��22(�67   $
��Bold"�6E   ���	#FFEBD9B4.��5	      � -   5         �Name$
 body��5	       � ColumnDefinitions 5
   
   �� 5      $��2* �6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      $��8* �6   �� 5      .+�5   
   �� $��34(�6   $��Center=�6"   $��Center=�6=   ���	#FF638889$��2��6q   $"VERIFIONS VOS CONNAISSANCES en WPF6�   � 5   
   -   5        $ 
gridchange��5      $��1��6#   62   �� 5   
   $��1��6   $��1��6"   ���#9DBC98.+�5      �� 
���   �
�������$��Paramétrage��5   ?   .��5      �� .+�5      �� $��0,25,0,0q�6   $��Choix de la disposition��5   S   .��5      �� .+�5      	� -   5         	�Name$ rbSolitaire��5   *   $��	Solitaire��6?    	� 	GroupName$ disposition��6S   $��10q�6k   	� 5      -   5        $ 	rbMarelle��5   *   $��Marelle��6=   $ disposition��6O   $��10q�6g   	� 5       -   5        $ rbLibre��5    *   $��Une Bande Latérale��6;   $ disposition��6X   $��10q�6p   5!      5"      �� 5#      -   5         ��Name$ taille��5#      $��	0,25,0,25q�6/   $��Taille du plateau��5$   M   .��5%      �  5&      �� 5'   "   $��1* �60   �� 5(   "   $��1* �60    5*      �� 5+   "   $��1* �63   �� 5,   "   $��1* �63   .+�5/      �� $��Nbre de Ligne :��6(   $��Center=�6?   $��5q�6Z   �� 50      -   5        $��	nbreLigne��50   &   $��1��67   $��5q�6G   $��50��6R   $
��Left=�6]   �� 52      $��Nbre de Colonnes :��6(   $��1��6B   $��Center=�6O   $��5q�6j   �� 53      -   5        $��nbreColonnes��53   &   $��1��6:   $��1��6G   $��5q�6W   $��50��6b   $
��Left=�6m   55      56      57      58      �� 59      -	   5         ��Name$ 
btnValider��59      $
��50px��6)   .��67   	VALIDER5;      �� 5<      -
   5        $ reset��5<      $
��50px��6$   .��62   RESET5>      5?      �� 5A   
   -   5         ��Name$ Error��5A      $��2��6#   $��2��60   $��30(�6D   $��Center=�6R   $��Center=�6m   
���  ��Test WPF 6T 20246�   5B      5C      