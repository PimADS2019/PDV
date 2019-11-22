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

        private void BtnIncluirProduto_Click(object sender, RoutedEventArgs e)
        {
            FrmCadProduto frmCadastrar = new FrmCadProduto();
            frmCadastrar.Show();    
        }

        private void BtnEditarProduto_Click(object sender, RoutedEventArgs e)
        {
            FrmEditProduto frmEditar = new FrmEditProduto();
            //preciso testar isso, não sei se vai dar certo
            frmEditar.txbCodReferencia.Text = dgProdutos.SelectedCells[0].ToString();
            frmEditar.txbProduto.Text = dgProdutos.SelectedCells[1].ToString();
            frmEditar.txbFabricante.Text = dgProdutos.SelectedCells[2].ToString();
            frmEditar.txbCusto.Text = dgProdutos.SelectedCells[3].ToString();
            frmEditar.txbPrecoVenda.Text = dgProdutos.SelectedCells[4].ToString();
            frmEditar.txbFornecedor.Text = dgProdutos.SelectedCells[5].ToString();
            frmEditar.Show();
        }

        private void dgProdutos_Initialized(object sender, EventArgs e)
        {
            List<ProdutoDTO> listDadosProdutos = Controller.getInstance().ConsultarProduto("");
            dgProdutos.ItemsSource = listDadosProdutos;
        }

        private void txbPesqProduto_TextChanged(object sender, TextChangedEventArgs e)
        {
            dgProdutos.FindName(txbPesqProduto.Text);
        }
    }
}
