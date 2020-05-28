using Feedback_facul.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.Service.Curso
{
    public interface ICursoService
    {
        IEnumerable<CursoDTO> ObterTodos();
        CursoDTO Obter(int id);
    }
}
