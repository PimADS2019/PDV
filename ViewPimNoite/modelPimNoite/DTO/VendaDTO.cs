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
        private List<ProdutoDTO> produtosDTO;

        public int Itens { get => itens; set => itens = value; }
        public double SbTotal { get => sbTotal; set => sbTotal = value; }
        public double Desconto { get => desconto; set => desconto = value; }
        public double VlTotal { get => vlTotal; set => vlTotal = value; }
        public List<ProdutoDTO> ProdutosDTO { get => produtosDTO; set => produtosDTO = value; }
    }
}
