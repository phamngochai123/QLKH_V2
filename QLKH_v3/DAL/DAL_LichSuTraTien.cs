using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKH_v3.DAL
{
    class DAL_LichSuTraTien
    {
        QLKHEntities _db = new QLKHEntities();
        Variable.Variable Variable = new Variable.Variable();
        Util.Util Util = new Util.Util();
        Message.Message Message = new Message.Message();
        public List<Model.HistoryPaid> Get_List_History_Paid()
        {
            List<Model.HistoryPaid> lst_History_Paid = new List<Model.HistoryPaid>();
            try
            {
                _db = new QLKHEntities();
                lst_History_Paid = (from data in _db.historyPaids
                                    join data_user in _db.users
                                    on data.CreatedBy equals data_user.id
                                    join data_customer in _db.customers
                                    on data.CustomerId equals data_customer.id
                                    where data.Status == true
                                    select new Model.HistoryPaid
                                    {
                                        IdHistory = data.id,
                                        NameCustomer = data_customer.FullName,
                                        IdCard = data_customer.IdCard,
                                        PhoneNumber = data_customer.PhoneNumber,
                                        PaidDate = data.PaidDate,
                                        PaidMoney = data.Money,
                                        NoteHistory = data.Note,
                                        TypePaid = data.TypePaid == "0" ? "Tiền gốc" : "Tiền lãi",
                                        CreatedByUser = data_user.FullName,
                                        CreatedAtHistory = data.CreatedAt
                                    }).AsEnumerable().ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return lst_History_Paid;
        }

        public List<Model.HistoryPaid> Get_List_History_Paid(int idCustomer)
        {
            List<Model.HistoryPaid> lst_History_Paid = new List<Model.HistoryPaid>();
            try
            {
                _db = new QLKHEntities();
                lst_History_Paid = (from data in _db.historyPaids
                                    join data_user in _db.users
                                    on data.CreatedBy equals data_user.id
                                    join data_customer in _db.customers
                                    on data.CustomerId equals data_customer.id
                                    where data.CustomerId == idCustomer
                                    orderby data.PaidDate descending
                                    select new Model.HistoryPaid
                                    {
                                        IdHistory = data.id,
                                        NameCustomer = data_customer.FullName,
                                        IdCard = data_customer.IdCard,
                                        PhoneNumber = data_customer.PhoneNumber,
                                        PaidDate = data.PaidDate,
                                        PaidMoney = data.Money,
                                        NoteHistory = data.Note,
                                        TypePaid = data.TypePaid == "0" ? "Tiền gốc" : "Tiền lãi",
                                        CreatedByUser = data_user.FullName,
                                        CreatedAtHistory = data.CreatedAt
                                    }).AsEnumerable().ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return lst_History_Paid;
        }
        /// <summary>
        ///  function insert and update and delete category
        /// </summary>
        /// <param name="ctgr"></param>         model category
        /// <param name="action_status"></param>        status: (add; edit; insert)
        /// <returns></returns>

        public customer Get_Customer_by_IdCard_or_PhoneNumber(string idCard, string phoneNumber)
        {
            customer Customer = new customer();
            try
            {
                Customer = (from data in _db.customers
                            where data.IdCard == idCard || data.PhoneNumber == phoneNumber
                            select data).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Customer;
        }
        public double Get_Tien_Lai(int IdCustomer)
        {
            historyPaid history = new historyPaid();
            customer customer = new customer();
            try
            {
                history = (from data in _db.historyPaids              // lấy bản ghi trả nợ gần nhất
                           join data_customer in _db.customers
                           on data.CustomerId equals data_customer.id
                           where data.CustomerId == IdCustomer && data.TypePaid == "1" && data_customer.Status == true
                           orderby data.PaidDate descending
                           select data).FirstOrDefault();


                customer = (from data in _db.customers
                            where data.id == IdCustomer
                            select data).FirstOrDefault();

                DateTime start_date = customer.CreatedAt;
                if (history != null)
                {
                    start_date = history.PaidDate;
                }

                List<historyInterestRate> lst_lai_suat = new List<historyInterestRate>();
                lst_lai_suat = (from data in _db.historyInterestRates
                                orderby data.StartDate ascending
                                select data).ToList();

                double tien_lai = 0;
                int so_tien_vay = customer.Money;

                int demngay = (Convert.ToDateTime(DateTime.Now) - Convert.ToDateTime(start_date)).Days + 1;

                for (int i = 0; i < demngay; i++)
                {
                    DateTime date_start = start_date.AddDays(i);//ngày để tính số tiền gốc đang nợ
                    double tien_goc = get_tien_goc_by_day(date_start, IdCustomer);

                    if (date_start >= lst_lai_suat[lst_lai_suat.Count - 1].StartDate)
                    {
                        tien_lai += tien_goc * lst_lai_suat[lst_lai_suat.Count - 1].Percents * 0.01;
                    }
                    else
                    {
                        for (int j = 0; j < (lst_lai_suat.Count - 1); j++)
                        {
                            if (date_start >= lst_lai_suat[j].StartDate && date_start < lst_lai_suat[j + 1].StartDate)
                            {
                                tien_lai += tien_goc * lst_lai_suat[j].Percents * 0.01;
                            }
                        }
                    }
                }


                // Util.Show_Message_Notification(Message.msg_notification, dateRange.ToString());
                return tien_lai;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public double get_tien_goc_by_day(DateTime date, int idCustomer)
        {
            try
            {
                List<historyPaid> list_paid = new List<historyPaid>();
                list_paid = (from data in _db.historyPaids
                             where data.TypePaid == "0" && data.CustomerId == idCustomer
                             orderby data.PaidDate ascending
                             select data).ToList();
                customer Customer = new customer();
                Customer = (from data in _db.customers
                            where data.id == idCustomer
                            select data).FirstOrDefault();
                int tien_goc_da_tra = 0;
                if (list_paid.Count == 0)
                {
                    return Customer.Money;
                }
                int tien_goc_no = 0;
                for (int i = 0; i < list_paid.Count; i++)
                {
                    if (date >= Customer.CreatedAt && date < list_paid[0].PaidDate)
                    {
                        tien_goc_no = Customer.Money;
                    }
                    else
                    {
                        tien_goc_da_tra += list_paid[i].Money;
                        DateTime end_date = DateTime.Now;
                        if (i + 1 < list_paid.Count)
                        {
                            end_date = list_paid[i + 1].PaidDate;
                        }
                        if (date >= list_paid[i].PaidDate && date < end_date)
                        {
                            tien_goc_no = Customer.Money - tien_goc_da_tra;
                        }

                    }
                }
                return tien_goc_no;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Add_Paid_Money(historyPaid hisPaid, int action_status, user user)
        {
            bool check = false;
            try
            {
                hisPaid.CreatedBy = user.id;
                hisPaid.UpdatedBy = user.id;
                _db.historyPaids.Add(hisPaid);
                _db.SaveChanges();
                check = true;
            }
            catch (Exception)
            {
                return check;
            }
            return check;
        }
    }
}
