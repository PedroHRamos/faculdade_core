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
    
    public partial class tb_consistencia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_consistencia()
        {
            this.tb_categoria = new HashSet<tb_categoria>();
        }
    
        public int id { get; set; }
        public int consistencia_cod { get; set; }
        public string descricao { get; set; }
        public string situacao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_categoria> tb_categoria { get; set; }
    }
}
