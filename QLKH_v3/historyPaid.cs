//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLKH_v3
{
    using System;
    using System.Collections.Generic;
    
    public partial class historyPaid
    {
        public int id { get; set; }
        public System.DateTime PaidDate { get; set; }
        public int Money { get; set; }
        public string TypePaid { get; set; }
        public int CustomerId { get; set; }
        public string Note { get; set; }
        public bool Status { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
    }
}
