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
    
    public partial class historyInterestRate
    {
        public int id { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<double> Percents { get; set; }
        public Nullable<int> InterestRateId { get; set; }
        public string Note { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
    
        public virtual interestRate interestRate { get; set; }
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
    }
}
