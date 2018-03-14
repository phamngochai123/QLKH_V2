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
    }
}
