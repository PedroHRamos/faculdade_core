using Feedback_facul.DTO;
using Feedback_facul.Service.Instituicao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Feedback_facul.core.Controllers
{
    [RoutePrefix("instituicao")]
    public class InstituicaoController : ApiController
    {
        private readonly IInstituicaoService _instituicaoService = new InstituicaoService();

        [HttpGet]
        public InstituicaoDTO Obter([FromUri] int id)
        {
            return _instituicaoService.Obter(id);
        }

        [HttpGet]
        public IEnumerable<InstituicaoDTO> ObterTodos()
        {
            return _instituicaoService.ObterTodos();
        }
    }
}