   M S B A M L   `   `   `  ����B  >CartWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:CartWPF.UserControlsCartWPF.UserControls  5      5    /CartWPF.UserControls.TransactionItemUserControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:CartWPF.UserControls     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5        .��5      � .+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$  Slide_TransitionContent��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6O   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromRight+   Duration$ 0:0:0.2X�.��5      ��  �� Orientation$ Vertical=�6   .+�5      �� .+�5      �� $
��Wrap=�6    $
��CART��64    �� TextAlignment$ Center=�6@   $	��Top=�6W   $��Palatino Linotype)�6o   $��25(�6�   $��25q�6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ Cart_DataGrid��5      $	��Top=�67   $	��168��6O   $	��525��6\      AutoGenerateColumns .  
�������   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��61   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6=   �� *Id+  5      $ 	Item Name��61   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6]   	 6D   �� *Name+6]     5      $ Quantity��61   $	
 100 6`   	 6C   �� *
Quantity+6`     5      $ Price��61   $	
 100 6Z   	 6@   �� *Price+6Z   4	  .System.Windows.Controls.DataGridTemplateColumn	  5      $ Action��65   $	
 150 6E    	  CellTemplate 5   "   �� 5   &   .R�5   *   �� $ 
Horizontal=�65   .+�5   .   �� $��
Cancel_Btn��5   1   -   5        $��Delete��5   1   $	��120��5   1   
���  ��5   L   5    +   5!   '   5#        5$      $  ��61   $
 0 6U   	 6;   �� *Price+6U      ColumnHeaderStyle 5&      �� 5'       �� 
TargetType=
  7System.Windows.Controls.Primitives.DataGridColumnHeader" 
 6$   .�5(   "   ��  �� Property � �� �� Value$ Center=�6O   �� 5)   "    � ��
 �����6?   �� 5*   "    � ��$ 30��6;   5+      5-      5.      �� 5/      $ 
Horizontal=�6   .+�50      �� $��	25,20,0,0q�6!   .+�51      �� $
��Left=�6$   $
��Wrap=�6?   $��Supplier Name��6S   $��Center=�6h   $��16(�6�   $	��115��6�   �� 52      -   5         ��Name$ Supplier_comboBox��52   #   $
��Left=�6>   $	��Top=�6Y   $	��235��6q   $��35��6}   $��16(�6�    �� Text$ Pick One��6�    �� DisplayMemberPath$
 Name��53   N    �� SelectedValuePath$ Id��6g   ��6!   ��  �� Source$ SupplierList��6~   �� 54      $
��Left=�6$   $
��Wrap=�6?   $��	Item Name��6S   $��Center=�6d   $��16(�6   $	��115��6�   �� 55      -   5        $ Item_comboBox��55   #   $
��Left=�6:   $	��Top=�6U   $	��235��6m   $��35��6y   $��16(�6�   $ Pick One��6�   $
 Name��56   J   $ Id��6c   ��6!   �� $ ItemList��6z   �� 57      $
��Left=�6$   $
��Wrap=�6?   $��
Item Price��6S   $��Center=�6e   $��16(�6�   $	��115��6�   �� 58      -   5         ��Name$ ItemPrice_Txt��58   "   $
��Left=�69   $��35��6T    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��235��6�   $��16(�6�    �� 
IsReadOnly . 6�   �� 59      $
��Left=�6$   $
��Wrap=�6?   $��Quantity��6S   $��Center=�6c   $��16(�6~   $	��115��6�   �� 5:      -   5        $ ItemQuantity_Txt��5:   "   $
��Left=�6<   $��35��6W   $
 Wrap=�6c   $	��Top=�6w   $	��235��6�   $��16(�6�   6�   �� 5;      -	   5         ��Name$ AddToCart_Btn��5;   !   $��Add To Cart��68   $
��Left=�6N   $	��Top=�6i   $	��130��6�   $��35��6�   $��50,10,50,10q�6�   6�   5<      �� 5=      $��	55,20,0,0q�6!   .+�5>      �� $
��Left=�6$   $
��Wrap=�6?   $��Total Price��6S   $��Center=�6f   $��16(�6�   $	��115��6�   �� 5?      -
   5        $ TotalPrice_Txt��5?   "   $
��Left=�6:   $��35��6U   $
 Wrap=�6a   $	��Top=�6u   $	��235��6�   $��16(�6�    . 6�   �� 5@      $
��Left=�6$   $
��Wrap=�6?   $��PPN 10%��6S   $��Center=�6b   $��16(�6}   $	��115��6�   �� 5A      -   5        $ PPN_Txt��5A   "   $
��Left=�63   $��35��6N   $
 Wrap=�6Z   $	��Top=�6n   $	��235��6�   $��16(�6�    . 6�   �� 5B      $
��Left=�6$   $
��Wrap=�6?   $��Payment��6S   $��Center=�6b   $��16(�6}   $	��115��6�   �� 5C      -   5        $ Payment_Txt��5C   "   $
��Left=�67   $��35��6R   $
 Wrap=�6^   $	��Top=�6r   $	��235��6�   $��16(�6�   6�   �� 5D      $
��Left=�6$   $
��Wrap=�6?   $��Return Payment��6S   $��Center=�6i   $��16(�6�   $	��115��6�   �� 5E      -   5        $ ReturnPayment_Txt��5E   "   $
��Left=�6=   $��35��6X   $
 Wrap=�6d   $	��Top=�6x   $	��235��6�   $��16(�6�    . 6�   �� 5F      -   5        $ PayCart_Btn��5F   !   $	��Pay��66   $
��Left=�6D   $	��Top=�6_   $	��130��6w   $��35��6�   $��50,10,50,10q�6�   ���#10BD446�   5G      5H      5I      5J      5K      5L      