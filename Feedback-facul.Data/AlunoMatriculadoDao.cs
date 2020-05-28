using Feedback_facul.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.Data
{
	public class AlunoMatriculadoDao
	{
		public IEnumerable<AlunoMatriculado> ObterTodos()
		{
			try
			{
				using (var context = new glassDbEntities())
				{
					IEnumerable<AlunoMatriculado> alunos = context.tb_aluno_matriculado.ToList();
					return alunos;
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
			}
		}

		public AlunoMatriculado Obter(int id)
		{
			try
			{
				using (var context = new glassDbEntities())
				{
					return context.tb_aluno_matriculado.Where(x => x.Usuario == id).Single();
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
			}
		}

		public bool Incluir(AlunoMatriculado aluno)
		{
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

		public AlunoMatriculado Editar(AlunoMatriculado aluno)
		{
			try
			{
				using (var context = new glassDbEntities())
				{
					var result = context.tb_aluno_matriculado.FirstOrDefault(x => x.Usuario == aluno.Usuario);
					result = aluno;
					context.SaveChanges();
					return result;
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
			}
		}

		public bool Excluir(int id)
		{
			try
			{
				using (var context = new glassDbEntities())
				{
					var aluno = context.tb_aluno_matriculado.Where(x => x.Usuario == id).Single();
					context.tb_aluno_matriculado.Remove(aluno);
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
