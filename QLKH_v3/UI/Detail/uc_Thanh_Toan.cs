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
        bool _isTiengoc = false, _isTienlai = false;
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
                lbl_tien_goc.Text = Util.formatMoney(Convert.ToInt32(tien_vay));
                lbl_tien_goc_da_tra.Text = Util.formatMoney(Convert.ToInt32(tien_goc_da_tra));
                lbl_tien_goc_con_no.Text = Util.formatMoney(Convert.ToInt32(tien_goc_con_no));
                lbl_tien_lai.Text = Util.formatMoney(Convert.ToInt32(tien_lai));
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
            bool check = false, checkTienLai = false, checkTienGoc = false;
            try
            {
                if (CheckValidate())
                {

                    bool confirmPaid = Util.Show_Message_YesNo(Message.msg_notification, "Chắc chắn thanh toán ?");
                    if (confirmPaid)
                    {
                        if (_isTienlai)
                        {
                            historyPaid paid = new historyPaid();
                            paid.Money = Convert.ToInt32(txt_money_lai.Text.ToString().Trim().Replace(",", ""));
                            paid.TypePaid = "1";
                            paid.CustomerId = idCustomer;
                            paid.CreatedAt = DateTime.Now;
                            paid.UpdatedAt = DateTime.Now;
                            paid.UpdatedBy = _user.id;
                            paid.CreatedBy = _user.id;
                            paid.Status = true;
                            paid.PaidDate = DateTime.Now;
                            checkTienLai = DAL_LichSuTraTien.Add_Paid_Money(paid, Variable.action_status.is_add, _user);
                        }
                        if (_isTiengoc)
                        {
                            historyPaid paid = new historyPaid();
                            paid.Money = Convert.ToInt32(txt_money.Text.ToString().Trim().Replace(",", ""));
                            paid.TypePaid = "0";
                            paid.CustomerId = idCustomer;
                            paid.CreatedAt = DateTime.Now;
                            paid.UpdatedAt = DateTime.Now;
                            paid.UpdatedBy = _user.id;
                            paid.CreatedBy = _user.id;
                            paid.Status = true;
                            paid.PaidDate = DateTime.Now;
                            checkTienGoc = DAL_LichSuTraTien.Add_Paid_Money(paid, Variable.action_status.is_add, _user);
                        }
                        if (_isTienlai && _isTiengoc)
                        {
                            if (checkTienGoc && checkTienLai)
                            {
                                check = true;
                            }
                        }
                        else if (_isTiengoc)
                        {
                            if (checkTienGoc)
                            {
                                check = true;
                            }
                        }
                        else if (_isTienlai)
                        {
                            if (checkTienLai)
                            {
                                check = true;
                            }
                        }
                        if (check)
                        {
                            Util.Show_Message_Notification(Message.msg_notification, "Thanh toán thành công !!!");
                            ((Form)this.TopLevelControl).Close();
                        }
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
                if ((txt_money.Text.ToString().Trim() == "" || txt_money.Text.ToString().Trim() == null) && (txt_money_lai.Text.ToString().Trim() == "" || txt_money_lai.Text.ToString().Trim() == null))
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập số tiền");
                    txt_money.Focus();
                    return false;
                }
                else if (txt_money.Text.ToString().Trim() == "" || txt_money.Text.ToString().Trim() == null)
                {
                    int parsedValue;
                    if (!int.TryParse(txt_money_lai.Text.ToString().Trim().Replace(",", ""), out parsedValue))
                    {
                        Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập đúng định dạng số tiền lãi");
                        txt_money_lai.Focus();
                        return false;
                    }

                    else if (Convert.ToInt32(txt_money_lai.Text.ToString().Trim().Replace(",", "")) != Convert.ToInt32(_tien_lai))
                    {
                        Util.Show_Message_Notification(Message.msg_notification, "Số tiền trả phải bằng số tiền lãi đang nợ");
                        txt_money_lai.Focus();
                        return false;
                    }
                    else
                    {
                        _isTienlai = true;
                    }
                }
                else if (txt_money_lai.Text.ToString().Trim() == "" || txt_money_lai.Text.ToString().Trim() == null)
                {
                    int parsedValue;
                    if (!int.TryParse(txt_money.Text.ToString().Trim().Replace(",", ""), out parsedValue))
                    {
                        Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập đúng định dạng số tiền gốc");
                        txt_money.Focus();
                        return false;
                    }

                    else if (Convert.ToInt32(txt_money.Text.ToString().Trim().Replace(",", "")) > Convert.ToInt32(_tien_goc_con_no))
                    {
                        Util.Show_Message_Notification(Message.msg_notification, "Số tiền không thể > số tiền đang nợ");
                        txt_money.Focus();
                        return false;
                    }
                    else
                    {
                        _isTiengoc = true;
                    }
                }
                else
                {
                    int parsedValue;
                    if (!int.TryParse(txt_money.Text.ToString().Trim().Replace(",", ""), out parsedValue))
                    {
                        Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập đúng định dạng số tiền gốc");
                        txt_money.Focus();
                        return false;
                    }

                    else if (Convert.ToInt32(txt_money.Text.ToString().Trim().Replace(",", "")) > Convert.ToInt32(_tien_goc_con_no))
                    {
                        Util.Show_Message_Notification(Message.msg_notification, "Số tiền không thể > số tiền đang nợ");
                        txt_money.Focus();
                        return false;
                    }
                    else
                    {
                        _isTiengoc = true;
                    }
                    if (!int.TryParse(txt_money_lai.Text.ToString().Trim().Replace(",", ""), out parsedValue))
                    {
                        Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập đúng định dạng số tiền lãi");
                        txt_money_lai.Focus();
                        return false;
                    }

                    else if (Convert.ToInt32(txt_money_lai.Text.ToString().Trim().Replace(",", "")) != Convert.ToInt32(_tien_lai))
                    {
                        Util.Show_Message_Notification(Message.msg_notification, "Số tiền trả phải bằng số tiền lãi đang nợ");
                        txt_money_lai.Focus();
                        return false;
                    }
                    else
                    {
                        _isTienlai = true;
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }

        private void txt_money_KeyUp(object sender, KeyEventArgs e)
        {
            Util.formatTextToMoney(txt_money);
        }

        private void txt_money_lai_KeyUp(object sender, KeyEventArgs e)
        {
            Util.formatTextToMoney(txt_money_lai);
        }
    }
}
