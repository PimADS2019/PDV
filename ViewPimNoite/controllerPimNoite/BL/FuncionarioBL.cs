using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelPimNoite.DTO;
using controllerPimNoite.DAO;

namespace controllerPimNoite.BL
{
    public class FuncionarioBL
    {
        public string mensagem;
        private static FuncionarioBL instance = null;

        private FuncionarioBL()
        {
        }

        public static FuncionarioBL getInstance()
        {
            if (instance == null)
            {
                instance = new FuncionarioBL();
            }

            return instance;
        }

        private void ValidarFuncionario(FuncionarioDTO funcionario)
        {
            if (funcionario.Nome.Length < 3)
            {
                this.mensagem = "Favor inserir o nome completo do funcionário.";
            }

            if ((funcionario.Cpf.Length < 11) || (funcionario.Cpf.Length > 14))
            {
                this.mensagem = "Favor verificar o campo CPF.";
            }

            if (funcionario.Usuario == "")
            {
                this.mensagem = "Campo usuário é obrigatório.";
            }

            if (funcionario.Senha == "")
            {
                this.mensagem = "Campo senha é obrigatório.";
            }

            if (funcionario.ConfSenha == "")
            {
                this.mensagem = "Favor confirmar a sua senha.";
            }

            if (funcionario.ConfSenha != funcionario.Senha)
            {
                this.mensagem = "Senha não coincide com Confirmação de Senha. Favor digitar novamente";
            }

            if ((funcionario.Cep.Length < 8) || (funcionario.Cep.Length > 9))
            {
                this.mensagem = "Favor verificar o campo CEP.";
            }
        }
        public void CadastrarFuncionario(FuncionarioDTO funcionario)
        {
            mensagem = "";
            ValidarFuncionario(funcionario);

            if (mensagem == "")
            {
                FuncionarioDAO.getInstance().CadastrarFuncionario(funcionario);
                this.mensagem = FuncionarioDAO.getInstance().mensagem;
            }
        }

        public List<FuncionarioDTO> ConsultarFuncionario(string nome)
        {
            return FuncionarioDAO.getInstance().ConsultarFuncionarioPorNome(nome);
        }

        public void ExcluirFuncionario(string idFuncionario)
        {
            FuncionarioDAO.getInstance().ExcluirFuncionario(Convert.ToInt32(idFuncionario));
            this.mensagem = FuncionarioDAO.getInstance().mensagem;
        }

        public void EditarFuncionario(FuncionarioDTO funcionario)
        {
            mensagem = "";
            ValidarFuncionario(funcionario);

            if (mensagem == "")
            {
                FuncionarioDAO.getInstance().EditarFuncionario(funcionario);
                this.mensagem = FuncionarioDAO.getInstance().mensagem;
            }
        }
    }
}
