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
        DAL.DAL_QLCustomer DAL_QLCustomer = new DAL.DAL_QLCustomer();
        DAL.DAL_QLCategory DAL_QLCategory = new DAL.DAL_QLCategory();
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
            }
        }
    }
}
