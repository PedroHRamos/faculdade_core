using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.DTO
{
    public class QuesitoDTO
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public char situacao { get; set; }

    }
}
