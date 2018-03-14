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
    public partial class ucQLLaiSuat : UserControl
    {
        DAL.DAL_QLLaiSuat DAL_QLLaiSuat = new DAL.DAL_QLLaiSuat();
        Util.Util Util = new Util.Util();
        Message.Message Message = new Message.Message();
        Variable.Variable Variable = new Variable.Variable();
        public ucQLLaiSuat()
        {
            InitializeComponent();
        }
        private void Load_Data()
        {
            try
            {
                grcLaiSuat.DataSource = Util.ConvertToDataTable(DAL_QLLaiSuat.Get_List_InterestRate());
            }
            catch (Exception ex)
            {
                Util.Show_Message_Error(Message.msg_error, ex.Message.ToString());

            }
        }

        private void ucQLLaiSuat_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
    }
}
