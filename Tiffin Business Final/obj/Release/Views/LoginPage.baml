   M S B A M L   `   `   `  ???? P  LTiffin Business Final, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Tiffin_Business_FinalTiffin_Business_Final  %    Tiffin_Business_Final.LoginPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     5local#clr-namespace:Tiffin_Business_Final       N? Title$  	LoginPage?? ? UseLayoutRounding .  N? 
Background
 ???? .??? .+???  ?? CornerRadius$ 50??$??5q?????  ?? BitmapScalingMode$ HighQuality=? ?? ImageSource$% /Images/BackgroundLoginPage.png??????  ?? 
StartPoint$	 0,0&? ?? EndPoint$	 1,1&?.???  ? Color$ #F0932B??	 ? Offset$	 0Q?? $ #FE0000??$		 0.8Q?? $ #37C453??$		 0.5Q?._?? 
 ? RowDefinitions
 ?? $??50 ??? $	??300 ??? $	??200 ??? $	??100 ? ? ColumnDefinitions ?? $	??100 ??? $	??450 ??? .+??? $??1??$??1?????	#90F0F0F0 ?? Orientation$ Vertical=?$??3??$??2??$??230,10,344,68q?.+??? $??Welcome Back!??$??34(?$??Center=?$??0??$??1??$??5q?$??Ubuntu)?$
??Bold"?
???   ??? $??\Images\Logo.png??$	??350??$	??344??$	??-30q?$ HighQuality=?? .+???  ?? Padding$ 0,9,0,0q?$??10,0,0,0q?$??	Username ??$??24(?$??Ubuntu)?$??39??
???   ??? -    ??Name$ username??$??Ubuntu)?$??18(?$	??298??$??33??
???   ?
???????$??0,0,0,2q?$??	20,10,0,0q?$
??Bold"?.?????? $ HighQuality=?$ \Images\user.png?? j? Stretch$ Uniform=? j? 
AlignmentX$
 Left=? ?? 	Transform ??  ?? ScaleX$	 0.6Q? ?? ScaleY$ 1Q?.??? .+??? $??	Password ??$??24(?$ 6,0,0,0q?$??Ubuntu)?$??32??
???   ?$??7,17,0,0q?G? -    G?Name$ password??$??Ubuntu)?$??18(?$	??296??$??32??
???   ?
???????$??0,0,0,2q?$??	20,10,0,0q?$??5q?$y?Visible=????? $ HighQuality=?$ \Images\key.png??$ Uniform=?$
 Left=? ?? $	 0.6Q?$ 1Q??? -    ??Name$ Eye_img?? ? ToolTip$ Show Password??$ HighQuality=?$??\Images\eye.png??$??41??$??30???? -    ??Name$ loginbtn??$??LOGIN??
???????$??32(? ? Cursor$
 Hand??$??SemiBold"?$	??154??$??64??????  ?? 
TargetType" ??.???  ?? Property ? ?? ?? Value ?#FF871D ?? Triggers P?  P? Property ?@J?IsMouseOver P? Value . . ???  ? ?? ?#30AC49????  ?? 
TargetType" ??.R??? $	??150??$??70??$ 15??#??z??$??	2,0,2,-22q?._??? $??Center=?$??Center=??? -   $ 
ChangePass??$??0,15,0,0q?$??Right=?
?????? $??0q?.???? $ 
Horizontal=?.+??? $ HighQuality=?$??15??$$??\Images\ChangePasswordIcon.png???? $??Change Password??$??15(?
???   ?
?????? ? -     ?Name$  progressbar??$??3??$??	0,79,0,-9q?$??3?????#FF871D???#729F2A! ? Orientation$! Vertical=?" ? IsIndeterminate" .  # ? Minimum$# 0Q?$ ? Maximum$	$ 100Q??? -   $ pwtxtbox??$
??Bold"?$??Ubuntu)?$??18(?$	??296??$??32??
???   ?
???????$??0,0,0,2q?$??1??$??2??$y?Hidden=?$??	20,10,0,0q?$??2??$??354,91,380,78q?.?????? $ \Images\key.png??$ Uniform=?$
 Left=?$ HighQuality=? ?? $	 0.6Q?$ 1Q?.???? -   $ EyeBlock_img??$ Hide Password??$ HighQuality=?$??\Images\eye-crossed.png??$??41??$??30??$y?Hidden=?$??2??$??205,88,345,72q?$??2??