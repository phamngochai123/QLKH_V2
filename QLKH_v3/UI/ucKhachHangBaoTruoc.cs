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

namespace QLKH_v3.UI
{
    public partial class ucKhachHangBaoTruoc : UserControl
    {
        public user _user { set; get; }
        DAL.DAL_QLCategory DAL_QLCategory = new DAL.DAL_QLCategory();
        DAL.DAL_QLCustomer DAL_QLCustomer = new DAL.DAL_QLCustomer();
        Util.Util Util = new Util.Util();
        Message.Message Message = new Message.Message();
        Variable.Variable Variable = new Variable.Variable();
        public ucKhachHangBaoTruoc()
        {
            InitializeComponent();
        }
        private void Load_Data()
        {
            try
            {
                grcKhachHangBaoTruoc.DataSource = Util.ConvertToDataTable(DAL_QLCustomer.Get_List_Customer(Variable.orderByAfterDate));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void ucKhachHangBaoTruoc_Load(object sender, EventArgs e)
        {
            SplashScreenManager.ShowDefaultWaitForm();
            Load_Data();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowDefaultWaitForm();
            int soNgay = Convert.ToInt32(numberDay.Value);
            if (soNgay > 0)
            {
                List<Model.Customer> lst_Customer = new List<Model.Customer>();
                DateTime afterDate = DateTime.Now.AddDays(soNgay);
                var DataSource = DAL_QLCustomer.Get_List_Customer(Variable.orderByAfterDate);
                DataSource = DataSource.Where(x => (((afterDate - x.CreatedAt).Days + 1) % x.Cycle == 0)).ToList();
                grcKhachHangBaoTruoc.DataSource = Util.ConvertToDataTable(DataSource);
            }
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void btn_export_excel_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowserDialog1.SelectedPath;
                path = path.Replace('/', '\\');
                grcKhachHangBaoTruoc.ExportToXls(@path + "\\Danh sách khách hàng cần báo trước" + DateTime.Now.ToString(Variable.format_date_time_replace) + ".xls", true);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Load_Data();
        }
    }
}
