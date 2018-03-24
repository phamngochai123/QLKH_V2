using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKH_v3.DAL
{
    class DAL_Thongke
    {
        QLKHEntities _db = new QLKHEntities();
        Variable.Variable Variable = new Variable.Variable();
        Util.Util Util = new Util.Util();

        public double Get_Total_Money()
        {
            double tong_tien = 0;
            List<customer> lst_customer = new List<customer>();
            try
            {
                lst_customer = (from data in _db.customers
                                select data).ToList();
                tong_tien = lst_customer.Select(m => m.Money).Sum();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return tong_tien;
        }

        public double Get_Total_Money_Paid(string typePaid)
        {
            double tong_tien_da_tra = 0;
            List<historyPaid> lst_paid = new List<historyPaid>();
            try
            {
                lst_paid = (from data in _db.historyPaids
                            where data.TypePaid == typePaid
                                select data).ToList();
                tong_tien_da_tra = lst_paid.Select(m => m.Money).Sum();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return tong_tien_da_tra;
        }

        public void Get_List_Customer_By_Month()
        {
            //List<customer> lst_customer = new List<customer>();
            ArrayList listDataSource = new ArrayList();
            var lst_customer = (from data in _db.customers
                            group data by new
                            {
                                Column1 = (int?)SqlFunctions.DatePart("mm", data.CreatedAt)
                            }
                                into g
                                select new
                                {
                                    month = g.Key.Column1,
                                    count = g.Count(data => data.id != null)
                                }
                                ).OrderBy(g => g.month).ToList();
        }
    }
}
