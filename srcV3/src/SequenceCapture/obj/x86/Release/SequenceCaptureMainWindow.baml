   M S B A M L   `   `   `  ���� S  OEmgu.CV.UI, Version=2.1.0.793, Culture=neutral, PublicKeyToken=7281126722ab4438;,clr-namespace:Emgu.CV.UI;assembly=Emgu.CV.UI
Emgu.CV.UI  B >GazeGUI, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null2&clr-namespace:GazeGUI;assembly=GazeGUIGazeGUI  SequenceCapture/   )SequenceCapture.SequenceCaptureMainWindow   R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     8x,http://schemas.microsoft.com/winfx/2006/xaml    ;emgu,clr-namespace:Emgu.CV.UI;assembly=Emgu.CV.UI    8GazeGUI&clr-namespace:GazeGUI;assembly=GazeGUI    >d2http://schemas.microsoft.com/expression/blend/2008    Hmc;http://schemas.openxmlformats.org/markup-compatibility/2006      � Title$  Window1��$	��348��$	��629�� � WindowStyle$
 None=� � 	Resources    iPhoneCheckBox �� 
TargetType �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels �� 
TargetType	 ��Name
 �� CornerRadius �� EndPoint �� 
StartPoint � Color � Offset �Name � ColumnDefinitions ��Name ��Name �� RadiusY �� RadiusX ��Name �� TextAlignment �� Triggers P� Property P� Value �� 
TargetName��%�  &	        �� " ��.���  �@�FocusVisualStyle �� .���  � �� �� .R��� ���	#FF000000$	 1 2R�$��1��$��0,0,0,0q� . ��  � ��# � ����  � ��# � ����  � �� �� " ��.R��� $	 border��$
 1,1,1,1��$��1,1,1,1q����	#FF353535���� $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFD6D6D6��$ 0Q�� $ 	#FFF7F7F7��$ 0.991Q�._�� $
 grid��$
��Auto��$
��Auto��$��Center=���Z�  �� $ columnDefinition��$
��Auto ��� $ columnDefinition2��$
��Auto ��� $ columnDefinition1��$
��Auto �.+��� $ 	rectangle�����	#FF919191$��0,0,0,0q�$��1��$��1��$��28��$��1��$ 1��$ 1������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFA1A1A1��$ 0Q�� $ 	#FFDEDEDE��$ 1Q��� $ ON��$��Center=�$��Stretch=�$��ON��$
��Wrap=�$��0��$��30��$ Center=�$y�	Collapsed=�$��Calibri)�$��14(�$
��Bold"����	#FFFFFFFF���� $ 0.5,1&�$ 0.5,0&�.��� $ 	#FF7DA9DE��$ 0Q�� $ 	#FF417AF5��$ 0.996Q��� $	 OFF��$��Center=�$��Stretch=�$	��OFF��$
��Wrap=�$��0,0,0,0q�$��2��$��30��$ Center=����	#FF474747$
��Bold"�$��Calibri)�$��14(� P�  �@d�	IsChecked$
 TrueY�. ��� $ ON�� � y�$ Visible=��� $	 OFF�� � y�$ 	Collapsed=��� $ ON�� � �� �� $ 0.5,1&�$ 0.5,0&�.��� $ 	#FF1C406A��$ 0Q�� $ 	#FF5C8BF2��$ 0.996Q�P�  � �� . P�  � {� .  . ��� # � �� � ��.��� ���� $ 0.498,0&�$ 0.502,1&�.��� $ Black��$ 0Q�� $ 	#FF2D2D2D��$ 1Q�.+��� $��-27,-28,-17,-19q�$=��7Graphics/f8e14b4df4c3413852893f1754a09ce037db2c70_m.jpg��$
��Fill=��� -   $��0q�$ 4��$ 4������ $ 0.498,0&�$ 0.502,1&�.��� $ 	#D8000000��$ 0Q�� $ 1Q�$ 	#23000000��� -   $ GridTop��$��49.123��$��6,-13.5,2,0q�$	��Top=�.+��� -   $��13.333(�$��GT Sequence Capture v0.1��$��0.665,16.174,0,5.783q�$
��Left=�$	��400��$��OCR A Extended)���Z� ���� $ 0.5,0.14&�$ 	0.5,1.022&�.��� $ 	#FFADADAD��� $ 	#FFE6E6E6��$ 0.623Q��� -    ��Name$ X��$��x��$��Verdana)�$��18.667(����	#FF8E8E8E$��Right=�$��25�� � ToolTip$ Close��$��0,10,-2,6.436q� K� ZIndex$ 99����Z� �� -   $ _��$��_��$��Shruti)�$��21.333(����	#FF8E8E8E$��Right=�$��19.773��$��0,1,18,-1.001q�$ Minimize��$ 99����Z� � -   $ GridCameraImage��$��8,28,0,0q�$	��336��$	��256��$
��Left=�$	��Top=�.+��� ���	#FF141414$��0q�$ 4��$ 4������ $ 0.5,0&�$ 0.5,1&�.��� $ 	#FF3F3F3F��$ 0Q�� $ 	#FF666666��$ 1Q�7  1System.Windows.Forms.Integration.WindowsFormsHost  -     Name$ windowsFormsHost��   
Background �	#00212121$	��320��$	��240��$��0q�$��Center=�$��Center=�    
Foreground  Z� !   Child.!    Emgu.CV.UI.ImageBox  -   imageBoxCapturedFrame��� -	   $ GridSessions��$��Right=�$��	0,28,8,48q�$	��251��.+��� $��0q�$ 4��$ 4�����	#3B000000���� $ 0.499,0&�$ 0.501,1&�.��� $ 	#FF252525��$ 0Q�� $ 	#FF505050��$ 1Q�� -
   $ GridSaveImagesProgress��$��	8,52,8,79q�$ 1��$	��235��$	��100��$y�	Collapsed=�.+��� ���	#FF707070$ 4��$ 4��" J� Effect" 3  -System.Windows.Media.Effects.DropShadowEffect  #   
BlurRadius$# 4Q�$   Color$$ 	#FF7A7A7A��%   	Direction$	% 311Q�&   ShadowDepth$& 4Q����� $ 0.49,0&�$ 0.51,1&�.��� $ 	#FF0A0A0A��� $ 	#FF2B2B2B��$ 1Q��� $��Saving data��$��29��$��0,12,0,0q�$	��Top=����	#FFB8B8B8$��Center=����	#00000000� -   ' �Name$' progressBarSaveImages��$��
12,15,12,0q�  SimpleProgressBar#���  $��20��$��Center=��� $��8,12,8,0q�( �� Orientation$( Vertical=�$	��Top=�$	��236��.+�� -   $ GridUsername��$��0,0,4,0q�.+��� $��Username��$
��Left=����	#FF9D9D9D$��10.667(��� -   ) ��Name$) TextBoxUsername��$��67.297,0,0,0q�* �� TextWrapping$
* Wrap=����	#FF00B60C���	#662D2D2D$��username��$��20��$��Center=����	#FF3B3B3B� -   $ GridDeviceName��$��25.96��$��0,4,4,0q�.+��� $��Device��$
��Left=����	#FF9D9D9D$��10.667(��� -   $) TextBoxDevice��$��67.297,0,0,0q�$
* Wrap=����	#FF00B60C$��Center=����	#66393939���	#FF393939$��20��� -   $ GridIRSources��$��25.96��$��0,4,0,0q�.+��� $��
IR Sources��$
��Left=����	#FF9D9D9D$��10.667(��� $��68.937,6,2,2q�$( 
Horizontal=�.+�	� -   + 	�Name$+ RadioIR0��$��0�����	#FF9F9F9F
���   �, d� 	IsChecked$
, TrueY�	� -   $+ RadioIR1��$��1�����	#FF9F9F9F$��4,0,0,0q�
���   �	� -   $+ RadioIR2��$��2�����	#FF9F9F9F$��4,0,0,0q�
���   �	� -   $+ RadioIR3��$��3�����	#FF9F9F9F$��4,0,0,0q�
���   �	� -   $+ RadioIR4��$��4�����	#FF9F9F9F$��4,0,0,0q�
���   �	� -   $+ RadioIR5��$��5�����	#FF9F9F9F$��4,0,0,0q�
���   �� -   $ GridLens��$��25.96��$��0,4,4,0q�.+��� $
��Lens��$
��Left=����	#FF9D9D9D$��10.667(��� -   $) TextBoxLens��$��67.297,0,0,0q�$
* Wrap=����	#FF00B60C���	#662D2D2D$��20��$��Center=����	#FF393939� -   $ GridLensParameters��$��25.96��$��67,0,4,0q�.+�� -   $ 
GridLensMM��$
��Left=�$��78��.+��� $��MM��$
��Left=����	#FF9D9D9D$��-4,0,0,0q�$��10.667(��� -   $) TextBoxLensMM��$
* Wrap=����	#FF00B60C���	#662D2D2D$��20��$��Center=�$��Right=�$��43.703�����	#FF3B3B3B� -   $ GridLensIris��$��0q�$��Right=�$��75��.+��� $
��Iris��$
��Left=����	#FF9D9D9D$��10.667(��� -   $) TextBoxLensIris��$
* Wrap=����	#FF00B60C���	#662D2D2D$��20��$��Center=�$��Right=�$��43.703�����	#FF393939� $��39.96��$��0,4,0,0q�.+��� $��Camera View��$
��Left=����	#FF9D9D9D$��0,-5,0,4q�$��10.667(�	� -   $+ RadioCameraViewBinocular��$��	Binocular��$
��Left=�$��4,0,0,0q����	#FF9D9D9D$��18.96��$��Bottom=�$��10.667(�$. (Both eyes are visible in the camera view��$
, TrueY�	� -   $+ RadioCameraViewMonocular��$��	Monocular��$
��Left=�$��74.127,0,0,0q����	#FF9D9D9D$��18.96��$��Bottom=�$��80.02��$��10.667(�$0 *Only one eye is visible in the camera view��	� -    $ + RadioCameraViewHeadmounted��$��Headmounted��$
��Left=�$��148.147,0,0,0q����	#FF9D9D9D$��18.96��$��Bottom=�$��90.853��$��10.667(�$D >Camera is placed close to the eye and covers most of the image��� $��0,0,4,0q�$��51.92��.+��� $��Notes��$
��Left=����	#FF9D9D9D$��10.667(�$��0,4,0,23.733q��� -!   $) TextBoxNotes��$
* Wrap=����	#641A1A1A���	#FF00B60C$��4,25.96,0,0q����	#FF353535� -"   $ GridShareData��$��24��$��8,0,0,14.62q�$��Bottom=�$
��Left=�$	��130��.+��� -#   - ��Name$- CheckBoxShareData��$�� ��$��0,3.62,0,1.29q�$��Right=�#���   $
, TrueY��� $��
Share data��$��0,0,63,0q����	#FFA7A7A7  GazeGUI.ButtonGlass  -$   .  Name$. BtnRun��$��Right=�$��30��$��0,0,8,8q�$��Bottom=�$	��136��/   
ButtonIcon$/ Graphics/GTsystem_run.png��0   ButtonLabel$0 Record sequence��� -%   $ GridShowSyncUI��$��24��$��142,0,0,14.62q�$��Bottom=�$
��Left=�$	��144��.+��� -&   $- CheckBoxShowSyncUI��$�� ��$��0,3.62,0,1.29q�$��Right=�#���   �� $��Show Sync UI��$��0,0,63,0q����	#FFA7A7A7