   M S B A M L   `   `   `  ����B  >Wpf_7_8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Wpf_7_8.ServicesWpf_7_8.Services  5   	   !    Wpf_7_8.Services.CreateTask   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Wpf_7_8.Services     5   	     � Title$  
CreateTask��5   	   $��432.266��6   $	��743��6-    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$	 New��5      5      .��5      � $	��747��6   $��0,0,0,-9q�6    J� RenderTransformOrigin$ 0.503,0.545&�6)   $
��Left=�6M   .+�5   
   (  "System.Windows.Controls.DatePicker  -   5        $��EndDate��5      $
��Left=�6$   $��382,67,244,297q�6?   $	��Top=�6W   $	��120��6p   6|   �� 5   
   -   5         ��Name$ Priority��5      $
��Left=�6%   $��382,123,0,0q�6@   $	��Top=�6U   $	��120��6m   6y   �� 5   
   -   5        $ Category��5      $
��Left=�6&   $��383,171,0,0q�6A   $	��Top=�6V   $	��120��6n   6z   �� 5   
   -   5         ��Name$
 Name��5      $
��Left=�6    $��24��6;   $��383,221,0,0q�6G    �� TextWrapping$
 Wrap=�6\   $�� ��6p   $	��Top=�6x   $	��120��6�   6�   �� 5   
   -   5        $ Description��5      $
��Left=�6'   $��23��6B   $��383,274,0,0q�6N   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��120��6�   6�   �� 5   
   $!��Дата окончания��6   $
��Left=�6)   $��
223,73,0,0q�6D   $	��Top=�6X   �� 5   
   $��Приоритет��6   $
��Left=�6$   $��223,123,0,0q�6?   $	��Top=�6T   �� 5   
   $��Категория��6   $
��Left=�6$   $��228,175,0,0q�6?   $	��Top=�6T   �� 5   
   $��Имя Задачи��6   $
��Left=�6%   $��227,227,0,0q�6@   $	��Top=�6U   �� 5   
   $��Описание��6   $
��Left=�6#   $��228,274,0,0q�6>   $	��Top=�6S   �� 5    
   -   5         ��Name$ button1��5       $��Добавить��6"   $	��New��65   $ 1.117,-0.004&�6D   $��223,329,244,38q�6i   5!      5"      