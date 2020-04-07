using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.Model.Alunos
{
    public class Aluno
    {
        [Key]
        public int AlunoID { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public DateTime Idade { get; set; }
    }
}
