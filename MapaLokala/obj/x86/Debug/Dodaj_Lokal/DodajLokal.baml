   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   E AMapaLokala, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MapaLokala.Dodaj_lokalMapaLokala.Dodaj_lokal 5   	   '   !MapaLokala.Dodaj_lokal.DodajLokal   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   O KEO.Wpf, Version=16.0.36.0, Culture=neutral, PublicKeyToken=e92353a6bf73fffc1eo(http://schemas.essentialobjects.com/wpf/  5   	   0sys&clr-namespace:System;assembly=mscorlib  5   	   .cvt$clr-namespace:MapaLokala.Dodaj_lokal  5   	     � Title$  Dodaj Lokal��5   	   $	��382��6   $	��600��6*    � 	Resources 5	       �� 
TargetType   	baseStyle �� Property �� Value �� BasedOn&   System.Windows.Controls.DataGrid:  4System.Windows.Controls.Primitives.DatePickerTextBox��%  &	        '�� H     7   '�� j     7   '�� �     7   '�� �     7   '�� �     7   '  �     7   '��     7   '  6    7   '9� X    7   �� 5
   
   " ��6   .�5      ��  � ��$ 22(�6)   5      �� 5   
   " ��6   8   6T   �� 5   
   " ��6   8   6S   �� 5   
   " ��6   8   6U   �� 5   
   " ��6   8   6V   �� 5   
   " ��6   8   6V   �� 5   
   "  6   8   6V   �� 5   
   " ��6   8   6V   �� 5   
   "  6   8   6_   �� 5   
   " 9�6   8   6V   5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       �� 5!      �� 5"      $��30 �6   �� 5#      �� 5$      �� 5%      �� 5&      �� 5'      �� 5(      �� 5)      �� 5*      $��30 �6    � ColumnDefinitions 5,   
   �� 5-      $
��Auto �6   �� 5.      .+�50   
   �� $��22(�6   $��0��6"   $��0��62   Oznaka lokala:6P   �� 51   
   $��22(�6   $��0��6"   $��1��62   Ime lokala:6M   �� 52   
   $��22(�6   $��0��6"   $��2��62   Opis lokala:6N   �� 53   
   $��22(�6   $��0��6"   $��3��62   Izaberite tip lokala:6W   �� 54   
   $��22(�6   $��0��6"   $��4��62   Status za sluzenje alkohola:6^   �� 55   
   $��22(�6   $��0��6"   $��5��62   Ikona lokala:6O   �� 56   
   $��22(�6   $��0��6"   $��6��62   +)Da li je lokal dostupan za hendikepirane?6k   �� 57   
   $��22(�6   $��0��6"   $��7��62   '%Da li je u lokalu dozvoljeno pusenje?6g   �� 58   
   $��22(�6   $��0��6"   $��8��62    Da li lokal prima rezervacije?6`   �� 59   
   $��22(�6   $��0��6"   $��9��62   %#Izaberite kategoriju cena u lokalu:6e   �� 5:   
   $��22(�6   $��0��6"   $��10��62   Kapacitet lokala:6T   �� 5;   
   $��22(�6   $��0��6"   $��11��62   Datum otvaranja lokala:6Z   �� 5<   
   $��22(�6   $��0��6"   $��12��62   Tagujte restoran:6T   �� 5>   
   -   5        $��txt_oznakaLokala��5>      $��1��6*   $��0��6:   $
��Auto��6G   6V   �� 5?   
   -   5        $��txt_imeLokala��5?      $��1��6'   $��1��67   $
��Auto��6D   6S   �� 5@   
   -   5        $��txt_opisLokala��5@      $��1��6(   $��2��68   $
��Auto��6E   6T   �� 5B   
   -   5        $��cmb_TipLokala��5B      $��1��6(   $��3��68    �� 
IsEditable .  ��6X   �� 	 �� Path$	 tipoviLokala��� 5C   
   -   5        $ ��cmb_statusSluzenjaAlkohola��5C      $��1��65   $��4��6E    .  ��6e   �� $	 statusSluzenjaAlkohola��� 5E   
   -   5        $��btn_loadImage��5E      $��1��6&   $��5��66   $
��Left=�6C   
 � ToolTip
 5F      �� 5G       �� Orientation$ 
Horizontal=�6   .+�5H      �� $��5q�6    $
��Wrap=�6+   $	��100��6?   64Pritiskom na ovo dugme ucitacete ikonu za vas lokal.5J      5K      .��5L      Ucitaj ikonu5M      �� 5N   
   -   5        $��img_ikonaLokala��5N      $��1��6'   $��5��67   $��Right=�6D   $
��Auto��6`   $
��Auto��6n   $��3q�6{   5O      �� 5Q   
   -   5        $��rdb_hendikepirani_da��5Q      $��1��6/   $��6��6?   $
��Left=�6L   $��Da��6g    d� 	IsChecked$
 TrueY�6t   �� 5S   
   -	   5        $��rdb_pusenje_da��5S      $��1��6)   $��7��69   $
��Left=�6F   $��Da��6a   �� 5U   
   -
   5        $��rdb_rezervacije_da��5U      $��1��6-   $��8��6=   $
��Left=�6J   $��Da��6e   $
 TrueY�6r   �� 5W   
   -   5        $��cmb_kategorijeCena��5W      $��1��6-   $��9��6=    .  ��6]   �� $	 kategorijeCena��� 5Y   
   -   5        $��txt_kapacitetLokala��5Y      $��1��6-   $��10��6=   $
��Auto��6K   6Z   (  "System.Windows.Controls.DatePicker  5[   
   -   5        $��dp_datum��5[   !   $	��115��6   $
��Left=�61   $��1��6L   $��11��6\   5\        EO.Wpf.ComboBox  5b   
   -   5        $��cmb_Etiketa��5b   :   $��22(�6      ShowCheckBoxes . $��1��6M   $��12��6]      
IsEditable .  ��6~   �� $	 etikete�   FooterTemplate 5d      �� 5e      .R�5f      �� $ 
Horizontal=�6!   .+�5g        EO.Wpf.LinkButton    Name$ PART_OKButton��63   $��2q�6(   .��6J   OK6N     5h      $ PART_CancelButton��63   $��2q�6(   .��6N   Cancel6V   5i      5j      5l      �� 5n   
   -   5        $��btnOdustani��5n      $��0��6$   $��13��64   $
��Left=�6B   $��80��5o      $��3q�6   $��Odustani��6&   
 5p      �� 5q      $ 
Horizontal=�6   .+�5r      �� $��5q�6    $
��Wrap=�6+   $	��100��6?   QOPritiskom na ovo dugme ponisticete sve sto ste uneli i lokal nece biti kreiran.5t      5u      5w      �� 5y   
   -   5        $��
btnSacuvaj��5y      $��1��6#   $��13��63   $��Right=�6A   $��80��5z      $��3q�6   $��Sacuvaj��6&   
 5{      �� 5|      $ 
Horizontal=�6   .+�5}      �� $��5q�6    $
��Wrap=�6+   $	��100��6?   /-Pritiskom na ovo dugme kreiracete novi lokal.5      5�      5�      5�      5�      