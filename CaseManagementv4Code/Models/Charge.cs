//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CaseManagementv4Code.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Charge
    {
        public int ChargeID { get; set; }
        public int DetailsID { get; set; }
        public string ChargeName { get; set; }
        public string Severity { get; set; }
        public decimal ORCSection { get; set; }
    
        public virtual CaseDetail CaseDetail { get; set; }
    }
}
