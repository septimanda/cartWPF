   M S B A M L   `   `   `  ����B  >CartWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:CartWPF.UserControlsCartWPF.UserControls  5      .    (CartWPF.UserControls.SupplierUserControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:CartWPF.UserControls     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5        .��5      � .+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$  Slide_TransitionContent��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6O   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromRight+   Duration$ 0:0:0.2X�.��5      ��  �� Orientation$ Vertical=�6   .+�5      �� .+�5      �� $
��Wrap=�6    $��SUPPLIER��64    �� TextAlignment$ Center=�6D   $	��Top=�6[   $��Palatino Linotype)�6s   $��25(�6�   $��25q�6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ Supplier_DataGrid��5      $	��Top=�6;   $	��168��6S   $	��450��6`      AutoGenerateColumns .  
�������   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��61   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6=   �� *Id+  5      $ Supplier Name��61   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6a   	 6H   �� *Name+6a     5      $ 	Join Date��61   $	
 150 6a   	 6D   �� *
JoinDate+6a      ColumnHeaderStyle 5      �� 5       �� 
TargetType=	  7System.Windows.Controls.Primitives.DataGridColumnHeader" 	 6$   .�5   "   ��  �� Property � �� �� Value$ Center=�6O   �� 5   "    � ��
 �����6?   �� 5   "    � ��$ 30��6;   5      5      5      �� 5       $��Center=�6   $
��0 30q�6:   .+�5!      �� $
��Left=�6    $
��Wrap=�6;   $��Supplier Name : ��6O   $��Center=�6g   $��16(�6�   �� 5"      -   5         ��Name$ SupplierName_Txt��5"      $��Center=�68    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $	��295��6�   $��Center=�6�   $��16(�6�   �� 5#      $
��Left=�6    $
��Wrap=�6;   $��Join Date : ��6O   $��Center=�6c   $��16(�6~   �� 5$      -   5        $ SupplierJoinDate_Txt��5$      $��Center=�6<   $
 Wrap=�6Y   $	��Top=�6m   $	��295��6�   $��Center=�6�   $��16(�6�   �� 5&      -   5        $ SupplierId_Txt��5&      $
��Left=�66   $
 Wrap=�6Q   $	��Top=�6e   $��48��6}   $y�	Collapsed=�6�   5'      �� 5(      $ 
Horizontal=�6   $��Center=�66   .+�5)      �� -   5         ��Name$ SaveSupplier_Btn��5)      $��Save Supplier��67   $
��Left=�6O   $	��Top=�6j   $	��130��6�   $��35��6�   $��10q�6�   6�   �� 5*      -   5        $ DeleteSupplier_Btn��5*      $��Delete Supplier��69   $
��Left=�6S   $	��Top=�6n   $	��130��6�   $��35��6�   $��10q�6�   6�   5+      5,      5.      5/      50      