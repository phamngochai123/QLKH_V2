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
        }
        public void close_form()
        {
            this.Close();
        }
    }
}