using Feedback_facul.DTO;
using Feedback_facul.Service.Curso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Feedback_facul.core.Controllers
{
    [RoutePrefix("curso")]
    public class CursoController : ApiController
    {
        private readonly ICursoService _cursoService = new CursoService();

        //public IEnumerable<CursoDTO> ObterTodos()
        //{
        //    return View();
        //}

        [HttpGet]
        [Authorize]
        public CursoDTO Obter([FromUri] int id)
        {
            return _cursoService.Obter(id);
        }
    }
}