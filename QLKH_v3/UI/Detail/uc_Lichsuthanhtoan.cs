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
    public partial class uc_Lichsuthanhtoan : UserControl
    {
        public int idCustomer { set; get; }
        Util.Util Util = new Util.Util();
        DAL.DAL_LichSuTraTien DAL_LichSuTraTien = new DAL.DAL_LichSuTraTien();
        Message.Message Message = new Message.Message();
        public uc_Lichsuthanhtoan()
        {
            InitializeComponent();
        }

        private void uc_Lichsuthanhtoan_Load(object sender, EventArgs e)
        {
            try
            {
                grcLichsu.DataSource = Util.ConvertToDataTable(DAL_LichSuTraTien.Get_List_History_Paid(idCustomer));
            }
            catch (Exception)
            {
                Util.Show_Message_Notification(Message.msg_notification, "Không thể kết nối đến cơ sở dữ liệu !!!");
            }
        }
    }
}
