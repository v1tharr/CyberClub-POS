   M S B A M L   `   `   `  ���� H  DCyberClub_POS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CyberClub_POS.ViewCyberClub_POS.View  %    CyberClub_POS.View.SettingsPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     2local clr-namespace:CyberClub_POS.View     _ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  S OHandyControl, Version=3.5.1.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol    N� Title$  	AboutPage��.��� ���#23262B$
��1241��$	��582�� � ColumnDefinitions �� $
��245* ��� $
��997* �.+��� -   $ ��Редактировать��$��159,499,687,22q�$��16(�$	��150��$��0q� � Cursor$
 Hand��
�������$��/Fonts/#Roboto Light)�$��1������  �� 
TargetType" ��.���  �� Property � �� �� Value �#462AD8 �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  � �� �#28AEED���� 	 �� 
TargetType"	 ��.R��� $	��150��$��40��
 �� CornerRadius$
 20��#��z��._��� $��Center=�$��Center=��� 
�������$��24,43,125,88q�$��2��.@�� ���	#FFE5E5E5 � RowDefinitions �� $	��43* ��� $	��20* �.+�&   System.Windows.Controls.DataGrid  -     Name$ Settings_DG��   AutoGenerateColumns .     SelectionMode$ Extended=�   CanUserResizeRows .     CanUserResizeColumns .    CanUserReorderColumns .  $��2��   Columns 0  *System.Windows.Controls.DataGridTextColumn  -   Standart_ID_DG��,  &System.Windows.Controls.DataGridColumn   Header$ № Тарифа��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ PriceID�  -   Standart_Day_DG��$ День��$ *  �� $ DayID�  -   Standart_Tariff_DG��$ 
Тариф��$ *  �� $ PeriodID�  -   Standart_Price_DG��$ Цена��$ *  �� $ Price�	� -    	� 	GroupName$ 1��$��STANDART��
�������$
��Left=�$��
134,10,0,0q�$	��Top=�$��28��$��90��$��1��	� -   $ 1��$	��VIP��
�������$
��Left=�$��
247,10,0,0q�$	��Top=�$��28��$��62��$��1��	� -	   $ 1��$��STREAM��
�������$
��Left=�$��
314,10,0,0q�$	��Top=�$��28��$��90��$��1��	� -
   $ 1��$��TV��
�������$
��Left=�$��
404,10,0,0q�$	��Top=�$��28��$��90��$��1��	� -   $ 1��$��ВСЕ��
�������$
��Left=�$	��Top=�$��28��$��90��$��
467,10,0,0q�$��1���� -   $��Обновить��$��337,499,502,22q�$��16(�$��0q�$
 Hand��
�������$��/Fonts/#Roboto Light)�$��1������ " ��.���  � �� �#462AD8 P�  �@J�IsMouseOver . . ���  � �� �#28AEED���� "	 ��.R��� $	��150��$��40��$
 20��#��z��._��� $��Center=�$��Center=�