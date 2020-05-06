using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.DTO
{
    public class UsuarioDTO
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public System.DateTime nascimento { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public string username { get; set; }
        public string senha { get; set; }

    }
}
