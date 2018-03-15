using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKH_v3.UI.Detail
{
    public partial class uc_Detail_Category : UserControl
    {
        public user _user { set; get; }
        //public int _userId { set; get; }
        DAL.DAL_QLCategory DAL_QLCategory = new DAL.DAL_QLCategory();
        Util.Util Util = new Util.Util();
        Message.Message Message = new Message.Message();
        Variable.Variable Variable = new Variable.Variable();
        public DataRow Data_Category { set; get; }
        int _ID_CATEGORY;
        public uc_Detail_Category()
        {
            InitializeComponent();
        }

        private void uc_Detail_Category_Load(object sender, EventArgs e)
        {
            if (Data_Category.ToString() != "")
            {
                _ID_CATEGORY = Util.Cnv_Int(Data_Category["id"].ToString().Trim());
                txt_name_category.Text = Data_Category["Name"].ToString().Trim();
                txt_Note.Text = Data_Category["Note"].ToString().Trim();
                txt_UpdateAt.Text = Data_Category["UpdatedAt"].ToString().Trim();
                txt_CreateAt.Text = Data_Category["CreatedAt"].ToString().Trim();
                txt_CreateBy.Text = Data_Category["UserCreate"].ToString().Trim();
                txt_UpdateBy.Text = Data_Category["UserUpdated"].ToString().Trim();
            }
        }
        private bool CheckValidate()
        {
            bool check = true;
            try
            {

            }
            catch (Exception ex)
            {
                throw;
            }
            return check;
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            category ctgr = new category();
            try
            {
                if (CheckValidate() == true)
                {
                    ctgr.Name = txt_name_category.Text.Trim();
                    ctgr.Note = txt_Note.Text.Trim();
                    ctgr.UpdatedAt = DateTime.Now;
                    ctgr.id = _ID_CATEGORY;
                    bool check = DAL_QLCategory.Add_and_Edit_Category(ctgr, Variable.action_status.is_update, _user);
                    if (check == true)
                    {
                        Util.Show_Message_Notification(Message.msg_notification, Message.msg_success_edit_data);
                        ((Form)this.TopLevelControl).Close();
                    }
                    else
                    {
                        Util.Show_Message_Error(Message.msg_error, Message.msg_error_edit_data);
                    }
                }
            }
            catch (Exception ex)
            {
                Util.Show_Message_Error(Message.msg_error, ex.Message.ToString());
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            category ctgr = new category();
            try
            {
                if (Util.Show_Message_YesNo("Xóa", "Chắc chắn xóa ?") == true)
                {
                    ctgr.UpdatedAt = DateTime.Now;
                    ctgr.Status = false;
                    ctgr.id = _ID_CATEGORY;
                    bool check = DAL_QLCategory.Add_and_Edit_Category(ctgr, Variable.action_status.is_delete, _user);
                    if (check == true)
                    {
                        Util.Show_Message_Notification(Message.msg_notification, Message.msg_success_delete_data);
                        ((Form)this.TopLevelControl).Close();
                    }
                    else
                    {
                        Util.Show_Message_Error(Message.msg_error, Message.msg_error_edit_data);
                    }
                }
            }
            catch (Exception ex)
            {
                Util.Show_Message_Error(Message.msg_error, ex.Message.ToString());
            }
        }
    }
}
