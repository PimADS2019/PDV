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
            dgUsuarios.IsReadOnly = true;
        }
        private void Pesquisar(FuncionarioDTO funcionario)
        {
            funcionario.Nome = txbPesqUsuario.Text.Trim();

            dgUsuarios.ItemsSource = Controller.getInstance().ConsultarFuncionarioPorNome(funcionario.Nome.ToString());
        }
        private void BtnIncluirUsuario_Click(object sender, RoutedEventArgs e)
        {
            FrmCadUsuario frmCadastrar = new FrmCadUsuario();
            frmCadastrar.ShowDialog();
        }

        private void BtnEditarUsuario_Click(object sender, RoutedEventArgs e)
        {
            FuncionarioDTO funcionario = new FuncionarioDTO();
            funcionario = dgUsuarios.SelectedItem as FuncionarioDTO;

            if (dgUsuarios.SelectedCells.Count > 0)
            {
                FrmEditUsuario frmEditar = new FrmEditUsuario();
                frmEditar.txbIdUsuario.Text = funcionario.IdFuncionario.ToString();
                frmEditar.txbNomeUsuario.Text = funcionario.Nome;
                frmEditar.txbCpfUsuario.Text = funcionario.Cpf;
                frmEditar.dtpDtNascUsuario.Text = funcionario.Dtnasc;
                frmEditar.txbUserUsuario.Text = funcionario.Usuario;
                frmEditar.txbTipoUsuario.Text = funcionario.TipoUsuario;
                frmEditar.txbSenhaUsuario.Password = funcionario.Senha;
                frmEditar.txbConfSenhaUsuario.Password = funcionario.ConfSenha;
                frmEditar.txbCepUsuario.Text = funcionario.Cep;
                frmEditar.txbEnderecoUsuario.Text = funcionario.Endereco;
                frmEditar.txbNumeroUsuario.Text = funcionario.Numero;
                frmEditar.txbBairroUsuario.Text = funcionario.Bairro;
                frmEditar.txbComplementoUsuario.Text = funcionario.Complemento;
                frmEditar.txbCidadeUsuario.Text = funcionario.Cidade;
                frmEditar.txbEstadoUsuario.Text = funcionario.Estado;
                frmEditar.txbTelefoneUsuario.Text = funcionario.Telefone;
                frmEditar.txbCelularUsuario.Text = funcionario.Celular;
                frmEditar.txbEmailUsuario.Text = funcionario.Email;
                frmEditar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione ao menos um usuário");
            }
        }

        private void dgUsuarios_Initialized(object sender, EventArgs e)
        {
            List<FuncionarioDTO> listDadosFuncionario = Controller.getInstance().ConsultarFuncionarioPorNome("");
            dgUsuarios.ItemsSource = listDadosFuncionario;
        }

        private void txbPesqUsuario_TextChanged(object sender, TextChangedEventArgs e)
        {
            FuncionarioDTO funcionario = new FuncionarioDTO();
            Pesquisar(funcionario);
        }

        private void btnExcluirUsuario_Click(object sender, RoutedEventArgs e)
        {
            FuncionarioDTO funcionario = new FuncionarioDTO();

            funcionario = dgUsuarios.SelectedItem as FuncionarioDTO;

            Controller.getInstance().ExcluirFuncionario(Convert.ToString(funcionario.IdFuncionario));

            MessageBox.Show(Controller.getInstance().mensagem);
        }
        private void txbPesqUsuario_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txbPesqUsuario.Text))
            {
                txbPesqUsuario.Visibility = Visibility.Collapsed;
                txbWaterMark.Visibility = Visibility.Visible;
            }
        }
        private void txbWaterMark_GotFocus(object sender, RoutedEventArgs e)
        {
            txbWaterMark.Visibility = Visibility.Collapsed;
            txbPesqUsuario.Visibility = Visibility.Visible;
            txbPesqUsuario.Focus();
        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {
            List<FuncionarioDTO> listDadosFuncionario = Controller.getInstance().ConsultarFuncionarioPorNome("");
            dgUsuarios.ItemsSource = listDadosFuncionario;
        }

    }
}
