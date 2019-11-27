using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelPimNoite.DTO;

namespace controllerPimNoite.DAO
{
    public class ProdutoDAO : Conexao
    {
        public string mensagem;
        private static ProdutoDAO instance = null;

        private ProdutoDAO()
        {
        }

        public static ProdutoDAO getInstance()
        {
            if (instance == null)
            {
                instance = new ProdutoDAO();
            }

            return instance;
        }

        public bool ConsultarExistenciadeProduto(int CodReferncia)
        {
            return false;
        }

        public void CadastrarProduto(ProdutoDTO produto)
        {
            SqlCommand cmd = new SqlCommand("SP_CadastroProdutos", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nome_Produto", produto.Produto);
            cmd.Parameters.AddWithValue("@Fabricante", produto.Fabricante);
            cmd.Parameters.AddWithValue("@Tamanho", produto.Tamanho);
            cmd.Parameters.AddWithValue("@Custo", produto.Custo);
            cmd.Parameters.AddWithValue("@Fornecedor", produto.Forncedor);
            cmd.Parameters.AddWithValue("@Precounitario", produto.PrecoVenda);
            cmd.Parameters.AddWithValue("@CodReferencia", produto.CodReferencia);
            cmd.Parameters.AddWithValue("@Quantidade", 0);
            cmd.Parameters.AddWithValue("@Inativar", 0);

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
        }

        public List<ProdutoDTO> ConsultarProduto(string produto)
        {
            SqlCommand cmd = new SqlCommand(@"select IdProduto, CodReferencia, Nome_produto, Fabricante, Custo, Fornecedor, ValorUnitario  from tb_Produtos
                                            inner join tb_Estoques
                                            on tb_Produtos.IdProduto = tb_Estoques.fk_Produtos_IdProduto
                                            where inativar = 0 and Nome_produto like @nome_Produto", conn);

            cmd.Parameters.AddWithValue("@nome_Produto", '%' + produto + '%');

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

                    produtoDTO.IdProduto = Convert.ToInt32(dr["IdProduto"]);
                    produtoDTO.CodReferencia = Convert.ToInt32(dr["CodReferencia"]);
                    produtoDTO.Produto = Convert.ToString(dr["Nome_produto"]);
                    produtoDTO.Fabricante = Convert.ToString(dr["Fabricante"]);
                    produtoDTO.Forncedor = Convert.ToString(dr["Fornecedor"]);
                    produtoDTO.Custo = Convert.ToDouble(dr["Custo"]);
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
            return listadeprodutos;
        }

        public ProdutoDTO ConsultarProdutoPorID(int IdProduto)
        {
            SqlCommand cmd = new SqlCommand(@"select IdProduto, CodReferencia, Nome_produto, Fabricante, Custo, Fornecedor, ValorUnitario  from tb_Produtos
                                            inner join tb_Estoques
                                            on tb_Produtos.IdProduto = tb_Estoques.fk_Produtos_IdProduto
                                            where inativar = 0 and IdProduto = @Id_Produto", conn);

            cmd.Parameters.AddWithValue("@Id_Produto", IdProduto);

            ProdutoDTO produtoDTO = null;

            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                produtoDTO = new ProdutoDTO();
                
                if (dr.Read())
                {
                    produtoDTO = new ProdutoDTO();

                    produtoDTO.IdProduto = Convert.ToInt32(dr["IdProduto"]);
                    produtoDTO.CodReferencia = Convert.ToInt32(dr["CodReferencia"]);
                    produtoDTO.Produto = Convert.ToString(dr["Nome_produto"]);
                    produtoDTO.Fabricante = Convert.ToString(dr["Fabricante"]);
                    produtoDTO.Forncedor = Convert.ToString(dr["Fornecedor"]);
                    produtoDTO.Custo = Convert.ToDouble(dr["Custo"]);
                    produtoDTO.PrecoVenda = Convert.ToDouble(dr["ValorUnitario"]);

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();

                mensagem = ex.ToString();
            }
            return produtoDTO;
        }

        public void ExcluirProduto(int idProduto)
        {
            SqlCommand cmd = new SqlCommand(@"update tb_Produtos
                                            set inativar = 1
                                            where IdProduto = @IdProduto", conn);
            cmd.Parameters.AddWithValue("@IdProduto", idProduto);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                this.mensagem = "Produto excluido com sucesso";
            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
                this.mensagem = "Falha ao excluir produto. Contate um administrador";
            }
        }

        public void EditarProduto(ProdutoDTO produto)
        {
            SqlCommand cmd = new SqlCommand("SP_EditarProduto", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdProduto", produto.IdProduto);
            cmd.Parameters.AddWithValue("@Nome_Produto", produto.Produto);
            cmd.Parameters.AddWithValue("@Tamanho", produto.Tamanho);
            cmd.Parameters.AddWithValue("@Fabricante", produto.Fabricante);
            cmd.Parameters.AddWithValue("@Fornecedor", produto.Forncedor);
            cmd.Parameters.AddWithValue("@Precounitario", produto.PrecoVenda);
            cmd.Parameters.AddWithValue("@Custo", produto.Custo);
            cmd.Parameters.AddWithValue("@Quantidade", produto.Quantidade);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                this.mensagem = "Produto editado com sucesso";
            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();

                throw ex;
            };
        }

        //Estoque
        public List<ProdutoDTO> ConsultarEstoque(string estoque)
        {
            SqlCommand cmd = new SqlCommand(@"select IdProduto, Nome_produto, Fabricante, Custo,
                                            ValorUnitario, Quantidade, Fornecedor, CodReferencia from tb_Produtos
                                            inner join tb_Estoques
                                            on tb_Produtos.IdProduto = tb_Estoques.fk_Produtos_IdProduto
                                            where inativar = 0 and Nome_produto like @nome_Produto and Quantidade <= 0", conn);

            cmd.Parameters.AddWithValue("@nome_Produto", '%'+estoque+'%');

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

                    produtoDTO.IdProduto = Convert.ToInt32(dr["IdProduto"]);
                    produtoDTO.Produto = Convert.ToString(dr["Nome_produto"]);
                    produtoDTO.CodReferencia = Convert.ToInt32(dr["CodReferencia"]);
                    produtoDTO.Forncedor = Convert.ToString(dr["Fornecedor"]);
                    produtoDTO.Fabricante = Convert.ToString(dr["Fabricante"]);
                    produtoDTO.Custo = Convert.ToDouble(dr["Custo"]);
                    produtoDTO.PrecoVenda = Convert.ToDouble(dr["ValorUnitario"]);
                    produtoDTO.Quantidade = Convert.ToInt32(dr["Quantidade"]);

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
            return listadeprodutos;
        }

        public ProdutoDTO ColetaDadosEstoque(int codReferencia)
        {
            SqlCommand cmd = new SqlCommand(@"select Nome_produto, Fornecedor  from tb_Produtos
                                              where inativar = 0 and IdProduto = @CodReferencia", conn);

            cmd.Parameters.AddWithValue("@CodReferencia", codReferencia);
            ProdutoDTO produtoDTO = null;
            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    produtoDTO = new ProdutoDTO();

                    produtoDTO.Produto = Convert.ToString(dr["Nome_produto"]);
                    produtoDTO.Forncedor = Convert.ToString(dr["Fornecedor"]);

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();

                mensagem = ex.ToString();
            }
            return produtoDTO;       
        }

        public void AcrescentarQuantidadeEstoque(ProdutoDTO produto, int quantidade)
        {
            SqlCommand cmd = new SqlCommand("SP_AdicionarQuantidade", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdProduto", produto.IdProduto);
            cmd.Parameters.AddWithValue("@Quantidade", quantidade);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                this.mensagem = "Entrada de produto com sucesso";
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
