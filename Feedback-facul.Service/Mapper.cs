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
                cfg.CreateMap<AlunoMatriculadoDTO, AlunoMatriculado>()
                    .ForMember(vm => vm.Usuario, map => map.MapFrom(m => m.Usuario))
                    .ForMember(vm => vm.Curso, map => map.MapFrom(m => m.Curso))
                    .ForMember(vm => vm.Instituicao, map => map.MapFrom(m => m.Instituicao));
                cfg.CreateMap<AlunoMatriculado, AlunoMatriculadoDTO>()
                    .ForMember(m => m.Usuario, map => map.MapFrom(vm => vm.Usuario))
                    .ForMember(m => m.Curso, map => map.MapFrom(vm => vm.Curso))
                    .ForMember(m => m.Instituicao, map => map.MapFrom(vm => vm.Instituicao));
            });
        }
    }
}
