//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QL.data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tuyenbay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tuyenbay()
        {
            this.CTchuyenbays = new HashSet<CTchuyenbay>();
        }
    
        public string MaTB { get; set; }
        public string SBdi { get; set; }
        public string SBden { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTchuyenbay> CTchuyenbays { get; set; }
        public virtual Sanbay Sanbay { get; set; }
        public virtual Sanbay Sanbay1 { get; set; }
    }
}
