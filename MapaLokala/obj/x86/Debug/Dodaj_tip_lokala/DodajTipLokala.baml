   M S B A M L   `   `   `  ����  
MapaLokala0    *MapaLokala.Dodaj_tip_lokala.DodajTipLokala   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Dodaj Tip Lokala��5   	   $	��300��6"   $	��565��6/    � 	Resources 5       �� 
TargetType   	baseStyle �� Property �� Value �� BasedOn&   System.Windows.Controls.DataGrid:  4System.Windows.Controls.Primitives.DatePickerTextBox��%2  &	        '�� H     7   '�� j     7   '�� �     7   '�� �     7   '�� �     7   '  �     7   '��     7   '  6    7   '9� X    7   'o� z    7   �� 5   
   " ��6   .�5      ��  � ��$ 22(�6)   5      �� 5	   
   " ��6   8   6T   �� 5
   
   " ��6   8   6S   �� 5   
   " ��6   8   6U   �� 5   
   " ��6   8   6V   �� 5   
   " ��6   8   6V   �� 5   
   "  6   8   6V   �� 5   
   " ��6   8   6V   �� 5   
   "  6   8   6_   �� 5   
   " 9�6   8   6V   �� 5   
   " o�6   8   6R   5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5!   
   �� $��22(�6   $��0��6"   $��0��62   Oznaka za tip lokala:6V   �� 5"   
   $��22(�6   $��0��6"   $��1��62   	Ime tipa:6J   �� 5#   
   $��22(�6   $��0��6"   $��2��62   
Opis tipa:6K   �� 5$   
   $��22(�6   $��0��6"   $��3��62   Ikona za tip lokala:6U   �� 5&   
   -   5        $��txt_oznakaTipaLokala��5&      $��1��6.   $��0��6>   $
��Auto��6K   6Z   �� 5'   
   -   5        $��txt_imeTipaLokala��5'      $��1��6+   $��1��6;   $
��Auto��6H   6W   �� 5(   
   -   5        $��txt_opisTipaLokala��5(      $��1��6,   $��2��6<   $
��Auto��6I   6X   �� 5*   
   -   5        $��btn_loadImage��5*      $��1��6&   $��3��66   $
��Left=�6C    � ToolTip 5+      �� 5,      	 �� Orientation$	 
Horizontal=�6   .+�5-      �� $��5q�6    $
��Wrap=�6+   $	��100��6?   NLPritiskom na ovo dugme otvorice vam se dialog za odabir slike za tip lokala.5/      50      .��51      Ucitaj ikonu52      �� 53   
   -   5        $��img_ikonaTipaLokala��53      $��1��6+   $��3��6;   $��Right=�6H   $
��Auto��6d   $
��Auto��6r   54      �� 56   
   -   5        $��btnOdustani��56      $��0��6$   $��13��64   $
��Left=�6B   $��80��57      $��3q�6   $��Odustani��6&    58      �� 59      $	 
Horizontal=�6   .+�5:      �� $��5q�6    $
��Wrap=�6+   $	��100��6?   VTPritiskom na ovo dugme ponisticete sve sto ste uneli i tip lokala nece biti kreiran.5<      5=      5?      �� 5B   
   -   5        $��
btnSacuvaj��5B      $��1��6#   $��13��63   $��Right=�6A   $��80��5C      $��3q�6   $��Sacuvaj��6&    5D      �� 5E      $	 
Horizontal=�6   .+�5F      �� $��5q�6    $
��Wrap=�6+   $	��100��6?   42Pritiskom na ovo dugme kreiracete novi tip lokala.5H      5I      5K      5M      5N      