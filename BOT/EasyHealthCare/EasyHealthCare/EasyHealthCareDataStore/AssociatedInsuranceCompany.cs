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
    
    public partial class AssociatedInsuranceCompany
    {
        public int hospital_id { get; set; }
        public int insurance_company_id { get; set; }
    
        public virtual hospital_medibuddy hospital_medibuddy { get; set; }
    }
}
