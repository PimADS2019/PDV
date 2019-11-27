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
        private List<ItensVendaDTO> listaItens = new List<ItensVendaDTO>();

        public UCEfetuarVenda()
        {
            InitializeComponent();
            Atualizar_cmbProduto();
        }
        private void Atualizar_cmbProduto()
        {
            List<ProdutoDTO> produto = Controller.getInstance().ConsultarEstoqueVenda();

            cmbProduto.ItemsSource = produto;
            cmbProduto.DisplayMemberPath = "Produto";
            cmbProduto.SelectedValuePath = "IdProduto";

        }
        private void btnIncluirItem_Click(object sender, RoutedEventArgs e)
        {
            if (cmbProduto.Text.Equals(""))
            {
                MessageBox.Show("Selecione um item para a venda");
            }
            else
            {
                ItensVendaDTO item = new ItensVendaDTO();
                item.ProdutoDTO = new ProdutoDTO();
                item.ProdutoDTO = Controller.getInstance().ConsultarProdutoPorID(Convert.ToInt32(cmbProduto.SelectedValue));

                item.Quantidade = int.Parse(txbQuantidadeProduto.Text);

                if (item.Quantidade > item.ProdutoDTO.Quantidade)
                {
                    MessageBox.Show("Quantidade Inserida maior do que se tem em estoque");
                }
                else
                {
                    listaItens.Add(item);
                    dgProdutosVenda.ItemsSource = listaItens;
                    dgProdutosVenda.Items.Refresh();

                    PreencherValoresVenda(item);
                    cmbProduto.Text = "";
                }
            }
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
            if (listaItens.Count() == 0)
            {
                MessageBox.Show("Selecione pelo menos um item para a venda");
            }
            else
            {
                vendaDTO.ItensVendaDTO = listaItens;
                vendaDTO.Desconto = Convert.ToDouble(lblDesconto.Content);
                vendaDTO.DtCompra = DateTime.Now;
                vendaDTO.SbTotal = Convert.ToDouble(lblSubTotal.Content);
                vendaDTO.VlTotal = Convert.ToDouble(lblTotal.Content);

                Controller.getInstance().SalvarVenda(vendaDTO, Estaticos.idFuncionario);

                MessageBox.Show(Controller.getInstance().mensagem);
            }

            lblQtdItens.Content = "";
            lblSubTotal.Content = "";
            lblDesconto.Content = "";
            lblTotal.Content = "";
        }

        private void txbQuantidadeProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.btnIncluirItem_Click(this, null);
            }
        }

        private void cmbProduto_MouseMove(object sender, MouseEventArgs e)
        {
            Atualizar_cmbProduto();
        }

        private void btnCancelarVenda_Click(object sender, RoutedEventArgs e)
        {
            cmbProduto.Text = "";
            txbQuantidadeProduto.Text = "1";
            dgProdutosVenda.ItemsSource = "";
            lblQtdItens.Content = "";
            lblSubTotal.Content = "";
            lblDesconto.Content = "";
            lblTotal.Content = "";
        }

        private void cmbProduto_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Atualizar_cmbProduto();
        }
    }
}
