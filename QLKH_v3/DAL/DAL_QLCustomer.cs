using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKH_v3.DAL
{
    class DAL_QLCustomer
    {

        QLKHEntities _db = new QLKHEntities();
        Variable.Variable Variable = new Variable.Variable();
        Util.Util Util = new Util.Util();
        DAL_LichSuTraTien DAL_Lichsutratien = new DAL_LichSuTraTien();
        public List<Model.Customer> Get_List_Customer()
        {
            List<Model.Customer> lst_Customer = new List<Model.Customer>();
            try
            {
                lst_Customer = (from data in _db.customers
                                where (data.Status == true)
                                select new Model.Customer {
                                    id = data.id,
                                    FullName = data.FullName,
                                    Money = data.Money,
                                    IdCard = data.IdCard,
                                    Phone = data.PhoneNumber,
                                    CreatedAt = data.CreatedAt,
                                }).AsEnumerable().ToList();
                for (int i = 0; i < lst_Customer.Count; i++)
                {
                    lst_Customer[i].AfterMoney = Get_After_Money(lst_Customer[i].id);
                    lst_Customer[i].InterestMoney = DAL_Lichsutratien.Get_Tien_Lai(lst_Customer[i].id);
                    lst_Customer[i].AfterDate = Get_After_Date(lst_Customer[i].id);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return lst_Customer;
        }

        public int Get_After_Date(int IdCustomer) //lấy số ngày chậm lãi
        {
            customer Customer = new customer();
            Customer = (from data in _db.customers
                        where data.id == IdCustomer && data.Status == true
                        select data).FirstOrDefault();
            historyPaid Last_Paid = new historyPaid();
            Last_Paid = (from data in _db.historyPaids
                         where data.CustomerId == IdCustomer
                         orderby data.PaidDate descending
                         select data).FirstOrDefault();
            if (Last_Paid != null)
            {
                return (DateTime.Now - Last_Paid.PaidDate).Days > 10 ? (DateTime.Now - Last_Paid.PaidDate).Days - 10 : 0;
            }
            return (DateTime.Now - Customer.CreatedAt).Days > 10 ? (DateTime.Now - Customer.CreatedAt).Days - 10 : 0;
        }

        public int Get_After_Money(int IdCustomer) //lấy số nợ còn phải trả
        {
            int tien_goc = (from data in _db.customers
                            where data.Status == true && data.id == IdCustomer
                            select data.Money).FirstOrDefault();
            var lich_su_tra_tien_goc = (from data in _db.historyPaids
                                        where data.CustomerId == IdCustomer && data.TypePaid == "0"
                                        select data).ToList();
            var tien_goc_da_tra = lich_su_tra_tien_goc.Select(m => m.Money).Sum();
            return tien_goc - tien_goc_da_tra;
        }

        public customer Get_Customer(int id_Customer)
        {
            customer Customer = new customer();
            try
            {
                Customer = (from data in _db.customers
                            where (data.Status == true && data.id == id_Customer)
                            select data).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw;
            }
            return Customer;
        }

        public List<friend> Get_Friend_By_IdCustomer(int id_Customer) //get friend by id customer
        {
            List<friend> lst_friend_of_customer = new List<friend>();
            try
            {
                lst_friend_of_customer = (from data in _db.friends
                                          where (data.Status == true && data.CustomerId == id_Customer)
                                          select data).AsEnumerable().ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
            return lst_friend_of_customer;
        }

        public List<historyPaid> Get_HistoryPaidInterest_By_IdCustomer(int id_Customer) //get history paid interest by id customer
        {
            List<historyPaid> lst_history_of_customer = new List<historyPaid>();
            try
            {
                lst_history_of_customer = (from data in _db.historyPaids
                                           where (data.Status == true && data.CustomerId == id_Customer)
                                           select data).AsEnumerable().ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
            return lst_history_of_customer;
        }

        public List<historyPaid> Get_HistoryPaidMoney_By_IdCustomer(int id_Customer) //get history paid interest by id customer
        {
            List<historyPaid> lst_history_of_customer = new List<historyPaid>();
            try
            {
                lst_history_of_customer = (from data in _db.historyPaids
                                           where (data.Status == true && data.CustomerId == id_Customer)
                                           select data).AsEnumerable().ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
            return lst_history_of_customer;
        }
        /// <summary>
        ///  function insert and update and delete User
        /// </summary>
        /// <param name="ctgr"></param>         model User
        /// <param name="action_status"></param>        status: (add; edit; insert)
        /// <returns></returns>
        public bool Add_and_Edit_Customer(customer ctgr, int action_status)
        {
            bool check = false;
            try
            {
                if (Util.Cnv_Int(ctgr.id.ToString()) > 0)
                {
                    customer data_edit = new customer();
                    data_edit = Get_Customer(ctgr.id);

                    if (action_status == Variable.action_status.is_update)
                    {            // update data
                        data_edit.FullName = ctgr.FullName;
                        data_edit.IdCard = ctgr.IdCard;
                        data_edit.Note = ctgr.Note;
                        data_edit.UpdatedAt = DateTime.Now;
                    }
                    else if (action_status == Variable.action_status.is_delete)         // delete data
                    {
                        data_edit.Status = ctgr.Status;
                    }
                }
                else
                {
                    _db.customers.Add(ctgr);                                           // add data
                }
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
