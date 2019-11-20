using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelPimNoite.DTO;
using System.Data.SqlClient;

namespace controllerPimNoite.DAO
{
    public class ClienteDAO
    {
        Conexao conn = new Conexao();
        SqlDataReader dr;

        public string mensagem;
        private static ClienteDAO instance = null;

        private ClienteDAO()
        {
        }

        public static ClienteDAO getInstance()
        {
            if (instance == null)
            {
                instance = new ClienteDAO();
            }

            return instance;
        }

        public void CadastrarCliente(ClienteDTO cliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO TPessoas(nome, ativo, dtnascimento, cpf, rg, telefone)
                                VALUES(@nome, @ativo, @nascimento, @cpf, @rg, @telefone)
                                DECLARE @id_pessoa int  =@@identity

                                INSERT INTO TEnderecos(fk_TPessoas_idPessoa, endereco, numero, bairro, cidade, estado, cep)
                                VALUES(@id_pessoa, @endereco, @numero, @bairro, @cidade, @estado, @cep)";

            cmd.Parameters.AddWithValue("@nome", cliente.Nome);
            try
            {
                cmd.Connection = conn.Conectar();
                cmd.ExecuteNonQuery();
                conn.Desconectar();
                this.mensagem = "Cliente cadastrado com sucesso";
            }
            catch (Exception)
            {
                this.mensagem = "Falha ao cadastrar cliente";
            }
        }

        public List<ClienteDTO> ConsultarCliente(string nome)
        {
            //id, cliente, cpf, telefone, endereço
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"";

            List<ClienteDTO> listadeclientes = null;

            try
            {
                cmd.Connection = conn.Conectar();
                dr = cmd.ExecuteReader();

                listadeclientes = new List<ClienteDTO>();

                while (dr.Read())
                {
                    ClienteDTO cliente = new ClienteDTO();

                    cliente.Nome = Convert.ToString(dr["nome"]);

                    listadeclientes.Add(cliente);
                }

                dr.Close();
                conn.Desconectar();
            }
            catch (Exception ex)
            {
                mensagem = ex.ToString();
            }

            return listadeclientes;
        }

        public void ExcluirCliente(int idCliente)
        {
            this.mensagem = "Cliente Excluido com sucesso";
        }

        public void EditarCliente(ClienteDTO cliente)
        {
            this.mensagem = "Cliente editado com sucesso";
        }
    }
}
