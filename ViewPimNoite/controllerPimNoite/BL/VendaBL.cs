using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelPimNoite.DTO;
using controllerPimNoite.DAO;

namespace controllerPimNoite.BL
{
    public class VendaBL
    {
        public string mensagem;
        private int codReferencia;
        private int qtdVenda;
        private ProdutoDTO produtoDTO;
        VendaDTO vendaDTO = new VendaDTO();
        private int idVenda;

        private static VendaBL instance = null;
        
        private VendaBL()
        {
        }

        public static VendaBL getInstance()
        {
            if (instance == null)
            {
                instance = new VendaBL();
            }

            return instance;
        }

        public List<VendaDTO> ConsultarVendas()
        {
            return VendaDAO.getInstance().ConsultarVendas();
        }

        public List<ProdutoDTO> ChecarVendaProduto(string produto)
        {
            try
            {
                this.codReferencia = Convert.ToInt32(produto);
                return ChecarVendaProduto(codReferencia);
            }
            catch (Exception)
            {
                produtoDTO.Produto = produto;
                return ChecarVendaProduto(produtoDTO);
            }
        }

        private List<ProdutoDTO> ChecarVendaProduto(ProdutoDTO produto)
        {
            return VendaDAO.getInstance().ChecarProdutoNome(produto);
        }

        private List<ProdutoDTO> ChecarVendaProduto(int CodReferencia)
        {
            return VendaDAO.getInstance().ChecarProdutoId(codReferencia);
        }

        public VendaDTO CalculosVenda(List<ItensVendaDTO> listProdutos, string qtdVendida, ProdutoDTO produtos)
        {
            
            //Calculando o subTotal
            try
            {
                qtdVenda = Convert.ToInt32(qtdVendida);
            }
            catch (Exception)
            {
                this.mensagem = "Quantidade inválida";
            }
            
            vendaDTO.SbTotal += produtos.PrecoVenda * qtdVenda;

            ItensVendaDTO itensPedido = null;
            //Preenchendo o ItensVendaDTO com as informações
            int i = 0;
            while (i <=listProdutos.Count())
            {
                itensPedido = new ItensVendaDTO();
                itensPedido.Quantidade = qtdVenda;
                itensPedido.ProdutoDTO = produtos;
                i++;
            }

            //Quantidade de itens
            vendaDTO.Itens = listProdutos.Count();
            
            //Registrando data da compra
            vendaDTO.DtCompra = DateTime.Now;

            //Descontos
            if (vendaDTO.SbTotal > 150)
            {
                vendaDTO.Desconto = 0.05;
            }

            if (vendaDTO.SbTotal > 300)
            {
                vendaDTO.Desconto = 0.10;
            }

            if (vendaDTO.Desconto == 0)
            {
                vendaDTO.VlTotal = vendaDTO.SbTotal;
            }
            else
            {
                vendaDTO.VlTotal = Math.Round(vendaDTO.SbTotal - (vendaDTO.SbTotal * vendaDTO.Desconto), 2);
            }

            //Atribuindo a lista preenchida ao VendaDTO
            vendaDTO.ItensVendaDTO = listProdutos;

            return vendaDTO;
        }

        public void SalvarVenda(VendaDTO venda, int idFuncionario)
        {
            this.idVenda = VendaDAO.getInstance().SalvarVenda(venda, idFuncionario);
            
            foreach(ItensVendaDTO itens in venda.ItensVendaDTO)
            {
                ItensVendaDAO.getInstance().RegistrarItensVendidos(itens.ProdutoDTO.IdProduto, itens.Quantidade, this.idVenda);
            }

            this.mensagem = ItensVendaDAO.getInstance().mensagem;
        }
    }
}
