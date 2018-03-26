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

namespace QLKH_v3.UI
{
    public partial class uc_thongkedoanhthu : UserControl
    {
        DAL.DAL_Thongke DAL_Thongke = new DAL.DAL_Thongke();
        Util.Util Util = new Util.Util();
        public uc_thongkedoanhthu()
        {
            InitializeComponent();
        }

        private void uc_thongkedoanhthu_Load(object sender, EventArgs e)
        {
            SetDataCbbYear();
            List<Model.Statistic> statistic = DAL_Thongke.Get_List_Customer_By_Month();
            grcStatistic.DataSource = Util.ConvertToDataTable(statistic);
        }

        private void SetDataCbbYear()
        {
            List<Model.Year> lst_year = new List<Model.Year>();

            lst_year = DAL_Thongke.get_list_all_year();

            ImageComboBoxItem item;
            foreach (var data in lst_year)
            {
                item = new ImageComboBoxItem(data.Year_Active.ToString(), data.Year_Active, data.Year_Active);
                cbb_statistic_year.Properties.Items.Add(item);
            }
        }
    }
}
