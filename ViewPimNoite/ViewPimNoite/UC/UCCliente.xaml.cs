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
            //frmEditar.txbNomeCliente = dgClientes.ItemsSource.
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
