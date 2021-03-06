﻿using System;
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
        public List<Model.Customer> Get_List_Customer(string orderBy)
        {
            List<Model.Customer> lst_Customer = new List<Model.Customer>();
            try
            {
                lst_Customer = (from data in _db.customers
                                where (data.Status == true)
                                orderby data.id descending
                                select new Model.Customer
                                {
                                    id = data.id,
                                    FullName = data.FullName,
                                    Money = data.Money,
                                    IdCard = data.IdCard,
                                    PhoneNumber = data.PhoneNumber,
                                    CreatedAt = data.CreatedAt,
                                    Address = data.Address,
                                    FamilyPhone = data.FamilyPhoneNumber,
                                    Sex = data.Sex,
                                    SexString = data.Sex ? "Nam" : "Nữ",
                                    BirthDay = data.BirthDay,
                                    IdCateGory = data.CategoryId,
                                    Cycle = data.cycle,
                                }).AsEnumerable().ToList();
                for (int i = 0; i < lst_Customer.Count; i++)
                {
                    lst_Customer[i].AfterMoney = Get_After_Money(lst_Customer[i].id); //lấy số tiền còn lại vay
                    lst_Customer[i].InterestMoney = DAL_Lichsutratien.Get_Tien_Lai(lst_Customer[i].id);
                    lst_Customer[i].AfterDate = Get_After_Date(lst_Customer[i].id);
                    lst_Customer[i].NextDay = Get_Next_Date(lst_Customer[i].id);
                }
                if (orderBy == Variable.orderByAfterDate)
                {
                    lst_Customer = lst_Customer.OrderByDescending(x => x.AfterDate).ToList();
                    lst_Customer = lst_Customer.Where(x => x.AfterDate > 0).ToList();
                }

                //for (int i = 0; i < lst_Customer.Count-1; i++)
                //{
                //    if (lst_Customer[i].AfterDate < lst_Customer[i + 1].AfterDate)
                //    {
                //        Model.Customer Customer = new Model.Customer();
                //        Customer = lst_Customer[i];
                //        lst_Customer[i] = lst_Customer[i + 1];
                //        lst_Customer[i + 1] = Customer;
                //    }
                //}
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return lst_Customer;
        }

        public int Get_After_Date(int IdCustomer) //lấy số ngày chậm lãi
        {
            _db = new QLKHEntities();
            customer Customer = new customer();
            Customer = (from data in _db.customers
                        where data.id == IdCustomer && data.Status == true
                        select data).FirstOrDefault();
            historyPaid Last_Paid = new historyPaid();
            Last_Paid = (from data in _db.historyPaids
                         where data.CustomerId == IdCustomer && data.TypePaid == "1"
                         orderby data.PaidDate descending
                         select data).FirstOrDefault();
            if (Last_Paid != null)
            {
                return (DateTime.Now - Last_Paid.PaidDate).Days + 1 > Customer.cycle ? (DateTime.Now - Last_Paid.PaidDate).Days + 1 - Customer.cycle : 0;
            }
            return (DateTime.Now - Customer.CreatedAt).Days + 1 > Customer.cycle ? (DateTime.Now - Customer.CreatedAt).Days + 1 - Customer.cycle : 0;
        }

        public DateTime Get_Next_Date(int IdCustomer) //lấy ngày nộp lãi tiếp theo
        {
            _db = new QLKHEntities();
            customer Customer = new customer();
            Customer = (from data in _db.customers
                        where data.id == IdCustomer && data.Status == true
                        select data).FirstOrDefault();
            int countDay = (DateTime.Now - Customer.CreatedAt).Days + 1;
            int countPaid = Convert.ToInt32(Math.Ceiling((double)(countDay * 1.0 / Customer.cycle)));
            int sumDay = countPaid * Customer.cycle - countDay;
            return DateTime.Now.AddDays(sumDay);
        }

        public int Get_After_Money(int IdCustomer) //lấy số nợ còn phải trả
        {
            _db = new QLKHEntities();
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
                throw ex;
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

                throw ex;
            }
            return lst_history_of_customer;
        }
        /// <summary>
        ///  function insert and update and delete User
        /// </summary>
        /// <param name="ctgr"></param>         model User
        /// <param name="action_status"></param>        status: (add; edit; insert)
        /// <returns></returns>
        public bool Delete_Info_Customer(customer customer, user user)
        {
            try
            {
                (from f in _db.friends
                 where f.CustomerId.Equals(customer.id)
                 select f)
                           .ToList()
                           .ForEach(i => i.Status = false);
                (from f in _db.friends
                 where f.CustomerId.Equals(customer.id)
                 select f)
                           .ToList()
                           .ForEach(i => i.UpdatedBy = user.id);
                (from f in _db.friends
                 where f.CustomerId.Equals(customer.id)
                 select f)
                           .ToList()
                           .ForEach(i => i.UpdatedAt = DateTime.Now);
                (from f in _db.historyPaids
                 where f.CustomerId.Equals(customer.id)
                 select f)
                           .ToList()
                           .ForEach(i => i.Status = false);
                (from f in _db.historyPaids
                 where f.CustomerId.Equals(customer.id)
                 select f)
           .ToList()
           .ForEach(i => i.UpdatedBy = user.id);
                (from f in _db.historyPaids
                 where f.CustomerId.Equals(customer.id)
                 select f)
                           .ToList()
                           .ForEach(i => i.UpdatedAt = DateTime.Now);
                _db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool Add_and_Edit_Customer(customer customer, List<Model.Friend> list_friend, int action_status, user user)
        {
            bool check = false;
            try
            {
                if (Util.Cnv_Int(customer.id.ToString()) > -1 && action_status != Variable.action_status.is_add)
                {
                    customer data_edit = new customer();
                    data_edit = Get_Customer(customer.id);

                    if (action_status == Variable.action_status.is_update)
                    {            // update data
                        data_edit.Address = customer.Address;
                        data_edit.BirthDay = customer.BirthDay;
                        data_edit.FullName = customer.FullName;
                        data_edit.IdCard = customer.IdCard;
                        data_edit.PhoneNumber = customer.PhoneNumber;
                        data_edit.Sex = customer.Sex;
                        data_edit.FamilyPhoneNumber = customer.FamilyPhoneNumber;
                        data_edit.CategoryId = customer.CategoryId;
                        data_edit.Money = customer.Money;
                        data_edit.Note = customer.Note;
                        data_edit.UpdatedAt = DateTime.Now;
                        data_edit.UpdatedBy = user.id;
                        data_edit.cycle = customer.cycle;
                    }
                    else if (action_status == Variable.action_status.is_delete)         // delete data
                    {
                        data_edit.Status = false;
                    }
                }
                else
                {
                    _db.customers.Add(customer);                                       // add data
                }
                _db.SaveChanges();
                int IdCustomer = customer.id;
                if (action_status == Variable.action_status.is_add && !add_friend(list_friend, user, IdCustomer))
                {
                    check = false;
                }
                check = true;
            }
            catch (Exception)
            {
                return check;
            }
            return check;
        }

        public bool add_friend(List<Model.Friend> lst_friend, user user, int IdCustomer)
        {
            try
            {
                friend friend = new friend();
                foreach (var item in lst_friend)
                {
                    friend.Status = true;
                    friend.UpdatedAt = DateTime.Now;
                    friend.UpdatedBy = user.id;
                    friend.CreatedBy = user.id;
                    friend.CreatedAt = DateTime.Now;
                    friend.CustomerId = IdCustomer;
                    friend.FullName = item.FullName;
                    friend.PhoneNumber = item.PhoneNumber;
                    friend.Relationship = item.Relationship;
                    _db.friends.Add(friend);
                    _db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public List<Model.Friend> get_list_friend(int idCustomer)
        {
            List<Model.Friend> lst_friend = new List<Model.Friend>();
            try
            {

                lst_friend = (from data in _db.friends
                              where data.CustomerId == idCustomer && data.Status == true
                              select new Model.Friend
                              {
                                  FullName = data.FullName,
                                  PhoneNumber = data.PhoneNumber,
                                  Relationship = data.Relationship,
                                  Note = data.Note,
                                  Status = data.Status,
                                  CustomerId = data.CustomerId,
                                  UpdatedAt = data.UpdatedAt,
                                  CreatedAt = data.CreatedAt,
                                  UpdatedBy = data.UpdatedBy,
                                  CreatedBy = data.CreatedBy,
                                  Id = data.id
                              }).ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lst_friend;
        }

    }
}
