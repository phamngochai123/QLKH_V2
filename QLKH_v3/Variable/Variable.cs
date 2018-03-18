using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKH_v3.Variable
{
    class Variable
    {
        public string format_date_time = "yyyy-MM-dd HH:mm:ss";
        public string format_date = "dd-MM-yyyy";
        public Action_Status action_status = new Action_Status();
        public Detail_Infor detail_infor = new Detail_Infor();
    }
    class Action_Status{
       public int is_update=1;
       public  int is_delete=2;
       public int is_add = 3;
    }
    class Detail_Infor {
        public string Category = "Detail_Category";
        public string User = "Detail_User";
    }

    
}
