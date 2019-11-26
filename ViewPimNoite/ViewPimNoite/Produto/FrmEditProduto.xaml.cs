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
using System.Windows.Shapes;
using modelPimNoite.DTO;
using controllerPimNoite.Controller;

namespace ViewPimNoite.Produto
{
    /// <summary>
    /// Lógica interna para FrmEditProduto.xaml
    /// </summary>
    public partial class FrmEditProduto : Window
    {
        public FrmEditProduto()
        {
            InitializeComponent();
        }

        private void btnSalvarProduto_Click(object sender, RoutedEventArgs e)
        {
            ProdutoDTO produto = new ProdutoDTO();

            produto.IdProduto = Convert.ToInt32(txbIdProduto.Text);
            produto.Produto = txbProduto.Text;
            produto.Fabricante = txbFabricante.Text;
            produto.CodReferencia = Convert.ToInt32(txbCodReferencia.Text);
            produto.Forncedor = txbFornecedor.Text;
            produto.Custo = Convert.ToInt32(txbCusto.Text);
            produto.PrecoVenda = Convert.ToInt32(txbPrecoVenda.Text);
            produto.Tamanho = "";

            Controller.getInstance().EditarProduto(produto);

            MessageBox.Show(Controller.getInstance().mensagem);

            if (Controller.getInstance().mensagem.Equals("Produto editado com sucesso"))
            {
                this.Close();
            }
        }

        private void txbCodReferencia_KeyDown(object sender, KeyEventArgs e)
        {
            KeyConverter key = new KeyConverter();

            if ((char.IsNumber((string)key.ConvertTo(e.Key, typeof(string)), 0) == false))
            {
                e.Handled = true;
            }
        }

        private void txbCusto_KeyDown(object sender, KeyEventArgs e)
        {
            KeyConverter key = new KeyConverter();

            if ((char.IsNumber((string)key.ConvertTo(e.Key, typeof(string)), 0) == false))
            {
                e.Handled = true;
            }
        }

        private void txbPrecoVenda_KeyDown(object sender, KeyEventArgs e)
        {
            KeyConverter key = new KeyConverter();

            if ((char.IsNumber((string)key.ConvertTo(e.Key, typeof(string)), 0) == false))
            {
                e.Handled = true;
            }
        }
    }
}
