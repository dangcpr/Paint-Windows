   M S B A M L   `   `   `  ����F  BMainProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MainProjectMainProject  5   	       MainProject.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:MainProject     5   	   -   5          � Title$  
MainWindow��5   	   $	��720��6   $
��1280��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      .+�5   
   +  %System.Windows.Controls.Ribbon.Ribbon   K� ZIndex$ 2��6   $��0��6"   .@�5      .  (System.Windows.Controls.Ribbon.RibbonTab  $
��Home��6   .@�5      0  *System.Windows.Controls.Ribbon.RibbonGroup  $��System��6   .@�5      1  +System.Windows.Controls.Ribbon.RibbonButton     Label$
 Save��6#      LargeImageSource$ assets/Ribbon/save.png��60     5      $ Load Saved File��6#   $ assets/Ribbon/load.png��6;     5      -   5        $ Import Image��5   #   $ assets/Ribbon/import.png��68   6d     5      -   5        $ Export Image��5   #   $ assets/Ribbon/export.png��68   6d   5        5      $��	Utilities��6   .@�5        -   5          Name$ 
UndoButton��5   #   $
 Undo��67   $ assets/Ribbon/undo.png��6D   6n     5      -   5        $ 
RedoButton��5   #   $
 Redo��67   $ assets/Ribbon/redo.png��6D   6n     5      -   5        $ 
ZoomButton��5   #   $
 Zoom��67   $ assets/Ribbon/zoom.png��6D   6n   5        5      $
��Draw��6   .@�5        -   5        $
 Line��5   #      SmallImageSource$ assets/Ribbon/lines.png��60   6[     5      -   5        $ Ellipse��5   #   $  assets/Ribbon/ellipses.png��63   6a     5      -	   5        $ 	Rectangle��5   #   $" assets/Ribbon/rentangles.png��65   6e     5      $ Reset��6#   $ assets/Ribbon/reset.png��61   5       5!      5#      �� 5$   
   -
   5         ��Name$ canvas��5$   5   
�������$ 1��6$   $��1��6E   5%      5'      5(      