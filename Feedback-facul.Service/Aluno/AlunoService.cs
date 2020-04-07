using Feedback_facul.Data.Aluno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.Service.Aluno
{
    public class AlunoService : IAlunoService
    {
        private readonly AlunoContext alunoContext = new AlunoContext();
        public void SalvarAluno(string nome, DateTime idade, string matricula)
        {
            // Regra de negócio
            alunoContext.InsereAluno();
        }
    }
}
