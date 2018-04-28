using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using System.Threading;

namespace QLKH_v3.UI
{
    public partial class uc_LichSuTraTien : UserControl
    {
        public user _user { set; get; }
        DAL.DAL_LichSuTraTien DAL_Lichsutratien = new DAL.DAL_LichSuTraTien();
        Util.Util Util = new Util.Util();
        Message.Message Message = new Message.Message();
        Variable.Variable Variable = new Variable.Variable();
        public uc_LichSuTraTien()
        {
            InitializeComponent();
        }

        private void Load_Data()
        {
            try
            {
                grcHistoryPaid.DataSource = Util.ConvertToDataTable(DAL_Lichsutratien.Get_List_History_Paid());
            }
            catch (Exception ex)
            {
                Util.Show_Message_Error(Message.msg_error, ex.Message.ToString());

            }
        }

        private void uc_Category_Load(object sender, EventArgs e)
        {
            SplashScreenManager.ShowDefaultWaitForm();
            Load_Data();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private bool CheckValidate()
        {
            return true;
        }

        private void restart_form_historypaid()
        {
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
        }

        private void btn_cancel_historypaid_Click(object sender, EventArgs e)
        {
            restart_form_historypaid();
        }

        private void btn_add_historypaid_Click(object sender, EventArgs e)
        {
        }

        private void radio_type_paid_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_export_excel_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowserDialog1.SelectedPath;
                path = path.Replace('/', '\\');
                grvHistoryPaid.ExportToXls(@path + "\\Lịch sử thanh toán" + DateTime.Now.ToString(Variable.format_date_time_replace) + ".xls", true);
            }
        }
    }
}
