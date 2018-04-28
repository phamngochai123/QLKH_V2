using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKH_v3.DAL
{

    class DAL_QLUser
    {
        QLKHEntities _DB = new QLKHEntities();
        Variable.Variable Variable = new Variable.Variable();
        Util.Util Util = new Util.Util();
        public List<Model.User> Get_Data_User(user user)
        {
            _DB = new QLKHEntities();
            List<Model.User> lst_user = new List<Model.User>();
            try
            {
                lst_user = (from use in _DB.users
                            where (use.Status == true && use.id != user.id)
                            select new Model.User
                            {
                                UserName = use.UserName,
                                FullName = use.FullName,
                                id = use.id,
                                CMND = use.IdCard,
                                BirthDay = use.BirthDay,
                                PhoneNumber = use.PhoneNumber,
                                Sex = use.Sex,
                                SexString = use.Sex ? "Nam" : "Nữ",
                                Address = use.Address,
                                Note = use.Note,
                                Type = use.Type
                            }).AsEnumerable().ToList();

            }
            catch (Exception ex)
            {
                throw;
            }
            return lst_user;
        }
        public user Get_User(int id_user)
        {
            user User = new user();
            try
            {
                User = (from data in _DB.users
                        where (data.Status == true && data.id == id_user)
                        select data).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw;
            }
            return User;
        }

        public user Check_Login(string username, string password)
        {
            QLKHEntities _DB = new QLKHEntities();
            user user = new user();
            try
            {
                user = (from data in _DB.users
                        where data.UserName == username && data.PassWord == password && data.Status == true
                        select data).FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return user;
        }
        public bool Add_and_Edit_User(user ctgr, int action_status)
        {
            bool check = false;
            try
            {
                if (Util.Cnv_Int(ctgr.id.ToString()) > 0)
                {
                    user data_edit = new user();
                    data_edit = Get_User(ctgr.id);

                    if (action_status == Variable.action_status.is_update)
                    {            // update data
                        data_edit.FullName = ctgr.FullName;
                        data_edit.Note = ctgr.Note;
                        data_edit.UpdatedAt = DateTime.Now;
                        data_edit.Sex = ctgr.Sex;
                        data_edit.Type = ctgr.Type;
                        data_edit.PhoneNumber = ctgr.PhoneNumber;
                        data_edit.IdCard = ctgr.IdCard;
                        data_edit.BirthDay = ctgr.BirthDay;
                        data_edit.Address = ctgr.Address;
                        if (ctgr.PassWord != "" && ctgr.PassWord != null)
                        {
                            data_edit.PassWord = ctgr.PassWord;
                        }
                    }
                    else if (action_status == Variable.action_status.is_delete)         // delete data
                    {
                        data_edit.Status = ctgr.Status;
                    }
                }
                else
                {
                    _DB.users.Add(ctgr);                                           // add data
                }
                _DB.SaveChanges();
                check = true;
            }
            catch (Exception)
            {
                return check;
            }
            return check;
        }

        public bool ChangePassword(user user, string new_password)
        {
            try
            {
                user users = (from data in _DB.users
                             where data.id == user.id
                             select data).FirstOrDefault();
                users.PassWord = new_password;
                _DB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
