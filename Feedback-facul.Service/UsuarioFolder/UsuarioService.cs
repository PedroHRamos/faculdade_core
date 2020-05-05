using Feedback_facul.DTO;
using Feedback_facul.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Feedback_facul.Model;

namespace Feedback_facul.Service.UsuarioFolder
{
    class UsuarioService : IUsuarioService
    {

        private readonly UsuarioDao usuarioDao = new UsuarioDao();

        public string SalvarUsuario(UsuarioDTO usuario)
        {
            try
            {
                Usuario usuarioTemp = new Usuario();
                //AlunoMatriculado aluno = new AlunoMatriculado();
                //aluno.id_usuario = usuario;
                //aluno.id_instituicao = instituicao;
                //aluno.id_curso = curso;
                var usuarioMapeado = AutoMapper.Mapper.Map<Model.Usuario>(usuario);
                // Regra de negócio
                usuarioDao.Incluir(usuarioMapeado);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return "";
        }
    }
}
