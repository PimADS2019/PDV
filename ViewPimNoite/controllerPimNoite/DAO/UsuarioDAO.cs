using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelPimNoite.DTO;
using System.Data.SqlClient;

namespace controllerPimNoite.DAO
{
    public class UsuarioDAO : Conexao
    {
        private static UsuarioDAO instance = null;

        private UsuarioDAO()
        {
        }

        public static UsuarioDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new UsuarioDAO();
            }

            return instance;
        }

        public Boolean ValidarUsuario(UsuarioDTO usuario)
        {
            String sqlText = String.Format("Select * from tb_Funcionarios Where Usuario = '{0}' and Senha = '{1}'", usuario.Usuario, usuario.Senha);
            SqlCommand cmd = new SqlCommand(sqlText, conn);
            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
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
