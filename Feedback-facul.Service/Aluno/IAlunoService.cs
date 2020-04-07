using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.Service.Aluno
{
    public interface IAlunoService
    {
        void SalvarAluno(string nome, DateTime idade, string matricula);
    }
}
