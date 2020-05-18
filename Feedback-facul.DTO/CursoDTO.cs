using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.DTO
{
    public class CursoDTO
    {
        public int? Id { get; set; }

        public string Nome { get; set; }

        public char TipoCurso { get; set; }

        public char Formacao { get; set; }

        public int QuantidadeSemestres { get; set; }
    }
}
