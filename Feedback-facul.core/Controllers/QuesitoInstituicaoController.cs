using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Feedback_facul.DTO;

namespace Feedback_facul.core.Controllers
{
    [RoutePrefix("instituicao")]
    public class QuesitoInstituicaoController { 

    //private readonly IUsuarioService usuarioService = new UsuarioService();

    [HttpPost]
    public void ObterQuesitoPraInstituicaoAtual([FromBody] UsuarioDTO usuario)
    {
        //usuarioService.SalvarUsuario(usuario);
    }

    [HttpPost]
    public IEnumerable<QuesitoInstituicao> ObterListaQuesitoInstituicao(int id)
    {
        List<QuesitoInstituicao> quesitoInstituicoes = new List<QuesitoInstituicao>();
        return quesitoInstituicoes;
    }

    private IEnumerable<QuesitoInstituicao> BuscaQuesitoInstituicao()
    {
        List<QuesitoInstituicao> quesitoInstituicoes = new List<QuesitoInstituicao>();



        return quesitoInstituicoes;
    }


    }
}