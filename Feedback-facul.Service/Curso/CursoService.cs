using Feedback_facul.Data;
using Feedback_facul.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.Service.Curso
{
    public class CursoService : ICursoService
    {
        private readonly CursoDao cursoDal = new CursoDao();

        public IEnumerable<CursoDTO> ObterTodos() {
            var cursos = cursoDal.ObterTodos();
            return AutoMapper.Mapper.Map<IEnumerable<CursoDTO>>(cursos);
        }

        public CursoDTO Obter(int id)
        {
            var curso = cursoDal.Obter(id);
            return AutoMapper.Mapper.Map<CursoDTO>(curso);
        }
    }
}
