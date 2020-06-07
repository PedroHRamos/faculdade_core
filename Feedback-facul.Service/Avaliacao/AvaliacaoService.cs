using Feedback_facul.Data;
using Feedback_facul.DTO;
using Feedback_facul.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.Service.Avaliacao
{
    public class AvaliacaoService : IAvaliacaoService
    {
        private readonly AvaliacaoDao avaliacaoDao = new AvaliacaoDao();
        public string SalvarAvaliacoes(IEnumerable<AvaliacaoDTO> avaliacoesDTO)
        {

            try
            {
                
                foreach (AvaliacaoDTO avaliacaoDTO in avaliacoesDTO)
                {
                    if (avaliacaoDTO.Estrelas != 0 && avaliacaoDTO.Estrelas != null)
                    {
                        InsereUmaAvaliacao(avaliacaoDTO);
                    }
                }

          
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return "";
        }

        private void InsereUmaAvaliacao(AvaliacaoDTO avaliacaoDTO)
        {
            avaliacaoDTO.Data_inicial = DateTime.Now;
            avaliacaoDTO.Data_ultima_atualizacao = DateTime.Now;
            avaliacaoDTO.Comentario = " ";

            //O mapper vai mapear o usuario que veio da tela para o que vai ser salvo no BD
            Model.Avaliacao avaliacaoMapeada = AutoMapper.Mapper.Map<Model.Avaliacao>(avaliacaoDTO);
            // Regra de negócio

            if (avaliacaoDTO.Estrelas == null || avaliacaoDTO.Estrelas == 0)
            {
                throw new System.ArgumentException("Parâmetro Inválido", "Estrelas");
            }

            if (avaliacaoDTO.Id_instituicao == null || avaliacaoDTO.Id_instituicao == 0)
            {
                throw new System.ArgumentException("Parâmetro Inválido", "Instituicao");
            }

            if (avaliacaoDTO.Id_quesito == null || avaliacaoDTO.Id_quesito == 0)
            {
                throw new System.ArgumentException("Parâmetro Inválido", "Quesito");
            }

            if (avaliacaoDTO.Id_usuario == null || avaliacaoDTO.Id_usuario == 0)
            {
                throw new System.ArgumentException("Parâmetro Inválido", "Usuario");
            }

            avaliacaoDao.Incluir(avaliacaoMapeada);
        }
    }

}
