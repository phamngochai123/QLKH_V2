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
using DevExpress.XtraEditors.Controls;

namespace QLKH_v3.UI
{
    public partial class ucQLKhachHang : UserControl
    {
        public user _user { set; get; }
        DAL.DAL_QLCategory DAL_QLCategory = new DAL.DAL_QLCategory();
        DAL.DAL_QLCustomer DAL_QLCustomer = new DAL.DAL_QLCustomer();
        Util.Util Util = new Util.Util();
        Message.Message Message = new Message.Message();
        Variable.Variable Variable = new Variable.Variable();
        public ucQLKhachHang()
        {
            InitializeComponent();
        }

        private void Load_Data()
        {
            try
            {
                grcKhachHang.DataSource = Util.ConvertToDataTable(DAL_QLCustomer.Get_List_Customer());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_fullname.ReadOnly = false;
            txt_address_customer.ReadOnly = false;
            txt_ghi_chu.ReadOnly = false;
            txt_idCard_customer.ReadOnly = false;
            txt_money.ReadOnly = false;
            txt_phone_customer.ReadOnly = false;
            txt_phone_family.ReadOnly = false;
            date_birthday.Enabled = true;
            radio_sex_customer.Enabled = true;
            cbb_category.Enabled = true;
            btn_add_customer.Enabled = true;
            btn_cancel_customer.Enabled = true;
            btn_them.Enabled = false;
            grcFriend.Enabled = true;
        }
        private void InitData()
        {
            reset_grv_friend();
            SetDataCbbCategory();
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

        private bool CheckValidate()
        {
            if (txt_fullname.Text.ToString().Trim() == "")
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập họ tên");
                return false;
            }
            if (txt_address_customer.Text.ToString().Trim() == "")
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập địa chỉ");
                return false;
            }
            if (txt_idCard_customer.Text.ToString().Trim() == "")
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập số chứng minh thư");
                return false;
            }
            if (txt_money.Text.ToString().Trim() == "")
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập số tiền vay");
                return false;
            }
            if (txt_phone_customer.Text.ToString().Trim() == "")
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập");
                return false;
            }
            if (txt_phone_family.Text.ToString().Trim() == "")
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập số điện thoại gia đình");
                return false;
            }
            if (date_birthday.Text.ToString().Trim() == "")
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập ngày sinh");
                return false;
            }
            if (radio_sex_customer.EditValue == null)
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng chọn giới tính");
                return false;
            }
            if (cbb_category.EditValue == null)
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng chọn đồ cần cầm");
                return false;
            }
            DataTable datasource = (DataTable)grcFriend.DataSource;
            List<Model.Friend> list_friend = datasource.AsEnumerable()
                .Select(m => new Model.Friend()
                {
                    PhoneNumber = m.Field<string>("PhoneNumber"),
                    FullName = m.Field<string>("FullName"),
                    Relationship = m.Field<string>("Relationship"),
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

        private void ucQLKhachHang_Load(object sender, EventArgs e)
        {
            InitData();
            Load_Data();
        }

        private void btn_cancel_customer_Click(object sender, EventArgs e)
        {
            reset_form_customer();
        }

        private void reset_form_customer()
        {
            txt_fullname.Text = "";
            txt_address_customer.Text = "";
            txt_ghi_chu.Text = "";
            txt_idCard_customer.Text = "";
            txt_money.Text = "";
            txt_phone_customer.Text = "";
            txt_phone_family.Text = "";
            date_birthday.Text = "";
            radio_sex_customer.EditValue = null;
            cbb_category.EditValue = null;
            txt_fullname.ReadOnly = true;
            txt_address_customer.ReadOnly = true;
            txt_ghi_chu.ReadOnly = true;
            txt_idCard_customer.ReadOnly = true;
            txt_money.ReadOnly = true;
            txt_phone_customer.ReadOnly = true;
            txt_phone_family.ReadOnly = true;
            date_birthday.Enabled = false;
            radio_sex_customer.Enabled = false;
            cbb_category.Enabled = false;
            btn_add_customer.Enabled = false;
            btn_cancel_customer.Enabled = false;
            btn_them.Enabled = true;
            reset_grv_friend();
        }

        public void reset_grv_friend(){
            List<Model.Friend> lst_friend = new List<Model.Friend>();
            grcFriend.DataSource = Util.ConvertToDataTable(lst_friend);
            grcFriend.Enabled = false;
        }

        private void grvKhachHang_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DXMouseEventArgs ea = e as DXMouseEventArgs;
                GridView view = sender as GridView;
                GridHitInfo info = view.CalcHitInfo(ea.Location);
                if (info.InRow || info.InRowCell)
                {
                    DataRow row = grvKhachHang.GetDataRow(info.RowHandle);
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

        private void btn_add_customer_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckValidate())
                {
                    customer customer = new customer();
                    customer.Address = txt_address_customer.Text.ToString().Trim();
                    customer.PhoneNumber = txt_phone_customer.Text.ToString().Trim();
                    customer.BirthDay = (DateTime)date_birthday.DateTime;
                    customer.CategoryId = int.Parse(cbb_category.EditValue.ToString()) ;
                    customer.FullName = txt_fullname.Text.ToString().Trim();
                    customer.IdCard = txt_idCard_customer.Text.ToString().Trim();
                    customer.Money = int.Parse(txt_money.Text.ToString().Trim());
                    customer.FamilyPhoneNumber = txt_phone_family.Text.ToString().Trim();
                    customer.Status = true;
                    customer.InterestId = 1;
                    customer.CreatedBy = _user.id;
                    customer.UpdatedBy = _user.id;
                    customer.CreatedAt = DateTime.Now;
                    customer.UpdatedAt = DateTime.Now;
                    DataTable datasource = (DataTable)grcFriend.DataSource;
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
                        Load_Data();
                    }
                    else
                    {
                        Util.Show_Message_Error(Message.msg_error, Message.msg_error_add_data);
                    }
                    reset_form_customer();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            int idCustomer = int.Parse(grvKhachHang.GetFocusedRowCellValue("id").ToString());
            //int idCustomer = int.Parse(row["id"].ToString().Trim());
            Detail_Infor Detail_Infor = new Detail_Infor();
            Detail_Infor.Str_Flag = Variable.detail_infor.Friend_Customer;
            Detail_Infor.idCustomer = idCustomer;
            //Detail_Infor.Data_Friend = lst_friend;
            //Detail_Infor.Data = row;
            //Detail_Infor._user = _user;
            Detail_Infor.ShowDialog();
        }

        private void btn_thanh_toan_Click(object sender, EventArgs e)
        {
            int idCustomer = int.Parse(grvKhachHang.GetFocusedRowCellValue("id").ToString());
            //int idCustomer = int.Parse(row["id"].ToString().Trim());
            Detail_Infor Detail_Infor = new Detail_Infor();
            Detail_Infor.Str_Flag = Variable.detail_infor.Paid_Money;
            Detail_Infor.idCustomer = idCustomer;
            Detail_Infor._user = _user;
            DialogResult dialog_result = Detail_Infor.ShowDialog();
            if (dialog_result == DialogResult.Cancel)
            {
                InitData();
                Load_Data();
            }
        }

        private void btn_lich_su_thanh_toan_Click(object sender, EventArgs e)
        {
            int idCustomer = int.Parse(grvKhachHang.GetFocusedRowCellValue("id").ToString());
            //int idCustomer = int.Parse(row["id"].ToString().Trim());
            Detail_Infor Detail_Infor = new Detail_Infor();
            Detail_Infor.Str_Flag = Variable.detail_infor.History_Paid;
            Detail_Infor.idCustomer = idCustomer;
            Detail_Infor._user = _user;
            Detail_Infor.ShowDialog();
        }

        private void btn_export_excel_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowserDialog1.SelectedPath;
                path = path.Replace('/', '\\');
                Object tmp_list = grcKhachHang.DataSource;
                grvKhachHang.Columns.ColumnByName("danh_sach_ban_be").Visible = false;
                grvKhachHang.Columns.ColumnByName("thanh_toan").Visible = false;
                grvKhachHang.Columns.ColumnByName("lich_su_thanh_toan").Visible = false;
                grcKhachHang.ExportToXls(@path + "\\Danh sách khách hàng" + DateTime.Now.ToString(Variable.format_date_time_replace) + ".xls", true);
                grvKhachHang.Columns.ColumnByName("danh_sach_ban_be").Visible = true;
                grvKhachHang.Columns.ColumnByName("thanh_toan").Visible = true;
                grvKhachHang.Columns.ColumnByName("lich_su_thanh_toan").Visible = true;
            }
        }
    }
}
