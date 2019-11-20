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
using ViewPimNoite.Produto;

namespace ViewPimNoite.UC
{
    /// <summary>
    /// Interação lógica para UCProduto.xam
    /// </summary>
    public partial class UCProduto : UserControl
    {
        public UCProduto()
        {
            InitializeComponent();
        }

        private void BtnIncluirProduto_Click(object sender, RoutedEventArgs e)
        {
            FrmCadProduto frmCadastrar = new FrmCadProduto();
            frmCadastrar.Show();    
        }

        private void BtnEditarProduto_Click(object sender, RoutedEventArgs e)
        {
            FrmEditProduto frmEditar = new FrmEditProduto();
            frmEditar.Show();
        }
    }
}
