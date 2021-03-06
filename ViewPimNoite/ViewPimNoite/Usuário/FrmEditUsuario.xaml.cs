﻿using System;
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

namespace ViewPimNoite.Usuário
{
    /// <summary>
    /// Lógica interna para FrmEditUsuario.xaml
    /// </summary>
    public partial class FrmEditUsuario : Window
    {
        public FrmEditUsuario()
        {
            InitializeComponent();
        }

        private void txbCpfUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            KeyConverter key = new KeyConverter();

            if ((char.IsNumber((string)key.ConvertTo(e.Key, typeof(string)), 0) == false))
            {
                e.Handled = true;
            }
        }

        private void txbCepUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            KeyConverter key = new KeyConverter();

            if ((char.IsNumber((string)key.ConvertTo(e.Key, typeof(string)), 0) == false))
            {
                e.Handled = true;
            }
        }

        private void txbNumeroUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            KeyConverter key = new KeyConverter();

            if ((char.IsNumber((string)key.ConvertTo(e.Key, typeof(string)), 0) == false))
            {
                e.Handled = true;
            }
        }

        private void txbTelefoneUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            KeyConverter key = new KeyConverter();

            if ((char.IsNumber((string)key.ConvertTo(e.Key, typeof(string)), 0) == false))
            {
                e.Handled = true;
            }
        }

        private void txbCelularUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            KeyConverter key = new KeyConverter();

            if ((char.IsNumber((string)key.ConvertTo(e.Key, typeof(string)), 0) == false))
            {
                e.Handled = true;
            }
        }

        private void btnSalvarUsuario_Click(object sender, RoutedEventArgs e)
        {
            FuncionarioDTO funcionario = new FuncionarioDTO();

            funcionario.IdFuncionario = Convert.ToInt32(txbIdUsuario.Text);
            funcionario.Nome = txbNomeUsuario.Text;
            funcionario.Cpf = txbCpfUsuario.Text;
            funcionario.Dtnasc = dtpDtNascUsuario.Text;
            funcionario.Usuario = txbUserUsuario.Text;
            funcionario.TipoUsuario = txbTipoUsuario.Text;
            funcionario.Senha = txbSenhaUsuario.Password;
            funcionario.ConfSenha = txbConfSenhaUsuario.Password;
            funcionario.Cep = txbCepUsuario.Text;
            funcionario.Endereco = txbEnderecoUsuario.Text;
            funcionario.Numero = txbNumeroUsuario.Text;
            funcionario.Bairro = txbBairroUsuario.Text;
            funcionario.Complemento = txbComplementoUsuario.Text;
            funcionario.Cidade = txbCidadeUsuario.Text;
            funcionario.Estado = txbEstadoUsuario.Text;
            funcionario.Telefone = txbTelefoneUsuario.Text;
            funcionario.Celular = txbCelularUsuario.Text;
            funcionario.Email = txbEmailUsuario.Text;

            Controller.getInstance().EditarFuncionario(funcionario);

            MessageBox.Show(Controller.getInstance().mensagem);

            if (Controller.getInstance().mensagem.Equals("Usuário editado com sucesso"))
            {
                this.Close();
            }
        }
    }
}
