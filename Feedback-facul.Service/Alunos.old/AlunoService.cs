using Feedback_facul.Data;
using Feedback_facul.DTO;
using Feedback_facul.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.Service.Alunos
{
    public class AlunoService : IAlunoService
    {
        private readonly AlunoMatriculadoDal alunoDal = new AlunoMatriculadoDal();
        public void SalvarAluno(AlunoMatriculadoDTO aluno)
        {
            //AlunoMatriculado aluno = new AlunoMatriculado();
            //aluno.id_usuario = usuario;
            //aluno.id_instituicao = instituicao;
            //aluno.id_curso = curso;
            var alunoMapeado = AutoMapper.Mapper.Map<AlunoMatriculado>(aluno);
            // Regra de negócio
            alunoDal.Incluir(alunoMapeado);
        }
    }
}
