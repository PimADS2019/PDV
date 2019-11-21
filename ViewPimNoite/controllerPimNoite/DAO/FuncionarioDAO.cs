using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelPimNoite.DTO;

namespace controllerPimNoite.DAO
{
    public class FuncionarioDAO : Conexao
    {
        public string mensagem;
        private static FuncionarioDAO instance = null;

        private FuncionarioDAO()
        {
        }

        public static FuncionarioDAO getInstance()
        {
            if (instance == null)
            {
                instance = new FuncionarioDAO();
            }

            return instance;
        }

        public void CadastrarFuncionario(FuncionarioDTO funcionario)
        {
            SqlCommand cmd = new SqlCommand("SP_CadastroFuncionario", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nome_Pessoa", funcionario.Nome);
            cmd.Parameters.AddWithValue("@CPF", funcionario.Cpf);
            cmd.Parameters.AddWithValue("@DataNascimento", funcionario.Dtnasc);
            cmd.Parameters.AddWithValue("@TipoUsuario", funcionario.TipoUsuario);
            cmd.Parameters.AddWithValue("@CEP", funcionario.Cep);
            cmd.Parameters.AddWithValue("@Endereco", funcionario.Endereco);
            cmd.Parameters.AddWithValue("@Numero", funcionario.Numero);
            cmd.Parameters.AddWithValue("@Bairro",  funcionario.Bairro);
            cmd.Parameters.AddWithValue("@Complemento", funcionario.Complemento);
            cmd.Parameters.AddWithValue("@Nome_Cidade", funcionario.Cidade);
            cmd.Parameters.AddWithValue("@Estado", funcionario.Estado);
            cmd.Parameters.AddWithValue("@Telefone", funcionario.Telefone);
            cmd.Parameters.AddWithValue("@Celular", funcionario.Celular);
            cmd.Parameters.AddWithValue("@Email", funcionario.Email);
            cmd.Parameters.AddWithValue("@Usuario", funcionario.Usuario);
            cmd.Parameters.AddWithValue("@Senha", funcionario.Senha);
            cmd.Parameters.AddWithValue("@Inativar", 1);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                this.mensagem = "funcionario cadastrado com sucesso";
            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();

                throw ex;
            }
            
        }

        public List<FuncionarioDTO> ConsultarFuncionarioPorNome(string nome)
        {
            //id, usuario, nome, telefone, cargo
            return null;
        }

        public void ExcluirFuncionario(int idFuncionario)
        {
            this.mensagem = "Excluido com sucesso";
        }

        public void EditarFuncionario(FuncionarioDTO funcionario)
        {
            this.mensagem = "Funcionario editado com sucesso";
        }
    }
}
