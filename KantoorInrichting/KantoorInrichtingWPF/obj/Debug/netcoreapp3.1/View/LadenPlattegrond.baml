   M S B A M L   `   `   `  ����O  KKantoorInrichtingWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:KantoorInrichtingWPF.ViewKantoorInrichtingWPF.View  5   	   O,clr-namespace:KantoorInrichtingWPF.ViewModelKantoorInrichtingWPF.ViewModel  5   	   /    )KantoorInrichtingWPF.View.LadenPlategrond   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:KantoorInrichtingWPF.View     5   	   B	ViewModel,clr-namespace:KantoorInrichtingWPF.ViewModel     5   	     � Title$  Laden Plattegrond��5	   	   $	��450��6#   $	��930��60    � DataContext 5
      9  3KantoorInrichtingWPF.ViewModel.PlattegrondViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $	��40* �6   �� 5      $
��177* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGLadenPlategronden��5      $��0,80,0,0q�60   $��2��6B      
IsReadOnly$
 True��6�   ��6S   �� *PlattegrondLijst+6�   �� 5   
   -   5         ��Name$ 
TBzoekbalk��5      $
��Left=�6&   $��	83,51,0,0q�6A    �� TextWrapping$
 Wrap=�6T   $	��Top=�6h   $	��120��6�   $��18��6�   ��6�   �� *
Zoekbalk+�� 5   
   -   5         ��Name$! ButtonZoekenPlattegrondNaam��5      $��Zoeken Plattegrond Naam��66   $
��Left=�6X   $��
220,50,0,0q�6s   $	��Top=�6�   $��19��6�   $	��154��6�   ��6�   �� *ZoekenPlattegrondNaam+ �� Mode$ OneWay=��� 5   
   $��Opgeslagen Plattegronden��6   $��Center=�63   $��0,14,0,0q�6P   $	��Top=�6b   �� 5   
   -   5        $ ButtonTerug��5      $��Terug��6&   $
��Left=�66   $��	26,20,0,0q�6Q   $	��Top=�6d   6|   �� 5   
   -   5        $ ButtonZoekenProjectNaam��5      $��Zoeken Project Naam��62   $
��Left=�6P   $��
396,50,0,0q�6k   $	��Top=�6   $��19��6�   $	��153��6�   ��6�   �� *ZoekenProjectNaam+$ OneWay=��� 5   
   -   5        $ ButoonRefresh��5      $��Refresh��6(   $
��Left=�6:   $��
575,50,0,0q�6U   $	��Top=�6i   ��6�   �� *UpdatePlattegrondenLijst+$ OneWay=��� 5   
   -   5        $ TBProjectNaam��5      $
��Left=�6)   $��
641,51,0,0q�6D   $
 Wrap=�6X   $	��Top=�6l   $	��120��6�   ��6�   �� *Projectbalk+�� 5   
   $��Bestelling project��6   $
��Left=�6.   $��
779,49,0,0q�6I   $	��Top=�6]   ��6u   �� *BestellenProject+$ OneWay=�5      5      