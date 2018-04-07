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
    public partial class uc_Add_Customer : UserControl
    {
        public user _user { set; get; }
        DAL.DAL_QLCategory DAL_QLCategory = new DAL.DAL_QLCategory();
        DAL.DAL_QLCustomer DAL_QLCustomer = new DAL.DAL_QLCustomer();
        Util.Util Util = new Util.Util();
        Message.Message Message = new Message.Message();
        Variable.Variable Variable = new Variable.Variable();
        public uc_Add_Customer()
        {
            InitializeComponent();
        }

        private bool CheckValidate()
        {
            if (txt_fullname.Text.ToString().Trim() == "" || txt_fullname.Text.ToString().Trim() == null)
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập họ tên");
                return false;
            }
            if (txt_address.Text.ToString().Trim() == "" || txt_address.Text.ToString().Trim() == null)
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập địa chỉ");
                return false;
            }
            if (txt_idcard.Text.ToString().Trim() == "" || txt_idcard.Text.ToString().Trim() == null)
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập số chứng minh thư");
                return false;
            }
            if (txt_money.Value == null || txt_money.Value == 0)
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập số tiền vay");
                return false;
            }
            if (txt_phone.Text.ToString().Trim() == "" || txt_phone.Text.ToString().Trim() == null)
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập");
                return false;
            }
            if (txt_familyphone.Text.ToString().Trim() == "" || txt_familyphone.Text.ToString().Trim() == null)
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập số điện thoại gia đình");
                return false;
            }
            if (birthDay_customer.Text.ToString().Trim() == "" || birthDay_customer.Text.ToString().Trim() == null)
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập ngày sinh");
                return false;
            }
            if (radio_sex.EditValue == null)
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng chọn giới tính");
                return false;
            }
            if (cbb_category.EditValue == null)
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng chọn đồ cần cầm");
                return false;
            }
            if (txt_cycle.Value == 0 || txt_cycle.Value == null)
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập chu kỳ");
                return false;
            }
            DataTable datasource = (DataTable)grcAddFriend.DataSource;
            if (datasource == null)
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập danh sách bạn bè");
                return false;
            }
            List<Model.Friend> list_friend = datasource.AsEnumerable()
                .Select(m => new Model.Friend()
                {
                    PhoneNumber = m.Field<string>("PhoneNumber"),
                    FullName = m.Field<string>("FullName"),
                    Relationship = m.Field<string>("Relationship"),
                    Note = m.Field<string>("Note")
                }).ToList();
            int count = list_friend.Count;
            if (count < 3)
            {
                Util.Show_Message_Notification(Message.msg_notification, "Số bạn bè phải >= 3");
                return false;
            }
            else
            {
                for (int i = 0; i < list_friend.Count; i++)
                {
                    if (list_friend[i].PhoneNumber == null)
                    {
                        Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập số điện thoại cho bạn số " + (i + 1));
                        return false;
                    }
                    if (list_friend[i].FullName == null)
                    {
                        Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập họ tên cho bạn số " + (i + 1));
                        return false;
                    }
                    if (list_friend[i].Relationship == null)
                    {
                        Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập mối quan hệ cho bạn số " + (i + 1));
                        return false;
                    }
                }
            }
            return true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckValidate())
                {
                    customer customer = new customer();
                    customer.Address = txt_address.Text.ToString().Trim();
                    customer.PhoneNumber = txt_phone.Text.ToString().Trim();
                    customer.BirthDay = (DateTime)birthDay_customer.DateTime;
                    customer.CategoryId = int.Parse(cbb_category.EditValue.ToString());
                    customer.FullName = txt_fullname.Text.ToString().Trim();
                    customer.IdCard = txt_idcard.Text.ToString().Trim();
                    customer.Money = Convert.ToInt32(txt_money.Value);
                    customer.FamilyPhoneNumber = txt_familyphone.Text.ToString().Trim();
                    customer.Sex = (bool)radio_sex.EditValue;
                    customer.Status = true;
                    customer.InterestId = 1;
                    customer.CreatedBy = _user.id;
                    customer.UpdatedBy = _user.id;
                    customer.CreatedAt = DateTime.Now;
                    customer.UpdatedAt = DateTime.Now;
                    customer.cycle = Convert.ToInt32(txt_cycle.Value);
                    DataTable datasource = (DataTable)grcAddFriend.DataSource;
                    List<Model.Friend> list_friend = datasource.AsEnumerable()
                        .Select(m => new Model.Friend()
                        {
                            PhoneNumber = m.Field<string>("PhoneNumber"),
                            FullName = m.Field<string>("FullName"),
                            Relationship = m.Field<string>("Relationship"),
                            Note = m.Field<string>("Note")
                        }).ToList();
                    bool check = DAL_QLCustomer.Add_and_Edit_Customer(customer, list_friend, Variable.action_status.is_add, _user);
                    if (check == true)
                    {
                        Util.Show_Message_Notification(Message.msg_notification, Message.msg_success_add_data);
                        ((Form)this.TopLevelControl).Close();
                    }
                    else
                    {
                        Util.Show_Message_Error(Message.msg_error, Message.msg_error_add_data);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void SetDataCbbCategory()
        {
            List<category> lst_category = new List<category>();

            lst_category = DAL_QLCategory.Get_List_Category("category");

            ImageComboBoxItem item;
            foreach (var data in lst_category)
            {
                item = new ImageComboBoxItem(data.Name, data.id, data.id);
                cbb_category.Properties.Items.Add(item);
            }
        }

        private void uc_Add_Customer_Load(object sender, EventArgs e)
        {
            SetDataCbbCategory();
            List<Model.Friend> lst_friend = new List<Model.Friend>();
            grcAddFriend.DataSource = Util.ConvertToDataTable(lst_friend);
        }
    }
}
