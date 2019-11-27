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
using controllerPimNoite;

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
            item.ProdutoDTO = Controller.getInstance().ConsultarProdutoPorID(Convert.ToInt32(cmbProduto.SelectedValue)); 
            item.Quantidade = int.Parse(txbQuantidadeProduto.Text);

            listaItens.Add(item);
            dgProdutosVenda.ItemsSource = listaItens;
            dgProdutosVenda.Items.Refresh();

            PreencherValoresVenda(item);
            cmbProduto.Text = "";
        }

        private void PreencherValoresVenda(ItensVendaDTO itens)
        {
            itens.VendaDTO = Controller.getInstance().CalculosVenda(listaItens, txbQuantidadeProduto.Text, itens.ProdutoDTO);
            lblQtdItens.Content = itens.VendaDTO.Itens;
            lblSubTotal.Content = itens.VendaDTO.SbTotal;
            lblDesconto.Content = itens.VendaDTO.Desconto;
            lblTotal.Content = itens.VendaDTO.VlTotal;
        }

        private void btnFinalizarVenda_Click(object sender, RoutedEventArgs e)
        {
            vendaDTO.ItensVendaDTO = listaItens;
            vendaDTO.Desconto = Convert.ToDouble(lblDesconto.Content);
            vendaDTO.DtCompra = DateTime.Now;
            vendaDTO.SbTotal = Convert.ToDouble(lblSubTotal.Content);
            vendaDTO.VlTotal = Convert.ToDouble(lblTotal.Content);

            Controller.getInstance().SalvarVenda(vendaDTO, Estaticos.idFuncionario);

            MessageBox.Show(Controller.getInstance().mensagem);
            dgProdutosVenda.ItemsSource = null;
            dgProdutosVenda.Items.Refresh();
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
