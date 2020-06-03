using AutoMapper;
using Feedback_facul.DTO;
using Feedback_facul.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_facul.Service
{
    public static class Mapper
    {
        //public Mapper()
        //{
        //    CreateMap<AlunoMatriculadoDTO, AlunoMatriculado>()
        //        .ForMember(vm => vm.Usuario, map => map.MapFrom(m => m.Usuario))
        //        .ForMember(vm => vm.Curso, map => map.MapFrom(m => m.Curso))
        //        .ForMember(vm => vm.Instituicao, map => map.MapFrom(m => m.Instituicao));
        //    CreateMap<AlunoMatriculado, AlunoMatriculadoDTO>()
        //        .ForMember(m => m.Usuario, map => map.MapFrom(vm => vm.Usuario))
        //        .ForMember(m => m.Curso, map => map.MapFrom(vm => vm.Curso))
        //        .ForMember(m => m.Instituicao, map => map.MapFrom(vm => vm.Instituicao));
        //}
        public static void Configurar()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                /*cfg.CreateMap<AlunoMatriculadoDTO, AlunoMatriculado>()
                    .ForMember(vm => vm.tb_usuario.id, map => map.MapFrom(m => m.Usuario))
                    .ForMember(vm => vm.tb_curso.id, map => map.MapFrom(m => m.Curso))
                    .ForMember(vm => vm.tb_instituicao.id, map => map.MapFrom(m => m.Instituicao));
                cfg.CreateMap<AlunoMatriculado, AlunoMatriculadoDTO>()
                    .ForMember(m => m.Usuario, map => map.MapFrom(vm => vm.tb_usuario.id))
                    .ForMember(m => m.Curso, map => map.MapFrom(vm => vm.tb_curso.id))
                    .ForMember(m => m.Instituicao, map => map.MapFrom(vm => vm.tb_instituicao.id));*/


                cfg.CreateMap<UsuarioDTO, Usuario>()
                    .ForMember(vm => vm.nome, map => map.MapFrom(m => m.nome))
                    .ForMember(vm => vm.cpf, map => map.MapFrom(m => m.cpf))
                    .ForMember(vm => vm.nascimento, map => map.MapFrom(m => m.nascimento))
                    .ForMember(vm => vm.estado, map => map.MapFrom(m => m.estado))
                    .ForMember(vm => vm.cidade, map => map.MapFrom(m => m.cidade))
                    .ForMember(vm => vm.username, map => map.MapFrom(m => m.username))
                    .ForMember(vm => vm.email, map => map.MapFrom(m => m.email))
                    .ForMember(vm => vm.senha, map => map.MapFrom(m => m.senha));

                cfg.CreateMap<Usuario, UsuarioDTO>()
                    .ForMember(m => m.nome, map => map.MapFrom(vm => vm.nome))
                    .ForMember(m => m.cpf, map => map.MapFrom(vm => vm.cpf))
                    .ForMember(m => m.nascimento, map => map.MapFrom(vm => vm.nascimento))
                    .ForMember(m => m.estado, map => map.MapFrom(vm => vm.estado))
                    .ForMember(m => m.cidade, map => map.MapFrom(vm => vm.cidade))
                    .ForMember(m => m.username, map => map.MapFrom(vm => vm.username))
                    .ForMember(m => m.email, map => map.MapFrom(vm => vm.email))
                    .ForMember(m => m.senha, map => map.MapFrom(vm => vm.senha));

                cfg.CreateMap<AlunoMatriculado, AlunoMatriculadoDTO>()
                    .ForMember(m => m.Usuario, map => map.MapFrom(vm => vm.Usuario))
                    .ForMember(m => m.Curso, map => map.MapFrom(vm => vm.Curso))
                    .ForMember(m => m.Instituicao, map => map.MapFrom(vm => vm.Instituicao));

                cfg.CreateMap<AlunoMatriculadoDTO, AlunoMatriculado>()
                    .ForMember(m => m.Usuario, map => map.MapFrom(vm => vm.Usuario))
                    .ForMember(m => m.Curso, map => map.MapFrom(vm => vm.Curso))
                    .ForMember(m => m.Instituicao, map => map.MapFrom(vm => vm.Instituicao));

                cfg.CreateMap<InstituicaoDTO, Model.Instituicao>();

                cfg.CreateMap<Model.Instituicao, InstituicaoDTO>();
            });
        }
    }
}
