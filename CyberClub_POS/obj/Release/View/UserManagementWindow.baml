   M S B A M L   `   `   `  ���� H  DCyberClub_POS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CyberClub_POS.ViewCyberClub_POS.View  -    'CyberClub_POS.View.UserManagementWindow   S OHandyControl, Version=3.5.1.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:CyberClub_POS.View     -     � Title$5  /Добавление пользователей��$	��298��$	��432�� � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=� � AllowsTransparency . 
������ .���� $��2q� J� Opacity$
 0.95Q�����  �� 
StartPoint$	 0,0&� �� EndPoint$	 1,1&�.���  � Color$ #462AD8�� � Offset$ 0Q�� $ #DA34AE��$
 0.75Q�� $ #8A16C1��$ 1Q����� $	 0,1&�$	 1,0&�.��� $ #060531��$ 0Q�� $ #1B1448��$ 1Q�._�� ���#23262B.+��� -   	 ��Name$	 Close_UM_Btn��   CloseBtnStyle#��[  $��0,4,10,0q�$��30���� -   $	 Minimize_UM_Btn��  MinBtnStyle#��[ $��0,0,50,0q�
 J� RenderTransformOrigin$
 -0.429,0.493&�$��38��$��36���� $��Укажите ФИО:��$��13(�$
��Bold"�$��/Fonts/#Roboto Light)�
�������$��21,70,251,198q��� $ ��Укажите номер:��$��13(�$
��Bold"�$��/Fonts/#Roboto Light)�
�������$��21,115,251,157q��� $/��)Укажите дату рождения:��$��13(�$
��Bold"�$��/Fonts/#Roboto Light)�
�������$��21,155,240,119q�$
 0.484,-0.261&��� -   $��AddFName_TB��$
��Left=�
���   �$��
132,68,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��276���� -   $��AddPhoneNum_TB��$
��Left=�
���   �$��132,109,0,0q�$
 Wrap=�$	��Top=�$	��276��&   HandyControl.Controls.DatePicker  -   $��AddBdate��$��178,151,20,115q��� -   $��Добавить��$��	0,216,0,0q�$	��Top=�$	��164��