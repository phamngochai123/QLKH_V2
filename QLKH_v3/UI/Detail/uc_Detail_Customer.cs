using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;

namespace QLKH_v3.UI.Detail
{
    public partial class uc_Detail_Customer : UserControl
    {
        public user _user { set; get; }
        DAL.DAL_QLCustomer DAL_QLCustomer = new DAL.DAL_QLCustomer();
        DAL.DAL_QLCategory DAL_QLCategory = new DAL.DAL_QLCategory();
        DAL.DAL_LichSuTraTien DAL_LichSuTraTien = new DAL.DAL_LichSuTraTien();
        Util.Util Util = new Util.Util();
        Message.Message Message = new Message.Message();
        Variable.Variable Variable = new Variable.Variable();
        public DataRow Data_Customer { set; get; }
        int _ID_CUSTOMER;
        public uc_Detail_Customer()
        {
            InitializeComponent();
        }

        public void uc_Detail_Customer_Load(object sender, EventArgs e)
        {
            if (Data_Customer.ToString() != "")
            {
                List<category> lst_category = new List<category>();

                lst_category = DAL_QLCategory.Get_List_Category("category");

                ImageComboBoxItem item;
                foreach (var data in lst_category)
                {
                    item = new ImageComboBoxItem(data.Name, data.id, data.id);
                    cbb_category.Properties.Items.Add(item);
                }
                _ID_CUSTOMER = Util.Cnv_Int(Data_Customer["id"].ToString().Trim());
                txt_edit_fullname.Text = Data_Customer["FullName"].ToString().Trim();
                txt_edit_note.Text = Data_Customer["Note"].ToString().Trim();
                txt_edit_familyphone.Text = Data_Customer["FamilyPhone"].ToString().Trim();
                txt_edit_idcard.Text = Data_Customer["IdCard"].ToString().Trim();
                txt_edit_money.Text = Data_Customer["Money"].ToString().Trim();
                txt_edit_phone.Text = Data_Customer["PhoneNumber"].ToString().Trim();
                radio_edit_sex.EditValue = (bool)Data_Customer["Sex"];
                txt_edit_address.Text = Data_Customer["Address"].ToString().Trim();
                cbb_category.EditValue = int.Parse(Data_Customer["IdCategory"].ToString());
                birthDay_customer.Text = (DateTime.Parse(Data_Customer["BirthDay"].ToString().Trim())).ToString(Variable.format_date);
                date_paid.Text = (DateTime.Parse(Data_Customer["CreatedAt"].ToString().Trim())).ToString(Variable.format_date);
            }
        }

        public bool CheckValidate()
        {
            if (txt_edit_fullname.Text.ToString().Trim() == "")
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập họ tên");
                return false;
            }
            if (txt_edit_address.Text.ToString().Trim() == "")
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập địa chỉ");
                return false;
            }
            if (txt_edit_idcard.Text.ToString().Trim() == "")
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập số chứng minh thư");
                return false;
            }
            if (txt_edit_money.Text.ToString().Trim() == "")
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập số tiền vay");
                return false;
            }
            if (txt_edit_phone.Text.ToString().Trim() == "")
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập");
                return false;
            }
            if (txt_edit_familyphone.Text.ToString().Trim() == "")
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập số điện thoại gia đình");
                return false;
            }
            if (birthDay_customer.Text.ToString().Trim() == "")
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập ngày sinh");
                return false;
            }
            if (cbb_category.EditValue == null)
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng chọn đồ cần cầm");
                return false;
            }
            return true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                customer Customer = new customer();
                if (CheckValidate())
                {
                    Customer.Address = txt_edit_address.Text.ToString().Trim();
                    Customer.BirthDay = DateTime.Parse(birthDay_customer.Text.ToString().Trim());
                    Customer.FullName = txt_edit_fullname.Text.ToString().Trim();
                    Customer.IdCard = txt_edit_idcard.Text.ToString().Trim();
                    Customer.PhoneNumber = txt_edit_phone.Text.ToString().Trim();
                    Customer.Sex = (bool)radio_edit_sex.EditValue;
                    Customer.FamilyPhoneNumber = txt_edit_familyphone.Text.ToString().Trim();
                    Customer.CategoryId = int.Parse(cbb_category.EditValue.ToString());
                    Customer.Money = int.Parse(txt_edit_money.Text.ToString().Trim());
                    Customer.Note = txt_edit_note.Text.ToString().Trim();
                    Customer.id = _ID_CUSTOMER;
                    bool check = DAL_QLCustomer.Add_and_Edit_Customer(Customer, new List<Model.Friend>(), Variable.action_status.is_update, _user);
                    if (check == true)
                    {
                        Util.Show_Message_Notification(Message.msg_notification, Message.msg_success_edit_data);
                        ((Form)this.TopLevelControl).Close();
                    }
                    else
                    {
                        Util.Show_Message_Error(Message.msg_error, Message.msg_error_edit_data);
                    }
                }
            }
            catch (Exception ex)
            {
                Util.Show_Message_Error(Message.msg_error, ex.Message.ToString());
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {

                double tien_lai = DAL_LichSuTraTien.Get_Tien_Lai(_ID_CUSTOMER);
                double tien_no = DAL_QLCustomer.Get_After_Money(_ID_CUSTOMER);
                if (tien_lai + tien_no > 0)
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Không thể xóa vì khách hàng vẫn còn nợ \n tiền lãi: " + tien_lai.ToString() + "\n tiền gốc: " + tien_no.ToString());
                }
                else
                {
                    bool check = Util.Show_Message_YesNo(Message.msg_notification, "Chắc chắn xóa");
                    if (check)
                    {
                        customer Customer = new customer();
                        Customer.id = _ID_CUSTOMER;
                        bool check_delete = DAL_QLCustomer.Add_and_Edit_Customer(Customer, new List<Model.Friend>(), Variable.action_status.is_delete, _user);
                        if (check_delete)
                        {
                            Util.Show_Message_Notification(Message.msg_notification, Message.msg_success_edit_data);
                            ((Form)this.TopLevelControl).Close();
                        }
                        else
                        {
                            Util.Show_Message_Error(Message.msg_error, Message.msg_error_delete_data);
                        }
                    }
                }
            }
            catch (Exception)
            {
                Util.Show_Message_Error(Message.msg_error, Message.msg_error_delete_data);
            }

        }
    }
}
