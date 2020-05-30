using Feedback_facul.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.Data
{
    public class InstituicaoDao
    {
		public IEnumerable<Instituicao> ObterTodos()
		{
			try
			{
				using (var context = new glassDbEntities())
				{
					IEnumerable<Instituicao> instituicoes = context.tb_instituicao.ToList();
					return instituicoes;
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
			}
		}

		public Instituicao Obter(int id)
		{
			try
			{
				using (var context = new glassDbEntities())
				{
					return context.tb_instituicao.Where(x => x.id == id).Single();
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
			}
		}
	}
}
