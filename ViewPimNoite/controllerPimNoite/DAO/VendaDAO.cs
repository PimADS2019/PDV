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
        public int idInsertVenda;
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
            SqlCommand cmd = new SqlCommand(@"select CodReferencia, ValorUnitario, Nome_produto from tb_Produtos
                                              inner join tb_Estoques
                                              on tb_Produtos.IdProduto = tb_Estoques.fk_Produtos_IdProduto
                                              where inativar = 1 and Nome_produto like @nome_Produto", conn);

            cmd.Parameters.AddWithValue("@nome_Produto", "%" + produto.Produto + "%");

            List<ProdutoDTO> listadeprodutos = null;

            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                listadeprodutos = new List<ProdutoDTO>();
                ProdutoDTO produtoDTO = null;

                while (dr.Read())
                {
                    produtoDTO = new ProdutoDTO();

                    produtoDTO.Produto = Convert.ToString(dr["Nome_produto"]);
                    produtoDTO.CodReferencia = Convert.ToInt32(dr["CodReferencia"]);
                    produtoDTO.PrecoVenda = Convert.ToDouble(dr["ValorUnitario"]);

                    listadeprodutos.Add(produtoDTO);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();

                mensagem = ex.ToString();
            }
            //codReferencia, vlVenda, produto, quantidade
            return listadeprodutos;
        }

        public List<ProdutoDTO> ChecarProdutoId(int produto)
        {
            SqlCommand cmd = new SqlCommand(@"select CodReferencia, ValorUnitario, Nome_produto from tb_Produtos
                                              inner join tb_Estoques
                                              on tb_Produtos.IdProduto = tb_Estoques.fk_Produtos_IdProduto
                                              where inativar = 1 and IdProduto = @Id_Produto", conn);

            cmd.Parameters.AddWithValue("@Id_Produto", produto);

            List<ProdutoDTO> listadeprodutos = null;

            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                listadeprodutos = new List<ProdutoDTO>();
                ProdutoDTO produtoDTO = null;

                while (dr.Read())
                {
                    produtoDTO = new ProdutoDTO();

                    produtoDTO.Produto = Convert.ToString(dr["Nome_produto"]);
                    produtoDTO.CodReferencia = Convert.ToInt32(dr["CodReferencia"]);
                    produtoDTO.PrecoVenda = Convert.ToDouble(dr["ValorUnitario"]);

                    listadeprodutos.Add(produtoDTO);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();

                mensagem = ex.ToString();
            }
            //codReferencia, vlVenda, produto, quantidade
            return listadeprodutos;
        }

        public int SalvarVenda(VendaDTO venda)
        {
            SqlCommand cmd = new SqlCommand("SP_CadastroVenda", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SubTotal", venda.SbTotal);
            cmd.Parameters.AddWithValue("@Desconto", venda.Desconto);
            cmd.Parameters.AddWithValue("@Total", venda.VlTotal);
            cmd.Parameters.AddWithValue("@DataVenda", venda.DtCompra);

            int id = 0;
            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                conn.Close();
                
                while (dr.Read())
                {
                    id = Convert.ToInt32(dr["IdVenda"]);
                }
                this.mensagem = "Venda Realizada com sucesso";
                return id;
            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
                return id;
                throw ex;
            }
        }
    }
}
