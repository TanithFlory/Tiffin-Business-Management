   M S B A M L   `   `   `  ???? P  LTiffin Business Final, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Tiffin_Business_FinalTiffin_Business_Final  $    Tiffin_Business_Final.HomePage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     5local#clr-namespace:Tiffin_Business_Final     -     N? Title$  Page1?? N? 
Background
 ????? ? UseLayoutRounding . .???  ? ColumnDefinitions ?? $	??250 ???  ? RowDefinitions ?? $??30 ??? $??* ?.+??? $??2?????#1E90FF ?? CornerRadius$ 	0,150,0,0??._??? .+???  ?? BitmapScalingMode$ HighQuality=?$??/Images/logo.png???? -    ??Name$ UserName??$??Ubuntu)?$??16(?$
??Bold"?$??51??$??Welcome Admin!??$??Center=?$??	0,-50,0,0q??? -    ??Name$ Dashboardbtn??	 ? ToolTip$ 	 Add Data Into The Database??
?????? $??0q?.???? 
 ?? Orientation$
 
Horizontal=?.+??? $ HighQuality=?$??30??$??\Images\DashboardIcon.png???? $??	Dashboard??$??28(?
???   ?
?????? ?? $??0,20,0,0q?
?????? $??0q?.???? $
 
Horizontal=?.+??? $ HighQuality=?$??30??$??\Images\PrintingIcon.png???? $??Billing??$??28(?
???   ?
?????? ?? -   $ LogoutButton??$	 Logout??$??Right=?$??	0,330,5,0q?
?????? 
?????? $??0q?.???? $
 
Horizontal=?.+??? $ HighQuality=?$??25??$??\Images\LogoutIcon.png???? $??Logout??$??20(?
???   ?
?????? ?? $??1??$??1??.+?&   System.Windows.Controls.DataGrid  -     Name$ DashBoardDataGrid1??   CanUserAddRows .     DataGridCellStyle1   	CellStyle# ?    ?? AlternationCount$ 2??   AlternatingRowBackground ?#94CAFF  DataGridRowStyle1   RowStyle# ?    DataGridColumnHeaderStyle1   ColumnHeaderStyle# ?  $??10,76,10,106q?   AutoGenerateColumns .  $	??496??   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$
 Name??   Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 1  +System.Windows.Controls.DataGridBoundColumn   Binding ?? *name+  $ Phone Number??$	 125  ?? *phone_number+  $ Email ID??$	 150  ?? *
Email_ID+  $ Vegetarian???$ 95  ?? *	non_veg+  $ Roti? ??$ 80  ?? *roti+  $ 	RiceType ??$ 75  ?? *	rice_type+  $ Address??$ *  ?? *	address+   ElementStyle ?? .???  ?? Property ? ?? ?? Value$
 Wrap=?  $ Addition Information??$ *  ?? *additional_info+ ?? .???  ? ??$
 Wrap=??? -   $ 	DeleteAll??$??
0,-100,0,0q?$??50??$%	 Clear Everything From Database.??  ButtonStylesT#??[ $	??187??.???? $
 
Horizontal=?.+??? $ HighQuality=?$??35??$??\Images\DeleteAll.png???? $??3,0,0,0q?$??30(?$??
Delete All??