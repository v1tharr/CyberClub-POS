   M S B A M L   `   `   `  ���� H  DCyberClub_POS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CyberClub_POS.ViewCyberClub_POS.View  )    #CyberClub_POS.View.ManageProductAdd   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:CyberClub_POS.View     -     � WindowStyle$
  None=� � WindowStartupLocation$ CenterScreen=� � AllowsTransparency . 
������  � Title$= 7Добавление продуктов на склад��$	��298��$	��432��.���� $��2q� J� Opacity$
 0.95Q�����  �� 
StartPoint$	 0,0&� �� EndPoint$	 1,1&�.���  � Color$ #462AD8�� � Offset$ 0Q�� $ #DA34AE��$
 0.75Q�� $ #8A16C1��$ 1Q����� $	 0,1&�$	 1,0&�.��� $ #060531��$ 0Q�� $ #1B1448��$ 1Q�._�� ���#23262B.+��� -   	 ��Name$	 Close_ProductAddition_btn��   CloseBtnStyle#��[  $��0,0,10,0q�$��30���� -   $"	 Minimize_ProductAddition_btn��  MinBtnStyle#��[ $��	0,-4,50,0q�
 J� RenderTransformOrigin$
 -0.429,0.493&�$��38��$��36���� $&�� Введите название:��$��13(�$
��Bold"�$��/Fonts/#Roboto Light)�
�������$��21,70,251,198q��� $(��"Укажите категорию:��$��13(�$
��Bold"�$��/Fonts/#Roboto Light)�
�������$��21,115,251,157q��� $��Укажите цену:��$��13(�$
��Bold"�$��/Fonts/#Roboto Light)�
�������$��21,152,268,124q��� $*��$Укажите количество:��$��13(�$
��Bold"�$��/Fonts/#Roboto Light)�
�������$��21,189,251,85q��� -   $��AddPName_TB��$
��Left=�
���   �$��
162,68,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��246���� -   $��AddCategory_TB��$
��Left=�
���   �$��162,109,0,0q�$
 Wrap=�$	��Top=�$	��246���� -   $��AddPrice_TB��$
��Left=�
���   �$��162,147,0,0q�$
 Wrap=�$	��Top=�$	��246���� -   $��AddQuantity_TB��$
��Left=�
���   �$��162,185,0,0q�$
 Wrap=�$	��Top=�$	��246���� -   $��Добавить��$��	0,248,0,0q�$	��Top=�$	��164��