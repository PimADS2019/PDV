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
    /// Interação lógica para UCEfetuarVenda.xam
    /// </summary>
    public partial class UCEfetuarVenda : UserControl
    {
        public UCEfetuarVenda()
        {
            InitializeComponent();
        }

        //private List<ItemVendaDTO> listaItens = new List<ItemVendaDTO>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Adicionar Button.CausesValidation para OK

            /*
            ItemVendaDTO item = new ItemVendaDTO();
            item.Quantidade = int.Parse(txbQuantidadeProduto.Text);
            item.Produto = new ProdutoDTO();
            item.Produto.Id = Convert.ToInt32(cmbProduto.SelectedValue);

            listaItens.Add(item);

            dgProdutosVenda.ItemsSource = carrinho;
            */
        }

        private void btnFinalizarVenda_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
