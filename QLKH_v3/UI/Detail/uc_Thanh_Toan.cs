using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKH_v3.UI.Detail
{
    public partial class uc_Thanh_Toan : UserControl
    {
        public user _user { get; set; }
        public int idCustomer { set; get; }
        public double _tien_goc_con_no { get; set; }
        public double _tien_lai { get; set; }
        Util.Util Util = new Util.Util();
        Variable.Variable Variable = new Variable.Variable();
        DAL.DAL_QLCustomer DAL_QLCustomer = new DAL.DAL_QLCustomer();
        DAL.DAL_LichSuTraTien DAL_LichSuTraTien = new DAL.DAL_LichSuTraTien();
        Message.Message Message = new Message.Message();
        public uc_Thanh_Toan()
        {
            InitializeComponent();
        }

        private void uc_Thanh_Toan_Load(object sender, EventArgs e)
        {
            try
            {
                customer Customer = DAL_QLCustomer.Get_Customer(idCustomer);
                int tien_vay = Customer.Money;
                double tien_goc_con_no = DAL_QLCustomer.Get_After_Money(idCustomer);
                double tien_goc_da_tra = tien_vay - tien_goc_con_no;
                double tien_lai = DAL_LichSuTraTien.Get_Tien_Lai(idCustomer);

                _tien_goc_con_no = tien_goc_con_no;
                _tien_lai = tien_lai;

                lbl_fullname.Text = Customer.FullName.ToString();
                lbl_cmnd.Text = Customer.IdCard.ToString();
                lbl_tien_goc.Text = tien_vay.ToString();
                lbl_tien_goc_da_tra.Text = tien_goc_da_tra.ToString();
                lbl_tien_goc_con_no.Text = tien_goc_con_no.ToString();
                lbl_tien_lai.Text = tien_lai.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void radio_type_paid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(radio_type_paid.EditValue.ToString() == "0"){
                    //var floatNumber = _tien_goc_con_no;
                    //var x = floatNumber.ToString().Substring(0, floatNumber.ToString().IndexOf(","));
                    //num_tien_tra.Maximum = Convert.ToInt32(_tien_goc_con_no);
                }

                if (radio_type_paid.EditValue.ToString() == "1")
                {
                    //var floatNumber = _tien_lai;
                    //var x = floatNumber.ToString().Substring(0, floatNumber.ToString().IndexOf("."));
                    //num_tien_tra.Maximum = Convert.ToInt32(_tien_lai); ;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void btn_thanh_toan_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckValidate())
                {
                    historyPaid paid = new historyPaid();
                    paid.Money = Convert.ToInt32(num_tien_tra.Value);
                    paid.TypePaid = radio_type_paid.EditValue.ToString();
                    paid.CustomerId = idCustomer;
                    paid.CreatedAt = DateTime.Now;
                    paid.UpdatedAt = DateTime.Now;
                    paid.UpdatedBy = _user.id;
                    paid.CreatedBy = _user.id;
                    paid.Status = true;
                    paid.PaidDate = DateTime.Now;
                    bool check =  DAL_LichSuTraTien.Add_Paid_Money(paid, Variable.action_status.is_add, _user);
                    if (check)
                    {
                        Util.Show_Message_Notification(Message.msg_notification, "Thanh toán thành công !!!");
                        ((Form)this.TopLevelControl).Close();
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool CheckValidate()
        {
            try
            {
                if (num_tien_tra.Value == 0)
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Số tiền phải > 0");
                    return false;
                }
                if (radio_type_paid.EditValue.ToString() == "<Null>")
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Vui lòng chọn kiểu thanh toán");
                    return false;
                }
                else if (radio_type_paid.EditValue.ToString() == "0" && num_tien_tra.Value > Convert.ToInt32(_tien_goc_con_no))
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Số tiền không thể > số tiền đang nợ");
                    return false;
                }
                else if (radio_type_paid.EditValue.ToString() == "1" && num_tien_tra.Value != Convert.ToInt32(_tien_lai))
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Số tiền trả phải bằng số tiền lãi đang nợ");
                    num_tien_tra.Value = 0;
                    return false;
                }

            }
            catch (Exception)
            {
                
                throw;
            }
            return true;
        }
    }
}
