using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controllerPimNoite.DAO
{
    public class ItensVendaDAO : Conexao
    {
        public string mensagem;
        private static ItensVendaDAO instance = null;

        private ItensVendaDAO()
        {
        }

        public static ItensVendaDAO getInstance()
        {
            if (instance == null)
            {
                instance = new ItensVendaDAO();
            }

            return instance;
        }

        public void RegistrarItensVendidos(int idProduto, int quantidadeVendida)
        {
            SqlCommand cmd = new SqlCommand("SP_CadastroProdutoVenda", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdProduto", idProduto);
            cmd.Parameters.AddWithValue("@Quantidade", quantidadeVendida);
            //cmd.Parameters.AddWithValue("@IdVenda", );


            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                this.mensagem = "Produto cadastrado com sucesso";
            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();

                throw ex;
            }
            this.mensagem = "Venda realizada com sucesso";
        }
    }
}
