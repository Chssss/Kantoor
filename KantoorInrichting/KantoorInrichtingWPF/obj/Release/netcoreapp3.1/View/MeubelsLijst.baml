   M S B A M L   `   `   `  ���� O  KKantoorInrichtingWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:KantoorInrichtingWPFKantoorInrichtingWPF  O,clr-namespace:KantoorInrichtingWPF.ViewModelKantoorInrichtingWPF.ViewModel  '    !KantoorInrichtingWPF.MeubelsLijst   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     4local"clr-namespace:KantoorInrichtingWPF     B	ViewModel,clr-namespace:KantoorInrichtingWPF.ViewModel       � Title$  MeubelsLijst��$	��450��$	��800�� � DataContext 4   .KantoorInrichtingWPF.ViewModel.MeubelViewModel  .���  � ColumnDefinitions �� $	��49* ��� $	��51* �.+��� $��Meubels��$
��Left=�$��
360,35,0,0q�$	��Top=� J� RenderTransformOrigin$ -0.002,-0.679&�$��2��$��26��$��55���� -    ��Name$ 	TBZoekbar��$
��Left=�$��	33,63,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��120��$��18������ *
Zoekbalk+�� -   $��Zoeken naam��$
��Left=�$��	33,38,0,0q�$	��Top=�$ 0.464,0.663&�$��20��$��87������ *ZoekNaamInCatalogus+ �� Mode$ OneWay=��� -   $��Terug��$��1��$
��Left=�$��
344,61,0,0q�$	��Top=�$��20��$��33���� -   $��Meubel Toevoegen��$��1��$
��Left=�$��
223,61,0,0q�$	��Top=�$��20��$	��105��&   System.Windows.Controls.DataGrid  -     Name$ 	DGMeubels��$��0,97,0,0q�$��2������ *	Catalogus+�� -    ��Name$ ButtonRefresh��$��Refresh��$��Center=�$��0,61,0,0q�$	��Top=�$ -0.283,-0.608&����� *UpdateCatalogus+$ OneWay=��� -   $��Zoeken categorie��$
��Left=�$��
136,36,0,0q�$	��Top=�$ 0.464,0.663&�$��20��$	��110������ *ZoekCategorieInCatalogus+$ OneWay=��� -   $ TBVerwijderMeubel��$��1��$
��Left=�$��	23,60,0,0q�$
 Wrap=�$	��Top=�$	��120������ *Verwijderbalk+�� -	   $��	Verwijder��$��1��$
��Left=�$��
151,60,0,0q�$	��Top=����� *VerwijderMeubel+$ OneWay=��� $��Type productcode in��$
��Left=�$��
291,56,0,0q�$	��Top=�$	��119��$��2��