   M S B A M L   `   `   `  ����B  >CartWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CartWPFCartWPF  5   	       CartWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:CartWPF     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          � Title$  	Menu Form��5	   	   $	��665��6   $	��800��6(    � WindowStartupLocation$ CenterScreen=�64   $y�Visible=�6Y    � WindowStyle$
 None=�6n    � 
ResizeMode$ NoResize=�6�   .��5      � -   5        .+�5   
   � $	��Top=�6   $��60��6'   ���	#FF477DCB$	��600��6J   $��Right=�6V   .+�5      �� -   5         ��Name$ Title_TxtBlock��5      $
��Wrap=�60   $��	Main Menu��6D   $��Center=�6U   $��Center=�6r   $��Palatino Linotype)�6�   $��23(�6�   
�������6�   �� 5      -   5         ��Name$ 	Close_Btn��5      
�������$��Center=�6h   $��553,12,10,16q�6�    � ToolTip$ Close Application��6�   ��6(   Z� ��6>   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ Close=�6*   $��25��67   $��25��6B   $	��-10q�6N   5      5      � 5   
   $	��200��6   $
��Left=�6   ���	#FF1C3368.+�5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ Slide_TransitionContent��5   2   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase	   OpeningEffect	 6S   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+
   Duration$
 0:0:0.2X�.��5      � -   5         �Name$ Cursor_Grid��5      $��10��6,   $
��Left=�67   $��60��6R   
�������$	��Top=�6u   5      �� 5      -   5         ��Name$ Menu_ListView��5      
�������$��Palatino Linotype)�6F   .@�5      �� $��60��6   ���	#FF9D3113.��5      ��  �� Orientation$ 
Horizontal=�6!   $	��183��6:   .+�5        $
 Home=�62   $��35��6>   $��35��6I   $
��20 0q�6U   $��Center=�6c   �� 5      $��	MetroData��6$   $��Center=�65   $��20(�6P   5      5      �� 5      $��60��6   .��5      �� $ 
Horizontal=�6!   .+�5         $ TruckDelivery=�62   $��35��6G   $��35��6R   $
��20 0q�6^   $��Center=�6l   �� 5!      $��Supplier��6$   $��Center=�64   $��20(�6O   5"      5#      �� 5$      $��60��6   .��5%      �� $ 
Horizontal=�6!   .+�5&        $ CardGiftcard=�62   $��35��6F   $��35��6Q   $
��20 0q�6]   $��Center=�6k   �� 5'      $
��Item��6$   $��Center=�60   $��20(�6K   5(      5)      �� 5*      $��60��6   .��5+      �� $ 
Horizontal=�6!   .+�5,        $ TrolleyOutline=�62   $��35��6H   $��35��6S   $
��20 0q�6_   $��Center=�6m   �� 5-      $
��Cart��6$   $��Center=�60   $��20(�6K   5.      5/      51      52      � 54   
   $��
200,65,0,0q�6   .+�55      � -   5        $ 	Main_Grid��55      $��Center=�6&   $	��Top=�6C   6]   56      57      58      