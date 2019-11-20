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
using ViewPimNoite.ViewModel;
using ViewPimNoite.UC;

namespace ViewPimNoite
{
    /// <summary>
    /// Lógica interna para MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {

            InitializeComponent();

            var menuVenda = new List<SubItem>();
            var item1 = new ItemMenu("PDV", menuVenda, PackIconKind.CashRegister);
            menuVenda.Add(new SubItem("Efetuar Venda", new UCVenda()));
            menuVenda.Add(new SubItem("Vendas Realizadas"));

            var menuCadastro = new List<SubItem>();
            var item2 = new ItemMenu("CADASTRO", menuCadastro, PackIconKind.AccountAdd);
            menuCadastro.Add(new SubItem("Cliente", new UCCliente()));
            menuCadastro.Add(new SubItem("Fornecedor"));
            menuCadastro.Add(new SubItem("Produto"));
            menuCadastro.Add(new SubItem("Usuário"));

            var menuEstoque = new List<SubItem>();
            var item3 = new ItemMenu("ESTOQUE", menuEstoque, PackIconKind.Basket);
            menuEstoque.Add(new SubItem("Consultar Estoque"));
            menuEstoque.Add(new SubItem("Entrada de Produto"));

            var menuAjuda = new List<SubItem>();
            var item4 = new ItemMenu("AJUDA", menuAjuda, PackIconKind.HelpCircle);
            menuAjuda.Add(new SubItem("Manual"));
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

    }
}
