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
    public partial class uc_Detail_User : UserControl
    {
        DAL.DAL_QLUser DAL_QLUser = new DAL.DAL_QLUser();
        Util.Util Util = new Util.Util();
        Message.Message Message = new Message.Message();
        Variable.Variable Variable = new Variable.Variable();
        public DataRow Data_User { set; get; }
        int _ID_USER;
        public uc_Detail_User()
        {
            InitializeComponent();
        }

        private void uc_Detail_User_Load(object sender, EventArgs e)
        {
            if (Data_User.ToString() != "")
            {
                _ID_USER = Util.Cnv_Int(Data_User["id"].ToString().Trim());
                txt_username.Text = Data_User["UserName"].ToString().Trim();
                txt_Note.Text = Data_User["Note"].ToString().Trim();
                txt_fullname.Text = Data_User["FullName"].ToString().Trim();
                txt_idCard_user.Text = Data_User["IdCard"].ToString().Trim();
                txt_phone_user.Text = Data_User["PhoneNumber"].ToString().Trim();
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
            user ctgr = new user();
            try
            {
                if (CheckValidate() == true)
                {
                    //ctgr.UserName = txt_name_category.Text.Trim();
                    ctgr.Note = txt_Note.Text.Trim();
                    ctgr.UpdatedAt = DateTime.Now;
                    ctgr.id = _ID_USER;
                    bool check = DAL_QLUser.Add_and_Edit_User(ctgr, Variable.action_status.is_update);
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
            user ctgr = new user();
            try
            {
                if (Util.Show_Message_YesNo("Xóa", "Chắc chắn xóa ?") == true)
                {
                    ctgr.UpdatedAt = DateTime.Now;
                    ctgr.Status = false;
                    ctgr.id = _ID_USER;
                    bool check = DAL_QLUser.Add_and_Edit_User(ctgr, Variable.action_status.is_delete);
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
