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
    
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.tb_aluno_matriculado = new HashSet<AlunoMatriculado>();
            this.tb_avaliacao = new HashSet<Avaliacao>();
        }
    
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public System.DateTime nascimento { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public string tipo_usuario { get; set; }
        public string username { get; set; }
        public string senha { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlunoMatriculado> tb_aluno_matriculado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Avaliacao> tb_avaliacao { get; set; }
    }
}
