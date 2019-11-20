using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelPimNoite.DTO;
using System.Data.SqlClient;

namespace controllerPimNoite.DAO
{
    public class UsuarioDAO
    {
        Conexao conn = new Conexao();
        SqlDataReader dr;

        private bool response;
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
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM TUsuario 
                                WHERE usuario = @usuario 
                                AND senha = @senha";

            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", usuario);

            try
            {
                cmd.Connection = conn.Conectar();
                cmd.ExecuteNonQuery();
                conn.Desconectar();
                return response = true;
            }
            catch (Exception)
            {
                return response = false;
            }
        }
    }
}
