using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Feedback_facul.DTO;
using System.Web.Http;
using Feedback_facul.Service.QuesitoServ;

namespace Feedback_facul.core.Controllers
{
    [RoutePrefix("quesito")]
    public class QuesitoController : ApiController
    {

        private readonly IQuesitoService quesitoService = new QuesitoService();

        [HttpGet]
        public QuesitoDTO Obter([FromUri] int id)
        {
            return quesitoService.Obter(id);
        }

        [HttpGet]
        public IEnumerable<QuesitoDTO> ObterTodos()
        {
            return quesitoService.ObterTodos();
        }
    }
}