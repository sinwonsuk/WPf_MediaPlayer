   M S B A M L   `   `   `  ����  MediaPlayer    MediaPlayer.View.Window1   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	   e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   Hei9http://schemas.microsoft.com/expression/2010/interactions     5   	     � Title$  Window1��5   	   $	��809��6   $
��1280��6&   .��5      � .+�5   
   r� -   5         r�Name$ VideoPlayer��5      $��18,10,18,65q�6,   $��0��6A   �� 5   
   $��0:00:00��6   $
��Left=�6"   $��9,0,0,33q�6=   $��Bottom=�6O   $��2��6j   �� 5   
   -   5        $��
mainSlider��5      $��64,0,264,33q�6#   $��Stretch=�68   $��Stretch=�6]   $��19��6�   $��Bottom=�6�    � Minimum$ 0Q�6�    � Value 6�   �� *SliderValue+ � Maximum 6�   �� *MediaFinishTime+*  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5   
   +  %Microsoft.Xaml.Behaviors.EventTrigger  5         	EventName$ PreviewMouseDown��6!   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6,   �� *DragStarted+	   CommandParameter	 6L   �� 
 �� ElementName$
 VideoPlayer��5        5      $ PreviewMouseUp��6!   . 5         6,   �� *DragCompleted+	 6N   �� $
 VideoPlayer��5      5      �� 5   
   $��0:00:00��6   $��Right=�6"   $��
0,0,211,33q�6>   $��Bottom=�6R    J� RenderTransformOrigin$ -0.097,0.48&�6m   �� 5"   
   -   5        $��	soundIcon��5"      $��Right=�6!   $��Bottom=�6=   $��22��6X   $��22��6c   $M��GC:\Users\onerp\Downloads\MediaPlayer\MediaPlayer\Resource\SoundIcon.png��6o   $��
0,0,184,35q�6�   $ -1.795,0.545&�6�   �� 5%   
   -   5         ��Name$ SoundSlider��5%      $��Right=�6&   $��	0,0,93,36q�6B   $��Bottom=�6U   $��85��6p   $ 0.5,0.5&�6{   $	 100Q�6�    6�   �� *SoundsliderValue+z�5&      V� 5'      .~�5(      �� �� 5)      �� 5*       �� Angle$ 1.224Q�6&   T� 5+      5,       5.        5/      $ PreviewMouseUp��6!   . 50         6,   �� *	SoundSlid+	 6J   �� $
 VideoPlayer��51      54      �� 57   
   -   5         ��Name$ btnStart��57      $	��▶��6#   $
��Left=�6/   $��12,0,0,5q�6J   $��29��6\   $��23��6g   $��Bottom=�6s   ���	#FFFFF8F8��6�   �� *
StartClick+��6�   �� $
 VideoPlayer���� 58   
   -   5        $ btnStop��58      $	��■��6"   $
��Left=�6.   $��50,0,0,5q�6I   $��29��6[   $��23��6f   $��Bottom=�6r   ���	#FFFFF8F8��6�   �� *	StopClick+��6�   �� $
 VideoPlayer���� 59   
   -   5        $ btnPause��59      $��II��6#   $
��Left=�60   $��88,0,0,5q�6K   $��29��6]   $��23��6h   $��Bottom=�6t   ���	#FFFFF8F8��6�   �� *
PauseClick+��6�   �� $
 VideoPlayer���� 5:   
   -   5        $ btnSelectFile��5:      $��파일열기��6(   $��	0,0,23,31q�67   $��Right=�6J   $��56��6f   $��24��6q   $��Bottom=�6}   
���������6�   �� *FileOpenClick+��6�   �� $
 VideoPlayer��5<      5=      