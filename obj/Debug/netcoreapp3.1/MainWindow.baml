   M S B A M L   `   `   `  ����C  ?TypeRace, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:TypeRaceTypeRace  5   	       TypeRace.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:TypeRace     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ SentenceToCopy��5
      $��Center=�6*   $��30��6G   $��	0,124,0,0q�6S   $3��-A frase a ser copiada irá ser mostrada aqui.��6f    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��700��6�   ${�False��6�   �� 5   
   -   5        $ TypedSentence��5      $��Center=�6)   $��30��6F   $��	0,170,0,0q�6R   $��Copiar a frase aqui.��6e   $
 Wrap=�6�   $	��Top=�6�   $	��700��6�   �� 5   
   $
��Left=�6   $��45��6/   $��
234,27,0,0q�6;   $o��iPara testar sua velocidade, aperte no botão "Começar" e então digite a frase que irá aparecer abaixo.��6O   $
��Wrap=�6�   $	��Top=�6�   $	��297��6�   �� 5   
   -   5        $��Começar��5      $
��Left=�6#   $��27��6>   $��
324,77,0,0q�6J   $	��Top=�6^   $	��138��6v    �� 	ClickMode$ Press=�6�   6�   �� 5   
   -   5         ��Name$
 Time��5      $
��Left=�6"   $��24��6=   $��
50,255,0,0q�6I   $��Tempo: ��6]   $
��Wrap=�6l   $	��Top=�6�   $	��205��6�   �� 5   
   -   5        $ TypedLetters��5      $
��Left=�6*   $��24��6E   $��
50,279,0,0q�6Q   $��Letras digitadas: ��6e   $
��Wrap=�6   $	��Top=�6�   $	��205��6�   �� 5   
   -   5        $	 LPS��5      $
��Left=�6!   $��24��6<   $��
50,303,0,0q�6H   $��Letras por segundo: ��6\   $
��Wrap=�6x   $	��Top=�6�   $	��304��6�   �� 5   
   -   5         ��Name$ 	Finalizar��5      $��	Finalizar��6$   $
��Left=�68   $��25��6S   $��
50,217,0,0q�6_   $	��Top=�6s   $	��118��6�   6�   �� 5   
   -   5         ��Name$ Falha��5      $�� ��6   $��Center=�6*   $��37��6G   $��	0,205,0,0q�6S   $	��Top=�6f   $	��292��6~   
�������6�   5      5      