   M S B A M L   `   `   `  ���� N  JSortingPhotosByDate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:SortingPhotosByDate.ViewSortingPhotosByDate.View  E'clr-namespace:SortingPhotosByDate.ModelSortingPhotosByDate.Model  M+clr-namespace:SortingPhotosByDate.ViewModelSortingPhotosByDate.ViewModel  ,    &SortingPhotosByDate.View.SortingPhotos   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     8local&clr-namespace:SortingPhotosByDate.View     9model'clr-namespace:SortingPhotosByDate.Model     A	viewModel+clr-namespace:SortingPhotosByDate.ViewModel     $	��700��  � 	Resources  <  6SortingPhotosByDate.ViewModel.GetPathOfImagesViewModel   Path9   3SortingPhotosByDate.ViewModel.ArrangPhotosViewModel  Sorting��%   &	        &	           � DataContext .   (SortingPhotosByDate.Model.ImagePathModel  .��� $��	0,0,-25,0q� J� RenderTransformOrigin$ 0.448,0.813&�.+��� $$��Auto arrange Photos and Videos��$��30(�$
��Bold"�$
��Left=�$��
115,10,0,0q�$	��Top=�$	��470���� $��Browes��$
��Left=�$��
600,95,0,0q�$	��Top=�$��90��$ 	2.709,0.5&�{��� *	IsEnabled+���� *LocationOfImages+ �� Source# [  ���� �� $��Browes��$
��Left=�$��600,130,0,0q�$	��Top=�$��90��$ 1.4,0.75&�{��� *	IsEnabled+���� *NewLocationOfImages+# [  ���� ��  �� 
IsReadOnly . $
��Left=�$��20��$��	10,95,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��575������ *PathOfImages+��  . $
��Left=�$��20��$��
10,130,0,0q�$
 Wrap=�$	��Top=�$	��575������ *	NewPath+�� -    ��Name$ listView��$��10,200,35,105q����� *NewLocation+�� $��Start To Arrang��$
��Left=�$��255,165,0,0q�$	��Top=�$	��175��$ 0.5,0.5&�{��� *	IsEnabled+���� *ArrangCommand+# [ ���� � -   $��progBar�� � Minimum$ 0Q�$��10,596,35,50q�
������� � Maximum �� *ProgBarLength+	 � Value	 �� *ProgBarValue+�� $��18(�$��Center=�$��310,596,195,50q�$	��220������ 
 �� ElementName$
 progBar�� �� Path$ Value� �� StringFormat$ Quantity {0}��