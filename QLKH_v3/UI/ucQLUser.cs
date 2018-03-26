using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace QLKH_v3.UI
{
    public partial class ucQLUser : UserControl
    {
        DAL.DAL_QLUser Dal_User = new DAL.DAL_QLUser();
        Util.Util Util = new Util.Util();
        Message.Message Message = new Message.Message();
        Variable.Variable Variable = new Variable.Variable();
        public ucQLUser()
        {
            InitializeComponent();
            
        }
        private void Load_Data()
        {
            try
            {
                grcUser.DataSource = Util.ConvertToDataTable(Dal_User.Get_Data_User());
            }
            catch (Exception ex)
            {
                Util.Show_Message_Error(Message.msg_error, ex.Message.ToString());

            }
        }
        private void ucQLUser_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private bool CheckValidate()
        {
            bool check = true;
            try
            {
                if (txt_add_fullname_user.Text.ToString().Trim() == "")
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập họ tên");
                    txt_add_fullname_user.Focus();
                    return false;
                }
                if (txt_add_username.Text.ToString().Trim() == "")
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập tên tài khoản");
                    txt_add_username.Focus();
                    return false;
                }
                if (txt_add_password.Text.ToString().Trim() == "")
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập mật khẩu");
                    txt_add_password.Focus();
                    return false;
                }
                if (txt_add_phone_user.Text.ToString().Trim() == "")
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập số điện thoại");
                    txt_add_phone_user.Focus();
                    return false;
                }
                if (txt_add_cmnd_user.Text.ToString().Trim() == "")
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập số chứng minh thư");
                    txt_add_cmnd_user.Focus();
                    return false;
                }
                if (txt_add_address_user.Text.ToString().Trim() == "")
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập địa chỉ");
                    txt_add_address_user.Focus();
                    return false;
                }
                if (date_birthday.Text.ToString().Trim() == "")
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Vui lòng chọn ngày sinh");
                    return false;
                }
                if (radio_sex_user.EditValue == null)
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Vui lòng chọn giới tính");
                    return false;
                }
                if (radio_type_user.EditValue == null)
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Vui lòng chọn loại tài khoản");
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return check;
        }

        private void grvUser_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                DataRow row = grvUser.GetDataRow(info.RowHandle);
                Detail_Infor Detail_Infor = new Detail_Infor();
                Detail_Infor.Str_Flag = Variable.detail_infor.User;
                Detail_Infor.Data = row;
                DialogResult dialog_result = Detail_Infor.ShowDialog();
                if (dialog_result == DialogResult.Cancel)
                {
                    Load_Data();
                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_them.Enabled = false;
            btn_confirm_user.Enabled = true;
            btn_cancel_user.Enabled = true;
            txt_add_address_user.ReadOnly = false;
            txt_add_cmnd_user.ReadOnly = false;
            txt_add_fullname_user.ReadOnly = false;
            txt_add_ghi_chu_user.ReadOnly = false;
            txt_add_password.ReadOnly = false;
            txt_add_phone_user.ReadOnly = false;
            txt_add_username.ReadOnly = false;
            date_birthday.Enabled = true;
            radio_sex_user.ReadOnly = false;
            radio_type_user.ReadOnly = false;
        }

        private void btn_confirm_user_Click(object sender, EventArgs e)
        {
            user usr = new user();
            try
            {
                if (CheckValidate() == true)
                {
                    usr.FullName = txt_add_fullname_user.Text.Trim();
                    usr.Note = txt_add_ghi_chu_user.Text.Trim();
                    usr.CreatedAt = DateTime.Now;
                    usr.UpdatedAt = DateTime.Now;
                    usr.Status = true;
                    usr.Address = txt_add_address_user.Text.Trim();
                    usr.UserName = txt_add_username.Text.Trim();
                    usr.PassWord = txt_add_password.Text.Trim();
                    usr.Type = (string)radio_type_user.EditValue;
                    usr.Sex = (bool)radio_sex_user.EditValue;
                    usr.BirthDay = DateTime.Parse(date_birthday.Text.ToString());
                    usr.IdCard = txt_add_cmnd_user.Text.Trim();
                    usr.PhoneNumber = txt_add_phone_user.Text.Trim();
                    bool check = Dal_User.Add_and_Edit_User(usr, Variable.action_status.is_add);
                    if (check == true)
                    {
                        Util.Show_Message_Notification(Message.msg_notification, Message.msg_success_add_data);
                        Load_Data();
                    }
                    else
                    {
                        Util.Show_Message_Error(Message.msg_error, Message.msg_error_add_data);
                    }
                    restart_form_add_user();
                }
            }
            catch (Exception ex)
            {
                Util.Show_Message_Error(Message.msg_error, ex.Message.ToString());
            }
        }

        private void btn_cancel_user_Click(object sender, EventArgs e)
        {
            restart_form_add_user();
        }

        private void restart_form_add_user()
        {
            btn_them.Enabled = true;
            btn_confirm_user.Enabled = false;
            btn_cancel_user.Enabled = false;
            txt_add_address_user.ReadOnly = true;
            txt_add_cmnd_user.ReadOnly = true;
            txt_add_fullname_user.ReadOnly = true;
            txt_add_ghi_chu_user.ReadOnly = true;
            txt_add_password.ReadOnly = true;
            txt_add_phone_user.ReadOnly = true;
            txt_add_username.ReadOnly = true;
            date_birthday.Enabled = false;
            radio_sex_user.ReadOnly = true;
            radio_type_user.ReadOnly = true;
            txt_add_address_user.Text = "";
            txt_add_cmnd_user.Text = "";
            txt_add_fullname_user.Text = "";
            txt_add_ghi_chu_user.Text = "";
            txt_add_password.Text = "";
            txt_add_phone_user.Text = "";
            txt_add_username.Text = "";
            date_birthday.Text = "";
            radio_sex_user.EditValue = null;
            radio_type_user.EditValue = null;
        }

    }
}
