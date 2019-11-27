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
            cmd.Parameters.AddWithValue("@Inativar", 0);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                this.mensagem = "Usuário cadastrado com sucesso";
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

            SqlCommand cmd = new SqlCommand(@"select * from tb_Pessoas
                                              inner join tb_Funcionarios
                                              on tb_Pessoas.IdPessoa = tb_Funcionarios.fk_Pessoas_IdPessoa
                                              join tb_Cidades
                                              on fk_Cidades_idCidade = idCidade
                                              join tb_Estados
                                              on fk_Estados_idEstado = idEstado
                                              where Inativar = 0 and Nome_Pessoa like @Nome_Pessoa", conn);

            cmd.Parameters.AddWithValue("@Nome_Pessoa", "%" + nome + "%");

            List<FuncionarioDTO> listadefuncionarios = null;

            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                listadefuncionarios = new List<FuncionarioDTO>();
                FuncionarioDTO funcionarioDTO = null;

                while (dr.Read())
                {
                    funcionarioDTO = new FuncionarioDTO();

                    funcionarioDTO.IdFuncionario = Convert.ToInt32(dr["IdPessoa"]);
                    funcionarioDTO.Nome = Convert.ToString(dr["Nome_Pessoa"]);
                    funcionarioDTO.Cpf = Convert.ToString(dr["CPF"]);
                    funcionarioDTO.Dtnasc = Convert.ToString(dr["DataNascimento"]);
                    funcionarioDTO.Usuario = Convert.ToString(dr["Usuario"]);
                    funcionarioDTO.TipoUsuario = Convert.ToString(dr["TipoUsuario"]);
                    funcionarioDTO.Cep = Convert.ToString(dr["CEP"]);
                    funcionarioDTO.Endereco = Convert.ToString(dr["Endereco"]);
                    funcionarioDTO.Numero = Convert.ToString(dr["Numero"]);
                    funcionarioDTO.Bairro = Convert.ToString(dr["Bairro"]);
                    funcionarioDTO.Complemento = Convert.ToString(dr["Complemento"]);
                    funcionarioDTO.Cidade = Convert.ToString(dr["Nome_Cidade"]);
                    funcionarioDTO.Estado = Convert.ToString(dr["Sigla"]);
                    funcionarioDTO.Telefone = Convert.ToString(dr["Telefone"]);
                    funcionarioDTO.Celular = Convert.ToString(dr["Celular"]);
                    funcionarioDTO.Email = Convert.ToString(dr["Email"]);

                    listadefuncionarios.Add(funcionarioDTO);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();

                mensagem = ex.ToString();
            }
            return listadefuncionarios;
        }

        public void ExcluirFuncionario(int idFuncionario)
        {
            SqlCommand cmd = new SqlCommand(@"update tb_Pessoas 
                                            set inativar = 1
                                            where IdPessoa = @IdFuncionario", conn);

            cmd.Parameters.AddWithValue("@IdFuncionario", idFuncionario);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                this.mensagem = "Usuário excluido com sucesso";
            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
                this.mensagem = "Falha ao excluir, contate um administrador";
            }
        }

        public void EditarFuncionario(FuncionarioDTO funcionario)
        {
            SqlCommand cmd = new SqlCommand("SP_EditarFuncionario", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nome_Pessoa", funcionario.Nome);
            cmd.Parameters.AddWithValue("@CPF", funcionario.Cpf);
            cmd.Parameters.AddWithValue("@DataNascimento", funcionario.Dtnasc);
            cmd.Parameters.AddWithValue("@TipoUsuario", funcionario.TipoUsuario);
            cmd.Parameters.AddWithValue("@CEP", funcionario.Cep);
            cmd.Parameters.AddWithValue("@Endereco", funcionario.Endereco);
            cmd.Parameters.AddWithValue("@Numero", funcionario.Numero);
            cmd.Parameters.AddWithValue("@Bairro", funcionario.Bairro);
            cmd.Parameters.AddWithValue("@Complemento", funcionario.Complemento);
            cmd.Parameters.AddWithValue("@Nome_Cidade", funcionario.Cidade);
            cmd.Parameters.AddWithValue("@Estado", funcionario.Estado);
            cmd.Parameters.AddWithValue("@Telefone", funcionario.Telefone);
            cmd.Parameters.AddWithValue("@Celular", funcionario.Celular);
            cmd.Parameters.AddWithValue("@Email", funcionario.Email);
            cmd.Parameters.AddWithValue("@IdPessoa", funcionario.IdFuncionario);
            cmd.Parameters.AddWithValue("@Usuario", funcionario.Usuario);
            cmd.Parameters.AddWithValue("@Senha", funcionario.Senha);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                this.mensagem = "Usuário editado com sucesso";
            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();

                throw ex;
            };
        }
        public Boolean ValidarUsuario(FuncionarioDTO funcionario)
        {
            String sqlText = String.Format(@"Select * from tb_Pessoas 
                                            inner join tb_Funcionarios
                                            on tb_Pessoas.IdPessoa = tb_Funcionarios.fk_Pessoas_IdPessoa
                                            where Inativar = 0 and Usuario = '{0}' and Senha = '{1}' ",
                                            funcionario.Usuario, funcionario.Senha);

            SqlCommand cmd = new SqlCommand(sqlText, conn);
            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Estaticos.usuarioConectado = dr["Usuario"].ToString();
                    Estaticos.idFuncionario = Convert.ToInt32(dr["IdFuncionario"]);
                    conn.Close();
                    return true;
                }

                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
                throw ex;
            }
        }
    }
}
