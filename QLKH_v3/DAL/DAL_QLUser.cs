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
        public List<user> Get_Data_User() {
           List<user>  lst_user = new List<user>();
            try
            {
                lst_user =(from use in _DB.users
                            where (use.Status == true)
                            select use).AsEnumerable().ToList();

            }
            catch (Exception ex)
            {
                throw;
            }
            return lst_user;
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
    }
}
