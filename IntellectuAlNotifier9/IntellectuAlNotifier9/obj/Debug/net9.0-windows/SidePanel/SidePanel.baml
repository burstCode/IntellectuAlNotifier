   M S B A M L   `   `   `  ����P  LIntellectuAlNotifier9, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:IntellectuAlNotifierDesktopIntellectuAlNotifierDesktop  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      +    %IntellectuAlNotifierDesktop.SidePanel   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:IntellectuAlNotifierDesktop     5      9system&clr-namespace:System;assembly=mscorlib     5      $
��1080��5	      $	��749��6     � 	Resources  5
         btn_HideMenu_ContentHide  btn_HideMenu_ContentShow  tbk_PageHeader_NewNote  tbk_PageHeader_Calendar  tbk_PageHeader_AllNotes  tbk_PageHeader_Settings  tbk_PageHeader_Profile��%d  &	        &	      &	 6     &	 o     &	 �     &	 �     &	 �     ��5   
   ��6C   ��5   
   ��6C   ��5   
   %!НОВОЕ НАПОМИНАНИЕ��6J   ��5   
   КАЛЕНДАРЬ��6C   ��5   
   !ВСЕ НАПОМИНАНИЯ��6I   ��5   
   ПАРАМЕТРЫ��6C   ��5   
   ПРОФИЛЬ��6@   5      .��5      � -   5         �Name$	 grd��5      $��0,0,0,0q�6    � RowDefinitions 5   
   �� 5      $	��71* �6   �� 5      $��1009* �6   .+�5   
   � $��0��6   ��5      �� 5       �� ImageSource$ /SidePanel/TopElement.png��6    j� Stretch$
 Fill=�6E   .+�5       �� -   5         ��Name$ tbk_PageHeader��5       #��[ 5!      $��36(�6H   $��Right=�5"      $��Center=�64   $��
120,0,50,0q�6O   ��5#      �� 5$        	TEXTLight �� Color# [ 6&   5&      5'      � 5(   
   $��1��6   .+�5)      �� $%��/SidePanel/TopElementBorder.png��6   $	��Top=�6=   $
��Fill=�6U   $��45��6d   $��0,-5,0,0q�6p   $��Center=�6�   $	��749��6�   �� 5*      -   5         ��Name$ brdr_SideMenu��5*      $
��Left=�6,   $	��307��6G   $
��1010��6S   $��60,0,0,0q�6a   ��5+      �� 5,      $ /SidePanel/Panel.png��6!   $
 Fill=�6D   5.      �� 50      $
��Left=�6   $��79��60   $
��1010��6;   $��0,-1,0,0q�6I   ��51      �� 52      $ /SidePanel/LeftBorder.png��6!   $
 Fill=�6I   ._�54      �  55      �� 56      $	��23* �6(   �� 57      $	��59* �6(   �� 58      $	��59* �6(   �� 59      $	��59* �6(   �� 5:      $	��59* �6(   �� 5;      $
��692* �6(   �� 5<      $	��59* �6(   .+�5>      �� -   5         ��Name$ btn_NewNote��5>      $��45��62   $��45��6=   $��7,0,0,7q�6I   $
��Left=�6Z   $��Bottom=�6u   $��1��6�   $��Segoe MDL2 Assets)�5?      $	����68     UIBorderButtonStyle#��[ 5@      5A      �� 5B      -   5        $ btn_Calendar��5B      $��45��63   $��45��6>   $��7,0,0,7q�6J   $
��Left=�6[   $��Bottom=�6v   $��2��6�   $��Segoe MDL2 Assets)�5C      $	����68   #��[ 5D      5E      �� 5F      -   5        $ btn_AllNotes��5F      $��45��63   $��45��6>   $��7,0,0,7q�6J   $
��Left=�6[   $��Bottom=�6v   $��3��6�   $��Segoe MDL2 Assets)�5G      $	����68   #��[ 5H      5I      �� 5J      -   5        $ btn_Settings��5J      $��45��63   $��45��6>   $��7,0,0,7q�6J   $
��Left=�6[   $��Bottom=�6v   $��4��6�   $��Segoe MDL2 Assets)�5K      $	����68   #��[ 5L      5M      �� 5N      -   5        $ btn_HideMenu��5N      $��45��63   $��45��6>   $��7,0,0,7q�6J   $
��Left=�6[   $��Bottom=�6v   $��6��6�   $��Segoe MDL2 Assets)�5O      #��[  68   #��[ 5P      5Q      5R      5S      5T      5U      5V      