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
    public partial class uc_QLDanhSachKhachHang : UserControl
    {
        public user _user { set; get; }
        DAL.DAL_QLCategory DAL_QLCategory = new DAL.DAL_QLCategory();
        DAL.DAL_QLCustomer DAL_QLCustomer = new DAL.DAL_QLCustomer();
        Util.Util Util = new Util.Util();
        Message.Message Message = new Message.Message();
        Variable.Variable Variable = new Variable.Variable();
        public uc_QLDanhSachKhachHang()
        {
            InitializeComponent();
        }

        private void Load_Data()
        {
            try
            {
                grcDanhSachKhachHang.DataSource = Util.ConvertToDataTable(DAL_QLCustomer.Get_List_Customer(Variable.orderByCreatedAt));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Detail_Infor Detail_Infor = new Detail_Infor();
            Detail_Infor._user = _user;
            UI.Detail.uc_Add_Customer uc_Add_Customer = new UI.Detail.uc_Add_Customer();
            int height = uc_Add_Customer.Size.Height;
            int width = uc_Add_Customer.Size.Width;
            //uc_List_Friend.List_Friend = Data_Friend;
            Detail_Infor.Size = new Size(width, height);
            Detail_Infor.Str_Flag = Variable.detail_infor.Form_Add_Customer;
            DialogResult dialog_result = Detail_Infor.ShowDialog();
            if (dialog_result == DialogResult.Cancel)
            {
                Load_Data();
            }
        }

        private void ucQLDanhSachKhachHang_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void grvDanhSachKhachHang_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DXMouseEventArgs ea = e as DXMouseEventArgs;
                GridView view = sender as GridView;
                GridHitInfo info = view.CalcHitInfo(ea.Location);
                if (info.InRow || info.InRowCell)
                {
                    DataRow row = grvDanhSachKhachHang.GetDataRow(info.RowHandle);
                    int idCustomer = int.Parse(row["id"].ToString().Trim());
                    Detail_Infor Detail_Infor = new Detail_Infor();
                    Detail_Infor.Str_Flag = Variable.detail_infor.Customer;
                    Detail_Infor.Data = row;
                    Detail_Infor._user = _user;
                    //Detail_Infor.ShowDialog();
                    DialogResult dialog_result = Detail_Infor.ShowDialog();
                    if (dialog_result == DialogResult.Cancel)
                    {
                        Load_Data();
                    }
                }
            }
            catch (Exception ex)
            {
                Util.Show_Message_Error(Message.msg_error, "Có lỗi xảy ra !!!");
            }
        }

        private void btn_export_excel_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowserDialog1.SelectedPath;
                path = path.Replace('/', '\\');
                grcDanhSachKhachHang.ExportToXls(@path + "\\Danh sách khách hàng" + DateTime.Now.ToString(Variable.format_date_time_replace) + ".xls", true);
            }
        }

        private void columnFriend_Click(object sender, EventArgs e)
        {

            int idCustomer = int.Parse(grvDanhSachKhachHang.GetFocusedRowCellValue("id").ToString());
            //int idCustomer = int.Parse(row["id"].ToString().Trim());
            Detail_Infor Detail_Infor = new Detail_Infor();
            Detail_Infor.Str_Flag = Variable.detail_infor.Friend_Customer;
            Detail_Infor.idCustomer = idCustomer;
            UI.Detail.uc_List_Friend uc_List_Friend = new UI.Detail.uc_List_Friend();
            int height = uc_List_Friend.Size.Height;
            int width = uc_List_Friend.Size.Width;
            //uc_List_Friend.List_Friend = Data_Friend;
            Detail_Infor.Size = new Size(width, height + 20);
            //Detail_Infor.Data_Friend = lst_friend;
            //Detail_Infor.Data = row;
            Detail_Infor._user = _user;
            Detail_Infor.ShowDialog();
        }

        private void columnPaid_Click(object sender, EventArgs e)
        {
            int idCustomer = int.Parse(grvDanhSachKhachHang.GetFocusedRowCellValue("id").ToString());
            //int idCustomer = int.Parse(row["id"].ToString().Trim());
            Detail_Infor Detail_Infor = new Detail_Infor();
            Detail_Infor.Str_Flag = Variable.detail_infor.Paid_Money;
            UI.Detail.uc_Thanh_Toan uc_Thanh_Toan = new UI.Detail.uc_Thanh_Toan();
            int height = uc_Thanh_Toan.Size.Height;
            int width = uc_Thanh_Toan.Size.Width;
            //uc_List_Friend.List_Friend = Data_Friend;
            Detail_Infor.Size = new Size(width, height + 20);
            Detail_Infor.idCustomer = idCustomer;
            Detail_Infor._user = _user;
            DialogResult dialog_result = Detail_Infor.ShowDialog();
            if (dialog_result == DialogResult.Cancel)
            {
                Load_Data();
            }
        }

        private void columnTransaction_Click(object sender, EventArgs e)
        {
            int idCustomer = int.Parse(grvDanhSachKhachHang.GetFocusedRowCellValue("id").ToString());
            //int idCustomer = int.Parse(row["id"].ToString().Trim());
            Detail_Infor Detail_Infor = new Detail_Infor();
            Detail_Infor.Str_Flag = Variable.detail_infor.History_Paid;
            UI.Detail.uc_Lichsuthanhtoan uc_Lichsuthanhtoan = new UI.Detail.uc_Lichsuthanhtoan();
            int height = uc_Lichsuthanhtoan.Size.Height;
            int width = uc_Lichsuthanhtoan.Size.Width;
            //uc_List_Friend.List_Friend = Data_Friend;
            Detail_Infor.Size = new Size(width, height);
            Detail_Infor.idCustomer = idCustomer;
            Detail_Infor._user = _user;
            Detail_Infor.ShowDialog();
        }
    }
}
