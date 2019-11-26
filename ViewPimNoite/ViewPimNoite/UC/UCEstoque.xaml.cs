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
using ViewPimNoite.Estoque;
using controllerPimNoite.Controller;
using modelPimNoite.DTO;

namespace ViewPimNoite.UC
{
    /// <summary>
    /// Interação lógica para UCEstoque.xam
    /// </summary>
    public partial class UCEstoque : UserControl
    {
        public UCEstoque()
        {
            InitializeComponent();
        }

        private void BtnEntradaProduto_Click(object sender, RoutedEventArgs e)
        {
            ProdutoDTO produto = new ProdutoDTO();
            produto = dgEstoque.SelectedItem as ProdutoDTO;

            if(dgEstoque.SelectedCells.Count > 0)
            {
                FrmEntradaProduto frmEntradaProduto = new FrmEntradaProduto();
                frmEntradaProduto.txbCodRefEstoque.Text = produto.CodReferencia.ToString();
                frmEntradaProduto.txbProdutoEntrada.Text = produto.Produto;
                frmEntradaProduto.txbFornecedor.Text = produto.Forncedor;
                frmEntradaProduto.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione ao menos um item");
            }
        }

        private void dgEstoque_Initialized(object sender, EventArgs e)
        {
            List<ProdutoDTO> listEstoque = Controller.getInstance().ConsultarEstoque("");

            dgEstoque.ItemsSource = listEstoque;

        }

        private void txbPesqProdutoEstoque_TextChanged(object sender, TextChangedEventArgs e)
        {
            dgEstoque.FindName(txbPesqProdutoEstoque.Text);
        }

        private void btnAtualizarEstoque_Click(object sender, RoutedEventArgs e)
        {
            List<ProdutoDTO> listEstoque = Controller.getInstance().ConsultarEstoque("");

            dgEstoque.ItemsSource = listEstoque;
        }


        private void txbPesqProdutoEstoque_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txbPesqProdutoEstoque.Text))
            {
                txbPesqProdutoEstoque.Visibility = Visibility.Collapsed;
                txbWaterMark.Visibility = Visibility.Visible;
            }
        }
        private void txbWaterMark_GotFocus(object sender, RoutedEventArgs e)
        {
            txbWaterMark.Visibility = Visibility.Collapsed;
            txbPesqProdutoEstoque.Visibility = Visibility.Visible;
            txbPesqProdutoEstoque.Focus();
        }

    }
}
