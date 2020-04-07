using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Feedback_facul.Model.Alunos;

namespace Feedback_facul.Data.Alunos
{
    public class AlunoContext
    {
        private ModelContext dbContext = new ModelContext();
        public void InsereAluno()
        {
            try
            {
                var aluno = new Aluno
                {
                    Nome = "Luan",
                    Idade = DateTime.Parse("2020-05-08"),
                    Matricula = "01"
                };
                dbContext.Alunos.Add(aluno);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
