﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelPimNoite.DTO
{
    public class ClienteDTO
    {
        private int idCliente;
        private string nome;
        private string cpf;
        private string dtnasc;
        private string cep;
        private string endereco;
        private string numero;
        private string bairro;
        private string cidade;
        private string estado;
        private string telefone;
        private string celular;
        private string email;
        private string tipoUsuario;
        private string complemento;

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Dtnasc { get => dtnasc; set => dtnasc = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Email { get => email; set => email = value; }
        public string TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
    }
}
