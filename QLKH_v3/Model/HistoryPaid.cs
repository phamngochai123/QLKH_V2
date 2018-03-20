using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKH_v3.Model
{
    class HistoryPaid
    {
        public int IdHistory { set; get; }
        public string NameCustomer { set; get; }
        public DateTime? CreatedAtHistory { set; get; }
        public DateTime? PaidDate { set; get; }
        public string CreatedByUser { set; get; }
        public string NoteHistory { set; get; }
        public string TypePaid { set; get; }
        public int PaidMoney { set; get; }
        public string IdCard { set; get; }
        public string PhoneNumber { set; get; }
    }
}
