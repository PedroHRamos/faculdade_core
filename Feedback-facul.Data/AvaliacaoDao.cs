using Feedback_facul.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.Data
{
    public class AvaliacaoDao
    {

		public bool Incluir(Avaliacao avaliaco)
		{
			try
			{
				using (var context = new glassDbEntities())
				{
					context.tb_avaliacao.Add(avaliaco);
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
