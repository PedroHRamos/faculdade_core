using Feedback_facul.DTO;
using Feedback_facul.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.Service.UsuarioFolder
{
    public interface IUsuarioService
    {
        Usuario Obter(string username, string password);
        bool SalvarUsuario(UsuarioDTO usuario);
        UsuarioDTO ObterDetalhe(int id);
    }
}
