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
    
    public partial class category
    {
        public category()
        {
            this.customers = new HashSet<customer>();
        }
    
        public int id { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public string Note { get; set; }
        public Nullable<bool> Status { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
        public virtual user user2 { get; set; }
        public virtual user user3 { get; set; }
        public virtual ICollection<customer> customers { get; set; }
    }
}
