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
            if (txt_login_username.Text.ToString().Trim() == "" || txt_login_username.Text == "Tên đăng nhập")
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập tên tài khoản");
                return false;
            }
            if (txt_login_password.Text.ToString().Trim() == "" || txt_login_password.Text == "Mật khẩu")
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập mật khẩu");
                return false;
            }
            return true;
        }

        private void HandleLogin()
        {
            try
            {
                if (checkValidate())
                {
                    user user = new user();
                    user = DAL_QLUser.Check_Login(txt_login_username.Text.ToString().Trim(), txt_login_password.Text.ToString().Trim());
                    if (user != null)
                    {
                        _user = user;
                        this.Hide();
                    }
                    else
                    {
                        Util.Show_Message_Notification(Message.msg_notification, "Tài khoản hoặc mật khẩu không chính xác !!!");
                    }
                }
            }
            catch (Exception ex)
            {
                Util.Show_Message_Error(Message.msg_error, "không thể kết nối đến cơ sở dữ liệu");
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.UseWaitCursor = true;
            btnExit.UseWaitCursor = true;
            HandleLogin();
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                HandleLogin();
            }
        }

        public void RemoveTextUser(object sender, EventArgs e)
        {
            txt_login_username.Text = "";
        }
        public void RemoveTextPassWord(object sender, EventArgs e)
        {
            txt_login_password.Text = "";
            txt_login_password.Properties.PasswordChar = '*';
        }
        public void AddTextUser(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_login_username.Text))
                txt_login_username.Text = "Tên đăng nhập";
            txt_login_username.ForeColor = Color.Gray;
        }

        public void AddTextPassWord(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_login_password.Text))
            {
                txt_login_password.Text = "Mật khẩu";
                txt_login_password.Properties.PasswordChar = '\0';
                txt_login_password.ForeColor = Color.Gray;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txt_login_username.Text = "Tên đăng nhập";
            txt_login_password.Text = "Mật khẩu";

            txt_login_username.ForeColor = Color.Gray;
            txt_login_password.ForeColor = Color.Gray;

            txt_login_username.GotFocus += new EventHandler(RemoveTextUser);
            txt_login_username.LostFocus += new EventHandler(AddTextUser);

            txt_login_password.GotFocus += new EventHandler(RemoveTextPassWord);
            txt_login_password.LostFocus += new EventHandler(AddTextPassWord);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
