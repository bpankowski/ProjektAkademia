   M S B A M L   `   `   `  ����C  ?Akademia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:AkademiaAkademia  5   	       Akademia.MainProgram   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Akademia     5   	     � Title$  Przepisomat��5   	   $��446.471��6   $��384.706��6.   .��5	      �  J� RenderTransformOrigin$ 0.479,0.462&�6    � ColumnDefinitions 5
   
   �� 5      �� 5      $��0* �6   .+�5   
   �� -   5         ��Name$ _PrintCanvas��5      $��0��6   $��-7,10,10,10q�64   .+�5      �� -   5         ��Name$ image��5      $
��Left=�6#   $��63��6>   $��	10,10,0,0q�6J   $	��Top=�6]   $	��101��6u   $+��%C:\Users\Pank\Desktop\obrazki\pan.jpg��6�   �� 5      -   5         ��Name$
 save��5      $
��Save��6#   $
��Left=�62   $��288,375,0,0q�6M   $	��Top=�6b   $��60��6z   $��20��6�   �� 5      -   5         ��Name$ recipe_name��5      $
��Left=�6+   $��23��6F   $��
208,27,0,0q�6R    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5      -   5         ��Name$ label��5      $��
Recipe for��6#   $
��Left=�68   $��
133,24,0,0q�6S   $	��Top=�6g   $��70��6   $��26��6�   �� 5      -   5        $ 
recipe_txt��5      $
��Left=�6*   $	��160��6E   $��
133,55,0,0q�6R   $
 Wrap=�6f   $	��Top=�6z   $	��215��6�   �� 5      -   5        $ update��5      $��Update��6%   $
��Left=�66   $	��Top=�6Q   $��60��6i   $��122,376,0,0q�6t   $��20��6�   �� 5      -   5        $ Delete��5      $��Delete��6%   $
��Left=�66   $��208,376,0,0q�6Q   $	��Top=�6f   $��60��6~   $��20��6�   �� 5      -	   5        $ all_rec��5      $��All Recipes��6&   $
��Left=�6<   $��
23,101,0,0q�6W   $	��Top=�6k   $��75��6�   $��20��6�   �� 5      -
   5        $ shopping��5      $��Shopping list��6'   $
��Left=�6?   $��
23,137,0,0q�6Z   $	��Top=�6n   $��75��6�   $ 	0.581,4.1&�6�   $��20��6�   �� 5      -   5        $ ing_txt��5      $
��Left=�6'   $	��135��6B   $��133,235,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��215��6�   �� 5      -   5        $ 
label_Copy��5      $��Ingredients:��6(   $
��Left=�6?   $��
36,235,0,0q�6Z   $	��Top=�6n   $��75��6�   $��26��6�   �� 5      -   5        $ button��5      $��Print��6%   $
��Left=�65   $��
22,173,0,0q�6P   $	��Top=�6d   $��75��6|   6�   5      5      5      