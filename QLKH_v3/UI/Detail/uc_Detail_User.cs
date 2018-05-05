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
                txt_idCard_user.Text = Data_User["CMND"].ToString().Trim();
                txt_phone_user.Text = Data_User["PhoneNumber"].ToString().Trim();
                txt_address_user.Text = Data_User["Address"].ToString().Trim();
                radio_sex_user.EditValue = (bool)Data_User["Sex"];
                radio_type_user.EditValue = Data_User["Type"];
                birthDay_user.Text = (DateTime.Parse(Data_User["BirthDay"].ToString().Trim())).ToString(Variable.format_date);
            }
        }
        private bool CheckValidate()
        {
            bool check = true;
            try
            {
                if (txt_address_user.Text.ToString().Trim() == "")
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập địa chỉ");
                    txt_address_user.Focus();
                    return false;
                }
                if (txt_fullname.Text.ToString().Trim() == "")
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập họ tên");
                    txt_fullname.Focus();
                    return false;
                }
                if (txt_idCard_user.Text.ToString().Trim() == "")
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập số chứng minh thư");
                    txt_idCard_user.Focus();
                    return false;
                }
                if (txt_phone_user.Text.ToString().Trim() == "")
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập số điện thoại");
                    txt_phone_user.Focus();
                    return false;
                }
                if (txt_username.Text.ToString().Trim() == "")
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập username");
                    txt_username.Focus();
                    return false;
                }
                if (birthDay_user.Text.ToString().Trim() == "")
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Vui lòng chọn ngày sinh");
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return check;
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            user ctgr = new user();
            try
            {
                if (CheckValidate() == true)
                    if (Util.Show_Message_YesNo(Message.msg_notification, "Chắc chắn sửa"))
                    {
                        {
                            //ctgr.UserName = txt_name_category.Text.Trim();
                            if (txt_password_user.Text.ToString().Trim() != "")
                            {
                                ctgr.PassWord = txt_password_user.Text.Trim();
                            }
                            ctgr.FullName = txt_fullname.Text.Trim();
                            ctgr.PhoneNumber = txt_phone_user.Text.Trim();
                            ctgr.Address = txt_address_user.Text.Trim();
                            ctgr.Note = txt_Note.Text.Trim();
                            ctgr.BirthDay = DateTime.Parse(birthDay_user.Text.Trim());
                            ctgr.Sex = (bool)radio_sex_user.EditValue;
                            ctgr.Type = (string)radio_type_user.EditValue;
                            ctgr.IdCard = txt_idCard_user.Text.Trim();
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
