using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKH_v3.DAL
{
    class DAL_QLCategory
    {
        QLKHEntities _db = new QLKHEntities();
        Variable.Variable Variable = new Variable.Variable();
        Util.Util Util = new Util.Util();
        public List<Model.Category> Get_List_Category()
        {
            List<Model.Category> lst_Category = new List<Model.Category>();
            try
            {
                _db = new QLKHEntities();
                lst_Category = (from data in _db.categories
                                join user_create in _db.users
                                on data.CreatedBy equals user_create.id
                                join user_update in _db.users
                                on data.UpdatedBy equals user_update.id
                                where (data.Status == true)
                                select new Model.Category
                                {
                                    id = data.id,
                                    Name = data.Name,
                                    CreatedAt = data.CreatedAt,
                                    UpdatedAt = data.UpdatedAt,
                                    Note = data.Note,
                                    Status = data.Status,
                                    CreatedBy = data.CreatedBy,
                                    UpdatedBy = data.UpdatedBy,
                                    UserCreate = user_create.FullName,
                                    UserUpdated = user_update.FullName
                                }).AsEnumerable().ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
            return lst_Category;
        }
        public category Get_Category(int id_category)
        {
            category Category = new category();
            try
            {
                Category = (from data in _db.categories
                            where (data.Status == true && data.id == id_category)
                            select data).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw;
            }
            return Category;
        }
        /// <summary>
        ///  function insert and update and delete category
        /// </summary>
        /// <param name="ctgr"></param>         model category
        /// <param name="action_status"></param>        status: (add; edit; insert)
        /// <returns></returns>
        public bool Add_and_Edit_Category(category ctgr, int action_status, user user)
        {
            bool check = false;
            try
            {
                if (Util.Cnv_Int(ctgr.id.ToString()) > 0)
                {
                    category data_edit = new category();
                    data_edit = Get_Category(ctgr.id);

                    if (action_status == Variable.action_status.is_update)
                    {            // update data
                        data_edit.Name = ctgr.Name;
                        data_edit.Note = ctgr.Note;
                        data_edit.UpdatedBy = user.id;
                        data_edit.UpdatedAt = DateTime.Now;
                    }
                    else if (action_status == Variable.action_status.is_delete)         // delete data
                    {
                        data_edit.Status = ctgr.Status;
                        data_edit.UpdatedBy = user.id;
                    }
                }
                else
                {
                    ctgr.CreatedBy = user.id;
                    ctgr.UpdatedBy = user.id;
                    _db.categories.Add(ctgr);                                           // add data
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