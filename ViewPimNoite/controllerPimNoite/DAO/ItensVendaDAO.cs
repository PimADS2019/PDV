using System;
using System.Collections.Generic;
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
            this.mensagem = "Venda realizada com sucesso";
        }
    }
}
