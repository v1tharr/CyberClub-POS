   M S B A M L   `   `   `  ���� H  DCyberClub_POS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:CyberClub_POSCyberClub_POS  A%clr-namespace:CyberClub_POS.ViewModelCyberClub_POS.ViewModel  7 clr-namespace:CyberClub_POS.ViewCyberClub_POS.View  #    CyberClub_POS.View.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:CyberClub_POS     4vm%clr-namespace:CyberClub_POS.ViewModel     /vn clr-namespace:CyberClub_POS.View     S OHandyControl, Version=3.5.1.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  -     � Title$  Главное меню��$	��850��$
��1400�� � WindowStyle$
 None=� � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=� � DataContext +  %CyberClub_POS.ViewModel.MainViewModel  .��� ���#23262B.+� � -     �Name$ 	MainFrame��
������ $��0q�$��	235,0,0,0q�  � NavigationUIVisibility$ Hidden=����� *	StartPage+�� $!��C Y B E R   C L U B   P O S�����#525965$��Fonts/#Orbitron Medium)�$��10(�$��Bottom=�$��Right=�$��	0,0,15,10q��� ���#D61734$��15�� �� CornerRadius$ 3,0,0,3��$��5��$��Bottom=�$��Right=�$��0,0,0,8q��� ���#2E333A$	��230�� �� Orientation$ Vertical=�$
��Left=�.+�� $��50��$	��Top=�$��0,30,0,0q�.+��� ���#D61734$��25��$ 3,0,0,3��$��6��$��Center=�$��Right=��� $!��C Y B E R   C L U B   P O S�����#FFFFFF$��Fonts/#Orbitron Medium)�$��15(�$��Center=�$��Center=�o� $	��450��
������ $��0,40,0,0q����� .R�$� 	 $� Orientation$	 Vertical=�.@�m� $��Главная��   Menu_Template#��[  
 m� Command
 �� *OpenGrlPage+ m� Icon �� $��Assets/img_home.png��$
��None=�m� $	��POS��  Menu_SubMenu_Template#��[  �� $��Assets/img_pos.png��$
��None=�.@�m� $��Продажи��  Item_Template#��[ 
 �� *OpenSalesPage+ �� $��Assets/img_sales.png��$
��None=�m� $��
Счета��#��[ 
 �� *OpenAccountsPage+ �� $��Assets/img_accounts.png��$
��None=�m� $��
Склад��#��[ 
 �� *OpenStoragePage+ �� $��Assets/img_storage.png��$
��None=�m� $��Отчеты��#��[  
 �� *OpenReportsPage+ �� $��Assets/img_report.png��$
��None=�m� $��Настройки��#��[  
 �� *OpenSettingsPage+ �� $��Assets/img_setting.png��$
��None=�m� -   $��
Выйти��#��[   �� $��Assets/img_exit.png��$
��None=��� -    ��Name$ btnMinimize��  MinBtnStyle#��[ $��
0,22,100,0q� J� RenderTransformOrigin$ -0.429,0.493&�$��32��$��32���� -   $ MaxBtn��  MaxBtnStyle#��[ �� -   $ CloseBtn��  CloseBtnStyle#��[ 