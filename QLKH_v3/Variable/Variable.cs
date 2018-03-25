﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKH_v3.Variable
{
    class Variable
    {
        public string format_date_time = CultureInfo.CurrentUICulture.DateTimeFormat.FullDateTimePattern;
        public string format_date = CultureInfo.CurrentUICulture.DateTimeFormat.ShortDatePattern;
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
    }

    
}
