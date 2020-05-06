using Feedback_facul.DTO;
using Feedback_facul.Service.Aluno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Feedback_facul.core.Controllers
{
    [RoutePrefix("aluno")]
    public class AlunoController : ApiController
    {
        private readonly IAlunoService _alunoService = new AlunoService();

        [Route("aluno")]
        [HttpPost]
        public void SalvarAluno([FromBody] AlunoMatriculadoDTO aluno)
        {
            _alunoService.SalvarAluno(aluno);
        }
    }
}
