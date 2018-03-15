using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKH_v3
{
    public partial class Login : Form
    {
        //public int _userId { set; get; }
        public user _user { set; get; }
        DAL.DAL_QLUser DAL_QLUser = new DAL.DAL_QLUser();
        Util.Util Util = new Util.Util();
        Message.Message Message = new Message.Message();
        Variable.Variable Variable = new Variable.Variable();
        public Login()
        {
            InitializeComponent();
        }

        private bool checkValidate()
        {
            if (txt_login_username.Text.ToString().Trim() == "")
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập tên tài khoản");
                return false;
            }
            if (txt_login_password.Text.ToString().Trim() == "")
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập mật khẩu");
                return false;
            }
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (checkValidate())
            {
                user user = new user();
                user = DAL_QLUser.Check_Login(txt_login_username.Text.ToString().Trim(), txt_login_password.Text.ToString().Trim());
                if (user != null)
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Đăng nhập thành công");
                    _user = user;
                    //_userId = user.id;
                    this.Hide();
                }
                else
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Tài khoản hoặc mật khẩu không chính xác !!!");
                }
            }
        }
    }
}
