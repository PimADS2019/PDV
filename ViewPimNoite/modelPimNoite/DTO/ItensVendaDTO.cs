using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelPimNoite.DTO
{
    public class ItensVendaDTO
    {
        private int quantidade;
        private VendaDTO vendaDTO;
        private ProdutoDTO produtoDTO;

        public int Quantidade { get => quantidade; set => quantidade = value; }
        public VendaDTO VendaDTO { get => vendaDTO; set => vendaDTO = value; }
        public ProdutoDTO ProdutoDTO { get => produtoDTO; set => produtoDTO = value; }

        public ItensVendaDTO()
        {
            VendaDTO = new VendaDTO();
            ProdutoDTO = new ProdutoDTO();
        }
    }
}
