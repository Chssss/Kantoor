   M S B A M L   `   `   `  ���� O  KKantoorInrichtingWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:KantoorInrichtingWPF.ViewKantoorInrichtingWPF.View  O,clr-namespace:KantoorInrichtingWPF.ViewModelKantoorInrichtingWPF.ViewModel  2    ,KantoorInrichtingWPF.View.OpslaanPlattegrond   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     9local'clr-namespace:KantoorInrichtingWPF.View     B	ViewModel,clr-namespace:KantoorInrichtingWPF.ViewModel       � Title$  OpslaanPlattegrond��$	��450��$	��800�� � DataContext 9  3KantoorInrichtingWPF.ViewModel.PlattegrondViewModel  .��� .+��� $��Opslaan Plattegrond��$��Center=�$��0,38,0,0q�$	��Top=��� $��Project naam��$
��Left=�$��	56,51,0,0q�$	��Top=�$��30��$��80���� -    ��Name$ TBProjectNaam��$
��Left=�$��	56,86,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��120������ *ProjectNaam+�� $��Plattegrond naam��$
��Left=�$��
56,109,0,0q�$	��Top=� J� RenderTransformOrigin$ -1.063,0.319&��� -   $ TBPlattegrondNaam��$
��Left=�$��
56,140,0,0q�$
 Wrap=�$	��Top=�$	��120������ *PlattegrondNaam+�� $��Lengte��$
��Left=�$��
56,163,0,0q�$	��Top=��� -   $ TBLengte��$
��Left=�$��
56,194,0,0q�$
 Wrap=�$	��Top=�$	��120������ *Lengte+�� $��Breedte��$
��Left=�$��
56,217,0,0q�$	��Top=��� -   $ 	TBBreedte��$
��Left=�$��
56,248,0,0q�$
 Wrap=�$	��Top=�$	��120������ *	Breedte+�� $��Hoogte��$
��Left=�$��
56,271,0,0q�$	��Top=��� -   $ TBHoogte��$
��Left=�$��
56,302,0,0q�$
 Wrap=�$	��Top=�$	��120������ *Hoogte+�� -    ��Name$ ButtonAnnuleren��$��	Annuleren��$
��Left=�$��464,341,0,0q�$	��Top=��� -   $ ButtonOpslaan��$��Opslaan��$��Center=�$��	0,341,0,0q�$	��Top=����� *ToevoegenPlattegrond+ �� Mode$ OneWay=��� $[��UAls de velden al zijn ingevuld, vul dan de laatste karakter opnieuw in voor elk veld.��$
��Left=�$��	25,12,0,0q�$	��Top=�$	��450��