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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;

namespace QLKH_v3.UI
{
    public partial class uc_Category : UserControl
    {
        //public int _userId { set; get; }
        public user _user { set; get; }
        DAL.DAL_QLCategory DAL_QLCategory = new DAL.DAL_QLCategory();
        Util.Util Util = new Util.Util();
        Message.Message Message = new Message.Message();
        Variable.Variable Variable = new Variable.Variable();

        int _ID_CATEGORY;
        public uc_Category()
        {
            InitializeComponent();
        }

        private bool CheckValidate()
        {
            bool check = true;
            try
            {
                if (txt_name_category.Text.ToString().Trim() == "")
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập tên danh mục");
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return check;
        }
        private void Load_Data()
        {
            try
            {
                grcCategory.DataSource = Util.ConvertToDataTable(DAL_QLCategory.Get_List_Category());
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

        private void Fill_Data_Category(int id_category)
        {
            category Category = new category();
            Category = DAL_QLCategory.Get_Category(id_category);

            txt_name_category.Text = Category.Name.ToString();
            txt_ghi_chu.Text = Category.Note.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_cancel_category.Enabled = true;
            btn_add_category.Enabled = true;
            txt_name_category.ReadOnly = false;
            txt_ghi_chu.ReadOnly = false;
            btn_them.Enabled = false;
        }

        private void grvCategory_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                DataRow row = grvCategory.GetDataRow(info.RowHandle);

               Detail_Infor Detail_Infor = new Detail_Infor();
               Detail_Infor.Str_Flag = Variable.detail_infor.Category;
               Detail_Infor.Data = row;
               //Detail_Infor._userId = _userId;
               Detail_Infor._user = _user;
               //Detail_Infor.ShowDialog();
               DialogResult dialog_result = Detail_Infor.ShowDialog();
               if (dialog_result == DialogResult.Cancel) {
                   Load_Data();
               }
            }
        }

        private void btn_add_category_Click(object sender, EventArgs e)
        {
            category ctgr = new category();
            try
            {
                if (CheckValidate() == true)
                {
                    ctgr.Name = txt_name_category.Text.Trim();
                    ctgr.Note = txt_ghi_chu.Text.Trim();
                    ctgr.CreatedAt = DateTime.Now;
                    ctgr.UpdatedAt = DateTime.Now;
                    ctgr.Status = true;

                    bool check = DAL_QLCategory.Add_and_Edit_Category(ctgr, Variable.action_status.is_add, _user);
                    if (check == true)
                    {
                        Util.Show_Message_Notification(Message.msg_notification, Message.msg_success_add_data);
                        Load_Data();
                    }
                    else
                    {
                        Util.Show_Message_Error(Message.msg_error, Message.msg_error_add_data);
                    }
                    restart_form_add_category();
                }
            }
            catch (Exception ex)
            {
                Util.Show_Message_Error(Message.msg_error, ex.Message.ToString());
            }
        }

        private void btn_cancel_category_Click(object sender, EventArgs e)
        {
            restart_form_add_category();
        }
        private void restart_form_add_category()
        {
            btn_add_category.Enabled = false;
            btn_cancel_category.Enabled = false;
            btn_them.Enabled = true;
            txt_name_category.ReadOnly = true;
            txt_ghi_chu.ReadOnly = true;
            txt_name_category.Text = "";
            txt_ghi_chu.Text = "";
        }

    }
}
