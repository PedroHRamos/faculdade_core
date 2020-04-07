using Feedback_facul.Service.Aluno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Feedback_facul.core.Controllers
{
    [RoutePrefix("aluno/")]
    public class AlunoController : ApiController
    {
        private readonly IAlunoService alunoService = new AlunoService();
        [Route("teste")]
        [HttpGet]
        public void SalvarAluno()
        {
            var nome = "Luan";
            var idade = DateTime.Parse("08-24-2000");
            var matricula = "01";
            alunoService.SalvarAluno(nome, idade, matricula);
        }
    }
}