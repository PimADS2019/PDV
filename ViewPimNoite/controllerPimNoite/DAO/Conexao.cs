using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace controllerPimNoite.DAO
{
    public class Conexao
    {
        SqlConnection conn;

        public Conexao()
        {
            conn.ConnectionString = @"Data Source=DESKTOP-E1CCUJ5\SQLEXPRESS;Initial Catalog=(nomedatabase);User ID=sa;Password=chuab23";
        }

        public SqlConnection Conectar()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            return conn;
        }

        public void Desconectar()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
        
    }
}
