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

namespace ViewPimNoite
{
    /// <summary>
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }


        private void btnLogar_Click(object sender, RoutedEventArgs e)
        {
            UsuarioDTO usuario = new UsuarioDTO();

            usuario.Usuario = txbUsuario.Text;
            usuario.Senha = txbSenha.Password;

            Controller.getInstance().ValidarUsuario(usuario);
        }

        private void btnFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
