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
using ViewPimNoite.Produto;
using controllerPimNoite.Controller;
using modelPimNoite.DTO;

namespace ViewPimNoite.UC
{
    /// <summary>
    /// Interação lógica para UCProduto.xam
    /// </summary>
    public partial class UCProduto : UserControl
    {
        public UCProduto()
        {
            InitializeComponent();
        }
        private void Pesquisar(ProdutoDTO produto)
        {
            produto.Produto = txbPesqProduto.Text.Trim();

            dgProdutos.ItemsSource = Controller.getInstance().ConsultarProduto(produto.Produto.ToString());
        }
        private void BtnIncluirProduto_Click(object sender, RoutedEventArgs e)
        {
            FrmCadProduto frmCadastrar = new FrmCadProduto();
            frmCadastrar.ShowDialog();    
        }

        private void BtnEditarProduto_Click(object sender, RoutedEventArgs e)
        {
            ProdutoDTO produto = new ProdutoDTO();
            produto = dgProdutos.SelectedItem as ProdutoDTO;

            FrmEditProduto frmEditar = new FrmEditProduto();
            if (dgProdutos.SelectedCells.Count > 0)
            {
                frmEditar.txbIdProduto.Text = produto.IdProduto.ToString();
                frmEditar.txbCodReferencia.Text = produto.CodReferencia.ToString();
                frmEditar.txbProduto.Text = produto.Produto;
                frmEditar.txbFabricante.Text = produto.Fabricante;
                frmEditar.txbCusto.Text = produto.Custo.ToString();
                frmEditar.txbPrecoVenda.Text = produto.PrecoVenda.ToString();
                frmEditar.txbFornecedor.Text = produto.Forncedor;
                frmEditar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione ao menos um produto");
            }
        }

        private void dgProdutos_Initialized(object sender, EventArgs e)
        {
            List<ProdutoDTO> listDadosProdutos = Controller.getInstance().ConsultarProduto("");
            dgProdutos.ItemsSource = listDadosProdutos;
        }

        private void txbPesqProduto_TextChanged(object sender, TextChangedEventArgs e)
        {
            ProdutoDTO produto = new ProdutoDTO();
            Pesquisar(produto);
        }
        private void btnExcluirProduto_Click(object sender, RoutedEventArgs e)
        {
            if (dgProdutos.SelectedCells.Count > 0)
            {
                ProdutoDTO produto = new ProdutoDTO();

                produto = dgProdutos.SelectedItem as ProdutoDTO;

                Controller.getInstance().ExcluirProduto(Convert.ToString(produto.IdProduto));

                MessageBox.Show(Controller.getInstance().mensagem);
            }
            else
            {
                MessageBox.Show("Selecione ao menos um produto");
            }
        }
        private void txbPesqProduto_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txbPesqProduto.Text))
            {
                txbPesqProduto.Visibility = Visibility.Collapsed;
                txbWaterMark.Visibility = Visibility.Visible;
            }
        }
        private void txbWaterMark_GotFocus(object sender, RoutedEventArgs e)
        {
            txbWaterMark.Visibility = Visibility.Collapsed;
            txbPesqProduto.Visibility = Visibility.Visible;
            txbPesqProduto.Focus();
        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {
            List<ProdutoDTO> listDadosProdutos = Controller.getInstance().ConsultarProduto("");
            dgProdutos.ItemsSource = listDadosProdutos;
        }
    }
}
