using Feedback_facul.DTO;
using Feedback_facul.Service.Avaliacao;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Owin;

namespace Feedback_facul.core.Controllers
{
    [RoutePrefix("avaliacao")]
    public class AvaliacaoController : ApiController
    {
        private readonly IAvaliacaoService avaliacaoService = new AvaliacaoService();

        [HttpPost]
        [Authorize]
        public void SalvarAvaliacoes([FromBody] IEnumerable<AvaliacaoDTO> avaliacaoDTO)
        {
            IOwinContext ctx = HttpContext.Current.GetOwinContext();
            string id = ctx.Authentication.User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
            avaliacaoService.SalvarAvaliacoes(avaliacaoDTO);
        }

    }
}