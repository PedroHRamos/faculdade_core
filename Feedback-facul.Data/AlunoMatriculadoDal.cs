using Feedback_facul.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.Data
{
    public class AlunoMatriculadoDal
    {
        public bool Incluir(AlunoMatriculado aluno) {
			try
			{
				using (var context = new glassDbEntities())
				{
					context.tb_aluno_matriculado.Add(aluno);
					context.SaveChanges();
					return true;
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
				
			}
        }
    }
}
