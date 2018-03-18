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

        }
    }
}
