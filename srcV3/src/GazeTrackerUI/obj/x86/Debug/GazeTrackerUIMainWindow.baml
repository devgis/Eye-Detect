   M S B A M L   `   `   `  ����J  FGazeGUIVelocity, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullJ6clr-namespace:GazeGUIVelocity;assembly=GazeGUIVelocityGazeGUIVelocity  5      H DGazeTrackerUI, Version=2.1.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:GazeTrackerUIGazeTrackerUI 5      I)clr-namespace:GazeTrackerUI.TrackerViewerGazeTrackerUI.TrackerViewer 5      +   %GazeTrackerUI.GazeTrackerUIMainWindow   5      R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     8x,http://schemas.microsoft.com/winfx/2006/xaml    5      >d2http://schemas.microsoft.com/expression/blend/2008    69   Hmc;http://schemas.openxmlformats.org/markup-compatibility/2006    5      PGazeGUIVelocity6clr-namespace:GazeGUIVelocity;assembly=GazeGUIVelocity    5      3GazeTrackerUIclr-namespace:GazeTrackerUI    5      ATrackerViewer)clr-namespace:GazeTrackerUI.TrackerViewer    5      -   5          �Name$  ITUGazeTracker��5	       � Title$ ITU GazeTracker��5
       � WindowStyle$
 None=�5       � AllowsTransparency .   � WindowStartupLocation$ CenterScreen=�5      $	��400��5      $	��240��6    � 
ResizeMode$ NoResize=�6    � Icon$/ )/GazeTrackerUI;component/Graphics/eye.ico��61   .��5      � -   5         �Name$ 
LayoutRoot��5      $��0q�6   $
��Left=�6*   $	��Top=�6E   $	��400��6]   $	��240��6i   .+�5   
   � -   5        $ GridBase��5      $��0q�6!   .+�5      � -   5        $ GridTop��5      $	��Top=�6$   $
��23.5��6<   $��0,-2,0,0q�6J   
�������.+�5      �� -   5        $��13.333(�5   9   $��GazeTracker Video Window��6K   $��4,2.834,0,-6.5q�6n   $
��Left=�6�   $	��400��6�   $��OCR A Extended)�6�   
���  ����6�   Z� 6�   5      � 5      -   5        $ GridCamerImage��5      $��Stretch=�6+   $��
0,22.5,0,0q�6I    K� ZIndex$ 1��6]   $
��Auto��6n   .+�5      � -   5        $ GridVideoImage��5      $��4,3,4,0q�6/   $	��Top=�6@   $	��210��6X   .+�5      3  -GazeTrackerUI.TrackerViewer.VideoImageControl  -   5        	  Name$	 videoImageControl��5   6   $��Center=�6Q   $	��Top=�6n   $ 1��6�   $��0q�6�   $	��384��6�   $	��204��6�   5      5      5      �� 5   
   -	   5        
 ��Name$
 X��5   �   $��x��6   $��Verdana)�6G   $��18.667(�6\   ���	#FF8E8E8E$��Right=�6�   $��25��6�    � ToolTip$ Close��6�   $��
0,-6.5,0,0q�6�   $ 99��6�   $	��Top=�6�   ��61   Z� 6�   �� 5   
   -
   5        $
 _��5   �   $��_��6   $��Shruti)�6J   $��21.333(�6^   ���	#FF8E8E8E$��Right=�6�   $��19.773��6�   $��0,-15.5,20,0q�6�   $ Minimize��6�   $ 99��6�   $	��Top=�6�   ��64   Z� 6�   5      5       