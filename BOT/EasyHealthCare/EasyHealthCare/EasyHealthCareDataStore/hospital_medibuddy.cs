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
    using System.ComponentModel;

    public partial class hospital_medibuddy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hospital_medibuddy()
        {
            this.AssociatedInsuranceCompanies = new HashSet<AssociatedInsuranceCompany>();
            this.medical_cost_medibuddy = new HashSet<medical_cost_medibuddy>();
            this.hosp_emp_emergency_map = new HashSet<hosp_emp_emergency_map>();
        }
        [DisplayName("Hospital ID")]
        public int hospital_id { get; set; }

        [DisplayName("Hospital Name")]
        public string hospital_name { get; set; }

        [DisplayName("Hospital Address")]
        public string hospital_address { get; set; }

        [DisplayName("Hospital State")]
        public string hospital_state { get; set; }

        [DisplayName("Hospital District")]
        public string hospital_district { get; set; }

        [DisplayName("Hospital City")]
        public string hospital_city { get; set; }

        [DisplayName("Hospital Pincode")]
        public string hospital_pincode { get; set; }

        [DisplayName("Hospital Phone")]
        public string hospital_phone { get; set; }

        [DisplayName("Hospital Email")]
        public string hospital_email { get; set; }

        [DisplayName("Hospital Latitude")]
        public string hospital_latitude { get; set; }

        [DisplayName("Hospital Longitude")]
        public string hospital_longitude { get; set; }

        [DisplayName("Hospital Speciality ID")]
        public Nullable<int> hosp_speciality_id { get; set; }

        [DisplayName("Hospital Average Rating")]
        public Nullable<int> avgRating { get; set; }

        [DisplayName("Entity ID")]
        public Nullable<int> entityId { get; set; }

        [DisplayName("Hospital Blacklisted")]
        public Nullable<bool> blacklisted { get; set; }

        [DisplayName("Location")]
        public string location { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssociatedInsuranceCompany> AssociatedInsuranceCompanies { get; set; }
        public virtual hospitalSpeciality hospitalSpeciality { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<medical_cost_medibuddy> medical_cost_medibuddy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hosp_emp_emergency_map> hosp_emp_emergency_map { get; set; }
    }
}
