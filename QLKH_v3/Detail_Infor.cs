using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLKH_v3
{
    public partial class Detail_Infor : DevExpress.XtraEditors.XtraForm
    {
        public user _user { set; get; }
        //public int _userId { set; get; }
        Variable.Variable variable = new Variable.Variable();
        public String Str_Flag { set; get; }
        public DataRow Data { set; get; }
        public int idCustomer { set; get; }
        //public List<Model.Friend> Data_Friend { set; get; }
        public Detail_Infor()
        {

            InitializeComponent();

        }

        private void Detail_Infor_Load(object sender, EventArgs e)
        {
            if (Str_Flag == variable.detail_infor.Category)
            {
                UI.Detail.uc_Detail_Category uc_Detail_Category = new UI.Detail.uc_Detail_Category();
                uc_Detail_Category.Data_Category = Data;
                uc_Detail_Category.Dock = DockStyle.Fill;
                panelMain.Controls.Clear();
                panelMain.Controls.Add(uc_Detail_Category);
                uc_Detail_Category._user = _user;
            }
            if (Str_Flag == variable.detail_infor.User)
            {
                UI.Detail.uc_Detail_User uc_Detail_User = new UI.Detail.uc_Detail_User();
                uc_Detail_User.Data_User = Data;
                uc_Detail_User.Dock = DockStyle.Fill;
                panelMain.Controls.Clear();
                panelMain.Controls.Add(uc_Detail_User);
            }
            if (Str_Flag == variable.detail_infor.Customer)
            {
                UI.Detail.uc_Detail_Customer uc_Detail_Customer = new UI.Detail.uc_Detail_Customer();
                uc_Detail_Customer.Data_Customer = Data;
                uc_Detail_Customer.Dock = DockStyle.Fill;
                panelMain.Controls.Clear();
                panelMain.Controls.Add(uc_Detail_Customer);
                uc_Detail_Customer._user = _user;
            }
            if (Str_Flag == variable.detail_infor.Friend_Customer)
            {
                UI.Detail.uc_List_Friend uc_List_Friend = new UI.Detail.uc_List_Friend();
                //uc_List_Friend.List_Friend = Data_Friend;
                uc_List_Friend.idCustomer = idCustomer;
                uc_List_Friend.Dock = DockStyle.Fill;
                panelMain.Controls.Clear();
                panelMain.Controls.Add(uc_List_Friend);
            }
            if (Str_Flag == variable.detail_infor.Paid_Money)
            {
                UI.Detail.uc_Thanh_Toan uc_Thanh_Toan = new UI.Detail.uc_Thanh_Toan();
                //uc_List_Friend.List_Friend = Data_Friend;
                uc_Thanh_Toan.idCustomer = idCustomer;
                uc_Thanh_Toan._user = _user;
                uc_Thanh_Toan.Dock = DockStyle.Fill;
                panelMain.Controls.Clear();
                panelMain.Controls.Add(uc_Thanh_Toan);
            }
            if (Str_Flag == variable.detail_infor.History_Paid)
            {
                UI.Detail.uc_Lichsuthanhtoan uc_Lichsuthanhtoan = new UI.Detail.uc_Lichsuthanhtoan();
                //uc_List_Friend.List_Friend = Data_Friend;
                uc_Lichsuthanhtoan.idCustomer = idCustomer;
                uc_Lichsuthanhtoan.Dock = DockStyle.Fill;
                panelMain.Controls.Clear();
                panelMain.Controls.Add(uc_Lichsuthanhtoan);
            }
            if (Str_Flag == variable.detail_infor.ChangePassword)
            {
                UI.Detail.uc_ChangePassword uc_ChangePassword = new UI.Detail.uc_ChangePassword();
                //uc_List_Friend.List_Friend = Data_Friend;
                uc_ChangePassword._user = _user;
                uc_ChangePassword.Dock = DockStyle.Fill;
                panelMain.Controls.Clear();
                panelMain.Controls.Add(uc_ChangePassword);
            }
        }
        public void close_form()
        {
            this.Close();
        }
    }
}