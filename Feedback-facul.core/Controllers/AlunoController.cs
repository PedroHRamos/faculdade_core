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

        [HttpGet]
        public IEnumerable<AlunoMatriculadoDTO> ObterAlunos()
        {
            return _alunoService.ObterTodos();
        }

        [HttpGet]
        public AlunoMatriculadoDTO ObterAluno([FromUri] int id)
        {
            return _alunoService.Obter(id);
        }

        [HttpPost]
        public void SalvarAluno([FromBody] AlunoMatriculadoDTO aluno)
        {
            _alunoService.Salvar(aluno);
        }

        [HttpPut]
        public AlunoMatriculadoDTO EditarAluno([FromBody] AlunoMatriculadoDTO aluno)
        {
            return _alunoService.Editar(aluno);
        }

        [HttpDelete]
        public bool ExcluirAluno([FromUri] int id)
        {
            return _alunoService.Excluir(id);
        }
    }
}
