using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKH_v3.Variable
{
    class Variable
    {
        public string format_date_time = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.FullDateTimePattern;
        public string format_date_time_replace = "ddMMyyyyHHmmss";
        public string orderByCreatedAt = "orderByCreatedAt";
        public string orderByAfterDate = "orderByAfterDate";
        public string format_date = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
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
        public string Customer = "Detail_Customer";
        public string Friend_Customer = "Friend_Customer";
        public string Paid_Money = "Paid_Money";
        public string History_Paid = "History_Paid";
        public string ChangePassword = "ChangePassword";
        public string Form_Add_Customer = "Add_Customer";
    }

    
}
