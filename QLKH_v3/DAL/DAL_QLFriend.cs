using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKH_v3.DAL
{
    class DAL_QLFriend
    {
        QLKHEntities _db = new QLKHEntities();
        Variable.Variable Variable = new Variable.Variable();
        Util.Util Util = new Util.Util();
        public List<friend> Get_List_Friend()
        {
            List<friend> lst_Friend = new List<friend>();
            try
            {
                lst_Friend = (from data in _db.friend
                            where (data.Status == true)
                            select data).AsEnumerable().ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
            return lst_Friend;
        }
        public friend Get_Friend(int id_Friend)
        {
            friend Friend = new friend();
            try
            {
                Friend = (from data in _db.friend
                        where (data.Status == true && data.id == id_Friend)
                        select data).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw;
            }
            return Friend;
        }

        /// <summary>
        ///  function insert and update and delete User
        /// </summary>
        /// <param name="ctgr"></param>         model User
        /// <param name="action_status"></param>        status: (add; edit; insert)
        /// <returns></returns>
        public bool Add_and_Edit_Friend(friend ctgr, int action_status)
        {
            bool check = false;
            try
            {
                if (Util.Cnv_Int(ctgr.id.ToString()) > 0)
                {
                    friend data_edit = new friend();
                    data_edit = Get_Friend(ctgr.id);

                    if (action_status == Variable.action_status.is_update)
                    {            // update data
                        //data_edit.UserName = ctgr.UserName;
                        //data_edit.PassWord = ctgr.PassWord;
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
                    _db.friend.Add(ctgr);                                           // add data
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
