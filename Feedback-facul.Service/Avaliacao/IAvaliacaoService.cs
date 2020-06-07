using Feedback_facul.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.Service.Avaliacao
{
    public interface IAvaliacaoService
    {

        string SalvarAvaliacoes(IEnumerable<AvaliacaoDTO> avaliacoes);

    }
}
