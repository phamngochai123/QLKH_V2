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
        public user _user { set; get; }
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
            this.UseWaitCursor = true;
            Load_Data();
            this.UseWaitCursor = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            date_start.Enabled = true;
            txt_percent.ReadOnly = false;
            txt_ghi_chu.ReadOnly = false;
            btn_add_interest.Enabled = true;
            btn_them.Enabled = false;
            btn_cancel_interest.Enabled = true;
        }

        public void restartFormAddInterest()
        {
            txt_percent.Text = "";
            txt_ghi_chu.Text = "";
            date_start.Text = "";
            txt_ghi_chu.ReadOnly = true;
            txt_percent.ReadOnly = true;
            date_start.Enabled = false;
            btn_them.Enabled = true;
            btn_cancel_interest.Enabled = false;
            btn_add_interest.Enabled = false;
        }

        public bool CheckValidate()
        {
            try
            {
                if (txt_percent.Text.ToString().Trim() == "")
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập phần trăm lãi xuất");
                    txt_percent.Focus();
                    return false;
                }
                else
                {
                    double percents;
                    bool isDouble = Double.TryParse(txt_percent.Text.ToString().Trim(), out percents);
                    if (!isDouble)
                    {
                        Util.Show_Message_Notification(Message.msg_notification, "Lãi suất nhập không đúng định dạng");
                        txt_percent.Focus();
                        return false;
                    }
                }

                if (date_start.Text.ToString().Trim() == "")
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập ngày bắt đầu");
                    date_start.Focus();
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        private void btn_add_interest_Click(object sender, EventArgs e)
        {
            try
            {
                historyInterestRate historyInterest = new historyInterestRate();
                if (CheckValidate() == true)
                {
                    historyInterest.Percents = Double.Parse(txt_percent.Text.Trim());
                    historyInterest.Note = txt_ghi_chu.Text.Trim();
                    historyInterest.CreatedAt = DateTime.Now;
                    historyInterest.UpdatedAt = DateTime.Now;
                    historyInterest.Status = true;
                    historyInterest.StartDate = DateTime.Parse(date_start.Text.ToString().Trim());

                    bool check = DAL_QLLaiSuat.Add_and_Edit_HistoryInterest(historyInterest, Variable.action_status.is_add, _user);
                    if (check == true)
                    {
                        Util.Show_Message_Notification(Message.msg_notification, Message.msg_success_add_data);
                        Load_Data();
                    }
                    else
                    {
                        Util.Show_Message_Error(Message.msg_error, Message.msg_error_add_data);
                    }
                    restartFormAddInterest();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void btn_cancel_interest_Click(object sender, EventArgs e)
        {
            restartFormAddInterest();
        }
    }
}
