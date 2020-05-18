using Feedback_facul.DTO;
using Feedback_facul.Service.Curso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Feedback_facul.core.Controllers
{
    public class CursoController : ApiController
    {
        private readonly ICursoService _cursoService = new CursoService();

        public IEnumerable<CursoDTO> ObterTodos()
        {
            return View();
        }
    }
}