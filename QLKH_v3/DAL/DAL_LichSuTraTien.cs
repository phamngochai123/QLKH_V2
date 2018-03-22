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
        public historyPaid Get_Tien_Lai(int IdCustomer)
        {
            historyPaid history = new historyPaid();
            customer customer = new customer();
            int lai = 0;
            try
            {
                history = (from data in _db.historyPaids                // lấy bản ghi trả nợ gần nhất
                            where data.CustomerId == IdCustomer
                            orderby data.PaidDate descending
                            select data).FirstOrDefault();


                customer = (from data in _db.customers
                                where data.id == IdCustomer
                                select data).FirstOrDefault();

              // List<int?> TongTienNoDaTra = _db.prd_TongTienNoDaTra(IdCustomer);

                int TongTienNoDaTra = 0;
               List<historyPaid> lstPair = new List<historyPaid>();
               lstPair = (from data in _db.historyPaids
                          where data.CustomerId == IdCustomer && data.TypePaid == "0"
                          select data).ToList();
                foreach (var item in lstPair)
	            {
		            TongTienNoDaTra += item.Money;
	            }

                // tiền nợ gốc = số tiền vay - số tiền trả
               int tien_no = customer.Money - TongTienNoDaTra;

               var lai_suat = (from data in _db.historyInterestRates
                                 where data.StartDate <= history.PaidDate
                                 orderby data.StartDate descending
                                 select data.Percents).FirstOrDefault();

               List<historyInterestRate> lst_lai_suat = new List<historyInterestRate>();
               lst_lai_suat = (from data in _db.historyInterestRates
                               select data).ToList();

                double tien_lai=0;
                int so_tien_vay = customer.Money;
                for (int i = 0; i < lstPair.Count; i++)
                {
                    DateTime start_date = lstPair[i].PaidDate.AddDays(i);
                    for (int j = 0; j < (lst_lai_suat.Count - 1); j++)
                    {
                        if (start_date >= lst_lai_suat[j].StartDate && start_date < lst_lai_suat[j + 1].StartDate)
                        {
                            tien_lai += tien_no * lst_lai_suat[j].Percents * 0.01;
                        }
                    }
                }
                int demngay = (Convert.ToDateTime(DateTime.Now) - Convert.ToDateTime(history.PaidDate)).Days;

                for (int i = 0; i < demngay; i++)
                {
                    DateTime start_date = history.PaidDate.AddDays(i);
                    for (int j = 0; j < (lst_lai_suat.Count - 1); j++)
                    {
                        if (start_date >= lst_lai_suat[j].StartDate && start_date < lst_lai_suat[j +1].StartDate) {
                            tien_lai += tien_no * lst_lai_suat[j].Percents * 0.01;
                        }
                    }
                }


               // Util.Show_Message_Notification(Message.msg_notification, dateRange.ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return history;
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
