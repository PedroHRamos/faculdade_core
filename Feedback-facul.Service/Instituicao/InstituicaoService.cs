using Feedback_facul.Data;
using Feedback_facul.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.Service.Instituicao
{
    public class InstituicaoService : IInstituicaoService
    {
        private readonly InstituicaoDao instituicaoDao = new InstituicaoDao();

        public IEnumerable<InstituicaoDTO> ObterTodos()
        {
            var instituicoes = instituicaoDao.ObterTodos();
            return AutoMapper.Mapper.Map<IEnumerable<InstituicaoDTO>>(instituicoes);
        }

        public InstituicaoDTO Obter(int id)
        {
            var instituicao = instituicaoDao.Obter(id);
            return AutoMapper.Mapper.Map<InstituicaoDTO>(instituicao);
        }
    }
}
