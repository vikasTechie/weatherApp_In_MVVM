   M S B A M L   `   `   `  ����D  @WetherAPp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WetherAPp.ViewWetherAPp.View  5   	   9!clr-namespace:WetherAPp.ViewModelWetherAPp.ViewModel  5   	   &     WetherAPp.View.WeatherMainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WetherAPp.View     5   	   0vm!clr-namespace:WetherAPp.ViewModel     5   	     � Title$  WeatherMainWindow��5	   	   $	��450��6#   $	��800��60    � 	Resources 5
      &    WetherAPp.ViewModel.accViewModel   vm��%   &	          5   
   6   5      .��5      �  � DataContext# [  6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��20q�6   .+�5      �� $��
Enter City��6   �� 5      ��6   �� *Query+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5      $
��0,10q�6   $��Search��5      ��6&   �� *cmd+�� 5      ��6   �� *Cities+ �� SelectedValue 66   �� *SelectedCity+��5      �� 5      .R�5      � .+�5      �� ��6(   �� *LocalizedName+5      5      5      5       � 5!   
   $��1��6   ���#4392f1 5"   $   �� *
CurrCond+ � ColumnDefinitions 5#      �� 5$      $��* �6#   �� 5%      $
��Auto �6#   .+�5'      �� $
��0,10q�6   .+�5(      �� # [  6   ���#f4f4f8$��20(�5*      $
��20,0q�5+      ��5(   >   �� *SelectedCity.LocalizedName+5+      �� 5,      ���#f4f4f8$��18(�5.      $
��20,0q�5/      ��5,      �� *WeatherText+5/      50      �� 51      $��1��6   $��Center=�52      ���#f4f4f8$��30(�55      $
��20,0q�56      ��53      �� *Temperature.Metric.Value+56      57      58      59      