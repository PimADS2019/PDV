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
using ViewPimNoite.Usuário;
using controllerPimNoite.Controller;
using modelPimNoite.DTO;

namespace ViewPimNoite.UC
{
    /// <summary>
    /// Interação lógica para UCUsuario.xam
    /// </summary>
    public partial class UCUsuario : UserControl
    {
        public UCUsuario()
        {
            InitializeComponent();
        }

        private void BtnIncluirUsuario_Click(object sender, RoutedEventArgs e)
        {
            FrmCadUsuario frmCadastrar = new FrmCadUsuario();
            frmCadastrar.Show();

        }

        private void BtnEditarUsuario_Click(object sender, RoutedEventArgs e)
        {
            FrmEditUsuario frmEditar = new FrmEditUsuario();
            frmEditar.Show();
        }

        private void dgUsuarios_Initialized(object sender, EventArgs e)
        {
            List<FuncionarioDTO> listDadosFuncionario = Controller.getInstance().ConsultarFuncionarioPorNome("");
            dgUsuarios.ItemsSource = listDadosFuncionario;
        }

        private void txbPesqUsuario_TextChanged(object sender, TextChangedEventArgs e)
        {
            dgUsuarios.FindName(txbPesqUsuario.Text);
        }
    }
}
