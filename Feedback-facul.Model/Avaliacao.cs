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
    
    public partial class Avaliacao
    {
        public int id_quesito { get; set; }
        public int id_usuario { get; set; }
        public int id_instituicao { get; set; }
        public int estrelas { get; set; }
        public string comentario { get; set; }
        public System.DateTime data_inicial { get; set; }
        public Nullable<System.DateTime> data_ultima_atualizacao { get; set; }
    
        public virtual Instituicao tb_instituicao { get; set; }
        public virtual Quesito tb_quesito { get; set; }
        public virtual Usuario tb_usuario { get; set; }
    }
}
