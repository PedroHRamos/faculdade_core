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
    
    public partial class tb_curso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_curso()
        {
            this.tb_aluno_matriculado = new HashSet<tb_aluno_matriculado>();
            this.tb_quesito = new HashSet<tb_quesito>();
        }
    
        public int id { get; set; }
        public string nome { get; set; }
        public string tipo_curso { get; set; }
        public string formacao { get; set; }
        public int quantidade_semestres { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_aluno_matriculado> tb_aluno_matriculado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_quesito> tb_quesito { get; set; }
    }
}