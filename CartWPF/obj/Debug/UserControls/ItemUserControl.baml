   M S B A M L   `   `   `  ����B  >CartWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:CartWPF.UserControlsCartWPF.UserControls  5      *    $CartWPF.UserControls.ItemUserControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:CartWPF.UserControls     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5        .��5      � .+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$  Slide_TransitionContent��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6O   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromRight+   Duration$ 0:0:0.2X�.��5      �� .+�5      ��  �� Orientation$ Vertical=�6   .+�5      �� -   5         ��Name$ 	textBlock��5       $
��Wrap=�63   $
��ITEM��6G   $	��Top=�6S    �� TextAlignment$ Center=�6k   $��Verdana)�6�   $��25(�6�   $��25q�6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ Item_DataGrid��5      $��Center=�66   $	��Top=�6S   $	��180��6k   $	��513��6x      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��61   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6=   �� *Id+  5      $	 	Item Name��61      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6]   
 6D   �� *Name+6]     5      $	 
Item Stock��61   $ 80 6_   
 6E   �� *Stock+6_     5      $	 
Item Price��61   $ 80 6_   
 6E   �� *Price+6_     5      $	 Supplier Name��61   $ * 6k   
 6H   �� *Suppliers.Name+6k      ColumnHeaderStyle 5      �� 5       �� 
TargetType=	  7System.Windows.Controls.Primitives.DataGridColumnHeader" 	 6$   .�5   "   ��  �� Property � �� �� Value$ Center=�6O   �� 5   "    � ��
 �����6?   �� 5   "    � ��$ 30��6;   5      5      5       �� 5!      $ 
Horizontal=�6   $��Center=�66   $
��0 30q�6S   .+�5"      �� $��15q�6!   .+�5#      �� $ 
Horizontal=�6%   .+�5$      �� -   5        $ 
textBlock1��5$   (   $
��Left=�6<   $
��Wrap=�6W   $��	Item Name��6k   $��Center=�6|   $��16(�6�   $	��115��6�   �� 5%      -   5         ��Name$ ItemName_Txt��5%   &   $
��Left=�6<   $��35��6W    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��235��6�   $��16(�6�   5&      �� 5'      $ 
Horizontal=�6%   .+�5(      �� -   5        $ 
textBlock2��5(   (   $
��Left=�6<   $
��Wrap=�6W   $��
Item Stock��6k   $��Center=�6}   $��16(�6�   $	��115��6�   �� 5)      -   5        $ ItemStock_Txt��5)   &   $
��Left=�6=   $��35��6X   $
 Wrap=�6d   $	��Top=�6x   $	��235��6�   $��16(�6�   6�   5*      �� 5+      $ 
Horizontal=�6%   .+�5,      �� -	   5        $ 
textBlock3��5,   (   $
��Left=�6<   $
��Wrap=�6W   $��
Item Price��6k   $��Center=�6}   $��16(�6�   $	��115��6�   �� 5-      -
   5        $ ItemPrice_Txt��5-   &   $
��Left=�6=   $��35��6X   $
 Wrap=�6d   $	��Top=�6x   $	��235��6�   $��16(�6�   6�   5.      �� 5/      $ 
Horizontal=�6%   .+�50      �� -   5        $ 
textBlock4��50   (   $
��Left=�6<   $
��Wrap=�6W   $��Supplier Name��6k   $��Center=�6�   $��16(�6�   $	��115��6�   �� 51      -   5         ��Name$ Supplier_comboBox��51   '   $
��Left=�6B   $	��Top=�6]   $	��235��6u   $��35��6�   $��16(�6�    �� Text$ Pick One��6�    �� DisplayMemberPath$
 Name��52   N    �� SelectedValuePath$ Id��6g   ��6!   ��  �� Source$ SupplierList��6g   53      �� 54      -   5        $ 
ItemId_Txt��54   "   $
��Left=�66   $��25��6Q   $
 Wrap=�6]   $	��Top=�6q   $��26��6�   $y�	Collapsed=�6�   55      �� 56      $��0,25,0,0q�6!   .+�57      �� -   5         ��Name$ SaveItem_Btn��57   !   $��	Save Item��67   $
��Left=�6K   $	��Top=�6f   $	��120��6~   $��35��6�   $��10q�6�   6�   �� 58      -   5        $ DeleteItem_Btn��58   !   $��Delete Item��69   $
��Left=�6O   $	��Top=�6j   $	��120��6�   $��35��6�   $��10q�6�   6�   59      5:      5;      5<      5=      5>      