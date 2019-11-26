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
            ProdutoDTO produtoDTO = new ProdutoDTO();

            cmbProduto.ItemsSource = Controller.getInstance().ConsultarProduto("");
            cmbProduto.DisplayMemberPath = "Produto";
            cmbProduto.SelectedValuePath = "IdProduto";

        }

        private List<ItensVendaDTO> listaItens = new List<ItensVendaDTO>();
        private void btnIncluirItem_Click(object sender, RoutedEventArgs e)
        {
            ItensVendaDTO item = new ItensVendaDTO();
            item.Quantidade = int.Parse(txbQuantidadeProduto.Text);
            item.ProdutoDTO.Produto = cmbProduto.SelectedValue.ToString();
            item.ProdutoDTO.IdProduto = Convert.ToInt32(cmbProduto.SelectedValue);

            listaItens.Add(item);
            dgProdutosVenda.ItemsSource = listaItens;

            item.VendaDTO = Controller.getInstance().CalculosVenda(listaItens, txbQuantidadeProduto.Text, item.ProdutoDTO);
            lblQtdItens.Content = item.VendaDTO.Itens;
            lblSubTotal.Content = item.VendaDTO.SbTotal;
            lblDesconto.Content = item.VendaDTO.Desconto;
            lblTotal.Content = item.VendaDTO.VlTotal;

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
    }
}
