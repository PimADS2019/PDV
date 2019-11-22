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
using ViewPimNoite.Cliente;
using modelPimNoite.DTO;
using controllerPimNoite.Controller;

namespace ViewPimNoite.UC
{
    /// <summary>
    /// Interação lógica para UCCliente.xam
    /// </summary>
    public partial class UCCliente : UserControl
    {
        public UCCliente()
        {
            InitializeComponent();
        }

        private void TxbPesqCliente_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            txbPesqCliente.Clear();
        }
        private void BtnIncluirCliente_Click(object sender, RoutedEventArgs e)
        {
            FrmCadCliente frmCadastrar = new FrmCadCliente();
            frmCadastrar.Show();

        }
        private void BtnEditarCliente_Click(object sender, RoutedEventArgs e)
        {
            FrmEditCliente frmEditar = new FrmEditCliente();
            frmEditar.txbNomeCliente.Text = dgClientes.SelectedCells[1].ToString();
            frmEditar.txbCpfCliente.Text = dgClientes.SelectedCells[2].ToString();
            frmEditar.txbDtNascCliente.Text = dgClientes.SelectedCells[3].ToString();
            frmEditar.txbCepCliente.Text = dgClientes.SelectedCells[4].ToString();
            frmEditar.txbEnderecoCliente.Text = dgClientes.SelectedCells[5].ToString();
            frmEditar.txbNumeroCliente.Text = dgClientes.SelectedCells[6].ToString();
            frmEditar.txbBairroCliente.Text = dgClientes.SelectedCells[7].ToString();
            frmEditar.txbComplemento.Text = dgClientes.SelectedCells[8].ToString();
            frmEditar.txbCidadeCliente.Text = dgClientes.SelectedCells[9].ToString();
            frmEditar.txbEstadoCliente.Text = dgClientes.SelectedCells[10].ToString();
            frmEditar.txbTelefoneCliente.Text = dgClientes.SelectedCells[11].ToString();
            frmEditar.txbCelularCliente.Text = dgClientes.SelectedCells[12].ToString();
            frmEditar.txbEmailCliente.Text = dgClientes.SelectedCells[13].ToString();
            frmEditar.Show();
        }
        private void dgClientes_Initialized(object sender, EventArgs e)
        {
            List<ClienteDTO> listDadosClientes = Controller.getInstance().ConsultarCliente("");
            dgClientes.ItemsSource = listDadosClientes;
        }
        private void txbPesqCliente_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            dgClientes.FindName(txbPesqCliente.Text);
        }
    }
}
