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
    
    public partial class hospital_medibuddy_backup
    {
        public int hospital_id { get; set; }
        public string hospital_name { get; set; }
        public string hospital_address { get; set; }
        public string hospital_state { get; set; }
        public string hospital_district { get; set; }
        public string hospital_city { get; set; }
        public string hospital_pincode { get; set; }
        public string hospital_phone { get; set; }
        public string hospital_email { get; set; }
        public string hospital_latitude { get; set; }
        public string hospital_longitude { get; set; }
        public Nullable<int> hosp_speciality_id { get; set; }
        public Nullable<int> avgRating { get; set; }
        public Nullable<int> entityId { get; set; }
        public Nullable<bool> blacklisted { get; set; }
        public string location { get; set; }
    
        public virtual hospitalSpeciality hospitalSpeciality { get; set; }
    }
}
