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
                grcUser.DataSource = Dal_User.Get_Data_User();
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

    }
}
