//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BPPS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class departments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public departments()
        {
            this.departments1 = new HashSet<departments>();
            this.Projects = new HashSet<Projects>();
        }
    
        public int department_id { get; set; }
        public Nullable<int> location_id { get; set; }
        public string name { get; set; }
        public Nullable<int> dep_department_id { get; set; }
    
        public virtual locations locations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<departments> departments1 { get; set; }
        public virtual departments departments2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Projects> Projects { get; set; }
    }
}