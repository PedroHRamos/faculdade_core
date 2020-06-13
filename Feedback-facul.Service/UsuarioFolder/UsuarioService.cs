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
    public class UsuarioService : IUsuarioService
    {

        private readonly UsuarioDao usuarioDao = new UsuarioDao();

        public Usuario Obter(string email, string password)
        {
            return usuarioDao.Obter(email, password);
        }

        public UsuarioDTO ObterDetalhe(int id)
        {
            return AutoMapper.Mapper.Map<UsuarioDTO>(usuarioDao.Obter(id));
        }

        public bool SalvarUsuario(UsuarioDTO usuario)
        {

            try
            {
                //O mapper vai mapear o usuario que veio da tela para o que vai ser salvo no BD
                Usuario usuarioMapeado = AutoMapper.Mapper.Map<Usuario>(usuario);
                // Regra de negócio


                if (String.IsNullOrEmpty(usuario.nome))
                {
                    throw new System.ArgumentException("Parâmetro Inválido", "nome");
                }

                if (String.IsNullOrEmpty(usuario.cpf))
                {
                    throw new System.ArgumentException("Parâmetro Inválido", "cpf");
                }

                if (usuario.nascimento == null || usuario.nascimento > DateTime.Now)
                {
                    throw new System.ArgumentException("Parâmetro Inválido", "nascimento");
                }

                if (String.IsNullOrEmpty(usuario.username))
                {
                    throw new System.ArgumentException("Parâmetro Inválido", "username");
                }

                if (String.IsNullOrEmpty(usuario.senha))
                {
                    throw new System.ArgumentException("Parâmetro Inválido", "senha");
                }

                if (String.IsNullOrEmpty(usuario.estado))
                {
                    throw new System.ArgumentException("Parâmetro Inválido", "username");
                }

                if (String.IsNullOrEmpty(usuario.cidade))
                {
                    throw new System.ArgumentException("Parâmetro Inválido", "senha");
                }


                return usuarioDao.Incluir(usuarioMapeado);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
