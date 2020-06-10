using Feedback_facul.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.Data
{
    public class UsuarioDao
    {
		public Usuario Obter(string email, string password)
		{
			try
			{
				using (var context = new glassDbEntities())
				{
					return context.tb_usuario.Where(x => x.email == email && x.senha == password).Single();
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
			}
		}

		public bool Incluir(Usuario usuario)
		{
			try
			{
				using (var context = new glassDbEntities())
				{
					context.tb_usuario.Add(usuario);
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
