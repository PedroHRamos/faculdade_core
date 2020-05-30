using Feedback_facul.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.Service.Instituicao
{
    public interface IInstituicaoService
    {
        IEnumerable<InstituicaoDTO> ObterTodos();
        InstituicaoDTO Obter(int id);
    }
}
