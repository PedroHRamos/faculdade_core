using Feedback_facul.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.Data
{
    public class CursoDal
    {
		public IEnumerable<Curso> ObterTodos()
		{
			try
			{
				using (var context = new glassDbEntities())
				{
					IEnumerable<Curso> cursos = context.tb_curso.ToList();
					return cursos;
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
			}
		}

		public Curso Obter(int id)
		{
			try
			{
				using (var context = new glassDbEntities())
				{
					return context.tb_curso.Where(x => x.id == id).Single();
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
			}
		}
	}
}
