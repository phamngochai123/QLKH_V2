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
    
    public partial class user
    {
        public user()
        {
            this.categories = new HashSet<category>();
            this.categories1 = new HashSet<category>();
            this.categories2 = new HashSet<category>();
            this.categories3 = new HashSet<category>();
            this.customers = new HashSet<customer>();
            this.customers1 = new HashSet<customer>();
            this.friends = new HashSet<friend>();
            this.friends1 = new HashSet<friend>();
            this.historyInterestRates = new HashSet<historyInterestRate>();
            this.historyInterestRates1 = new HashSet<historyInterestRate>();
            this.historyPaids = new HashSet<historyPaid>();
            this.historyPaids1 = new HashSet<historyPaid>();
            this.interestRates = new HashSet<interestRate>();
            this.interestRates1 = new HashSet<interestRate>();
        }
    
        public int id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string FullName { get; set; }
        public string IdCard { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<System.DateTime> BirthDay { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public string Note { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<bool> Sex { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
    
        public virtual ICollection<category> categories { get; set; }
        public virtual ICollection<category> categories1 { get; set; }
        public virtual ICollection<category> categories2 { get; set; }
        public virtual ICollection<category> categories3 { get; set; }
        public virtual ICollection<customer> customers { get; set; }
        public virtual ICollection<customer> customers1 { get; set; }
        public virtual ICollection<friend> friends { get; set; }
        public virtual ICollection<friend> friends1 { get; set; }
        public virtual ICollection<historyInterestRate> historyInterestRates { get; set; }
        public virtual ICollection<historyInterestRate> historyInterestRates1 { get; set; }
        public virtual ICollection<historyPaid> historyPaids { get; set; }
        public virtual ICollection<historyPaid> historyPaids1 { get; set; }
        public virtual ICollection<interestRate> interestRates { get; set; }
        public virtual ICollection<interestRate> interestRates1 { get; set; }
    }
}
