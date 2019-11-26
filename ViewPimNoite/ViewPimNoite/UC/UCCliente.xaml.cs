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
        private void BtnIncluirCliente_Click(object sender, RoutedEventArgs e)
        {
            FrmCadCliente frmCadastrar = new FrmCadCliente();
            frmCadastrar.ShowDialog();

        }
        private void BtnEditarCliente_Click(object sender, RoutedEventArgs e)
        {
            FrmEditCliente frmEditar = new FrmEditCliente();

            ClienteDTO cliente = new ClienteDTO();
            cliente = dgClientes.SelectedItem as ClienteDTO;
            if (dgClientes.SelectedCells.Count > 0)
            {
                frmEditar.txbNomeCliente.Text = cliente.Nome;
                frmEditar.txbCpfCliente.Text = cliente.Cpf;
                frmEditar.txbDtNascCliente.Text = cliente.Dtnasc;
                frmEditar.txbCepCliente.Text = cliente.Cep;
                frmEditar.txbEnderecoCliente.Text = cliente.Endereco;
                frmEditar.txbNumeroCliente.Text = cliente.Numero;
                frmEditar.txbBairroCliente.Text = cliente.Bairro;
                frmEditar.txbComplemento.Text = cliente.Complemento;
                frmEditar.txbCidadeCliente.Text = cliente.Cidade;
                frmEditar.txbEstadoCliente.Text = cliente.Estado;
                frmEditar.txbTelefoneCliente.Text = cliente.Telefone;
                frmEditar.txbCelularCliente.Text = cliente.Celular;
                frmEditar.txbEmailCliente.Text = cliente.Email;
                frmEditar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione ao menos um cliente");
            }
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

        private void btnExcluirCliente_Click(object sender, RoutedEventArgs e)
        {
            ClienteDTO cliente = new ClienteDTO();

            cliente = dgClientes.SelectedItem as ClienteDTO;

            Controller.getInstance().ExcluirCliente(Convert.ToString(cliente.IdCliente));

            MessageBox.Show(Controller.getInstance().mensagem);
        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {
            List<ClienteDTO> listDadosClientes = Controller.getInstance().ConsultarCliente("");
            dgClientes.ItemsSource = listDadosClientes;
        }

        private void txbPesqCliente_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txbPesqCliente.Text))
            {
                txbPesqCliente.Visibility = Visibility.Collapsed;
                txbWaterMark.Visibility = Visibility.Visible;
            }
        }

        private void txbWaterMark_GotFocus(object sender, RoutedEventArgs e)
        {
            txbWaterMark.Visibility = Visibility.Collapsed;
            txbPesqCliente.Visibility = Visibility.Visible;
            txbPesqCliente.Focus();
        }
    }
}
