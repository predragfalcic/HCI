   M S B A M L   `   `   `  ����  
MapaLokala+    %MapaLokala.Dodaj_Etiketu.DodajEtiketu   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Dodaj Etiketu��5   	   $	��300��6   $	��544��6,    � 	Resources 5       �� 
TargetType   	baseStyle �� Property �� Value �� BasedOn&   System.Windows.Controls.DataGrid:  4System.Windows.Controls.Primitives.DatePickerTextBox��%  &	        '�� H     7   '�� j     7   '�� �     7   '�� �     7   '�� �     7   '  �     7   '��     7   '  6    7   '9� X    7   �� 5   
   " ��6   .�5      ��  � ��$ 22(�6)   5	      �� 5   
   " ��6   8   6T   �� 5   
   " ��6   8   6S   �� 5   
   " ��6   8   6U   �� 5   
   " ��6   8   6V   �� 5   
   " ��6   8   6V   �� 5   
   "  6   8   6V   �� 5   
   " ��6   8   6V   �� 5   
   "  6   8   6_   �� 5   
   " 9�6   8   6V   5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5    
   �� 5!      $
��Auto �6   �� 5"      .+�5$   
   �� $��22(�6   $��0��6"   $��0��62   Oznaka etikete:6P   �� 5%   
   $��22(�6   $��0��6"   $��1��62   Ime etikete:6M   �� 5&   
   $��22(�6   $��0��6"   $��2��62   Opis etikete:6N   �� 5'   
   $��22(�6   $��0��6"   $��3��62   Izaberite ikonu za etiketu:6\   �� 5)   
   -   5        $��txt_oznakaEtikete��5)      $��1��6+   $��0��6;   $
��Auto��6H   6W   �� 5*   
   -   5        $��txt_imeEtikete��5*      $��1��6(   $��1��68   $
��Auto��6E   6T   �� 5+   
   -   5        $��txt_opisEtikete��5+      $��1��6)   $��2��69   $
��Auto��6F   6U   �� 5-   
   -   5        $��btn_loadImage��5-      $��1��6&   $��3��66   $
��Left=�6C    � ToolTip 5.      �� 5/      	 �� Orientation$	 
Horizontal=�6   .+�50      �� $��5q�6    $
��Wrap=�6+   $	��100��6?   KIPritiskom na ovo dugme otvorice vam se dialog za odabir slike za etiketu.52      53      .��54      Ucitaj ikonu55      �� 56   
   -   5        $��img_ikonaEtikete��56      $��1��6(   $��3��68   $��Right=�6E   $
��Auto��6a   $
��Auto��6o   6~   �� 58   
   -   5        $��btnOdustani��58      $��0��6$   $��13��64   $
��Left=�6B   $��80��59      $��3q�6   $��Odustani��6&    5:      �� 5;      $	 
Horizontal=�6   .+�5<      �� $��5q�6    $
��Wrap=�6+   $	��100��6?   TRPritiskom na ovo dugme ponisticete sve sto ste uneli i etiketa nece biti kreirana.5>      5?      5A      �� 5C   
   -   5        $��
btnSacuvaj��5C      $��1��6#   $��13��63   $��Right=�6A   $��80��5D      $��3q�6   $��Sacuvaj��6&    5E      �� 5F      $	 
Horizontal=�6   .+�5G      �� $��5q�6    $
��Wrap=�6+   $	��100��6?   1/Pritiskom na ovo dugme kreiracete novu etiketu.5I      5J      5L      5M      5N      