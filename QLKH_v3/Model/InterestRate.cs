using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKH_v3.Model
{
    class InterestRate
    {
        public int IdInterestRate { set; get; }
        public string NameInterestRate { set; get; }
        public DateTime? CreatedAtInterestRate { set; get; }
        public DateTime? UpdatedAtInterestRate { set; get; }
        public string NoteInterestRate { set; get; }
        public bool? StatusInterestRate { set; get; }


        public int IdHistory { set; get; }
        public DateTime? StartDateHistory { set; get; }
        public DateTime? EndDateHistory { set; get; }
        public double? Percents { set; get; }
        public string NoteHistory { set; get; }
        public bool? StatusHistory { set; get; }
        public DateTime? CreateAtHisgory { set; get; }
        public DateTime? UpdatedAtHistory { set; get; }

    }
}
