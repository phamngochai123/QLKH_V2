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
        public List<customer> Get_List_Customer()
        {
            List<customer> lst_Customer = new List<customer>();
            try
            {
                lst_Customer = (from data in _db.customer
                            where (data.Status == true)
                            select data).AsEnumerable().ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
            return lst_Customer;
        }
        public customer Get_Customer(int id_Customer)
        {
            customer Customer = new customer();
            try
            {
                Customer = (from data in _db.customer
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
                lst_friend_of_customer = (from data in _db.friend
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
                lst_history_of_customer = (from data in _db.historyPaid
                          where (data.Status == true && data.CustomerId == id_Customer && data.TypePaid == true)
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
                lst_history_of_customer = (from data in _db.historyPaid
                                           where (data.Status == true && data.CustomerId == id_Customer && data.TypePaid == false)
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
                    _db.customer.Add(ctgr);                                           // add data
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
