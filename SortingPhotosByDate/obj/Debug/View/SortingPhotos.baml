   M S B A M L   `   `   `  ����N  JSortingPhotosByDate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:SortingPhotosByDate.ViewSortingPhotosByDate.View  5      E'clr-namespace:SortingPhotosByDate.ModelSortingPhotosByDate.Model  5      M+clr-namespace:SortingPhotosByDate.ViewModelSortingPhotosByDate.ViewModel  5      ,    &SortingPhotosByDate.View.SortingPhotos   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:SortingPhotosByDate.View     5      9model'clr-namespace:SortingPhotosByDate.Model     5      A	viewModel+clr-namespace:SortingPhotosByDate.ViewModel     5      $	��700��5
   #     � 	Resources  5      <  6SortingPhotosByDate.ViewModel.GetPathOfImagesViewModel   Path9   3SortingPhotosByDate.ViewModel.ArrangPhotosViewModel  Sorting��%:   &	        &	        5   
   6-     5   
   6*   5       � DataContext 5      .   (SortingPhotosByDate.Model.ImagePathModel  5   
   .��5      � $��	0,0,-25,0q�6    J� RenderTransformOrigin$ 0.448,0.813&�6   .+�5   
   �� $$��Auto arrange Photos and Videos��6   $��30(�69   $
��Bold"�6G   $
��Left=�6Y   $��
115,10,0,0q�6t   $	��Top=�6�   $	��470��6�   �� 5   
   $��Browes��61   $
��Left=�6�   $��
600,95,0,0q�6�   $	��Top=�6�   $��90��6�   $ 	2.709,0.5&�6�   {�6   �� *	IsEnabled+��6B   �� *LocationOfImages+ �� Source# [  ��6�   �� 6�   �� 5   
   $��Browes��61   $
��Left=�6�   $��600,130,0,0q�6�   $	��Top=�6�   $��90��6�   $ 1.4,0.75&�6�   {�6   �� *	IsEnabled+��6B   �� *NewLocationOfImages+# [  ��6�   �� 6�   �� 5   
    �� 
IsReadOnly . $
��Left=�6$   $��20��6?   $��	10,95,0,0q�6K    �� TextWrapping$
 Wrap=�6^   $	��Top=�6�   $	��575��6�   ��6r   �� *PathOfImages+6�   �� 5   
    . $
��Left=�6$   $��20��6?   $��
10,130,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $	��575��6�   ��6s   �� *	NewPath+6�   �� 5   
   -   5         ��Name$ listView��5      $��10,200,35,105q�6I   ��6%   �� *NewLocation+6I   �� 5   
   $��Start To Arrang��61   $
��Left=�6�   $��255,165,0,0q�6�   $	��Top=�6�   $	��175��6�   $ 0.5,0.5&�6�   {�6   �� *	IsEnabled+��6K   �� *ArrangCommand+# [ ��6�   �� 6�   � 5   
   -   5        $��progBar��5       � Minimum$ 0Q�6%   $��10,596,35,50q�6r   
������� � Maximum 61   �� *ProgBarLength+	 � Value	 6S   �� *ProgBarValue+6�   �� 5   
   $��18(�6   $��240,596,140,50q�6�   ��6"   �� 
 �� ElementName$
 progBar�� �� Path$ Value� �� StringFormat$# Number of images arranged {0}��6�   5       5!      