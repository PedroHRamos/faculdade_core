using Feedback_facul.Data;
using Feedback_facul.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.Service.Quesito
{
    public class QuesitoService : IQuesitoService
    {
        private readonly QuesitoDao quesitoDao = new QuesitoDao();
        public QuesitoDTO ObterPorInstituicao(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<QuesitoDTO> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
