//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Feedback_facul.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class AlunoMatriculado
    {
        public int Usuario { get; set; }
        public int Instituicao { get; set; }
        public int Curso { get; set; }
    
        public virtual Curso tb_curso { get; set; }
        public virtual Instituicao tb_instituicao { get; set; }
        public virtual Usuario tb_usuario { get; set; }
    }
}
