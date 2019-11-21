using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelPimNoite.DTO;
using controllerPimNoite.BL;

namespace controllerPimNoite.Controller
{
    public class Controller
    {
        private static Controller instance = null;
        public string mensagem;

        private Controller()
        {
        }

        public static Controller getInstance()
        {
            if (instance == null)
            {
                instance = new Controller();
            }

            return instance;
        }

        //Login
        public String ValidarUsuario(UsuarioDTO usuario)
        {
            return UsuarioBL.getInstance().ValidarUsuario(usuario);
        }
        
        //Funcionarios
        public void CadastrarFuncionario(FuncionarioDTO funcionario)
        {
            FuncionarioBL.getInstance().CadastrarFuncionario(funcionario);
            this.mensagem = FuncionarioBL.getInstance().mensagem;
        }

        public List<FuncionarioDTO> ConsultarFuncionarioPorNome(string nome)
        {
            return FuncionarioBL.getInstance().ConsultarFuncionario(nome);
        }

        public void ExcluirFuncionario(string idFuncionario)
        {
            FuncionarioBL.getInstance().ExcluirFuncionario(idFuncionario);
            this.mensagem = FuncionarioBL.getInstance().mensagem;
        }

        public void EditarFuncionario(FuncionarioDTO funcionario)
        {
            FuncionarioBL.getInstance().EditarFuncionario(funcionario);
            this.mensagem = FuncionarioBL.getInstance().mensagem;
        }

        //Clientes
        public void CadastrarCliente(ClienteDTO cliente)
        {
            ClienteBL.getInstance().CadastrarCliente(cliente);
            this.mensagem = ClienteBL.getInstance().mensagem;
        }

        public List<ClienteDTO> ConsultarCliente(string nome)
        {
            return ClienteBL.getInstance().ConsultarCliente(nome);
        }

        public void ExcluirCliente(string idCliente)
        {
            ClienteBL.getInstance().ExcluirCliente(idCliente);
            this.mensagem = ClienteBL.getInstance().mensagem;
        }

        public void EditarCliente(ClienteDTO cliente)
        {
            ClienteBL.getInstance().EditarCliente(cliente);
            this.mensagem = ClienteBL.getInstance().mensagem;
        }
        //Produtos
        public void CadastrarProduto(ProdutoDTO produto)
        {
            ProdutoBL.getInstance().CadastrarProduto(produto);
            this.mensagem = ProdutoBL.getInstance().mensagem;
        }

        public List<ClienteDTO> ConsultarProduto(string produto)
        {
            return ClienteBL.getInstance().ConsultarCliente(produto);
        }

        public void ExcluirProduto(string idProduto)
        {
            ProdutoBL.getInstance().ExcluirProduto(idProduto);
            this.mensagem = ProdutoBL.getInstance().mensagem;
        }

        public void EditarProduto(ProdutoDTO produto)
        {
            ProdutoBL.getInstance().EditarProduto(produto);
            this.mensagem = ProdutoBL.getInstance().mensagem;
        }

        //Estoque
        public List<ProdutoDTO> ConsultarEstoque(string estoque)
        {
            return ProdutoBL.getInstance().ConsultarEstoque(estoque);
        }

        public ProdutoDTO ColetaDadosEstoque(string codReferencia)
        {
            ProdutoDTO produto = ProdutoBL.getInstance().ColetaDadosEstoque(codReferencia);

            if(produto == null)
            {
                this.mensagem = ProdutoBL.getInstance().mensagem;
                return null;
            }

            return produto;
        }

        public void AcrescentarQuantidadeEstoque(ProdutoDTO produto, string quantidade)
        {
            ProdutoBL.getInstance().AcrescentarQuantidadeEstoque(produto, quantidade);
            this.mensagem = ProdutoBL.getInstance().mensagem;
        }

        //Vendas
        public List<ProdutoDTO> ChecarVendaProduto(string produto)
        {
            return VendaBL.getInstance().ChecarVendaProduto(produto);
        }

        public VendaDTO CalculosVenda(List<int> qtdProdutos, string quantidade, ProdutoDTO produtoDTO)
        {
            return VendaBL.getInstance().CalculosVenda(qtdProdutos, quantidade, produtoDTO);
        }

        public void SalvarVenda(VendaDTO venda)
        {
            VendaBL.getInstance().SalvarVenda(venda);
            this.mensagem = VendaBL.getInstance().mensagem;
        }
    }
}
