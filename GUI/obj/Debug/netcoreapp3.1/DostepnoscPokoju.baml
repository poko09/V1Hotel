   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.DostepnoscPokoju   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	     � Title$  DostepnoscPokoju��5   	   $	��300��6"   $	��700��6/   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��70* �6   �� 5      $
��100* �6   �� 5      $	��65* �6   �� 5      $	��85* �6    � ColumnDefinitions 5   
   �� 5      $	��40* �6   �� 5      $	��90* �6   �� 5      $	��40* �6   �� 5      $	��90* �6   .+�5   
   �� $��3��6   $��30(�6(   $#��Sprawdź dostępność pokoju��66   $
��Left=�6W   $��Center=�6r   $��Medium"�6�   $��51,0,0,0q�6�   $��1��6�   �� 5   
   $��1��6   $��0��6!   $	��Od:��61   $��20(�6<   $��Center=�6J   $��Center=�6g   $��Medium"�6�   �� 5   
   $��1��6   $��2��6!   $	��Do:��61   $��20(�6<   $��Center=�6J   $��Center=�6g   $��Medium"�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dpDataPoczatkowa��5      $��1��6/   $��1��6<   $��20(�6L   $��10,20,10,20q�6Z   $��Medium"�6o     5   
   -   5        $ dpDataKoncowa��5      $��1��6,   $��3��69   $��20(�6I   $��10,20,10,20q�6W   $��Medium"�6l   �� 5   
   -   5         ��Name$ buttonSprawdz��5      $��2��6(   $+��%Sprawdź dostępność w tym terminie��65   $��20(�6a   $��Center=�6o   $
��Left=�6�   $	��400��6�   $��3��6�   $��42,0,0,0q�6�   $��1��6�   6�   �� 5   
   -   5        $ 
buttonWroc��5      $��Wróć��6&   $��4��65   $��1��6B   $��20(�6R   $��Center=�6`   $��Center=�6}   $��Medium"�6�   $	��130��6�   6�   �� 5   
   -   5        $ buttonWyczysc��5      $��Wyczyść okna��6)   $��4��6@   $��3��6M   $��20(�6]   $��Center=�6k   $��Center=�6�   $��Medium"�6�   $	��130��6�   6�   5       5!      