using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelPimNoite.DTO;

namespace controllerPimNoite.DAO
{
    public class VendaDAO
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
            this.mensagem = "Venda Realizada com sucesso";
        }
    }
}
