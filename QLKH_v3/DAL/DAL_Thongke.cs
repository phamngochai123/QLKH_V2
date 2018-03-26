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

        public List<Model.Statistic> Get_List_Customer_By_Month()
        {
            //List<customer> lst_customer = new List<customer>();
            List<Model.Statistic_Customer> statistic_customer = new List<Model.Statistic_Customer>();
            List<Model.Statistic_Money> statistic_money = new List<Model.Statistic_Money>();
            List<Model.Statistic_Money> statistic_interset = new List<Model.Statistic_Money>();
            List<Model.Statistic> statistic = new List<Model.Statistic>();
            for (int i = 1; i < 13; i++)
            {
                Model.Statistic statis = new Model.Statistic();
                statis.Month = i;
                statis.NumCustomer = 0;
                statis.NumInterestMoney = 0;
                statis.NumMoney = 0;
                statis.NumReturnMoney = 0;
                statistic.Add(statis);
            }
            statistic_customer = (from data in _db.customers
                                  group data by new
                                  {
                                      Column1 = (int)SqlFunctions.DatePart("mm", data.CreatedAt)
                                  }
                                      into g
                                      select new Model.Statistic_Customer
                                      {
                                          Month = g.Key.Column1,
                                          Count = g.Count(data => data.id != null),
                                          Money = g.Sum(data => data.Money)
                                      }
                                ).ToList();

            statistic_money = (from data in _db.historyPaids
                               where data.TypePaid == "0"
                               group data by new
                               {
                                   Column1 = (int)SqlFunctions.DatePart("mm", data.CreatedAt)
                               }
                                   into g
                                   select new Model.Statistic_Money
                                   {
                                       Month = g.Key.Column1,
                                       Money = g.Sum(data => data.Money)
                                   }
                    ).ToList();
            statistic_interset = (from data in _db.historyPaids
                                  where data.TypePaid == "1"
                                  group data by new
                                  {
                                      Column1 = (int)SqlFunctions.DatePart("mm", data.CreatedAt)
                                  }
                                      into g
                                      select new Model.Statistic_Money
                                      {
                                          Month = g.Key.Column1,
                                          Money = g.Sum(data => data.Money)
                                      }
        ).ToList();
            for (int i = 0; i < statistic_customer.Count; i++)
            {
                for (int j = 0; j < statistic.Count; j++)
                {
                    if (statistic[j].Month == statistic_customer[i].Month)
                    {
                        statistic[j].NumMoney = Convert.ToInt32(statistic_customer[i].Money);
                        statistic[j].NumCustomer = Convert.ToInt32(statistic_customer[i].Count);
                    }

                }

            }
            for (int i = 0; i < statistic_money.Count; i++)
            {
                for (int j = 0; j < statistic.Count; j++)
                {
                    if (statistic[j].Month == statistic_money[i].Month)
                    {

                        statistic[j].NumReturnMoney = Convert.ToInt32(statistic_money[i].Money);
                    }

                }
            }
            for (int i = 0; i < statistic_interset.Count; i++)
            {
                for (int j = 0; j < statistic.Count; j++)
                {
                    if (statistic[j].Month == statistic_interset[i].Month)
                    {

                        statistic[j].NumInterestMoney = Convert.ToInt32(statistic_interset[i].Money);
                    }

                }
            }
            return statistic;
        }

        public List<Model.Year> get_list_all_year()
        {
            List<Model.Year> lst_year = new List<Model.Year>();
            try
            {
                lst_year = (from data in _db.customers
                            group data by new
                            {
                                Column1 = (int)SqlFunctions.DatePart("yy", data.CreatedAt)
                            }
                                into g
                                select new Model.Year
                                {
                                    Year_Active = g.Key.Column1,
                                }
        ).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lst_year;
        }
    }
}
