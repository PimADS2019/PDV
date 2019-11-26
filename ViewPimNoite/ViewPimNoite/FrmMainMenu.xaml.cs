using MaterialDesignThemes.Wpf;
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
using System.Windows.Threading;
using ViewPimNoite.ViewModel;
using ViewPimNoite.UC;
using controllerPimNoite;

namespace ViewPimNoite
{
    /// <summary>
    /// Lógica interna para MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        private void DataHoraAtual()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tickevent;
            timer.Start();
        }

        private void tickevent(object sender, EventArgs e)
        {
            lblHoraAtual.Content = DateTime.Now.ToString("HH:mm:ss");
            lblDataAtual.Content = DateTime.Now.ToShortDateString();
        }

        public MainMenu()
        {
            InitializeComponent();
            DataHoraAtual();
            lblUsuarioConectado.Content = Estaticos.usuarioConectado;
            
            var menuVenda = new List<SubItem>();
            var item1 = new ItemMenu("PDV", menuVenda, PackIconKind.CashRegister);
            menuVenda.Add(new SubItem("Efetuar Venda", new UCEfetuarVenda()));
            menuVenda.Add(new SubItem("Vendas Realizadas", new UCVendas()));

            var menuCadastro = new List<SubItem>();
            var item2 = new ItemMenu("CADASTRO", menuCadastro, PackIconKind.AccountAdd);
            menuCadastro.Add(new SubItem("Cliente", new UCCliente()));
            menuCadastro.Add(new SubItem("Produto", new UCProduto()));
            menuCadastro.Add(new SubItem("Usuário", new UCUsuario()));

            var menuEstoque = new List<SubItem>();
            var item3 = new ItemMenu("ESTOQUE", menuEstoque, PackIconKind.Basket);  
            menuEstoque.Add(new SubItem("Estoque de Produto", new UCEstoque()));

            var menuAjuda = new List<SubItem>();
            var item4 = new ItemMenu("AJUDA", menuAjuda, PackIconKind.HelpCircle);
            menuAjuda.Add(new SubItem("Sobre"));

            Menu.Children.Add(new UCMenuItem(item1, this));
            Menu.Children.Add(new UCMenuItem(item2, this));
            Menu.Children.Add(new UCMenuItem(item3, this));
            Menu.Children.Add(new UCMenuItem(item4, this));
        }

        internal void MudarTela(object sender)
        {
            var screen = ((UserControl)sender);

            if (screen != null)
            {
                StackPanelMain.Children.Clear();
                StackPanelMain.Children.Add(screen);
            }
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            Estaticos.logado = false;
            Login login = new Login();
            this.Close();
            login.ShowDialog();
            if (!Estaticos.logado)
            {
                this.Close();
            }
        }
    }
}
