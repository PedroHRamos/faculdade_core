using Feedback_facul.DTO;
using Feedback_facul.Service.Avaliacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Feedback_facul.core.Controllers
{
    [RoutePrefix("avaliacao")]
    public class AvaliacaoController : ApiController
    {
        private readonly IAvaliacaoService avaliacaoService = new AvaliacaoService();

        [HttpPost]
        public void SalvarAvaliacoes([FromBody] IEnumerable<AvaliacaoDTO> avaliacaoDTO)
        {
            avaliacaoService.SalvarAvaliacoes(avaliacaoDTO);
        }

    }
}