//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasyHealthCareDataStore
{
    using System;
    using System.Collections.Generic;
    
    public partial class hospitalSpeciality
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hospitalSpeciality()
        {
            this.hospital_manual = new HashSet<hospital_manual>();
            this.hospital_medibuddy = new HashSet<hospital_medibuddy>();
            this.hospital_medibuddy_backup = new HashSet<hospital_medibuddy_backup>();
        }
    
        public int hosp_speciality_id { get; set; }
        public string Speciality_Name { get; set; }
        public string Speciality_Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hospital_manual> hospital_manual { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hospital_medibuddy> hospital_medibuddy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hospital_medibuddy_backup> hospital_medibuddy_backup { get; set; }
    }
}
