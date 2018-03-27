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
            Load_Data();
        }

        private bool CheckValidate()
        {
            if (txt_cmnd.Text.Trim() == "" && txt_phone.Text.Trim() == "")
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập số cmnd hoặc số điện thoại để xác thực thông tin khách hàng");
                return false;
            }
            if (numeric_money.Value == 0)
            {
                Util.Show_Message_Notification(Message.msg_notification, "Số tiền phải lớn hơn 0");
                return false;
            }
            if (radio_type_paid.EditValue == null)
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng chọn kiểu thanh toán");
                return false;
            }

            return true;
        }

        private void restart_form_historypaid()
        {
            radio_type_paid.EditValue = null;
            numeric_money.Value = 0;
            txt_phone.Text = "";
            txt_ghi_chu.Text = "";
            txt_cmnd.Text = "";
            btn_them.Enabled = true;
            btn_add_historypaid.Enabled = false;
            btn_cancel_historypaid.Enabled = false;
            radio_type_paid.Enabled = false;
            numeric_money.ReadOnly = true;
            txt_cmnd.ReadOnly = true;
            txt_ghi_chu.ReadOnly = true;
            txt_phone.ReadOnly = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_them.Enabled = false;
            btn_add_historypaid.Enabled = true;
            btn_cancel_historypaid.Enabled = true;
            radio_type_paid.Enabled = true;
            numeric_money.ReadOnly = false;
            txt_cmnd.ReadOnly = false;
            txt_ghi_chu.ReadOnly = false;
            txt_phone.ReadOnly = false;
        }

        private void btn_cancel_historypaid_Click(object sender, EventArgs e)
        {
            restart_form_historypaid();
        }

        private void btn_add_historypaid_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckValidate())
                {
                    customer Customer = DAL_Lichsutratien.Get_Customer_by_IdCard_or_PhoneNumber(txt_cmnd.Text.Trim(), txt_phone.Text.Trim());
                    if (Customer == null)
                    {
                        Util.Show_Message_Notification(Message.msg_notification, "Khách hàng không tồn tại, Vui lòng kiểm tra lại");
                    }
                    else
                    {
                        DAL_Lichsutratien.Get_Tien_Lai(Customer.id);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void radio_type_paid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radio_type_paid.EditValue == "1")
            {

            }
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
