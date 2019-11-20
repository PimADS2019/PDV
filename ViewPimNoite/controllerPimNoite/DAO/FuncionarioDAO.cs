using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelPimNoite.DTO;

namespace controllerPimNoite.DAO
{
    public class FuncionarioDAO
    {
        public string mensagem;
        private static FuncionarioDAO instance = null;

        private FuncionarioDAO()
        {
        }

        public static FuncionarioDAO getInstance()
        {
            if (instance == null)
            {
                instance = new FuncionarioDAO();
            }

            return instance;
        }

        public void CadastrarFuncionario(FuncionarioDTO funcionario)
        {
            this.mensagem = "funcionario cadastrado com sucesso";
        }

        public List<FuncionarioDTO> ConsultarFuncionarioPorNome(string nome)
        {
            //id, usuario, nome, telefone, cargo
            return null;
        }

        public void ExcluirFuncionario(int idFuncionario)
        {
            this.mensagem = "Excluido com sucesso";
        }

        public void EditarFuncionario(FuncionarioDTO funcionario)
        {
            this.mensagem = "Funcionario editado com sucesso";
        }
    }
}
