   M S B A M L   `   `   `  ����  WpfApplication1'    !WpfApplication1.WinWpfDataBinding   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  WinWpfDataBinding��5   	   $	��324��6#   $	��400��60   .��5      � $	��216��6    � RowDefinitions 5   
   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��28 �6    � ColumnDefinitions 5   
   �� 5      $	��122 �6   �� 5      $	��122 �6   �� 5      $	��137 �6   .+�5   
   �� -   5        $��L1��5      $��0��6   $��0��6'   $��One Time��67   $
��Bold"�6J   �� 5   
   -   5        $��L2��5      $��1��6   $��0��6'   $��One Way��67   $
��Bold"�6I   �� 5   
   -   5        $��L3��5      $��2��6   $��0��6'   $��Two way��67   $
��Bold"�6I   �� 5   
   -   5        $��L4��5      $��3��6   $��0��6'   $��One Way To Source��67   $
��Bold"�6S   �� 5   
   -   5        $��T1��5      $��0��6   $��1��6)   $��One Time��69   �� 5   
   -   5        $��T2��5      $��1��6   $��1��6)   $��One Way��69   �� 5   
   -   5        $��T3��5      $��2��6   $��1��6)   $��Two way��69   �� 5   
   -   5        $��T4��5      $��3��6   $��1��6)   $��One Way To Source��69   �� 5   
   $��2��6   $��0��6"   $��3q�6/   ��6:   ��  �� ElementName$ T1�� �� Path$
 Text� �� Mode$ OneTime=� �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��2��6   $��1��6"   $��3q�6/   ��6:   �� $ T2��$
 Text�$ OneWay=�$ PropertyChanged=��� 5   
   $��2��6   $��2��6"   $��3q�6/   ��6:   �� $ T3��$
 Text�$ TwoWay=�$ PropertyChanged=��� 5   
   $��2��6   $��3��6"   $��3q�6/   ��6:   �� $ T4��$
 Text�$ OneWayToSource=�$ PropertyChanged=�5      5!      