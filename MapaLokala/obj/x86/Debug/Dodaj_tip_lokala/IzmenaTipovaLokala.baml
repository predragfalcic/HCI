   M S B A M L   `   `   `  ����  
MapaLokala4    .MapaLokala.Dodaj_tip_lokala.IzmenaTipovaLokala   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Izmena Tipova Lokala��5   	   $	��600��6&   $	��910��63    � 	Resources 5       �� 
TargetType   	baseStyle �� Property �� Value �� BasedOn&   System.Windows.Controls.DataGrid:  4System.Windows.Controls.Primitives.DatePickerTextBox��%2  &	        '�� H     7   '�� j     7   '�� �     7   '�� �     7   '�� �     7   '  �     7   '��     7   '  6    7   '9� X    7   'o� z    7   �� 5   
   " ��6   .�5      ��  � ��$ 22(�6)   5	      �� 5
   
   " ��6   8   6T   �� 5   
   " ��6   8   6S   �� 5   
   " ��6   8   6U   �� 5   
   " ��6   8   6V   �� 5   
   " ��6   8   6V   �� 5   
   "  6   8   6V   �� 5   
   " ��6   8   6V   �� 5   
   "  6   8   6_   �� 5   
   " 9�6   8   6V   �� 5   
   " o�6   8   6R   5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5!   
   9� $��Pretraga��6   $��0��6%   .��5"      ]� $��0,5,0,5q�6   .+�5#      �� $��Pretraga po nazivu��6   $��0,0,20,0q�66   �� 5$      $	��150��6   ��6&   ��  �� Path$ 
SearchText� �� UpdateSourceTrigger$ PropertyChanged=�5%      5&        5(   
   -   5        	  Name$	 dgrMain��5(      
   
IsReadOnly
 . $��3��6j   $��0,5,0,0q�6w      AutoGenerateColumns .  ��6$   �� $ PretrazeniTipoviLokala�   Columns 5)      4  .System.Windows.Controls.DataGridTemplateColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Header$ Image��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 68      
IsReadOnly .    CellTemplate 5+      �� 5,      .R�5-      ��  �� Orientation$ 
Horizontal=�6)   .+�5.   "   �� $	��100��6(   ��64   �� $ IkonaTipaLokala�5/      50      52        53         SortMemberPath$ OznakaTipaLokala��6)      CanUserSort .    SortDirection$ 	AscendingX�6^   $ Oznaka tipa��6x   $
 Auto 6�    .  54      �� 55      .R�56      �� $ 
Horizontal=�6)   .+�57   "   �� $
��Auto��6*    �� 
IsReadOnly . ��6I   �� $ OznakaTipaLokala�6r   58      59      5;        5<      $	 Ime��6)    . $ Naziv��6Q   $
 Auto 6`    .  5=      �� 5>      .R�5?      �� $ 
Horizontal=�6)   .+�5@   "   �� $
��Auto��6*    . ��6I   �� $	 Ime�6e   5A      5B      5D        5E      $
 Opis��6)    . $
 Opis��6R   $
 Auto 6`    .  5F      �� 5G      .R�5H      �� $ 
Horizontal=�6)   .+�5I   "   �� $
��Auto��6*    . ��6I   �� $
 Opis�6f   5J      5K      5M      5O      �� 5P   
   $��4��6   $��5q�6"   .+�5Q      �� $��0,5,0,0q�6    �� CornerRadius$ 5��6&   
�������$��1q�6L    �� Padding$ 5q�6`    � DataContext 6l   ��  �� ElementName$ dgrMain��$ SelectedItem�._�5R      �  5S      �� 5T      �� 5U      �� 5V      �� 5W      �� 5X      �� 5Y      �� 5Z       � ColumnDefinitions 5\      �� 5]      $	��160��6+   �� 5^      .+�5a      �� $��0��6    $��Izabran tip lokala��6-   $
��Bold"�6G   $��Center=�6Y   $��2��6v   �� 5c      $��22(�6    $��1��6.   Oznaka tipa:6J   �� 5d      $��22(�6    $��2��6.   Izmenite naziv tipa:6R   �� 5e      $��22(�6    $��3��6.   Izmenite opis tipa:6Q   �� 5f      $��22(�6    $��4��6.   Izaberite novu ikonu za tip:6Z   �� 5h      -   5        $��txt_oznakaTipaLokala��5h      $��1��6:   $��1��6G    . ��6W   �� $ OznakaTipaLokala�6�   �� 5i      -   5        $��txt_imeTipaLokala��5i   .   $��2��6   $��2��6G   ��6T   �� $	 Ime�6p   �� 5j      -   5        $��txt_opisTipaLokala��5j   .   $��3��6   $��3��6H   ��6U   �� $
 Opis�6r   �� 5k      -   5        $��img_ikonaTipaLokala��5k      $��4��67   $��4��6G   $
��Left=�6�   $��80��6�   ��6T   �� $ IkonaTipaLokala� �� Mode$ TwoWay=�$ PropertyChanged=�6�   �� 5l      -   5        $��btn_loadImage��5l      $��4��62   $��Center=�6[   $
��Auto��6x   $
��Auto��6�   $��4��6�    � ToolTip 5m      �� 5n      $ 
Horizontal=�6)   .+�5o   "   �� $��5q�6,   $
��Wrap=�67   $	��100��6K   HFPritisnite dugme da bi ste ucitali novu ikonicu za izabran tip lokala.5q   #   5r      .��5s   *   Izaberite ikonu5t   &   �� 5v      -   5        $��btn_odustani��5v      $��6��61   $
��Left=�6X   $��2��6s    5w      �� 5x      $ 
Horizontal=�6)   .+�5y   "   �� $��5q�6,   $
��Wrap=�67   $	��100��6K   TRPritiskom na ovo dugme ponisticete sve izmene koje ste izvirsili a niste sacuvali.5{   #   5|      .��5}   *   
Odustani5~      �� 5      -   5        $��btn_sacuvaj��5      $��6��60   $��Center=�6V   $��2��6s    5�      �� 5�      $ 
Horizontal=�6)   .+�5�   "   �� $��5q�6,   $
��Wrap=�67   $	��100��6K   `^Pritiskom na ovo dugme sacuvacete sve izmene koje ste izvrsili za trenutno izabran tip lokala.5�   #   5�      .��5�   *   Sacuvaj izmene5�   %   �� 5�      -	   5        $��
btn_obrisi��5�      $��6��6/   $��Right=�6T   $��2��6p    5�      �� 5�      $ 
Horizontal=�6)   .+�5�   "   �� $��5q�6,   $
��Wrap=�67   $	��100��6K   *(Brisanje trenutno izabranog tipa lokala.5�   #   5�      .��5�   *   Obrisi tip lokala5�   (   5�      5�      5�      5�      5�      