   M S B A M L   `   `   `  ����O  KKantoorInrichtingWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:KantoorInrichtingWPF.ViewKantoorInrichtingWPF.View  5   	   O,clr-namespace:KantoorInrichtingWPF.ViewModelKantoorInrichtingWPF.ViewModel  5   	   2    ,KantoorInrichtingWPF.View.OpslaanPlattegrond   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:KantoorInrichtingWPF.View     5   	   B	ViewModel,clr-namespace:KantoorInrichtingWPF.ViewModel     5   	     � Title$  OpslaanPlattegrond��5	   	   $	��450��6$   $	��800��61    � DataContext 5
      9  3KantoorInrichtingWPF.ViewModel.PlattegrondViewModel  5   
   .��5      � .+�5   
   �� $��Opslaan Plattegrond��6   $��Center=�6.   $��0,38,0,0q�6K   $	��Top=�6]   �� 5   
   $��Project naam��6   $
��Left=�6'   $��	56,51,0,0q�6B   $	��Top=�6U   $��30��6m   $��80��6y   �� 5   
   -   5         ��Name$ TBProjectNaam��5      $
��Left=�6)   $��	56,86,0,0q�6D    �� TextWrapping$
 Wrap=�6t   $	��Top=�6�   $	��120��6�   ��6W   �� *ProjectNaam+6�   �� 5   
   $��Plattegrond naam��6   $
��Left=�6+   $��
56,109,0,0q�6F   $	��Top=�6Z    J� RenderTransformOrigin$ -1.063,0.319&�6r   �� 5   
   -   5        $ TBPlattegrondNaam��5      $
��Left=�6-   $��
56,140,0,0q�6H   $
 Wrap=�6}   $	��Top=�6�   $	��120��6�   ��6\   �� *PlattegrondNaam+6�   �� 5   
   $��Lengte��6   $
��Left=�6!   $��
56,163,0,0q�6<   $	��Top=�6P   �� 5   
   -   5        $ TBLengte��5      $
��Left=�6$   $��
56,194,0,0q�6?   $
 Wrap=�6k   $	��Top=�6   $	��120��6�   ��6S   �� *Lengte+6�   �� 5   
   $��Breedte��6   $
��Left=�6"   $��
56,217,0,0q�6=   $	��Top=�6Q   �� 5   
   -   5        $ 	TBBreedte��5      $
��Left=�6%   $��
56,248,0,0q�6@   $
 Wrap=�6m   $	��Top=�6�   $	��120��6�   ��6T   �� *	Breedte+6�   �� 5   
   $��Hoogte��6   $
��Left=�6!   $��
56,271,0,0q�6<   $	��Top=�6P   �� 5   
   -   5        $ TBHoogte��5      $
��Left=�6$   $��
56,302,0,0q�6?   $
 Wrap=�6k   $	��Top=�6   $	��120��6�   ��6S   �� *Hoogte+6�   �� 5   
   -   5         ��Name$ ButtonAnnuleren��5      $��	Annuleren��6*   $
��Left=�6>   $��464,341,0,0q�6Y   $	��Top=�6n   6�   �� 5   
   -   5        $ ButtonOpslaan��5      $��Opslaan��6(   $��Center=�6:   $��	0,341,0,0q�6W   $	��Top=�6j   ��6�   �� *ToevoegenPlattegrond+ �� Mode$ OneWay=��� 5   
   $[��UAls de velden al zijn ingevuld, vul dan de laatste karakter opnieuw in voor elk veld.��6   $
��Left=�6p   $��	25,12,0,0q�6�   $	��Top=�6�   $	��450��6�   5      5      