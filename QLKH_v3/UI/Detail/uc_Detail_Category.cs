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
    public partial class uc_Detail_Category : UserControl
    {
        Util.Util Util = new Util.Util();
        public DataRow Data_Category { set; get; }
        int _ID_CATEGORY;
        public uc_Detail_Category()
        {
            InitializeComponent();
        }

        private void uc_Detail_Category_Load(object sender, EventArgs e)
        {
            if (Data_Category.ToString() !="") {
                _ID_CATEGORY = Util.Cnv_Int(Data_Category["id"].ToString().Trim());
                txt_name_category.Text = Data_Category["Name"].ToString().Trim();
                txt_Note.Text = Data_Category["Note"].ToString().Trim();
                txt_UpdateAt.Text = Data_Category["UpdatedAt"].ToString().Trim();
                txt_CreateAt.Text = Data_Category["CreatedAt"].ToString().Trim();
                txt_CreateBy.Text = Data_Category["CreatedBy"].ToString().Trim();
                txt_UpdateBy.Text = Data_Category["UpdatedBy"].ToString().Trim();
            }
        }
    }
}
