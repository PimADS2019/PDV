   M S B A M L   `   `   `  ����G  CViewPimNoite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ViewPimNoite.ProdutoViewPimNoite.Produto  5   	   (    "ViewPimNoite.Produto.FrmCadProduto   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:ViewPimNoite.Produto     5   	   $��431.5��5      $	��800��6)     � 
ResizeMode$  NoResize=�65    � Title$ Cadastro de Produto��6K    � WindowStyle$ 
ToolWindow=�6g    � WindowStartupLocation$ CenterScreen=�6�   .��5      � $��0,0,0,4q�6   .+�5	   
   �� ���	#FF2196F3$
��Left=�6&   $��55��6A   ���	#FF2196F3$	��Top=�6`   $	��792��6x    �� RadiusX$ 15��6�    �� RadiusY$ 10��6�   �� 5
   
   $��Produto��6   $
��Left=�6"   $��	17,-2,0,0q�6=   $	��Top=�6P   $
��auto��6h   $��20(�6v   $
��Bold"�6�   ���	#DDFFFFFF$��86��6�   �� 5   
   $9��3Informe os dados para inclusão de um novo produto.��6   $
��Left=�6M   $��	19,27,0,0q�6h   $	��Top=�6{   $
��auto��6�   $��12(�6�   ���	#DDFFFFFF$	��483��6�   �� 5   
   
�������$
��Left=�6!   $	��254��6<   $��	19,80,0,0q�6I   ���	#DDA6A6A6$	��Top=�6p   $	��753��6�   �� 5   
   $��Produto��6   $
��Left=�6"   $��
39,109,0,0q�6=   $	��Top=�6Q   ���	#DDA6A6A66i   �� 5   
   -   5         ��Name$ 
txbProduto��5      $
��Left=�6&   $��23��6A   $��
45,135,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6v   $	��275��6�    J� RenderTransformOrigin$ 0.492,0.478&�6�   ���	#DDA6A6A6	 �� 	MaxLength$	 40��6�   �� 5   
   $��
Fabricante��6   $
��Left=�6%   $��
39,178,0,0q�6@   $	��Top=�6T   ���	#DDA6A6A66l   �� 5   
   -   5        $ txbFabricante��5      $
��Left=�6)   $��23��6D   $��
45,204,0,0q�6P   $
 Wrap=�6d   $	��Top=�6y   $	��275��6�   $ 0.492,0.478&�6�   ���	#DDA6A6A6$	 40��6�   �� 5   
   $��Código de Referência��6   $
��Left=�6/   $��
39,251,0,0q�6J   $	��Top=�6^   ���	#DDA6A6A66v   �� 5   
   -   5        $ txbCodReferencia��5      $
��Left=�6,   $��23��6G   $��
45,277,0,0q�6S   $
 Wrap=�6g   $	��Top=�6|   $	��275��6�   $ 0.492,0.478&�6�   ���	#DDA6A6A66�   �� 5   
   $��
Fornecedor��6   $
��Left=�6%   $��456,109,0,0q�6@   $	��Top=�6U   ���	#DDA6A6A66m   �� 5   
   -   5        $ txbFornecedor��5      $
��Left=�6)   $��23��6D   $��462,135,0,0q�6P   $
 Wrap=�6e   $	��Top=�6z   $	��275��6�   $ 0.492,0.478&�6�   ���	#DDA6A6A6$	 40��6�   �� 5   
   $��Custo��6   $
��Left=�6    $��456,178,0,0q�6;   $	��Top=�6P   ���	#DDA6A6A66h   �� 5   
   -   5        $ txbCusto��5      $
��Left=�6%   $��23��6@   $��462,204,0,0q�6L   $
 Wrap=�6a   $	��Top=�6v   $	��275��6�   $ 0.492,0.478&�6�   ���	#DDA6A6A66�   �� 5   
   $��Preço de Venda��6   $
��Left=�6)   $��456,251,0,0q�6D   $	��Top=�6Y   ���	#DDA6A6A66q   �� 5   
   -   5        $ txbPrecoVenda��5      $
��Left=�6*   $��23��6E   $��462,277,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6{   $	��275��6�   $ 0.492,0.478&�6�   ���	#DDA6A6A66�   �� 5   
   $��DADOS��6   $
��Left=�6    $��15(�6;   $
��Bold"�6I   $��	45,63,0,0q�6[   $	��Top=�6n   
�������$��63��6�   ���	#DDA6A6A66�   �� 5   
   -   5        
 ��Name$
 btnSalvarProduto��5      $��Salvar��6+   $
��Left=�6<   $��628,352,0,0q�6W   $	��Top=�6l   $	��144��6�   $ 
0.727,0.75&�6�   ���	#FF2799156�   5      5      