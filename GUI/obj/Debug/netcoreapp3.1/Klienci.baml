   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	   U QSystem.Runtime, Version=4.2.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a7,clr-namespace:System;assembly=System.RuntimeSystem 5   	       GUI.Klienci   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	   ?System,clr-namespace:System;assembly=System.Runtime     5   	     � Title$  Klienci��5	   	   $	��450��6   $	��800��6&   .��5
      � .+�5   
   �� -   5         ��Name$ bDodaj��5      $��Dodaj��6!   $
��Left=�61   $��150,363,0,0q�6L   $	��Top=�6a   $��30��6y   $	��107��6�   6�   �� 5   
   -   5         ��Name$ tbImie��5      $
��Left=�6"   $��
170,84,0,0q�6=    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6e   $��87��6}   $��27��6�   $�� ��6�   �� 5   
   -   5        $ 
tbNazwisko��5      $
��Left=�6&   $��170,123,0,0q�6A   $
 Wrap=�6V   $	��Top=�6j   $��87��6�   $��26��6�   �� 5   
   -   5         ��Name$ LImie��5      $��Imię��6   $
��Left=�6.   $��	61,84,0,0q�6I   $	��Top=�6\   $��27��6t   $��87��6�   �� 5   
   -   5        $ 	LNazwisko��5      $��	Nazwisko	��6#   $
��Left=�6;   $��
61,123,0,0q�6V   $	��Top=�6j   $��62��6�   �� 5   
   -   5        $ LEmail��5      $��Email	��6    $
��Left=�65   $��
61,167,0,0q�6P   $	��Top=�6d   $��62��6|   �� 5   
   -   5        $ LTelefon��5      $��Telefon��6"   $
��Left=�64   $��61,0,0,0q�6O   $��Center=�6a   $��62��6|   �� 5   
   -   5        $ LDataUr��5      $��	Data  ur.��6!   $
��Left=�65   $��
61,243,0,0q�6P   $	��Top=�6d   $��62��6|   �� 5   
   -	   5        $ LPesel��5      $��PESEL��6    $
��Left=�60   $��
61,278,0,0q�6K   $	��Top=�6_   $��62��6w   �� 5   
   -
   5        $ tbEmail��5      $
��Left=�6#   $��170,167,0,0q�6>   $
 Wrap=�6S   $	��Top=�6g   $��87��6   $��26��6�   �� 5   
   -   5        $ 	tbTelefon��5      $
��Left=�6%   $��	170,0,0,0q�6@   $
 Wrap=�6S   $��Center=�6g   $��87��6�   $��26��6�   �� 5   
   -   5        $ tbPesel��5      $
��Left=�6#   $��170,278,0,0q�6>   $
 Wrap=�6S   $	��Top=�6g   $��87��6   $��26��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dpDataUr��5      $
��Left=�6'   $��170,243,0,0q�6B   $	��Top=�6W   $��87��6o   �� 5   
   -   5         ��Name$ 	lbKlienci��5      $��3,3,3,3q�6&   $��393,98,10,147q�6@   �� 5   
   -   5        $ LKlienci��5      $��Klienci:��6"   $
��Left=�65   $��
393,72,0,0q�6P   $	��Top=�6d   $��87��6|   �� 5   
   $��KLIENCI��6   $��Center=�6"   $��0,22,0,0q�6?   $	��Top=�6Q   $��74��6i   $
��Bold"�6t   $��16(�6�   �� 5   
   -   5         ��Name$ cmbTytul��5      $
��Left=�6%   $��170,323,0,0q�6@   $	��Top=�6U   $��87��6m   .@�5      ��Pan��6!   ��5      Pani��6"   5      �� 5   
   -   5        $ LTytul��5      $��Tytuł	��6    $
��Left=�65   $��
61,323,0,0q�6P   $	��Top=�6d   $��62��6|   �� 5    
   -   5        $ bWyczysc��5       $��	Wyczyść��6#   $
��Left=�65   $��305,363,0,0q�6P   $	��Top=�6e   $��30��6}   $	��107��6�   6�   5"      5#      