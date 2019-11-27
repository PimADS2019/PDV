using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelPimNoite.DTO
{
    public class VendaDTO
    {
        private int id;
        private int itens;
        private Double sbTotal;
        private Double desconto;
        private Double vlTotal;
        private DateTime dtCompra;
        private List<ItensVendaDTO> itensVendaDTO;
        private ProdutoDTO produtoDTO;

        public int Itens { get => itens; set => itens = value; }
        public double SbTotal { get => sbTotal; set => sbTotal = value; }
        public double Desconto { get => desconto; set => desconto = value; }
        public double VlTotal { get => vlTotal; set => vlTotal = value; }
        public DateTime DtCompra { get => dtCompra; set => dtCompra = value; }
        public List<ItensVendaDTO> ItensVendaDTO { get => itensVendaDTO; set => itensVendaDTO = value; }
        public int Id { get => id; set => id = value; }
        public ProdutoDTO ProdutoDTO { get => produtoDTO; set => produtoDTO = value; }

        public VendaDTO()
        {
            ProdutoDTO = new ProdutoDTO();
        }
    }
}
