   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Library.PagesLibrary.Pages  5      "    Library.Pages.SearchItemPage   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Library.Pages     5        N� Title$  SearchItemPage��5	      .��5      �� .+�5   
   �� -   5         ��Name$ 
searchText��5      $	��422��6&   $y�Visible=�62    �� Left$ 33��6G   
 �� Top$ 32��6X   �� 5   
   $	 136��6   $��Enter Item To Search:��6&   $
��Wrap=�6C   $	��216��6W   $
��Bold"�6c    �� TextAlignment$ Center=�6u   $��20(�6�   �� 5   
   -   5         ��Name$ searchButton��5      $��Search��6'   $ 33��68   $ 55��6I   $	��422��6Y   $
��Bold"�6e   $��Normal$�6w   6�   �� 5   
   -   5         ��Name$ bookList��5       �� SelectionMode$ Extended=�6%   $	��205��6>   $	��468��6K   $ 10��6W   $ 80��6h   ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $��/assets/images/Book.png��6    $	��100��6A   $	��100��6M   �� 5      $ Vertical=�6%   .+�5      �� $��16(�6>   $
��Bold"�6L   ��6(   �� *Name+6L   �� 5      $��13(�6?   ��6(   �� *Genre+6?   �� 5      $��10(�6A   ��6(   �� *	Company+6A   �� 5      $��8(�6C   ��6(   �� *	PrintDate+6C   �� 5      $��Price:��6(   $��10(�66   �� 5      $��9(�6P   ��6(   �� *Price+	 �� StringFormat$	 N2��6P   �� 5      $��
Available:��6(   $��11(�6:   �� 5      $��10(�6E   ��6(   �� *IsAvailable+6E   �� 5      $ 
removeItem��6%   -   5        $��Remove��5   9   6J   �� 5      $ editItem��6%   -   5        $
��Edit��5   7   6F   �� 5      $ rentItem��6%   -   5        $
��Rent��5   7   6F   5       5!      5"      5$       � 5%   
   -   5        
  �Name$
 	frameView��5%      $	��285��6#   $	��468��60   $ 10��6<   
���   �$y�	Collapsed=�6`   5&      5'      