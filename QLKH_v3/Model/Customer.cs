﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKH_v3.Model
{
    class Customer
    {
        public int id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime UpdatedAt { get; set; }
        public string Note { get; set; }
        public bool Status { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdated { get; set; }
        public int Money { get; set; }
        public int AfterMoney { get; set; }
        public double InterestMoney { get; set; }
        public string PhoneNumber { get; set; }
        public string IdCard { get; set; }
        public int AfterDate { get; set; }
        public string FamilyPhone { get; set; }
        public Boolean Sex { get; set; }
        public string SexString { get; set; }
        public DateTime BirthDay { get; set; }
        public int IdCateGory { get; set; }
        public int Cycle { get; set; }
        public DateTime NextDay { get; set; }
    }
}
