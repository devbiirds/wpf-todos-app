   M S B A M L   `   `   `  ����B  >Wpf_7_8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Wpf_7_8Wpf_7_8  5   	   3clr-namespace:Wpf_7_8.ServicesWpf_7_8.Services  5   	       Wpf_7_8.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   )controlclr-namespace:Wpf_7_8     5   	   0localclr-namespace:Wpf_7_8.Services     5   	   -   5          � Title$#  Планировщик дел��5   	   $	��450��6!   $
��1000��6.      WindowStyle#���   6R    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5	   
   -   5           Command$  local:WindowCommands.Reset��5	      6>     5
   
   -   5        $! local:WindowCommands.Search��5
      6?    � 	Resources 5       �� 
TargetType  
VisibleBtn �� Triggers �� Binding �� ElementName �� Path	 �� Value
 �� Property �� Value  ChangeColor ]� 
Conditions �� Property �� Value  EventChanging :� RoutedEvent g� Duration �� TargetProperty	 W� To �� 
TargetType  
btTemplate �� CornerRadius  AddTask��%�  &	       &	 �     &	 �    &	 �    �� 5   
   " ��6    5      �� 5       6   �� $ SearchInput��$
 Text�	  5      .a�5      �� 
 � y�$ 	Collapsed=�63   5      5      �� 5   
   " m�6    5      ]� 5       5      �� 5       �@J�IsMouseOver . 6;   �� 5       �@m�	IsPressed . 69   /�5      �� 5      
 � ��$ 16(�65   5      5!      �� 5"   
   " m�6    5$      :� 5%      $ Click��6   [�5&      �� 5'      .��5(      �� .��5)   "   W� $ 0:0:0.2D�62   $ FontSize�5*   2   $ 22X�5+   2   5,   #   W� 5-   "   $ 0:0:0.3D�62   $ FontSize�5.   2   $ 14X�5/   2   50   #   51      52      54      56      �� 57   
   " m�6   .R�58      �� $ 10��6   
�����_�$��2q�6?   
����ح�$��30��59   ,   $	��120��68   ._�5:      �� $��5q�6!   $��Center=�6,   $��Center=�6I   #���  6d   5;      5<      5=      .��5?      � .+�5@   
   o� $��0,10,0,0q�6%   ��6   Z� .@�5A      m� -   5         m�Name$
 Task��5A      #��[ 68   #��[ 6]   m� 5D      -   5        $ 
DeleteTask��5D       
 Delete#���  6@   #��[ 6b   m� 5E      -   5        $ menuLanguage��5E        Language#���  6-   #��[ 6Q   m� 5F       
 Filter#���  6   #��[ 69   .@�5G      m�  	 
byCategory#��� 	 6   .@�5H      m� -   5         
 Work#��� 
 5H      6c   m� 5I      -   5          Home#���  5I      6c   m� 5J      -	   5         	 Study#���  5J      6d   m� 5K      -
   5          Personal#���  5K      6g   5L      m� 5M        
byPriotity#���  6   .@�5N      m� -   5         
 Lowest#���  5N      6e   m� 5O      -   5         
 Normal#���  5O      6e   m� 5P      -   5          Highest#���  5P      6f   5Q      5R      m� 5S      -   5        $ Reset��5S       m� Command$  local:WindowCommands.Reset��6&    	 Reset#���  6L   #��[ 6m   m� 5T       
 Window#���  6   .@�5U      �� .+�5V      �� -   5         ��Name$ styleBox��5V      5Y      5Z      m� 5]      $ ApplicationCommands.Redo��6   m� 5^      $ ApplicationCommands.Undo��6   c� 5_      
�������.@�5`      c� $��25��6   $	��Top=�6&   .@�5b      �� -   5         ��Name$ SearchInput��5b      $	��100��64   5c      c� 5d      .@�5e      �� $!��local:WindowCommands.Search��6   #��[ 6C   .��5f      ��  �� Orientation$ 
Horizontal=�6%   .+�5g      A� $��10��6&   $��10��61   
���   �6=   �� 5h      $��Right=�6(   $��60��6D   $��5 0 0 0q�6O   �� 6a   $�
Найти��6e   6u   5i      5j      5k      5l      5n      �� 5o   
   .+�5p         Wpf_7_8.CustomControlWPF  -   5          Name$ customControl��5p   '      Wpf_7_8.CustomControlWPF   Click$ customControl_Click��6Y   $��	Show Info��6A   $��
695,0,71,0q�6w   �� 5q      -   5         ��Name$ txtBlock��5q      $��
720,0,71,0q�6,   $��20��6@   5r      &   System.Windows.Controls.DataGrid  5s   
   -   5          Name$ toDoL��5s      $��0,50,0,0q�6"      AutoGenerateColumns .  $��5��6P      Columns 5t      4  .System.Windows.Controls.DataGridCheckBoxColumn  5u      ,  &System.Windows.Controls.DataGridColumn    
IsReadOnly  .  -   5        
Status��!   Width5  /System.Windows.Controls.DataGridLengthConverter$
! Auto 5u   �   "   MinWidth$" 40Q�6�   1  +System.Windows.Controls.DataGridBoundColumn#   Binding# 6)   �� $ Status�$ �� UpdateSourceTrigger$$ PropertyChanged=�%   Header% 5v      �� 5w        Done#���  6$   5y      0	  *System.Windows.Controls.DataGridTextColumn	  5z        . -   5        CreationDate��$
! Auto 5z   �   $	" 100Q�6�   # 6&   �� $ CreationDate�& �� StringFormat$& dd MMM yyyy��% 5{      �� 5|        CreationDate#���  6$   5~      4
  .System.Windows.Controls.DataGridTemplateColumn
  5        .  -   5        EndDate��% 5�      �� 5�        
FinishDate#���  6$   ' 
  CellTemplate' 5�      �� 5�      .R�5�      �� ��6(   �� $ EndDate�$& dd MMM yyyy��5�      ( 
  CellEditingTemplate( 5�      �� 5�      .R�5�      (  "System.Windows.Controls.DatePicker  $��
DatePicker��6)   )   SelectedDate) 6<   �� $ EndDate�5�      5�      4  .System.Windows.Controls.DataGridComboBoxColumn  5�      -   5        Priority��  .  *   SelectedValueBinding* 5�   ;   �� *
Priority++ �� Mode$+ TwoWay=�,   DisplayMemberPath, 5�      �� *
Priority+% 5�      �� 5�        Priority#���  6$   5�        5�      -   5        Category��  .  * 5�   O   �� *
Category+$+ TwoWay=�, 5�      �� *
Category+% 5�      �� 5�        Category#���  6$   5�      	  5�        .  -   5        NameTask��# 5�   %   �� $
 Name�% 5�      �� 5�        NameTask#���  6$   5�      	  5�        .  -   5        Description��$! * 5�   u   # 6%   �� $ Description�% 5�      �� 5�        Description#���  6$   5�      5�      5�      5�      