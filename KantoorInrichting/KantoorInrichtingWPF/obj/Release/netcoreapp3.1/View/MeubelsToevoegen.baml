   M S B A M L   `   `   `  ���� O  KKantoorInrichtingWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:KantoorInrichtingWPFKantoorInrichtingWPF  O,clr-namespace:KantoorInrichtingWPF.ViewModelKantoorInrichtingWPF.ViewModel  +    %KantoorInrichtingWPF.MeubelsToevoegen   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     4local"clr-namespace:KantoorInrichtingWPF     B	ViewModel,clr-namespace:KantoorInrichtingWPF.ViewModel       � Title$  MeubelsToevoegen��$	��450��$	��800�� � DataContext 4   .KantoorInrichtingWPF.ViewModel.MeubelViewModel  .��� .+��� $��	Categorie��$
��Left=�$��
109,54,0,0q�$	��Top=��� $
��Naam��$
��Left=�$��105,107,0,0q�$	��Top=��� $��Prijs��$
��Left=�$��108,156,0,0q�$	��Top=��� $��Lengte��$
��Left=�$��100,257,0,0q�$	��Top=��� $��Breedte��$
��Left=�$��105,307,0,0q�$	��Top=��� -    ��Name$ TBNaam��$
��Left=�$��102,138,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��120�� J� RenderTransformOrigin$ 0.493,-1.479&����� *Naam+�� -   $ TBPrijs��$
��Left=�$��100,189,0,0q�$
 Wrap=�$	��Top=�$	��120��$ 0.482,-0.768&����� *Prijs+�� -   $ TBLengte��$
��Left=�$��100,283,0,0q�$
 Wrap=�$	��Top=�$	��120������ *Lengte+�� -   $ 	TBBreedte��$
��Left=�$��100,333,0,0q�$
 Wrap=�$	��Top=�$	��120������ *	Breedte+�� $��Meubel tevoegen��$��Center=�$��0,46,0,0q�$	��Top=��� -    ��Name$ ButtonToevoegen��$��	Toevoegen��$
��Left=�$��31��$��382,338,0,0q�$	��Top=�$��69������ *ToevoegenMeubel+ �� Mode$ OneWay=��� -   $ ButtonAnnuleren��$��	Annuleren��$
��Left=�$��509,338,0,0q�$	��Top=�$��31��$��63��	� -    	�Name$ RBStoel��$��Stoel��$
��Left=�$��416,157,0,0q�$	��Top=����� *StoelCommand+$ OneWay=�	� -   $ RBTafel��$��Tafel��$
��Left=�$��416,179,0,0q�$	��Top=����� *TafelCommand+$ OneWay=�	� -	   $ RBLamp��$
��Lamp��$
��Left=�$��416,205,0,0q�$	��Top=����� *LampCommand+$ OneWay=�	� -
   $ RBPlant��$��Plant��$
��Left=�$��416,231,0,0q�$	��Top=����� *PlantCommand+$ OneWay=�	� -   $ RBKast��$
��Kast��$
��Left=�$��416,257,0,0q�$	��Top=����� *KastCommand+$ OneWay=�	� -   $ 
RBApparaat��$��Apparaat��$
��Left=�$��499,159,0,0q�$	��Top=����� *ApparaatCommand+$ OneWay=�	� -   $ RBDeur��$
��Deur��$
��Left=�$��499,182,0,0q�$	��Top=����� *DeurCommand+$ OneWay=�	� -   $ RBRaam��$
��Raam��$
��Left=�$��499,205,0,0q�$	��Top=����� *RaamCommand+$ OneWay=�	� -   $ RBTapijt��$��Tapijt��$
��Left=�$��501,231,0,0q�$	��Top=����� *TapijtCommand+$ OneWay=��� $��Hoogte��$
��Left=�$��102,212,0,0q�$	��Top=�$ 0.547,0.508&��� -   $ TBHoogte��$
��Left=�$��100,236,0,0q�$
 Wrap=�$	��Top=�$	��120������ *Hoogte+�� -    ��Name$ CBCategorie��$
��Left=�$��
102,85,0,0q�$	��Top=�$	��120������ *Categorieen+	 �� SelectedValue	 �� *	Categorie+�� $��Leverancier��$
��Left=�$��
247,49,0,0q�$	��Top=�$��26��$��76���� -   $ CBLeverancier��$
��Left=�$��
247,85,0,0q�$	��Top=�$	��120��	 �� *Leverancier+���� *Leveranciers+