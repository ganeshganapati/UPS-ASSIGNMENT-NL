   M S B A M L   `   `   `  ����M  IEmployeeManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:EmployeeManagement.ViewsEmployeeManagement.Views  5      F BDomainModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullL5clr-namespace:DomainModel.Models;assembly=DomainModelDomainModel.Models 5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      +    %EmployeeManagement.Views.RegisterView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:EmployeeManagement.Views     5      Hlocal15clr-namespace:DomainModel.Models;assembly=DomainModel     5      6sys&clr-namespace:System;assembly=mscorlib     5        � 	Resources  5         GenderLists S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName  StatusLists   BooleanToVisibilityConverter��%  &	        &	 o     &	 �     S� 5   
   $ 	GetValues��61   "  6H    5      M� 5      $ local1:gender��6   64   5      S� 5   
   $ 	GetValues��61   "  6H    5      M� 5      $ local1:status��6   64   5      �� 5   
   6'   5      .��5      �� $��10q�6    �� Padding$ 30q�6   $��Center=�5   	   $��Center=�5   	   
�������  BrushPrimary2#��[ 5   	   $��0q�5   	    �� CornerRadius$ 1��5    	    J� Effect 5!   
   3  -System.Windows.Media.Effects.DropShadowEffect  5"         
BlurRadius$ 0Q�6   	   Color$	 White��6.   ._�5$   
   � 
 � IsSharedSizeScope
 .  � ColumnDefinitions 5%      �� 5&      $
��301* �6#   �� 5'      $	��62* �6#    � RowDefinitions 5)      �� 5*      $
��auto �6    �� 5,      $
��auto �6    �� 5-      $
��auto �6    .+�56      � $��0,20,0.4,19.8q�6   $��2��6*    57      �� 58      $
��auto �6$   �� 59      $
��auto �6$   �� 5:      $
��auto �6$   �� 5;      $
��auto �6$   �� 5<      $
��auto �6$   �� 5=      $
��auto �6$   �� 5>      $
��auto �6$   .+�5L      � $��1��6   $
��0,10q�6$    5M      �� 5N       z� SharedSizeGroup$ Label��6+   �� 5O      $	��300 �6+   .+�5R      �� $��0��6    $��
Enter Name��60   �� 5S      $��1��6   $��20,0,0,0q�6.   ��5T      �� *name+ �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=�5Y      � 5\      $��2��6   $
��0,10q�6$    5]      �� 5^      $ Label��6+   �� 5_      $	��300 �6+   .+�5b      �� $��0��6    $��Enter Email��60   �� 5c      $��1��6   $��20,0,0,0q�6.   ��5d      �� *email+ . $ PropertyChanged=�5e      � 5g      $��3��6   $
��0,10q�6$    5h      �� 5i      $
��auto �6+   $ Label��68   �� 5j      $	��300 �6+   .+�5m      �� $��0��6    $��Gender��60   �� 5n      $��1��6   $��20,0,0,0q�6.    �� TextAlignment$ Right=�5o   q   ���	#FFF3F3F6$��0q�6�   {�.  ��6   �� *gender+ . $ PropertyChanged=�6�   �� 5q      $��right=�6   $��Center=�6;   $��1��5s   B   $��0,0,218,-0.4q�6R   $��64��6h   ��5r      ��  �� Source# [   �� SelectedItem 5s      �� *gender+ �� Mode$ TwoWay=�5t      5v      � 5x      $��4��6   $
��0,10q�6$    5y      �� 5z      $
��auto �6+   $ Label��68   �� 5{      $	��300 �6+   .+�5~      �� $��0��6    $��Status��60   �� 5      $��1��6   $��20,0,0,0q�6-   $ Right=�5�   q   ���	#FFF3F3F6$��0q�6�   {�.  ��6   �� *status+ . $ PropertyChanged=�6�   �� 5�      $��right=�6   $��Center=�6;   $��1��5�   B   $��0,0,218,-0.4q�6R   $��64��6h   ��5�      �� # [  5�      �� *status+$ TwoWay=�5�      5�      � 5�      $��5��6   $��0,41.4,-0.2,20.6q�6$   $��2��6>    5�      �� 5�      $
��auto �6+   $ Label��68   .+�5�      �� $��1��6    $��0,10,0,0q�6-   $��Center=�6?   
���  �� � DataContext 5�      �� *ErrorMessageViewModel+��5�   "   �� *	Message+y�5�      �� *
HasMessage+ �� 	Converter# [ �� 5�      $��2��6    $��0,10,0,0q�6-   $��Center=�6?   
��� d � 5�      �� *StatusMessageViewModel+��5�      �� *	Message+y�5�      �� *
HasMessage+# [ 5�      �� 5�      $��5��6   $	��0,5q�6&   $��Center=�5�      $��Register��5�       �� 	IsDefault . ��5�      �� *RegisterUserCommand+5�   (   �� 5�      $��7��6   $��208,10.2,207.6,15.4q�6)   $��Center=�5�      
���  ����5�      �� *	Message+5�      5�      5�      5�      