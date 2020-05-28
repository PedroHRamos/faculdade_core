using Feedback_facul.Data;
using Feedback_facul.DTO;
using Feedback_facul.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.Service.Aluno
{
    public class AlunoService : IAlunoService
    {
        private readonly AlunoMatriculadoDao alunoDal = new AlunoMatriculadoDao();

        public IEnumerable<AlunoMatriculadoDTO> ObterTodos()
        {
            var alunos = alunoDal.ObterTodos();
            return AutoMapper.Mapper.Map<IEnumerable<AlunoMatriculadoDTO>>(alunos);
        }

        public AlunoMatriculadoDTO Obter(int id)
        {
            var aluno = alunoDal.Obter(id);
            return AutoMapper.Mapper.Map<AlunoMatriculadoDTO>(aluno);
        }

        public void Salvar(AlunoMatriculadoDTO aluno)
        {
            var alunoMapeado = AutoMapper.Mapper.Map<AlunoMatriculado>(aluno);
            // Regra de negócio
            alunoDal.Incluir(alunoMapeado);
        }

        public AlunoMatriculadoDTO Editar(AlunoMatriculadoDTO aluno)
        {
            var alunoMapeado = AutoMapper.Mapper.Map<AlunoMatriculado>(aluno);
            var alunoDto = alunoDal.Editar(alunoMapeado);
            return AutoMapper.Mapper.Map<AlunoMatriculadoDTO>(alunoDto);
        }

        public bool Excluir(int id)
        {
            return alunoDal.Excluir(id);
        }
    }
}
