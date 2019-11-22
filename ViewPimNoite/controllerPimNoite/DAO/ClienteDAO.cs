using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelPimNoite.DTO;
using System.Data.SqlClient;

namespace controllerPimNoite.DAO
{
    public class ClienteDAO : Conexao
    {     
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
            SqlCommand cmd = new SqlCommand("SP_CadastroCliente", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nome_Pessoa",cliente.Nome);
            cmd.Parameters.AddWithValue("@CPF", cliente.Cpf);
            cmd.Parameters.AddWithValue("@DataNascimento",cliente.Dtnasc);
            cmd.Parameters.AddWithValue("@TipoUsuario",cliente.TipoUsuario);
            cmd.Parameters.AddWithValue("@CEP", cliente.Cep);
            cmd.Parameters.AddWithValue("@Endereco", cliente.Endereco);
            cmd.Parameters.AddWithValue("@Numero",cliente.Numero);
            cmd.Parameters.AddWithValue("@Bairro",cliente.Bairro);
            cmd.Parameters.AddWithValue("@Complemento", cliente.Complemento);
            cmd.Parameters.AddWithValue("@Nome_Cidade",cliente.Cidade);
            cmd.Parameters.AddWithValue("@Estado", cliente.Estado );
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
            cmd.Parameters.AddWithValue("@Celular", cliente.Celular);
            cmd.Parameters.AddWithValue("@Email", cliente.Email );
            cmd.Parameters.AddWithValue("@Inativar", 1);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                this.mensagem = "Cliente cadastrado com sucesso";
            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();

                throw ex;
            }
        }
        public List<ClienteDTO> ConsultarCliente(string nome)
        {
            String sqlText = "select IdPessoa, Nome_Pessoa, CPF, Telefone, Endereco from tb_Pessoas where Inativar = 1";
            SqlCommand cmd = new SqlCommand(sqlText, conn);
            List<ClienteDTO> listadeclientes = null;

            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                listadeclientes = new List<ClienteDTO>();
                ClienteDTO clienteDTO = null;

                while (dr.Read())
                {
                    clienteDTO = new ClienteDTO();

                    clienteDTO.IdCliente = Convert.ToInt32(dr["IdPessoa"]);
                    clienteDTO.Nome = Convert.ToString(dr["Nome_Pessoa"]);
                    clienteDTO.Cpf = Convert.ToString(dr["CPF"]);
                    clienteDTO.Telefone = Convert.ToString(dr["Telefone"]);
                    clienteDTO.Endereco = Convert.ToString(dr["Endereco"]);

                    listadeclientes.Add(clienteDTO);

                }
                conn.Close();
               
            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();

                mensagem = ex.ToString();
            }

            return listadeclientes;
        }

        public void ExcluirCliente(int idCliente)
        {
            SqlCommand cmd = new SqlCommand(@"update tb_Pessoas 
                                            set inativar = 0
                                            where IdPessoas = @IdCliente",conn);
            cmd.Parameters.AddWithValue("@IdCliente", idCliente);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                this.mensagem = "Cliente Excluido com sucesso";
            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();  
            }
        }

        public void EditarCliente(ClienteDTO cliente)
        {
            SqlCommand cmd = new SqlCommand("SP_EditarCliente", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nome_Pessoa", cliente.Nome);
            cmd.Parameters.AddWithValue("@CPF", cliente.Cpf);
            cmd.Parameters.AddWithValue("@DataNascimento", cliente.Dtnasc);
            cmd.Parameters.AddWithValue("@TipoUsuario", cliente.TipoUsuario);
            cmd.Parameters.AddWithValue("@CEP", cliente.Cep);
            cmd.Parameters.AddWithValue("@Endereco", cliente.Endereco);
            cmd.Parameters.AddWithValue("@Numero", cliente.Numero);
            cmd.Parameters.AddWithValue("@Bairro", cliente.Bairro);
            cmd.Parameters.AddWithValue("@Complemento", cliente.Complemento);
            cmd.Parameters.AddWithValue("@Nome_Cidade", cliente.Cidade);
            cmd.Parameters.AddWithValue("@Estado", cliente.Estado);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
            cmd.Parameters.AddWithValue("@Celular", cliente.Celular);
            cmd.Parameters.AddWithValue("@Email", cliente.Email);
            cmd.Parameters.AddWithValue("@IdPessoa", cliente.IdCliente);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                this.mensagem = "Cliente Editado com sucesso";
            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();

                throw ex;
            };
        }
    }
}
