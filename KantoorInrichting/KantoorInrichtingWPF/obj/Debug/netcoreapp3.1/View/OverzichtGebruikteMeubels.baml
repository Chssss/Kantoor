   M S B A M L   `   `   `  ����O  KKantoorInrichtingWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:KantoorInrichtingWPF.ViewKantoorInrichtingWPF.View  5   	   O,clr-namespace:KantoorInrichtingWPF.ViewModelKantoorInrichtingWPF.ViewModel  5   	   9    3KantoorInrichtingWPF.View.OverzichtGebruikteMeubels   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:KantoorInrichtingWPF.View     5   	   B	ViewModel,clr-namespace:KantoorInrichtingWPF.ViewModel     5   	     � Title$  OverzichtGebruikteMeubels��5	   	   $	��450��6+   $	��500��68    � DataContext 5
      9  3KantoorInrichtingWPF.ViewModel.PlattegrondViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $	��19* �6   �� 5      $
��179* �6   �� 5      $	��19* �6   .+�5   
   �� -   5         ��Name$ ButtonTerug��5      $��Terug��6&   $
��Left=�66   $��	168,0,0,0q�6Q   $��Center=�6d   $��20��6�   $��33��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DGGebruikteMeubels��5      $��0,38,0,0q�6/   $��2��6A      
IsReadOnly$
 True��6R   ��6d   �� *GebruikteMeubelsLijst+�� 5   
   -   5         ��Name$ LabelTotalprijs��5      $�� ��6)   $
��Left=�64   $��	213,0,0,0q�6O   $��2��6b   $��Center=�6o   �� 5   
   $!��Overzicht gebruikte meubels��6   $
��Left=�66   $��Center=�6Q   �� 5   
   -   5        $��	Bestellen��5      $
��Left=�6%   $��	396,0,0,0q�6@   $��2��6S   $��Center=�6`   6{   5      5      