using modelPimNoite.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controllerPimNoite.DAO
{
    public class pedidoDAO : Conexao
    {
        private static pedidoDAO instance = null;
 

        private pedidoDAO()
        {
            
        }

        public static pedidoDAO GetInstance()
        {
            if (instance==null)
            {
                instance = new pedidoDAO();
            }

            return instance;
        }

        public void SalvarPedido(PedidoDTO pedido)
        {
            
            SqlCommand cmd = new SqlCommand("sp_cadastraPedido", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@qt",pedido.Qt);
            cmd.Parameters.AddWithValue("@cod", pedido.Produto.Codigo);
            cmd.Parameters.AddWithValue("@desconto", pedido.Desconto);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
                throw ex;
            }
        }
    }
}
