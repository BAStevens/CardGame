   M S B A M L   `   `   `  ����C  ?CardGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CardGameCardGame  5   	       CardGame.Playfield   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:CardGame     5   	     � Title$  	Playfield��5   	   $	��720��6   $
��1280��6(   .��5	      �  � RowDefinitions 5
   
   �� 5      $��3* �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��0��6   $��0q�6%   .+�5      �� -   5        $��	PlayerIMG��5      $��20(�6&   $��100,80,100,0q�64   $	��182��6J   $��Placeholder��6W   �� 5      $��35(�6   $��50,100,50,100q�6&   $
��Bold"�6=    �� TextAlignment$ Center=�6O   You6k   �� 5      $��50(�6   $��50,0,50,100q�6&   $
��Bold"�6;   $ Center=�6M   1006i   5      �� 5   
   $��1��6   $��0q�6%   .+�5      �� -   5         ��Name$ btnNormalAttack��5      $��40(�6.   $��50,200,50,0q�6Z   $	��100��6o   $��Normal��6|   $
��Bold"�6�   �� 5      -   5        $ btnSpecialAttack��5      $��40(�6/   $��50,100,50,200q�6\   $	��100��6s   $��Special��6�   $
��Bold"�6�   5      �� 5    
   $��2��6   $��0q�6%   .+�5!      �� -   5        $ EnemyIMG��5!      $��20(�6'   $��100,80,100,0q�65   $	��182��6K   $��Placeholder��6X   �� 5"      $��35(�6   $��50,100,50,100q�6&   $
��Bold"�6=   $ Center=�6O   (Insert NPC Name)6y   �� 5#      $��50(�6   $��50,0,50,100q�6&   $
��Bold"�6;   $ Center=�6M   1006i   5$      5&      5'      