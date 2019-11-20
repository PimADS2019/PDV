using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelPimNoite.DTO
{
    public class ProdutoDTO
    {
        private int codigo;
        private string produto;
        private string fabricante;
        private int codReferencia;
        private string tamanho;
        private double custo;
        private double precoVenda;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Produto { get => produto; set => produto = value; }
        public string Fabricante { get => fabricante; set => fabricante = value; }
        public int CodReferencia { get => codReferencia; set => codReferencia = value; }
        public string Tamanho { get => tamanho; set => tamanho = value; }
        public double Custo { get => custo; set => custo = value; }
        public double PrecoVenda { get => precoVenda; set => precoVenda = value; }
    }
}
