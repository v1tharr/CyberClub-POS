   M S B A M L   `   `   `  ���� H  DCyberClub_POS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CyberClub_POS.ViewCyberClub_POS.View  "    CyberClub_POS.View.SalesPage   _ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     2local clr-namespace:CyberClub_POS.View     S OHandyControl, Version=3.5.1.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol    N� Title$  	SalesPage�� � Cursor$  �� � 	Resources  �� 
TargetType �� Property �� Value��%,   '�       �� " �.���  � ��$ 0q�.��� ���#23262B#��[B�$
��1241��$	��582��.+��� -   $
 Hand��$��10,8,0,0q�$
��Left=�$��94��$	��Top=�$��93������ " ��.���  � �� ��  �� 
TargetType" ��.R��� #��z��$��0q�._��� $��Center=�$��Center=���  � ��
 ���� ��  � ��
 ���� ��  � ��$ 0q���  �@�OverridesDefaultStyle . .���� $��/Assets/img_newuser.png��$��81��$��86���� $��Корзина:��$��16(�$
��Bold"�$��/Fonts/#Roboto Light)�
�������$��19,102,978,457q�&   System.Windows.Controls.DataGrid  -     Name$ GoodsCard_DG��   AutoGenerateColumns .  	   SelectionMode$	 Extended=�
   CanUserResizeRows
 .     CanUserResizeColumns .    CanUserReorderColumns .  $��19,130,738,253q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$	 №��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ 	ProductID�  $ Название��$ *  �� $ ProductName�  $ Категория��$ *  �� $ ProdCategory�  $ Цена��$ *  �� $ Price�  $ Наличие��$ *  �� $ AvailableQuantity��� -   $��Оплатить��$��16(�$��0q�$
 Hand��
�������$��/Fonts/#Roboto Light)�$	��150��$��40��$��94,352,997,190q����� " ��.���  � �� �#462AD8 �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  � �� �#28AEED���� " ��.R��� $	��150��$��40�� �� CornerRadius$ 20��#��z��._��� $��Center=�$��Center=��� -   $��Очистить��$��16(�$��0q�$
 Hand��
�������$��/Fonts/#Roboto Light)�$	��150��$��40��$��308,352,783,190q����� " ��.���  � �� �#462AD8 P�  �@J�IsMouseOver . . ���  � �� �#28AEED���� " ��.R��� $	��150��$��40��$ 20��#��z��._��� $��Center=�$��Center=��� $��0��
�������$��531,35,354,120q�.@��� $��
Время��$��-2,-2,-69,0q�.���� .@�� .+�$  HandyControl.Controls.ComboBox  -   $��
CategoryCB��
����������#462AD8$��35��$��50,26,50,306q�  -   $��DaysCB��
����������#462AD8$��35��$��50,79,50,253q�  -   $��TimeCB��
����������#462AD8$��35��$��50,131,50,201q��� $��Еда��$��69,-3,-124,-1q�.��� $��10q�.+�  -   $��FoodSale�� .     $	 №��$ *  �� $ 	ProductID�  $ Название��$ *  �� $ ProductName�  $ Категория��$ *  �� $ ProdCategory�  $ Цена��$ *  �� $ Price�  $ Наличие��$ *  �� $ AvailableQuantity��� $��Напитки��$��123,-2,-170,-1q�.��� $��10q�.+�  -	   $��
DrinksSale�� .     $	 №��$ *  �� $ 	ProductID�  $ Название��$ *  �� $ ProductName�  $ Категория��$ *  �� $ ProdCategory�  $ Цена��$ *  �� $ Price�  $ Наличие��$ *  �� $ AvailableQuantity��� -
   $
 Hand��$��78��$��92��$
��Left=�$��
34,398,0,0q�$	��Top=����� " ��.���  � �� �� " ��.R��� #��z��$��0q�._��� $��Center=�$��Center=���  � ��
 ���� ��  � ��
 ���� ��  � ��$ 0q���  �@�OverridesDefaultStyle . .���� $��/Assets/img_sbp.png��$��60��$��67��  -   $��PaymentMethod_ComboBox��$
��Left=�$��123,423,0,0q�$	��Top=�$	��372��$��22��  -     Name$ UserSelect_ComboBox�� �� 
IsEditable . $
��Left=� �� IsTextSearchEnabled . $��
103,42,0,0q�$	��Top=�$	��392��