   M S B A M L   `   `   `  ����F  BValidierung, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ValidierungValidierung  5   	       Validierung.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Validierung     5   	     � Title$  
MainWindow��5   	   $��347.175��6   $��381.921��6-   .��5	      �� $��10q�6    � DataContext 5
   
      Validierung.Person  5       � 	Resources 5   
      ctpTbxError ��Name �� ElementName �� Path��%�   &	        �� 5      .R�5      �� .+�5      �� 
���  ��$��3q�63   ._�5      �� $	 aep��64   5      �� 5      
���  ����5       �� $	 aep��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�5      5      5      .+�5   
   �� -   5         ��Name$ 
tbxIpInput��5       =� ErrorTemplate# [  6&   .��6^   ��5      �� 5      $ tblIpOutput��6   $
 Text�64    �� UpdateSourceTrigger$ PropertyChanged=�6@   	 �� ValidationRules	 5         Validierung.IpValidierung  5      5       .��5!      5"      �� 5#   
   -   5        
 ��Name$
 tblIpOutput��5#      �� 5$   
   -   5        $
 tblErrorMessage��5$      ��6-   �� $ 
tbxIpInput��$) #(Validation.Errors)[0].ErrorContent��� 5&   
   $��5q�6   �� 5(   
   -   5        $ tbxName��5(      ��5)      �� *Name+$ PropertyChanged=� �� ValidatesOnExceptions . �� 5*   
   ��6   �� $ tbxName��$) #(Validation.Errors)[0].ErrorContent��� 5,   
   $��5q�6   �� 5.   
   -   5        $ tbxAlter��5.      ��5/      �� *Alter+$ PropertyChanged=� �� ValidatesOnDataErrors . .��6j    50      �� 51      .R�52      �� .+�53      ��  ��Name$ bdrAep��6G   
���  ��$��1q�63   ._�54      �� $	 aep��68   55      � 56      $
��Fade=�58        � PlacementTarget 56       �� $ bdrAep����57       �� $	 aep��$* $AdornedElement.IsKeyboardFocusWithin� �� Mode$ OneWay=�.��59      �� 
�������
���  ����5:   (   �� $	 aep��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�5;      5<      5=      .��5>   (   5?      �� 5@   
   ��6   �� $ tbxAlter��$) #(Validation.Errors)[0].ErrorContent��� 5A   
   $��Übernehmen��6   ��5B      �� 5C       �� 
TargetType" ��6   .�5D      ��  �� Property � {� �� Value .  62    �� Triggers 5E      ^� 5F      .0�5G      ��  � {� . 6:    ^� 
Conditions 5H      �� 5I   "    �� Binding 6,   �� $ 
tbxIpInput��$ (Validation.HasError)� �� Value	 False6s   �� 5J   "    6,   �� $ tbxName��$ (Validation.HasError)�	 False6p   �� 5K   "    6,   �� $ tbxAlter��$ (Validation.HasError)�	 False6q   5M      5O      5Q      5R      5S      