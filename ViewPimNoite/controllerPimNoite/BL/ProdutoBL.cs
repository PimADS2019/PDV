using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelPimNoite.DTO;
using controllerPimNoite.DAO;

namespace controllerPimNoite.BL
{
    public class ProdutoBL
    {
        public string mensagem;
        private int codReferencia;
        private int quantidade;
        private static ProdutoBL instance = null;

        private ProdutoBL()
        {
        }

        public static ProdutoBL getInstance()
        {
            if (instance == null)
            {
                instance = new ProdutoBL();
            }

            return instance;
        }

        private void ValidarProduto(ProdutoDTO produto)
        {
            if (produto.Produto == "")
            {
                this.mensagem = "O nome do produto é obrigatório.";
                return;
            }

            if (produto.CodReferencia <= 0)
            {
                this.mensagem = "O Código de referência do produto não pode ser um valor negativo.";
                return;
            }

            if (produto.PrecoVenda <= 0)
            {
                this.mensagem = "O preço de venda do produto não pode ser um valor negativo ou 0.";
                return;
            }

            if (produto.Custo <= 0)
            {
                this.mensagem = "O preço de venda do produto não pode ser um valor negativo ou 0.";
                return;
            }
        }

        public void CadastrarProduto(ProdutoDTO produto)
        {
            mensagem = "";

            if (produto.CodReferencia > 0)
            {
                if (ProdutoDAO.getInstance().ConsultarExistenciadeProduto(produto.CodReferencia))
                {
                    this.mensagem = "Este código de Referência já existe, favor digitar outro.";
                }
            }

            ValidarProduto(produto);

            if (mensagem == "")
            {
                ProdutoDAO.getInstance().CadastrarProduto(produto);
                this.mensagem = ProdutoDAO.getInstance().mensagem;
            }
        }

        public List<ProdutoDTO> ConsultarProduto(string produto)
        {
            return ProdutoDAO.getInstance().ConsultarProduto(produto);
        }

        public ProdutoDTO ConsultarProdutoPorId(int idProduto)
        {
            return ProdutoDAO.getInstance().ConsultarProdutoPorID(idProduto);
        }

        public void ExcluirProduto(string idProduto)
        {
            try
            {
                ProdutoDAO.getInstance().ExcluirProduto(Convert.ToInt32(idProduto));
                this.mensagem = ProdutoDAO.getInstance().mensagem;
            }
            catch (Exception)
            {
                this.mensagem = "Id inválido";
            }
        }

        public void EditarProduto(ProdutoDTO produto)
        {
            mensagem = "";
            ValidarProduto(produto);

            if (mensagem == "")
            {
                ProdutoDAO.getInstance().EditarProduto(produto);
                this.mensagem = ProdutoDAO.getInstance().mensagem;
            }
        }

        //Estoque
        public List<ProdutoDTO> ConsultarEstoque(string estoque)
        {
            return ProdutoDAO.getInstance().ConsultarEstoque(estoque);
        }

        public List<ProdutoDTO> ConsultarEstoqueVenda()
        {
            return ProdutoDAO.getInstance().ConsultarEstoqueVenda();
        }

        public ProdutoDTO ColetaDadosEstoque(string codReferencia)
        {
            try
            {
                this.codReferencia = Convert.ToInt32(codReferencia);
            }
            catch (Exception)
            {

                this.mensagem = "Código de referência inválida";
                return null;
            }

            return ProdutoDAO.getInstance().ColetaDadosEstoque(this.codReferencia);
        }

        public void AcrescentarQuantidadeEstoque(ProdutoDTO produto, string quantidade)
        {
            try
            {
                this.quantidade = Convert.ToInt32(quantidade);
            }
            catch (Exception)
            {
                this.mensagem = "Quantidade inválida";
            }

            ProdutoDAO.getInstance().AcrescentarQuantidadeEstoque(produto, this.quantidade);
            this.mensagem = ProdutoDAO.getInstance().mensagem;
        }
    }
}
