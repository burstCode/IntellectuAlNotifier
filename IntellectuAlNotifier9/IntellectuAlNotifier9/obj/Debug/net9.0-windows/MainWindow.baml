   M S B A M L   `   `   `  ����P  LIntellectuAlNotifier9, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:IntellectuAlNotifierDesktopIntellectuAlNotifierDesktop  5   	   ,    &IntellectuAlNotifierDesktop.MainWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:IntellectuAlNotifierDesktop     5   	   -   5          �Name$  wdw_MainWindow��5   	    � Title$ 
MainWindow��5	   	   $	��450��6   $	��800��6)   $	��400��65    � WindowState$ 	Maximized=�5
   	    � WindowStyle$ SingleBorderWindow=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   $��5q�6.   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      CaptionHeight$ 32Q�6   %  System.Windows.SystemParameters"   WindowResizeBorderThickness   ResizeBorderThickness# Z 6*   ��5      *�5   
   
Ubuntu)�6   ��5      �� 5   
      UIBackground	 �� Color#	 [  6   ��5      #�5   
   Bold"�6   .��5      � .+�5   
   .   (IntellectuAlNotifierDesktop.ViewboxPanel  .+�5      ]� -   5        
 ]�Name$
 dk_SidePanel��5      $
��Left=�6.   .+�5      +   %IntellectuAlNotifierDesktop.SidePanel  -   5          Name$ 
sdpnl_Menu��5   "   3   -IntellectuAlNotifierDesktop.NotificationPanel  5      -   5          Name$ ntfpnl_NotificationPanel��5   *   $	��Top=�6L   ��6d   �� *Width+ �� ElementName$ dk_SidePanel��5      5      5       5!      