   M S B A M L   `   `   `  ����O  KKantoorInrichtingWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:KantoorInrichtingWPFKantoorInrichtingWPF  5   	   O,clr-namespace:KantoorInrichtingWPF.ViewModelKantoorInrichtingWPF.ViewModel  5   	   +    %KantoorInrichtingWPF.MeubelsToevoegen   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:KantoorInrichtingWPF     5   	   B	ViewModel,clr-namespace:KantoorInrichtingWPF.ViewModel     5   	     � Title$  MeubelsToevoegen��5	   	   $	��450��6"   $	��800��6/    � DataContext 5
      4   .KantoorInrichtingWPF.ViewModel.MeubelViewModel  5   
   .��5      � .+�5   
   �� $��	Categorie��6   $
��Left=�6$   $��
109,54,0,0q�6?   $	��Top=�6S   �� 5   
   $
��Naam��6   $
��Left=�6   $��105,107,0,0q�6:   $	��Top=�6O   �� 5   
   $��Prijs��6   $
��Left=�6    $��108,156,0,0q�6;   $	��Top=�6P   �� 5   
   $��Lengte��6   $
��Left=�6!   $��100,257,0,0q�6<   $	��Top=�6Q   �� 5   
   $��Breedte��6   $
��Left=�6"   $��105,307,0,0q�6=   $	��Top=�6R   �� 5   
   -   5         ��Name$ TBNaam��5      $
��Left=�6"   $��102,138,0,0q�6=    �� TextWrapping$
 Wrap=�6R   $	��Top=�6f   $	��120��6~    J� RenderTransformOrigin$ 0.493,-1.479&�6�   ��6�   �� *Naam+6�   �� 5   
   -   5        $ TBPrijs��5      $
��Left=�6#   $��100,189,0,0q�6>   $
 Wrap=�6S   $	��Top=�6g   $	��120��6   $ 0.482,-0.768&�6�   ��6�   �� *Prijs+6�   �� 5   
   -   5        $ TBLengte��5      $
��Left=�6$   $��100,283,0,0q�6?   $
 Wrap=�6T   $	��Top=�6h   $	��120��6�   ��6�   �� *Lengte+�� 5   
   -   5        $ 	TBBreedte��5      $
��Left=�6%   $��100,333,0,0q�6@   $
 Wrap=�6U   $	��Top=�6i   $	��120��6�   ��6�   �� *	Breedte+�� 5   
   $��Meubel tevoegen��6   $��Center=�6*   $��0,46,0,0q�6G   $	��Top=�6Y   �� 5   
   -   5         ��Name$ ButtonToevoegen��5      $��	Toevoegen��6*   $
��Left=�6>   $��31��6Y   $��382,338,0,0q�6e   $	��Top=�6z   $��69��6�   ��6�   �� *ToevoegenMeubel+ �� Mode$ OneWay=��� 5   
   -   5        $ ButtonAnnuleren��5      $��	Annuleren��6*   $
��Left=�6>   $��509,338,0,0q�6Y   $	��Top=�6n   $��31��6�   $��63��6�   6�   	� 5   
   -   5         	�Name$ RBStoel��5      $��Stoel��6'   $
��Left=�67   $��416,157,0,0q�6R   $	��Top=�6g   ��6�   �� *StoelCommand+$ OneWay=�	� 5   
   -   5        $ RBTafel��5      $��Tafel��6'   $
��Left=�67   $��416,179,0,0q�6R   $	��Top=�6g   ��6�   �� *TafelCommand+$ OneWay=�	� 5   
   -	   5        $ RBLamp��5      $
��Lamp��6&   $
��Left=�65   $��416,205,0,0q�6P   $	��Top=�6e   ��6�   �� *LampCommand+$ OneWay=�	� 5   
   -
   5        $ RBPlant��5      $��Plant��6'   $
��Left=�67   $��416,231,0,0q�6R   $	��Top=�6g   ��6�   �� *PlantCommand+$ OneWay=�	� 5   
   -   5        $ RBKast��5      $
��Kast��6&   $
��Left=�65   $��416,257,0,0q�6P   $	��Top=�6e   ��6�   �� *KastCommand+$ OneWay=�	� 5   
   -   5        $ 
RBApparaat��5      $��Apparaat��6*   $
��Left=�6=   $��499,159,0,0q�6X   $	��Top=�6m   ��6�   �� *ApparaatCommand+$ OneWay=�	� 5    
   -   5        $ RBDeur��5       $
��Deur��6&   $
��Left=�65   $��499,182,0,0q�6P   $	��Top=�6e   ��6�   �� *DeurCommand+$ OneWay=�	� 5!   
   -   5        $ RBRaam��5!      $
��Raam��6&   $
��Left=�65   $��499,205,0,0q�6P   $	��Top=�6e   ��6�   �� *RaamCommand+$ OneWay=�	� 5"   
   -   5        $ RBTapijt��5"      $��Tapijt��6(   $
��Left=�69   $��501,231,0,0q�6T   $	��Top=�6i   ��6�   �� *TapijtCommand+$ OneWay=��� 5#   
   $��Hoogte��6   $
��Left=�6!   $��102,212,0,0q�6<   $	��Top=�6Q   $ 0.547,0.508&�6i   �� 5$   
   -   5        $ TBHoogte��5$      $
��Left=�6$   $��100,236,0,0q�6?   $
 Wrap=�6T   $	��Top=�6h   $	��120��6�   ��6�   �� *Hoogte+�� 5%   
   -   5         ��Name$ CBCategorie��5%      $
��Left=�6(   $��
102,85,0,0q�6C   $	��Top=�6W   $	��120��6o   ��6{   �� *Categorieen+	 �� SelectedValue	 6�   �� *	Categorie+�� 5&   
   $��Leverancier��6   $
��Left=�6&   $��
247,49,0,0q�6A   $	��Top=�6U   $��26��6m   $��76��6y   �� 5'   
   -   5        $ CBLeverancier��5'      $
��Left=�6*   $��
247,85,0,0q�6E   $	��Top=�6Y   $	��120��6q   	 6}   �� *Leverancier+��6�   �� *Leveranciers+5)      5*      