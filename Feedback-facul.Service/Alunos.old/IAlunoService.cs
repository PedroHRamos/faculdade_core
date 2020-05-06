using Feedback_facul.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.Service.Alunos
{
    public interface IAlunoService
    {
        void SalvarAluno(AlunoMatriculadoDTO aluno);
    }
}
