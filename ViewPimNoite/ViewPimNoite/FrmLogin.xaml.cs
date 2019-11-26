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
using ViewPimNoite;

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
            FuncionarioDTO funcionario = new FuncionarioDTO();

            funcionario.Usuario = txbUsuario.Text;
            funcionario.Senha = txbSenha.Password;

            if (Controller.getInstance().ValidarUsuario(funcionario).Equals(""))
            {
                MainMenu mainMenu = new MainMenu();

                mainMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show(Controller.getInstance().ValidarUsuario(funcionario));
            }

        }

        private void btnFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txbSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.btnLogar_Click(this, null);
            }
        }
    }
}
