   M S B A M L   `   `   `  ????P  LTiffin Business Final, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Tiffin_Business_FinalTiffin_Business_Final  5      $    Tiffin_Business_Final.HomePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:Tiffin_Business_Final     5      -   5          N? Title$  Page1??5	       N? 
Background
 ????? ? UseLayoutRounding . .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $	??250 ?6   ?? 5       ? RowDefinitions 5   
   ?? 5      $??30 ?6   ?? 5      $??* ?6   .+?5   
   ?? $??2??6   ???#1E90FF ?? CornerRadius$ 	0,150,0,0??67   ._?5      ?? .+?5      ??  ?? BitmapScalingMode$ HighQuality=?6   $??/Images/logo.png??5      ?? 5      -   5         ??Name$ UserName??5      $??Ubuntu)?6+   $??16(?5      $
??Bold"?6&   $??51??5      $??Welcome Admin!??5      $??Center=?5      $??	0,-50,0,0q?5       ?? 5!      -   5         ??Name$ Dashboardbtn??5!      
?????? $??0q?5#      .??5$      ?? 	 ?? Orientation$	 
Horizontal=?6!   .+?5%      ?? $ HighQuality=?6    $??30??5&   $   $??\Images\DashboardIcon.png??6/   ?? 5'      $??	Dashboard??6$   $??28(?65   
???   ?
?????? 5*      5+      5,      ?? 5-      $??0,20,0,0q?6   
?????? $??0q?5/      .??50      ?? $	 
Horizontal=?6!   .+?51      ?? $ HighQuality=?6    $??30??52   !   $??\Images\PrintingIcon.png??6,   ?? 53      $??Billing??6$   $??28(?63   
???   ?
?????? 56      57      58      ?? 5;      -   5        $ LogoutButton??5<      $??Right=?5=      $??	0,330,5,0q?5>      
?????? 
?????? $??0q?5A      .??5B      ?? $	 
Horizontal=?6!   .+?5C      ?? $ HighQuality=?6    $??25??6N   $??\Images\LogoutIcon.png??6Y   ?? 5D      $??Logout??6$   $??20(?62   
???   ?
?????? 5G      5H      5I      5K      5L      &   System.Windows.Controls.DataGrid  5M   
   -   5        
  Name$
 DashBoardDataGrid1??5Q         DataGridCellStyle1   	CellStyle# ?   5N       ?? AlternationCount$ 2??6>      AlternatingRowBackground ?#94CAFF  DataGridRowStyle1   RowStyle# ?  5P        DataGridColumnHeaderStyle1   ColumnHeaderStyle# ?  6F   $??10,76,10,106q?6?      AutoGenerateColumns .  $??1??5R   3   $??1??6C      Columns 5S      0  *System.Windows.Controls.DataGridTextColumn  5T      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name??6>      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ?? *name+6L     5U      $ Phone Number??6F   $	 125 6\    6%   ?? *phone_number+6\     5V      $ Email ID??6B   $	 150 6T    6%   ?? *
Email_ID+6T     5W      $ Vegetarian???6A   $ 95 6V    6%   ?? *	non_veg+6V     5X      $ Roti? ??6>   $ 80 6N    6%   ?? *roti+6N     5Y      $ 	RiceType ??6C   $ 75 6V    6%   ?? *	rice_type+6V     5Z      $ Address??6A   $ * 6R    6%   ?? *	address+   ElementStyle 5[      ?? 5\      .?5]      ??  ?? Property ? ?? ?? Value$
 Wrap=?6G   5^      5`        5a      $ Addition Information??6I   $ * 6g    6%   ?? *additional_info+ 5b      ?? 5c      .?5d      ??  ? ??$
 Wrap=?6G   5e      5g      5i      5j      5k      