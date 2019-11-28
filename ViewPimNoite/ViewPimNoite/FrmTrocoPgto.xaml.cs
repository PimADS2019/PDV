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
using controllerPimNoite;

namespace ViewPimNoite
{
    /// <summary>
    /// Lógica interna para FrmTrocoPgto.xaml
    /// </summary>
    public partial class FrmTrocoPgto : Window
    {
        Double ValorPago;
        Double Troco;

        public FrmTrocoPgto()
        {
            InitializeComponent();
        }
        private void txbValorPago_TextChanged(object sender, TextChangedEventArgs e)
        {
            ValorPago = Convert.ToDouble(txbValorPago.Text);

            Troco = ValorPago - Estaticos.valorTotal;

            lblTroco.Content = Troco.ToString();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
