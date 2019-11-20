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
using controllerPimNoite.Controller;
using modelPimNoite.DTO;

namespace ViewPimNoite.Cliente
{
    /// <summary>
    /// Lógica interna para FrmCadCliente.xaml
    /// </summary>
    public partial class FrmCadCliente : Window
    {
        public FrmCadCliente()
        {
            InitializeComponent();
        }

        private void btnSalvarCliente_Click(object sender, RoutedEventArgs e)
        {
            ClienteDTO cliente = new ClienteDTO();

            cliente.Nome = txbNomeCliente.Text;


            Controller.getInstance().CadastrarCliente(cliente);
        }
    }
}
