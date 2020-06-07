using Feedback_facul.Data;
using Feedback_facul.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.Service.QuesitoServ
{
    public class QuesitoService: IQuesitoService
    {
        private readonly QuesitoDao quesitoDao = new QuesitoDao();

        public IEnumerable<QuesitoDTO> ObterTodos()
        {
            var quesitos = quesitoDao.ObterTodos();
            return AutoMapper.Mapper.Map<IEnumerable<QuesitoDTO>>(quesitos);
        }

        public QuesitoDTO Obter(int id)
        {
            var quesito = quesitoDao.Obter(id);
            return AutoMapper.Mapper.Map<QuesitoDTO>(quesito);
        }
    }
}
