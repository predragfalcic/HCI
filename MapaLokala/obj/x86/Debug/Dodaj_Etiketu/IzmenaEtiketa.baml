   M S B A M L   `   `   `  ����  
MapaLokala,    &MapaLokala.Dodaj_Etiketu.IzmenaEtiketa   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Izmena Etiketa��5   	   $	��600��6    $	��910��6-    � 	Resources 5       �� 
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
   " 9�6   8   6V   5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5"   
   9� $��Pretraga��6   $��0��6%   .��5#      ]� $��0,5,0,5q�6   .+�5$      �� $��Pretraga po nazivu��6   $��0,0,20,0q�66   �� 5%      $	��150��6   ��6&   ��  �� Path$ 
SearchText� �� UpdateSourceTrigger$ PropertyChanged=�5&      5'        5)   
   -   5        	  Name$	 dgrMain��5)      
   
IsReadOnly
 . $��3��6e   $��0,5,0,0q�6r      AutoGenerateColumns .  $	��600��6�   ��6$   �� $ PretrazeneEtikete�   Columns 5*   
   4  .System.Windows.Controls.DataGridTemplateColumn  5+      ,  &System.Windows.Controls.DataGridColumn   Header$ Image��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 64      
IsReadOnly .    CellTemplate 5,      �� 5-      .R�5.      ��  �� Orientation$ 
Horizontal=�6)   .+�5/   "   �� $	��100��6(   ��64   �� $ IkonicaEtikete�50      51      53        54         SortMemberPath$ OznakaEtikete��6%      CanUserSort .    SortDirection$ 	AscendingX�6W   $ Oznaka etikete��6q   $
 Auto 6�    .  55      �� 56      .R�57      �� $ 
Horizontal=�6%   .+�58   "   �� $
��Auto��6*    �� 
IsReadOnly . ��6I   �� $ OznakaEtikete�6o   59      5:      5<        5=      $	 Ime��6%    . $ Naziv��6M   $
 Auto 6\    .  5>      �� 5?      .R�5@      �� $ 
Horizontal=�6%   .+�5A      �� $
��Auto��6&    . ��6E   �� $	 Ime�6a   5B      5C      5E        5F      $
 Opis��6%    . $
 Opis��6N   $
 Auto 6\    .  5G      �� 5H      .R�5I      �� $ 
Horizontal=�6%   .+�5J      �� $
��Auto��6&    . ��6E   �� $
 Opis�6b   5K      5L      5N      5P      �� 5Q   
   $��4��6   $��5q�6"   .+�5R      �� $��0,5,0,0q�6    �� CornerRadius$ 5��6&   
�������$��1q�6L    �� Padding$ 5q�6`    � DataContext 6l   ��  �� ElementName$ dgrMain��$ SelectedItem�._�5S      �  5T      �� 5U      �� 5V      �� 5W      �� 5X      �� 5Y      �� 5Z      �� 5[       � ColumnDefinitions 5]      �� 5^      $	��160��6+   �� 5_      .+�5b      �� $��0��6    $��Izabrana etiketa��6-   $
��Bold"�6E   $��Center=�6W   $��2��6t   �� 5d      $��22(�6    $��1��6.   	Oznaka:6E   �� 5e      $��22(�6    $��2��6.   Izmenite naziv etikete:6U   �� 5f      $��22(�6    $��3��6.   Izmenite opis etikete:6T   �� 5g      $��22(�6    $��4��6.   " Izaberite novu ikonu za etiketu:6^   �� 5i      -   5        $��txt_oznakaEtikete��5i      $��1��67   $��1��6D    . ��6T   �� $ OznakaEtikete�6�   �� 5j      -   5        $��txt_imeEtikete��5j   .   $��2��6   $��2��6D   ��6Q   �� $	 Ime�6m   �� 5k      -   5        $��txt_opisEtikete��5k   .   $��3��6   $��3��6E   ��6R   �� $
 Opis�6o   �� 5l      -   5        $��img_ikonaEtikete��5l      $��4��64   $��4��6D   $
��Left=�6�   $��80��6�   ��6Q   �� $ IkonicaEtikete� �� Mode$ TwoWay=�$ PropertyChanged=�6�   �� 5m      -   5        $��btn_loadImage��5m      $��4��62   $��Center=�6[   $
��Auto��6x   $
��Auto��6�   $��4��6�    � ToolTip 5n      �� 5o      $ 
Horizontal=�6)   .+�5p   "   �� $��5q�6,   $
��Wrap=�67   $	��100��6K   FDPritisnite dugme da bi ste ucitali novu ikonicu za izabranu etiketu.5r   #   5s      .��5t   *   Izaberite ikonu5u   *   �� 5w      -   5        $��btn_odustani��5w      $��6��61   $
��Left=�6X   $��2��6s    5x      �� 5y      $ 
Horizontal=�6)   .+�5z   "   �� $��5q�6,   $
��Wrap=�67   $	��100��6K   TRPritiskom na ovo dugme ponisticete sve izmene koje ste izvirsili a niste sacuvali.5|   #   5}      .��5~   *   
Odustani5   #   �� 5�      -   5        $��btn_sacuvaj��5�      $��6��60   $��Center=�6V   $��2��6s    5�      �� 5�      $ 
Horizontal=�6)   .+�5�   "   �� $��5q�6,   $
��Wrap=�67   $	��100��6K   ^\Pritiskom na ovo dugme sacuvacete sve izmene koje ste izvrsili za trenutno izabranu etiketu.5�   #   5�      .��5�   *   Sacuvaj izmene5�   )   �� 5�      -	   5        $��
btn_obrisi��5�      $��6��6/   $��Right=�6T   $��2��6p    5�      �� 5�      $ 
Horizontal=�6)   .+�5�   "   �� $��5q�6,   $
��Wrap=�67   $	��100��6K   %#Brisanje trenutno izabrane etikete.5�   #   5�      .��5�   *   Obrisi etiketu6:   5�      5�      5�      5�      5�      