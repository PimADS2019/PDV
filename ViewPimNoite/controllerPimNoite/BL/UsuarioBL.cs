using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelPimNoite.DTO;
using controllerPimNoite.DAO;

namespace controllerPimNoite.BL
{
    public class UsuarioBL
    {
        private string mensagem;
        private static UsuarioBL instance = null;

        private UsuarioBL()
        {
        }

        public static UsuarioBL getInstance()
        {
            if (instance == null)
            {
                instance = new UsuarioBL();
            }

            return instance;
        }

        public string ValidarUsuario(UsuarioDTO usuario)
        {
            mensagem = "";

            if ((usuario.Usuario == "") || (usuario.Senha == ""))
            {
                return mensagem = "Usuário ou senha não foi digitado, favor inserir Usuário e senha.";
            }

            if (UsuarioDAO.GetInstance().ValidarUsuario(usuario) == false)
            {
                return mensagem = "Usuario ou senha incorreto.";
            }

            return mensagem = "";
        }
    }
}
