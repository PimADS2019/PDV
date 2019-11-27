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
using modelPimNoite.DTO;
using controllerPimNoite.Controller;

namespace ViewPimNoite.UC
{
    /// <summary>
    /// Interação lógica para UCEfetuarVenda.xam
    /// </summary>
    public partial class UCEfetuarVenda : UserControl
    {
        VendaDTO vendaDTO = new VendaDTO();

        public UCEfetuarVenda()
        {
            InitializeComponent();
            Atualizar_cmbProduto();
        }
        private void Atualizar_cmbProduto()
        {
            List<ProdutoDTO> produto = Controller.getInstance().ConsultarEstoque("");

            cmbProduto.ItemsSource = produto;
            cmbProduto.DisplayMemberPath = "Produto";
            cmbProduto.SelectedValuePath = "IdProduto";

        }

        private List<ItensVendaDTO> listaItens = new List<ItensVendaDTO>();
        
        private void btnIncluirItem_Click(object sender, RoutedEventArgs e)
        {
            ItensVendaDTO item = new ItensVendaDTO();
            item.ProdutoDTO = new ProdutoDTO();
            item.ProdutoDTO = controllerPimNoite.DAO.ProdutoDAO.getInstance().ConsultarProdutoPorID(Convert.ToInt32(cmbProduto.SelectedValue));
            item.Quantidade = int.Parse(txbQuantidadeProduto.Text);

            listaItens.Add(item);
            dgProdutosVenda.ItemsSource = listaItens;
            dgProdutosVenda.Items.Refresh();

            cmbProduto.Text = "";
        }

        private void btnFinalizarVenda_Click(object sender, RoutedEventArgs e)
        {
            vendaDTO.ItensVendaDTO = listaItens;

            Controller.getInstance().SalvarVenda(vendaDTO);

            MessageBox.Show(Controller.getInstance().mensagem);
        }

        private void txbQuantidadeProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.btnIncluirItem_Click(this, null);
            }
        }

        private void dgProdutosVenda_AddingNewItem(object sender, AddingNewItemEventArgs e)
        {
            ItensVendaDTO item = new ItensVendaDTO();

            item.VendaDTO = Controller.getInstance().CalculosVenda(listaItens, txbQuantidadeProduto.Text, item.ProdutoDTO);
            lblQtdItens.Content = vendaDTO.Itens;
            lblSubTotal.Content = vendaDTO.SbTotal;
            lblDesconto.Content = vendaDTO.Desconto;
            lblTotal.Content = vendaDTO.VlTotal;
        }
    }
}
