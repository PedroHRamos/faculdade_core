using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.Data.Aluno
{
    public class AlunoContext
    {
        private ModelContext dbContext = new ModelContext();
        public void InsereAluno()
        {
            try
            {
                var aluno = new Feedback_facul.Model.Aluno.Aluno();
                aluno.Nome = "Luan";
                aluno.Idade = DateTime.Parse("08-24-1997");
                aluno.Matricula = "01";
                dbContext.Alunos.Add(aluno);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
