   M S B A M L   `   `   `  ���� H  DCyberClub_POS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CyberClub_POS.ViewCyberClub_POS.View  #    CyberClub_POS.View.AuthWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:CyberClub_POS.View     -     � Title$  Авторизация��$	��450��$	��800�� � WindowStyle$
 None=� � AllowsTransparency . 
������  � WindowStartupLocation$ CenterScreen=�.����  �� CornerRadius$ 12�����#462AD8$��2q�����  �� ImageSource$T Npack://application:,,,/CyberClub_POS;component/Assets/background_auth_orig.jpg�� j� Stretch$
 None=� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 10Q�	   ShadowDepth$	 0Q�
   Opacity$	
 0.7Q� J� Clip ��  �� Rect$ 0,0,800,450� �� RadiusX$ 12Q� �� RadiusY$ 12Q�._�� ���#1B1448 J� Opacity$
 0.95Q� �� $ 12Q�$ 12Q�$ 0,0,800,450� � ColumnDefinitions �� $	��63* ��� $
��265* ��� $
��123* ��� $
��268* ��� $	��77* � � RowDefinitions �� $��30 ��� .+�� $��0��$��5��$��	0,0,0,405q�$��2�� �� �� $��25 ��� $��25 ��� $��5 �.+��� -    ��Name$ btnMinimize��$��0q�$��-��
�������$��16(�$��/Fonts/#Roboto Light)� � Cursor$
 Hand�� J� RenderTransformOrigin$ -1.096,0.421&�$��	715,0,0,0q�   MinBtnStyle#��[  $��34��$��42��$
��Left=�$��2��$��Center=��� -   $ btnClose��$��0q�$��X��
�������$��12(�$��/Fonts/#Roboto Light)�$
 Hand��  CloseBtnStyle#��[ $ 1.098,-0.43&�$��2��$��31��$��13,0,0,1q�$��32��$��1��$
��Left=�$��Center=��� $	��220��$��1�� �� Orientation$ Vertical=�$��225,35,211,0q�$��3��$��1��.+��� $K��Epack://application:,,,/CyberClub_POS;component/Assets/cyberx_logo.png��$	��100��$	��100���� $��C Y B E R  C L U B  POS��
�������$��17(�$��0,7,0,-5q�$��Medium"�$��/Fonts/#Orbitron Medium)�$��26��$	��221���� $`��ZПожалуйста, авторизуйтесь для дальнейшей работы!��
�������$��12(�$��
0,12,0,-20q�$��Medium"�$��/Fonts/#Roboto Light)�$
��Wrap=� �� TextAlignment$ Center=�$ 0.495,3.266&�$��31���� $��
Логин��
�������$��12(�$��Medium"�$��/Fonts/#Roboto Light)�$��0,35,0,0q��� -    ��Name$ txtUser��$��13(�$��Medium"�$��/Fonts/#Roboto Light)�
������� �� 
CaretBrush
 �����
�������$��0,0,0,2q�$��28��$��Center=�$��0,5,0,0q�$��20,0,0,0q�.������ $ /Assets/img_user_auth.png��$
 None=� j� 
AlignmentX$
 Left=�.���� $��Пароль��
�������$��12(�$��Medium"�$��/Fonts/#Roboto Light)�$��0,15,0,0q�G� -    G�Name$ txtPass��$��13(�$��Medium"�$��/Fonts/#Roboto Light)�
������� G� 
CaretBrush
 �����
�������$��0,0,0,2q�$��28��$��Center=�$��0,5,0,0q�$��20,0,0,0q����� $ /Assets/key-icon.png��$
 None=�$
 Left=��� $ 
Horizontal=�$��Center=�$��0,15,0,0q��� -   $ btnLogin��$��0q�$��
ВОЙТИ��
�������$��12(�$��/Fonts/#Roboto Light)�$
 Hand������  �� 
TargetType" ��.���  �� Property � �� �� Value �#462AD8 �� Triggers P�   P� Property  �@J�IsMouseOver! P� Value! . . ���  � �� �#28AEED���� " �� 
TargetType"" ��.R��� $	��150��$��40��$ 20��#��z��._��� $��Center=�$��Center=�