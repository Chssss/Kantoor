   M S B A M L   `   `   `  ���� O  KKantoorInrichtingWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:KantoorInrichtingWPFKantoorInrichtingWPF  O,clr-namespace:KantoorInrichtingWPF.ViewModelKantoorInrichtingWPF.ViewModel  ?$clr-namespace:WPF.JoshSmith.ControlsWPF.JoshSmith.Controls  %    KantoorInrichtingWPF.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     4local"clr-namespace:KantoorInrichtingWPF     B	ViewModel,clr-namespace:KantoorInrichtingWPF.ViewModel     9Controls$clr-namespace:WPF.JoshSmith.Controls       � Title$  Plattegrond editor��$	��650��$
��1000�� � WindowStartupLocation$ CenterScreen=� � DataContext 4   .KantoorInrichtingWPF.ViewModel.MeubelViewModel  .���  � RowDefinitions �� $	��43* ��� $
��520* ��� $	��71* � � ColumnDefinitions �� $
��111* ��� $
��121* ��� $
��133* ��� $
��635* �.+�]� $��False��$��	0,0,0,500q�$��2��$��3��.+�o� $	��100��$
��Left=�$	��Top=�.@�m� $
��Open��.@�m� -   $��Nieuwe plattegrond��m� -   $��Open plattegrond��o� $	��100��$
��Left=�$	��Top=�.@�m� $��Opslaan��.@�m� -   $��Opslaan��m� -   $��Opslaan als��o� $	��100��$
��Left=�$	��Top=�.@�m� $��Meubels��.@�m� -   $��	Toevoegen��m� -   $��Lijst��o� $	��Top=�$��17��$
��Left=�$	��Top=�$	��Top=�.@�m� -   $��	Bestellen���� -    ��Name$ 	TBMeubels��$
��Left=�$��0,25,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��120��$��18��$��2������ *
Zoekbalk+�� -	    ��Name$ ButtonZoekenMeubelNaam��$��Zoeken naam��$
��Left=�$��	27,24,0,0q�$	��Top=�$��20��$��96��$��2��$��1��$��2������ *ZoekNaamInCatalogus+ �� Mode$ OneWay=�&   System.Windows.Controls.DataGrid  -
   	  Name$	 	DGMeubels��
   
IsReadOnly$

 True��$��0,43,0,0q�$��2��$��3������ *	Catalogus+�� -   $ ButtonRefresh��$��Refresh��$
��Left=�$��27,0,0,0q�$��Center=�$��20��$��44��$��3������ *UpdateCatalogus+$ OneWay=��� -   $! ButtonZoekenMeubelCategorie��$��Zoeken categorie��$
��Left=�$��7,22,0,0q�$	��Top=�$��20��$	��103��$��2������ *ZoekCategorieInCatalogus+$ OneWay=��� $��1q�
���   �$��3��$��0,43,0,0q�$��2��._�'   !WPF.JoshSmith.Controls.DragCanvas  -     Name$ DragCavasPlattegrond��'   !WPF.JoshSmith.Controls.DragCanvas   MouseRightButtonDown$ OnMouseRightButtonPressed��   PreviewMouseDown$ OnMouseDownPressed��   MouseLeftButtonUp$, &DragCavasPlattegrond_MouseLeftButtonUp��   MouseLeftButtonDown$. (DragCavasPlattegrond_MouseLeftButtonDown��   	MouseMove$$ DragCavasPlattegrond_MouseMove��$��	0,0,-1,-1q�
������ �� -    ��Name$ LabelTotalPrijs��$��3��$
��Left=�$��	412,0,0,0q�$��Center=�$��30��$��64��$��16(�$��2���� -   $ ButtonTotaalPrijs��$��Totaalprijs��$��3��$
��Left=�$��	530,0,0,0q�$��Center=�$��33��$��67��$��2��d� -    d�Name$ 
ButtonMuur��$
��Muur��$��Center=�$��2��$��Center=�$��71��$	��111���� -   $ 
ButtonRaam��$
��Raam��$��Center=�$��2��$��Center=�$��71��$	��123��$��1���� -   $ 
ButtonDeur��$
��Deur��$��Center=�$��2��$��Center=�$��71��$	��133��$��2���� -   $ LabelLengte��$�� ��$��3��$
��Left=�$��	120,0,0,0q�$��Center=��� -   $ LabelBreedte��$�� ��$��3��$
��Left=�$��	210,0,0,0q�$��Center=��� -   $ LabelHoogte��$�� ��$��3��$
��Left=�$��	317,7,0,0q�$	��Top=��� -   $ ButtonNotitie��$��Notitie��$��3��$
��Left=�$��2��$��Center=�$��71��$	��101���� -   $ 
ButtonHelp��$
��Help��$��3��$
��Left=�$��86,0,0,0q�$��Center=�