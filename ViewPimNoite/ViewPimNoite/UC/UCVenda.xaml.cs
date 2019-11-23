using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ViewPimNoite.UC
{
    /// <summary>
    /// Interação lógica para UCVenda.xam
    /// </summary>
    public partial class UCVenda : UserControl
    {
        public UCVenda()
        {
            InitializeComponent();
        }

        private List<ItemVendaDTO> carrinho = new List<ItemVendaDTO>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ItemVendaDTO it = new ItemVendaDTO();
            it.Quantidade = int.Parse(txbQuantidadeProduto.Text);
            it.Produto = new ProdutoDTO();
            it.Produto.Id = Convert.ToInt32(cmbProduto.SelectedValue);

            carrinho.Add(it);

            dgProdutosVenda.ItemsSource = carrinho;
        }
    }
}
