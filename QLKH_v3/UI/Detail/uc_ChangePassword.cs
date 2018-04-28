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
    public partial class uc_ChangePassword : UserControl
    {
        Util.Util Util = new Util.Util();
        Message.Message Message = new Message.Message();
        DAL.DAL_QLUser DAL_QLUser = new DAL.DAL_QLUser();
        public user _user { get; set; }
        public uc_ChangePassword()
        {
            InitializeComponent();
        }

        public bool CheckValidate()
        {
            if (txt_password.Text == "")
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập mật khẩu cũ");
                return false;
            }
            else if (txt_password.Text != _user.PassWord)
            {
                Util.Show_Message_Notification(Message.msg_notification, "Mật khẩu cũ không chính xác");
                return false;
            }
            if (txt_new_password.Text == "")
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập mật khẩu mới");
                return false;
            }
            if (txt_confirm_password.Text == "")
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng xác nhận mật khẩu mới");
                return false;
            }
            else if (txt_new_password.Text != txt_confirm_password.Text)
            {
                Util.Show_Message_Notification(Message.msg_notification, "Xác nhận mật khẩu không chính xác !!!");
                return false;
            }
            return true;
        }

        private void btn_change_password_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckValidate())
                {
                    bool confirm = Util.Show_Message_YesNo(Message.msg_notification, "Chắc chắn đổi mật khẩu ?");
                    if (confirm)
                    {
                        bool check_change = DAL_QLUser.ChangePassword(_user, txt_new_password.Text);
                        if (check_change)
                        {
                            this.DialogResult = DialogResult.OK;
                            Util.Show_Message_Notification(Message.msg_notification, "Đổi mật khẩu thành công");
                            ((Form)this.TopLevelControl).Close();
                        }
                    }
                }
            }
            catch (Exception)
            {
                Util.Show_Message_Notification(Message.msg_notification, "Đổi mật khẩu thất bại, thử lại sau");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            ((Form)this.TopLevelControl).Close();
        }

        public DialogResult DialogResult { get; set; }
    }
}
