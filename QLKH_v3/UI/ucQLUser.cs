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
    public partial class ucQLUser : UserControl
    {
        DAL.DAL_QLUser Dal_User = new DAL.DAL_QLUser();
        public ucQLUser()
        {
            InitializeComponent();
            
        }

        private void ucQLUser_Load(object sender, EventArgs e)
        {
            grcUser.DataSource = Dal_User.Get_Data_User();
        }

    }
}
