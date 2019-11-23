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
            frmCadastrar.ShowDialog();
        }

        private void BtnEditarUsuario_Click(object sender, RoutedEventArgs e)
        {
            FrmEditUsuario frmEditar = new FrmEditUsuario();
            frmEditar.txbNomeUsuario.Text = dgUsuarios.SelectedCells[1].ToString();
            frmEditar.txbCpfUsuario.Text = dgUsuarios.SelectedCells[2].ToString();
            frmEditar.txbDtNascUsuario.Text = dgUsuarios.SelectedCells[3].ToString();
            frmEditar.txbUserUsuario.Text = dgUsuarios.SelectedCells[4].ToString();
            frmEditar.txbSenhaUsuario.Password = dgUsuarios.SelectedCells[5].ToString();
            frmEditar.txbConfSenhaUsuario.Password = dgUsuarios.SelectedCells[6].ToString();
            frmEditar.txbCepUsuario.Text = dgUsuarios.SelectedCells[7].ToString();
            frmEditar.txbEnderecoUsuario.Text = dgUsuarios.SelectedCells[8].ToString();
            frmEditar.txbNumeroUsuario.Text = dgUsuarios.SelectedCells[9].ToString();
            frmEditar.txbBairroUsuario.Text = dgUsuarios.SelectedCells[10].ToString();
            frmEditar.txbComplementoUsuario.Text = dgUsuarios.SelectedCells[11].ToString();
            frmEditar.txbCidadeUsuario.Text = dgUsuarios.SelectedCells[12].ToString();
            frmEditar.txbEstadoUsuario.Text = dgUsuarios.SelectedCells[13].ToString();
            frmEditar.txbTelefoneUsuario.Text = dgUsuarios.SelectedCells[14].ToString();
            frmEditar.txbCelularUsuario.Text = dgUsuarios.SelectedCells[15].ToString();
            frmEditar.txbEmailUsuario.Text = dgUsuarios.SelectedCells[16].ToString();
            frmEditar.ShowDialog();
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

        private void btnExcluirUsuario_Click(object sender, RoutedEventArgs e)
        {
            FuncionarioDTO funcionario = new FuncionarioDTO();

            funcionario.IdFuncionario= Convert.ToInt32(dgUsuarios.SelectedCells[0].ToString());

            Controller.getInstance().ExcluirFuncionario(Convert.ToString(funcionario));

            MessageBox.Show(Controller.getInstance().mensagem);
        }
    }
}
