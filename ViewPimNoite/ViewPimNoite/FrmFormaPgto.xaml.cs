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

namespace ViewPimNoite
{
    /// <summary>
    /// Lógica interna para FrmFormaPgto.xaml
    /// </summary>
    public partial class FrmFormaPgto : Window
    {
        public FrmFormaPgto()
        {
            InitializeComponent();
        }

        private void btnDinheiro_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            FrmTrocoPgto frmTroco = new FrmTrocoPgto();
            frmTroco.ShowDialog();
        }


        private void btnCartao_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
