   M S B A M L   `   `   `  ���� J  FGazeGUIVelocity, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullJ6clr-namespace:GazeGUIVelocity;assembly=GazeGUIVelocityGazeGUIVelocity   GazeTrackerUI!   GazeTrackerUI.MessageWindow   R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     8x,http://schemas.microsoft.com/winfx/2006/xaml    >d2http://schemas.microsoft.com/expression/blend/2008    Hmc;http://schemas.openxmlformats.org/markup-compatibility/2006    PGazeGUIVelocity6clr-namespace:GazeGUIVelocity;assembly=GazeGUIVelocity    -     �Name$  Window�� � Title$ MessageWindow��
������  � WindowStyle$
 None=� � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�$	��541��$	��312��.��� -    �Name$ 
LayoutRoot��.+�� -   $ GridContent��$y�Visible=�$��0q�.+��� -    ��Name$ RectBG2�� �� RadiusX$ 7�� �� RadiusY$ 7��$��0q����	#D8000000���� 	 �� EndPoint$	 0.379,0.448&�
 �� 
StartPoint$
 0.918,0.929&�.���  � Color$ 	#FF787878�� � Offset$ 0Q�� $ 	#FFB1B1B1��$ 1Q�� -   $ GridTop��$��8,-3,5,0q�$	��Top=�$��40.41��.+��� -    ��Name$ LabelCloseX��$��x��$��Verdana)�$��18(����	#FF989898$��Right=�$
��Auto��$
��Auto��$��0,0.533,0,8q���Z� �� -   $ 
LabelTitle�����	#00FBFBFB$��
Lithos Pro)�$��18.667(�
�������$��0,2.998,0,3.996q�$
��Auto��$	��GT2��$��Center=�� -   $ GridMessage��$��8,29.998,8,0q�$	��Top=�$��121.002��.+��� ���	#D9161616���	#FF474747$ 2��$ 2��$��0q��� -	    ��Name$ TextBlockMessage��
�������$
��Wrap=�$��8,8,8,3q�$��13.333(�� $��	8,155,8,8q�.+��� ���	#D8161616���	#FF474747$ 2��$ 2���� $��
16,11,16,0q�$	��Top=�$��67�����	#FFAFAFAF$
��Wrap=�$��10.667(��� $���The Gaze Tracker is a open source community driven effort continuously improving the platform. We hope that you will contribute your experience in our user community. ���� �� $� ���� �� $�Available resources:��� $��	6,73,10,4q� � Orientation$ 
Horizontal=� � 	ItemWidth$ 85��.+�   GazeGUIVelocity.Button  -
     Name$ BtnForum�����	#FF343434���	#FFB7B7B7   ActivationMethod$ Mouse��   Icon$ Graphics/users.png��   Label$ Forum��$��70��$��65��$��Center=�  -   $ 	BtnManual��$��70�����	#FF343434
���   �$ Mouse��$ Graphics/book.png��$ Manual��$��65��$��Center=�  -   $ BtnVideoInstruction�����	#FF343434
���   �$ Mouse��$  Graphics/little_tv_256.png��$ Videos��$��65��$��Center=�$��70��