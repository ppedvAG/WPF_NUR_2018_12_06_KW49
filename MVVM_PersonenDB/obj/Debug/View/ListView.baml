   M S B A M L   `   `   `  ����J  FMVVM_PersonenDB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:MVVM_PersonenDB.ViewMVVM_PersonenDB.View  5   	   #    MVVM_PersonenDB.View.ListView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   .local"clr-namespace:MVVM_PersonenDB.View  5   	     � Title$  Personen Datenbank��5	   	   $��436.187��6$   $��486.906��65      sylWndGlobal#��[  5
   	    � 	Resources 5       �� 
TargetType �� Property �� Value��%x   '��       �� 5      " ��6   .�5   
   ��  � ��$	 100��6"   �� 5   
    � ��$	 5,0q�6#   5      5      .��5      ]� .+�5   
   o� $	��Top=�6   .@�5      m� $��Datei��6   .@�5      m� $��Beenden��6    m� Command 5      �� *SchließenCmd+5      m� 5      $��
Bearbeiten��6   .@�5      m� $��Neue Person einfügen��6    5      �� *NeuCmd+�� 5      m� 5      $��Ändere Person��6    5      �� *
ÄndernCmd+ m� CommandParameter 5      ��  �� ElementName$ dgdPersonen�� �� Path$ SelectedValue�m� 5      $��Lösche Person��6    5      �� *LöschenCmd+ 5       �� $ dgdPersonen��$ SelectedValue�5!      5"      � 5#   
   $��Bottom=�6   $��5,0,5,5q�6,   $��Right=�5$      .+�5%      �� -   5        	 ��Name$	 btnNeu��5%      $��Neue Person��6%   ��5&      �� *NeuCmd+�� 5'      -   5        $	 
btnÄndern��5'      $��Ändere Person��6(   ��5(      �� *
ÄndernCmd+��5)      �� $ dgdPersonen��$ SelectedValue��� 5*      -   5        $	 btnLöschen��5*      $��Lösche Person��6)   ��5+      �� *LöschenCmd+��5,      �� $ dgdPersonen��$ SelectedItem�5-      &   System.Windows.Controls.DataGrid  5.   
   -   5        
  Name$
 dgdPersonen��5.      $��5q�6(      AutoGenerateColumns .   J� IsManipulationEnabled .     
IsReadOnly . ��51      �� *PersonenListe+   Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$ Vorname��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6R   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *	Vorname+6R     54      $ Nachname��6%   $ * 6T    67   �� *
Nachname+6T     55      $ Geburtsdatum��6%   $
 Auto 6u    6;   �� *Geburtsdatum+ �� StringFormat$ 
dd.MM.yyyy��6u   4  .System.Windows.Controls.DataGridCheckBoxColumn  56      $ Verheiratet��6)   $
 Auto 6^    6>   �� *Verheiratet+6^     57      $ Lieblingsfarbe��6%   $
 Auto 6`    6=   �� *Lieblingsfarbe+6`     58      $ 
Geschlecht��6%   $
 Auto 6X    69   �� *
Geschlecht+6X   .  (System.Windows.Interactivity.Interaction   Triggers 5:      /  )System.Windows.Interactivity.EventTrigger  5;         	EventName$ MouseDoubleClick��6!   .	  (System.Windows.Interactivity.TriggerBase 	  Actions. 5<      6
  0System.Windows.Interactivity.InvokeCommandAction
   
  Command 6,   �� *
ÄndernCmd+ 
  CommandParameter 5=   ,   �� $ dgdPersonen��$ SelectedValue�5>      5@      5A      5B      