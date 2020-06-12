using Feedback_facul.DTO;
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

		public IEnumerable<AvaliacaoMediaDTO> MediaAvaliacoes(int idInstituicao)
		{

			List<AvaliacaoMediaDTO> avaliacoes = new List<AvaliacaoMediaDTO>();
			List<Quesito> quesitos = new List<Quesito>();
			QuesitoDao quesitoDao = new QuesitoDao();

			try
			{
				using (var context = new glassDbEntities())
				{

					quesitos = quesitoDao.ObterTodos().ToList();

					foreach (var quesito in quesitos)
					{
						var avaliacaoMedia = new AvaliacaoMediaDTO();
						avaliacaoMedia.id_quesito = quesito.id;
						avaliacaoMedia.media = context.tb_avaliacao.Average(c => c.id_instituicao);
						avaliacaoMedia.nome = context.tb_quesito.FirstOrDefault(x => x.id == quesito.id).nome;
						avaliacoes.Add(avaliacaoMedia);
					}

				}
			}
			catch(Exception ex)
			{
				throw new Exception(ex.ToString());
			}

			return avaliacoes;

		}

	}
}
