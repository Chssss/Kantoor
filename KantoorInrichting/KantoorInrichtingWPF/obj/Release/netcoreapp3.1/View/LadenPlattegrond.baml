   M S B A M L   `   `   `  ���� O  KKantoorInrichtingWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:KantoorInrichtingWPF.ViewKantoorInrichtingWPF.View  O,clr-namespace:KantoorInrichtingWPF.ViewModelKantoorInrichtingWPF.ViewModel  /    )KantoorInrichtingWPF.View.LadenPlategrond   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     9local'clr-namespace:KantoorInrichtingWPF.View     B	ViewModel,clr-namespace:KantoorInrichtingWPF.ViewModel       � Title$  Laden Plattegrond��$	��450��$	��930�� � DataContext 9  3KantoorInrichtingWPF.ViewModel.PlattegrondViewModel  .���  � RowDefinitions �� $	��40* ��� $
��177* �.+�&   System.Windows.Controls.DataGrid  -     Name$ DGLadenPlategronden��$��0,80,0,0q�$��2��   
IsReadOnly$
 True������ *PlattegrondLijst+�� -    ��Name$ 
TBzoekbalk��$
��Left=�$��	83,51,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��120��$��18������ *
Zoekbalk+�� -    ��Name$! ButtonZoekenPlattegrondNaam��$��Zoeken Plattegrond Naam��$
��Left=�$��
220,50,0,0q�$	��Top=�$��19��$	��154������ *ZoekenPlattegrondNaam+ �� Mode$ OneWay=��� $��Opgeslagen Plattegronden��$��Center=�$��0,14,0,0q�$	��Top=��� -   $ ButtonTerug��$��Terug��$
��Left=�$��	26,20,0,0q�$	��Top=��� -   $ ButtonZoekenProjectNaam��$��Zoeken Project Naam��$
��Left=�$��
396,50,0,0q�$	��Top=�$��19��$	��153������ *ZoekenProjectNaam+$ OneWay=��� -   $ ButoonRefresh��$��Refresh��$
��Left=�$��
575,50,0,0q�$	��Top=����� *UpdatePlattegrondenLijst+$ OneWay=��� -   $ TBProjectNaam��$
��Left=�$��
641,51,0,0q�$
 Wrap=�$	��Top=�$	��120������ *Projectbalk+�� $��Bestelling project��$
��Left=�$��
779,49,0,0q�$	��Top=����� *BestellenProject+$ OneWay=�