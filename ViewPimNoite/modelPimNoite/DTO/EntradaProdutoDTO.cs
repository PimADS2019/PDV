using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelPimNoite.DTO
{
    public class EntradaProdutoDTO
    {
        private int codReferencia;
        private string produto;
        private string tamanho;
        private string fornecedor;
        private int quantidade;

        public int CodReferencia { get => codReferencia; set => codReferencia = value; }
        public string Produto { get => produto; set => produto = value; }
        public string Tamanho { get => tamanho; set => tamanho = value; }
        public string Fornecedor { get => fornecedor; set => fornecedor = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
    }
}
