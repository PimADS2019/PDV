using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelPimNoite.DTO;

namespace controllerPimNoite.DAO
{
    public class VendaDAO : Conexao
    {
        public string mensagem;
        private static VendaDAO instance = null;

        private VendaDAO()
        {
        }

        public static VendaDAO getInstance()
        {
            if (instance == null)
            {
                instance = new VendaDAO();
            }

            return instance;
        }

        public List<VendaDTO> ConsultarVendas(string vendas)
        {
            //data, id produto e total
            return null;
        }

        public List<ProdutoDTO> ChecarProdutoNome(ProdutoDTO produto)
        {
            //codReferencia, vlVenda, produto, quantidade
            return null;
        }

        public List<ProdutoDTO> ChecarProdutoId(int produto)
        {
            //codReferencia, vlVenda, produto, quantidade
            return null;
        }

        public void SalvarVenda(VendaDTO venda)
        {
            SqlCommand cmd = new SqlCommand("SP_CadastroCliente", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SubTotal", venda.SbTotal);
            cmd.Parameters.AddWithValue("@Desconto", venda.Desconto);
            cmd.Parameters.AddWithValue("@Total", venda.VlTotal);
            //Incompleto
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                this.mensagem = "Venda Realizada com sucesso";
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
