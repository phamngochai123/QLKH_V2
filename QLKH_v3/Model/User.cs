using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKH_v3.Model
{
    class User
    {
        public string UserName { get; set; }
        public string CMND { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public int id { get; set; }
        public DateTime BirthDay { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public string Type { get; set; }
    }
}
