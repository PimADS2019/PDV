using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelPimNoite.DTO
{
    public class PedidoDTO
    {
        private int codigo;
        private int qt;
        private ProdutoDTO produto;
        private Double desconto;

        public int Codigo { get => codigo; set => codigo = value; }
        public int Qt { get => qt; set => qt = value; }
        public ProdutoDTO Produto{ get => produto; set => produto= value; }
        public Double Desconto { get => desconto; set => desconto = value; }
    }
}
