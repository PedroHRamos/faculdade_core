using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Feedback_facul.DTO;
using Feedback_facul.Service.UsuarioFolder;

namespace Feedback_facul.core.Controllers
{
    [RoutePrefix("usuario")]
    public class UsuarioController: ApiController
    {

        private readonly IUsuarioService usuarioService = new UsuarioService();

        [Route("usuario")]
        [HttpPost]
        public void SalvarAluno([FromBody] UsuarioDTO usuario)
        {
            usuarioService.SalvarUsuario(usuario);
        }
    }
}