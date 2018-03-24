using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.SqlServer;

namespace QLKH_v3.UI
{
    public partial class ucThongKe : UserControl
    {
        QLKHEntities _db = new QLKHEntities();
        public user _user { set; get; }
        DAL.DAL_Thongke DAL_Thongke = new DAL.DAL_Thongke();
        Util.Util Util = new Util.Util();
        Message.Message Message = new Message.Message();
        Variable.Variable Variable = new Variable.Variable();
        public ucThongKe()
        {
            InitializeComponent();
        }

        private void Load_Data()
        {
            txt_total_money.Text = DAL_Thongke.Get_Total_Money().ToString();
            txt_total_paid_money.Text = DAL_Thongke.Get_Total_Money_Paid("0").ToString();
            txt_interset_money.Text = DAL_Thongke.Get_Total_Money_Paid("1").ToString();
            var lst_customer = (from data in _db.customers
                                group data by new
                                {
                                    Column1 = (int?)SqlFunctions.DatePart("mm", data.CreatedAt)
                                }
                                    into g
                                    select new
                                    {
                                        month = g.Key.Column1,
                                        count = g.Count(data => data.id != null)
                                    }
                     ).OrderBy(g => g.month).ToList();
            chart_customer_by_month.DataSource = lst_customer;
        }

        private void uc_Category_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
    }
}
