using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.DTO
{
    public class AvaliacaoDTO
    {
        public int Id_usuario { get; set; }
        public int Id_instituicao { get; set; }
        public int Id_quesito { get; set; }
        public int Estrelas { get; set; }
        public string Comentario { get; set; }
        public DateTime Data_inicial { get; set; }
        public DateTime? Data_ultima_atualizacao { get; set; }
    }
}
