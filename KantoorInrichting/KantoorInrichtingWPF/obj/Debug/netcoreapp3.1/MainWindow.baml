   M S B A M L   `   `   `  ����O  KKantoorInrichtingWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:KantoorInrichtingWPFKantoorInrichtingWPF  5   	   O,clr-namespace:KantoorInrichtingWPF.ViewModelKantoorInrichtingWPF.ViewModel  5   	   ?$clr-namespace:WPF.JoshSmith.ControlsWPF.JoshSmith.Controls  5   	   %    KantoorInrichtingWPF.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:KantoorInrichtingWPF     5   	   B	ViewModel,clr-namespace:KantoorInrichtingWPF.ViewModel     5   	   9Controls$clr-namespace:WPF.JoshSmith.Controls     5   	     � Title$  Plattegrond editor��5   	   $	��650��6$   $
��1000��61    � WindowStartupLocation$ CenterScreen=�6>    � DataContext 5      4   .KantoorInrichtingWPF.ViewModel.MeubelViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $	��43* �6   �� 5      $
��520* �6   �� 5      $	��71* �6    � ColumnDefinitions 5   
   �� 5      $
��111* �6   �� 5      $
��121* �6   �� 5      $
��133* �6   �� 5      $
��635* �6   .+�5   
   ]� $��False��6   $��	0,0,0,500q�6*   $��2��6=   $��3��6N   .+�5      o� $	��100��6   $
��Left=�6   $	��Top=�6:   .@�5      m� $
��Open��6   .@�5      m� -   5        $��Nieuwe plattegrond��5      6;   m� 5       -   5        $��Open plattegrond��5       69   5!      5"      o� 5#      $	��100��6   $
��Left=�6   $	��Top=�6:   .@�5$      m� $��Opslaan��6   .@�5%      m� -   5        $��Opslaan��5%      60   m� 5'      -   5        $��Opslaan als��5'      64   5)      5*      o� 5+      $	��100��6   $
��Left=�6   $	��Top=�6:   .@�5,      m� $��Meubels��6   .@�5-      m� -   5        $��	Toevoegen��5-      62   m� 5/      -   5        $��Lijst��5/      6.   50      51      o� 52      $	��Top=�6   $��17��6(   $
��Left=�64   $	��Top=�6O   $	��Top=�6g   .@�53      m� -   5        $��	Bestellen��53      6.   54      56      �� 57   
   -   5         ��Name$ 	TBMeubels��57      $
��Left=�6%   $��0,25,0,0q�6@    �� TextWrapping$
 Wrap=�6R   $	��Top=�6f   $	��120��6~   $��18��6�   $��2��6�   ��6�   �� *
Zoekbalk+6�   �� 58   
   -	   5         ��Name$ ButtonZoekenMeubelNaam��58      $��Zoeken naam��61   $
��Left=�6G   $��	27,24,0,0q�6b   $	��Top=�6u   $��20��6�   $��96��6�   $��2��6�   $��1��6  $��2��6"  ��6�   �� *ZoekNaamInCatalogus+ �� Mode$ OneWay=�6"  &   System.Windows.Controls.DataGrid  59   
   -
   5        	  Name$	 	DGMeubels��59      
   
IsReadOnly$

 True��6&   $��0,43,0,0q�6�   $��2��6�   $��3��6�   ��68   �� *	Catalogus+6�   �� 5:   
   -   5        $ ButtonRefresh��5:      $��Refresh��6(   $
��Left=�6:   $��27,0,0,0q�6U   $��Center=�6g   $��20��6�   $��44��6�   $��3��6�   ��6�   �� *UpdateCatalogus+$ OneWay=��� 5;   
   -   5        $! ButtonZoekenMeubelCategorie��5;      $��Zoeken categorie��66   $
��Left=�6Q   $��7,22,0,0q�6l   $	��Top=�6~   $��20��6�   $	��103��6�   $��2��6  ��6�   �� *ZoekCategorieInCatalogus+$ OneWay=�6  d� 5<   
   -   5         d�Name$ ButtonShowRaster��5<      $��Raster��61   $��135,9,415,12q�6B   $��3��6X   �� 5>   
   $��1q�6   
���   �$��3��5@      $��5,43,0,0q�5A      $��2��5B      ._�5D      � -   5        $��ShapeCanvas��5D      $
��Left=�6&   $	��645��6A   $��	-1,-1,0,9q�6M   ��5E      L� 5F       j� TileMode$
 Tile=�6#    j� Viewport$ 0, 0, 50, 50�5G   #    j� ViewportUnits$ Absolute=�5H   #    j� Stretch$
 Fill=�6<    j� 
AlignmentX$
 Left=�6K    j� 
AlignmentY$	 Top=�6]    L� Drawing 5L      � 5M       � Geometry 5N   "   �� 5O   &    �� Rect$ 0, 0, 100, 100�68   
 � Pen 5Q   "   >� 5R   &    >� Brush
 ����� >� 	Thickness$ 1Q�67   -   5        
Raster��5R   E   5T      5V      .+�5Y      '   !WPF.JoshSmith.Controls.DragCanvas  -   5          Name$ DragCavasPlattegrond��5Y   &   '   !WPF.JoshSmith.Controls.DragCanvas   MouseRightButtonDown$ OnMouseRightButtonPressed��5Z         PreviewMouseDown$ OnMouseDownPressed��5[         MouseLeftButtonUp$, &DragCavasPlattegrond_MouseLeftButtonUp��5\         MouseLeftButtonDown$. (DragCavasPlattegrond_MouseLeftButtonDown��5]         	MouseMove$$ DragCavasPlattegrond_MouseMove��5^         AllowDragOutOfView$ False��5_      5a      5b      �� 5d   
   -   5         ��Name$ LabelTotalPrijs��5d      $��3��6)   $
��Left=�69   $��	412,0,0,0q�6T   $��Center=�6g   $��30��6�   $��64��6�   $��16(�6�   $��2��6�   �� 5e   
   -   5        $ ButtonTotaalPrijs��5e      $��Totaalprijs��6,   $��3��6B   $
��Left=�6R   $��	530,0,0,0q�6m   $��Center=�6�   $��33��6�   $��67��6�   $��2��6�   d� 5f   
   -   5        $ 
ButtonMuur��5f      $
��Muur��6+   $��Center=�6:   $��2��6W   $��Center=�6d   $��71��6   $	��111��6�   6�   �� 5g   
   -   5        $ 
ButtonRaam��5g      $
��Raam��6%   $��Center=�64   $��2��6Q   $��Center=�6^   $��71��6y   $	��123��6�   $��1��6�   �� 5h   
   -   5        $ 
ButtonDeur��5h      $
��Deur��6%   $��Center=�64   $��2��6Q   $��Center=�6^   $��71��6y   $	��133��6�   $��2��6�   �� 5i   
   -   5        $ LabelLengte��5i      $�� ��6%   $��3��60   $
��Left=�6@   $��	120,0,0,0q�6[   $��Center=�6n   �� 5j   
   -   5        $ LabelBreedte��5j      $�� ��6&   $��3��61   $
��Left=�6A   $��	210,0,0,0q�6\   $��Center=�6o   �� 5k   
   -   5        $ LabelHoogte��5k      $�� ��6%   $��3��60   $
��Left=�6@   $��	317,7,0,0q�6[   $	��Top=�6n   �� 5l   
   -   5        $ ButtonNotitie��5l      $��Notitie��6(   $��3��6:   $
��Left=�6J   $��2��6e   $��Center=�6r   $��71��6�   $	��101��6�   6�   �� 5m   
   -   5        $ 
ButtonHelp��5m      $
��Help��6%   $��3��64   $
��Left=�6D   $��86,0,0,0q�6_   $��Center=�6q   6�   5q      5r      