   M S B A M L   `   `   `  ���� H  DCyberClub_POS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CyberClub_POS.ViewCyberClub_POS.View  $    CyberClub_POS.View.StoragePage   S OHandyControl, Version=3.5.1.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     2local clr-namespace:CyberClub_POS.View       N� Title$  StoragePage��.��� ���#23262B$
��1241��$	��582��.+�&   System.Windows.Controls.DataGrid  -   $��	StorageDG��   AutoGenerateColumns .     SelectionMode$ Extended=�   CanUserResizeRows .     CanUserResizeColumns .    CanUserReorderColumns .  $��44,39,111,10q�   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   HeaderTemplate ��    CellTemplate �� .R��� 	 ��Name$	 	AllSelect��0  *System.Windows.Controls.DataGridTextColumn  -   Storage_ID_DG��
   Header$	
 №��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ 	ProductID�  -   Storage_PName_DG��$
 Название��$ *  �� $ ProductName�  -   Storage_Category_DG��$
 Категория��$ *  �� $ ProdCategory�  -   Storage_Price_DG��$
 Цена��$ *  �� $ Price�  -   Storage_AQ_DG��$
 Наличие��$ *  �� $ AvailableQuantity�  -   Storage_operation��$
 Действие��$ *  �� .R���  �� Orientation$ 
Horizontal=�.+���  ��Name$ EditRow_btn��-   $��30��$��15�� � Cursor$
 Hand������  �� 
TargetType" ��.���  �� Property � �� �� Value ��  �� 
TargetType" ��.R��� #��z��$��0q�._��� $��Center=�$��Center=���  � ��
 ���� ��  � ��
 ���� ��  � ��$ 0q���  �@�OverridesDefaultStyle . .���� $"��/Assets/img_storage_edit.png���� $ DeleteRow_btn��-	   $��30��$
 Hand��$��15������ " ��.���  � �� �� " ��.R��� #��z��$��0q�._��� $��Center=�$��Center=���  � ��
 ���� ��  � ��
 ���� ��  � ��$ 0q���  �@�OverridesDefaultStyle . .���� $$��/Assets/img_storage_delete.png���� $��Поиск:��$��16(�$
��Bold"�$��/Fonts/#Roboto Light)�
�������$��44,10,1136,548q�%  HandyControl.Controls.SearchBar  -
   $��SearchBar_Storage_DG��
���   �$
��Left=�$��	105,6,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��536���� -   $��Добавить��$��	646,6,0,0q�$	��Top=�$	��240��$
��Left=�$��28�� J� RenderTransformOrigin$ 0.495,0.643&��� -   $��Обновить��$��	891,6,0,0q�$	��Top=�$	��239��$
��Left=�$��28��$ 	0.446,0.5&�