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
            FrmEntradaProduto frmEntradaProduto = new FrmEntradaProduto();
            frmEntradaProduto.txbCodRefEstoque.Text = dgEstoque.SelectedCells[0].ToString();
            frmEntradaProduto.txbProdutoEntrada.Text = dgEstoque.SelectedCells[1].ToString();
            frmEntradaProduto.txbFornecedor.Text = dgEstoque.SelectedCells[2].ToString();
            frmEntradaProduto.Show();
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
    }
}
