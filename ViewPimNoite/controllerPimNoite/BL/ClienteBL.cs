using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelPimNoite.DTO;
using controllerPimNoite.DAO;

namespace controllerPimNoite.BL
{
    public class ClienteBL
    {
        public string mensagem;
        private static ClienteBL instance = null;

        private ClienteBL()
        {
        }

        public static ClienteBL getInstance()
        {
            if (instance == null)
            {
                instance = new ClienteBL();
            }

            return instance;
        }

        private void ValidarCliente(ClienteDTO cliente)
        {
            if (cliente.Nome.Length < 3)
            {
                this.mensagem = "Favor inserir o nome completo do funcionário.";
            }

            if ((cliente.Cpf.Length < 11) || (cliente.Cpf.Length > 14))
            {
                this.mensagem = "Favor verificar o campo CPF.";
            }

            if ((cliente.Cep.Length < 8) || (cliente.Cep.Length > 9))
            {
                this.mensagem = "Favor verificar o campo CEP.";
            }
        }

        public void CadastrarCliente(ClienteDTO cliente)
        {
            mensagem = "";
            ValidarCliente(cliente);

            if (mensagem == "")
            {
                ClienteDAO.getInstance().CadastrarCliente(cliente);
                this.mensagem = ClienteDAO.getInstance().mensagem;
            }
        }

        public List<ClienteDTO> ConsultarCliente(string nome)
        {
            return ClienteDAO.getInstance().ConsultarCliente(nome);
        }

        public void ExcluirCliente(string idCliente)
        {
            try
            {
                ClienteDAO.getInstance().ExcluirCliente(Convert.ToInt32(idCliente));
                this.mensagem = ClienteDAO.getInstance().mensagem;
            }
            catch (Exception)
            {
                this.mensagem = "Id inválido";
            }
        }

        public void EditarCliente(ClienteDTO cliente)
        {
            mensagem = "";
            ValidarCliente(cliente);

            if (mensagem == "")
            {
                ClienteDAO.getInstance().EditarCliente(cliente);
                this.mensagem = ClienteDAO.getInstance().mensagem;
            }
        }
    }
}
