using Feedback_facul.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.Service.Aluno
{
    public interface IAlunoService
    {
        IEnumerable<AlunoMatriculadoDTO> ObterTodos();
        AlunoMatriculadoDTO Obter(int id);
        void Salvar(AlunoMatriculadoDTO aluno);
        AlunoMatriculadoDTO Editar(AlunoMatriculadoDTO aluno);
        bool Excluir(int id);
    }
}
