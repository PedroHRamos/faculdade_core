using Feedback_facul.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.Data
{
    public class QuesitoDao
    {

		public IEnumerable<Quesito> ObterTodos()
		{
			try
			{
				using (var context = new glassDbEntities())
				{
					IEnumerable<Quesito> quesitos = context.tb_quesito.ToList();
					return quesitos;
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
			}
		}

		public Quesito Obter(int id)
		{
			try
			{
				using (var context = new glassDbEntities())
				{
					return context.tb_quesito.Where(x => x.id == id).Single();
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
			}
		}

	}
}
