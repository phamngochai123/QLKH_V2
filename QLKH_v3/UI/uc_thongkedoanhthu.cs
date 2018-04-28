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
using DevExpress.XtraSplashScreen;
using System.Threading;

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
            SplashScreenManager.ShowDefaultWaitForm();
            Load_Data();
            SplashScreenManager.CloseDefaultWaitForm();
            SetDataCbbYear();
            List<Model.Statistic> statistic = DAL_Thongke.Get_List_Customer_By_Month();
            grcStatistic.DataSource = Util.ConvertToDataTable(statistic);
        }

        private void Load_Data()
        {
            txt_total_money.Text = DAL_Thongke.Get_Total_Money().ToString();
            txt_total_paid_money.Text = DAL_Thongke.Get_Total_Money_Paid("0").ToString();
            txt_interset_money.Text = DAL_Thongke.Get_Total_Money_Paid("1").ToString();
            txt_total_money.Text = string.Format("{0:#,##0}", double.Parse(txt_total_money.Text));
            txt_total_paid_money.Text = string.Format("{0:#,##0}", double.Parse(txt_total_paid_money.Text));
            txt_interset_money.Text = string.Format("{0:#,##0}", double.Parse(txt_interset_money.Text));
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
