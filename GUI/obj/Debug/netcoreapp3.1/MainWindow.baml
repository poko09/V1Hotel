   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	     � Title$  LoginWindow��5   	   $	��500��6   $	��300��6*   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��40 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��40 �6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $	��100 �6   �� 5      $
��auto �6   �� 5      $��50 �6   �� 5      $
��auto �6   �� 5      $	��100 �6   �� 5      $��40 �6   .+�5   
   �� $��1��6   $��2��6$   $��Login��61   $��20(�6>   $��0,0,20,0q�6L   $��Normal&�6^   $��DemiBold"�6s   �� 5   
   $��1��6   $��4��6$   $��Hasło��61   $��20(�6>   $��0,0,20,0q�6L   $��DemiBold"�6^   �� 5   
   -   5         ��Name$ textBoxLogin��5      $��2��6(   $��3��65   $	��130��6E   $��3,3,3,3q�6Q   G� 5   
   -   5         G�Name$ passwordBoxHasło��5      $��4��60   $��3��6=   $	��130��6M    G� PasswordChar$ *��6Y   $��3,3,3,3q�6j   $
}�True��6�   �� 5!   
   -   5         ��Name$ buttonZaloguj��5!      $��Zaloguj��6(   $��1��6:   $��6��6J   $��3��6W   $��4,4,4,4q�6�   $��DemiBold"�6�   $��Normal$�6�   $��Normal&�6�   �� 5"   
   $��	login.png��6   $��1��6#   $��3��63   $��4��6G   $��
0,-47,0,32q�6X   5#      5$      