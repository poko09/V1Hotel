   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	   U QSystem.Runtime, Version=4.2.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a7,clr-namespace:System;assembly=System.RuntimeSystem 5   	       
GUI.Pokoje   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	   ?System,clr-namespace:System;assembly=System.Runtime     5   	     � Title$  Pokoje��5	   	   $	��450��6   $	��900��6%   .��5
      �  � RowDefinitions 5   
   �� 5      $	��90* �6   �� 5      $	��70* �6   �� 5      $	��70* �6   �� 5      $	��70* �6   �� 5      $	��70* �6   �� 5      $	��70* �6    � ColumnDefinitions 5   
   �� 5      $
��170* �6   �� 5      $
��170* �6   �� 5      $
��338* �6   .+�5   
   �� $��2��6   $��30(�6)   $��Zarządzanie pokojami!��67   $
��Left=�6T   $��Center=�6o   $��Medium"�6�   $��1��6�   $��70,0,0,0q�6�   �� 5   
   $��1��6   $��Numer pokoju��6!   $��20(�65   $��Center=�6C   $��Center=�6`   $��Light"�6{   �� 5   
   $��2��6   $��Rodzaj pokoju��6!   $��20(�66   $��Center=�6D   $��Center=�6a   $��Light"�6|   �� 5   
   $��3��6   $��Liczba miejsc��6!   $��20(�66   $��Center=�6D   $��Center=�6a   $��Light"�6|   �� 5   
   -   5         ��Name$ tbNumerPokoju��5      $��1��6*   $��1��67   $��20(�6G   $��Center=�6U   $��Center=�6r   $��Light"�6�   $	��130��6�   �� 5   
   -   5         ��Name$ cmbLiczbaMiejsc��5       �� Text$ liczba miejsc��6-   $��3��6B   $��1��6O   $��20(�6_   $��Center=�6m   $��Center=�6�   $��Light"�6�   $	��130��6�   .@�5      ��	1-osobowy��6'   ��5      	2-osobowy��6'   ��5       	3-osobowy��6'   ��5!      	4-osobowy��6'   5"      �� 5#   
   -   5        $ cmbRodzajPokoju��5#      $��2��6.   $��1��6;   $��20(�6L   $��Center=�6Z   $��Center=�6w   $��Light"�6�   $	��130��6�   .@�5$      ��
Apartament��6(   ��5%      Pokój Basic��6)   ��5&      Pokój Premium��6+   5'      �� 5(   
   -   5         ��Name$ lbListaPokoi��5(      $��2��6(   $��20(�69   $��Center=�6G   $	��Top=�6d   $��Light"�6|   $	��200��6�   $	��300��6�   $��1��6�   $��0,27,0,0q�6�   $��4��6�   �� 5)   
   -   5         ��Name$ buttonDodajPokoj��5)      $��Dodaj pokój��6,   $��4��6B   $��0��6O   $��20(�6_   $��Center=�6m   $��Center=�6�   $��Medium"�6�   $	��206��6�   6�   �� 5*   
   -   5        $ buttonUsunPokoj��5*      $��Usuń pokój��6+   $��4��6@   $��1��6M   $��20(�6]   $��Center=�6k   $��Center=�6�   $��Medium"�6�   $	��205��6�   6�   �� 5+   
   -   5        $ buttonEdytuj��5+      $��Edytuj liczbę miejsc��6(   $��5��6G   $��1��6T   $��20(�6d   $��Center=�6r   $��Center=�6�   $��Medium"�6�   $	��205��6�   6�   �� 5,   
   -   5        $ buttonWyczysc��5,      $��Wyczyść wszystkie pola��6)   $��5��6J   $��0��6W   $��20(�6g   $��Center=�6u   $��Center=�6�   $��Medium"�6�   $	��206��6�   6�   �� 5-   
   -	   5        $ buttonSprawdzDostepnosc��5-      $��2��62   $��4��6B   $#��Sprawdź dostępność pokoju��6O   $��50��6s   $	��300��6   $��20(�6�   $��DemiBold"�6�   $��75,39,74,39q�6�   $��2��6�   6�   51      52      