using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKH_v3.UI
{
    public partial class ucQLKhachHang : UserControl
    {
        public user _user { set; get; }
        DAL.DAL_QLCategory DAL_QLCategory = new DAL.DAL_QLCategory();
        Util.Util Util = new Util.Util();
        Message.Message Message = new Message.Message();
        Variable.Variable Variable = new Variable.Variable();
        public ucQLKhachHang()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_fullname.ReadOnly = false;
            txt_address_customer.ReadOnly = false;
            txt_ghi_chu.ReadOnly = false;
            txt_idCard_customer.ReadOnly = false;
            txt_money.ReadOnly = false;
            txt_phone_customer.ReadOnly = false;
            txt_name_friend1.ReadOnly = false;
            txt_name_friend2.ReadOnly = false;
            txt_name_friend3.ReadOnly = false;
            txt_phone_friend1.ReadOnly = false;
            txt_phone_friend2.ReadOnly = false;
            txt_phone_friend3.ReadOnly = false;
            txt_rela_friend1.ReadOnly = false;
            txt_rela_friend2.ReadOnly = false;
            txt_rela_friend3.ReadOnly = false;
            txt_phone_family.ReadOnly = false;
            date_birthday.Enabled = true;
            radio_sex_customer.Enabled = true;
            cbx_category_customer.Enabled = true;
            btn_add_customer.Enabled = true;
            btn_cancel_customer.Enabled = true;
        }
    }
}
