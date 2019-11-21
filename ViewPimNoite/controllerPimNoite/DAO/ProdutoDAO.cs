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
            cmd.Parameters.AddWithValue("@Inativar", 1);


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
            //código de referncia, Produtos, fabricante, custo, preço venda
            return null;
        }

        public void ExcluirProduto(int idProduto)
        {
            this.mensagem = "Produto Excluido com sucesso.";
        }

        public void EditarProduto(ProdutoDTO produto)
        {
            this.mensagem = "Produto editado com sucesso";
        }

        //Estoque
        public List<ProdutoDTO> ConsultarEstoque(string estoque)
        {
            //produto, fabricante, custo, preço venda, quantidade
            return null;
        }

        public ProdutoDTO ColetaDadosEstoque(int codReferencia)
        {
            //produto, fornecedor
            return null;       
        }

        public void AcrescentarQuantidadeEstoque(ProdutoDTO produto, int quantidade)
        {
            this.mensagem = "Estoque atualizado com sucesso.";
        }
    }
}
