   M S B A M L   `   `   `  ����O  KKantoorInrichtingWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:KantoorInrichtingWPFKantoorInrichtingWPF  5   	   O,clr-namespace:KantoorInrichtingWPF.ViewModelKantoorInrichtingWPF.ViewModel  5   	   '    !KantoorInrichtingWPF.MeubelsLijst   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:KantoorInrichtingWPF     5   	   B	ViewModel,clr-namespace:KantoorInrichtingWPF.ViewModel     5   	     � Title$  MeubelsLijst��5	   	   $	��450��6   $	��800��6+    � DataContext 5
      4   .KantoorInrichtingWPF.ViewModel.MeubelViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��49* �6   �� 5      $	��51* �6   .+�5   
   �� $��Meubels��6   $
��Left=�6"   $��
360,35,0,0q�6=   $	��Top=�6Q    J� RenderTransformOrigin$ -0.002,-0.679&�6i   $��2��6�   $��26��6�   $��55��6�   �� 5   
   -   5         ��Name$ 	TBZoekbar��5      $
��Left=�6%   $��	33,63,0,0q�6@    �� TextWrapping$
 Wrap=�6S   $	��Top=�6g   $	��120��6   $��18��6�   ��6�   �� *
Zoekbalk+�� 5   
   -   5        $��Zoeken naam��5      $
��Left=�6'   $��	33,38,0,0q�6B   $	��Top=�6U   $ 0.464,0.663&�6m   $��20��6�   $��87��6�   ��6�   �� *ZoekNaamInCatalogus+ �� Mode$ OneWay=��� 5   
   -   5        $��Terug��5      $��1��6!   $
��Left=�61   $��
344,61,0,0q�6L   $	��Top=�6`   $��20��6�   $��33��6�   �� 5   
   -   5        $��Meubel Toevoegen��5      $��1��6,   $
��Left=�6<   $��
223,61,0,0q�6W   $	��Top=�6k   $��20��6�   $	��105��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	DGMeubels��5      $��0,97,0,0q�6&   $��2��68   ��6L   �� *	Catalogus+�� 5   
   -   5         ��Name$ ButtonRefresh��5      $��Refresh��6(   $��Center=�6:   $��0,61,0,0q�6W   $	��Top=�6i   $ -0.283,-0.608&�6�   ��6�   �� *UpdateCatalogus+$ OneWay=��� 5   
   -   5        $��Zoeken categorie��5      $
��Left=�6,   $��
136,36,0,0q�6G   $	��Top=�6[   $ 0.464,0.663&�6s   $��20��6�   $	��110��6�   ��6�   �� *ZoekCategorieInCatalogus+$ OneWay=��� 5   
   -   5        $ TBVerwijderMeubel��5      $��1��6-   $
��Left=�6=   $��	23,60,0,0q�6X   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6k   �� *Verwijderbalk+6�   �� 5   
   -	   5        $��	Verwijder��5      $��1��6%   $
��Left=�65   $��
151,60,0,0q�6P   $	��Top=�6d   ��6�   �� *VerwijderMeubel+$ OneWay=��� 5   
   $��Type productcode in��6   $
��Left=�6.   $��
291,56,0,0q�6I   $	��Top=�6]   $	��119��6u   $��2��6�   5      5      