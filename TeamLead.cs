//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Releasemanagment
{
    using System;
    using System.Collections.Generic;
    
    public partial class TeamLead
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TeamLead()
        {
            this.Developers = new HashSet<Developer>();
            this.Modules = new HashSet<Module>();
        }
    
        public int TeamLead_id { get; set; }
        public string TeamLead_name { get; set; }
        public Nullable<int> Project_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Developer> Developers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Module> Modules { get; set; }
        public virtual Project Project { get; set; }
    }
}