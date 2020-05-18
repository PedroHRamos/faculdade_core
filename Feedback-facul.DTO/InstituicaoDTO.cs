using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.DTO
{
    public class InstituicaoDTO
    {
        public int? Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string Bairro { get; set; }

        public string Rua { get; set; }

        public string Campus { get; set; }
    }
}
