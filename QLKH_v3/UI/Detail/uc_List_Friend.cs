using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKH_v3.DAL;

namespace QLKH_v3.UI.Detail
{
    public partial class uc_List_Friend : UserControl
    {
        //public List<Model.Friend> List_Friend { set; get; }
        public int idCustomer { set; get; }
        Util.Util Util = new Util.Util();
        DAL.DAL_QLCustomer DAL_QLCustomer = new DAL.DAL_QLCustomer();
        Message.Message Message = new Message.Message();
        public uc_List_Friend()
        {
            InitializeComponent();
        }

        private void uc_List_Friend_Load(object sender, EventArgs e)
        {
            try
            {

                List<Model.Friend> lst_friend = DAL_QLCustomer.get_list_friend(idCustomer);
                grcFriend.DataSource = Util.ConvertToDataTable(lst_friend);
            }
            catch (Exception)
            {
                Util.Show_Message_Notification(Message.msg_notification, "Không thể kết nối đến cơ sở dữ liệu !!!");
            }
        }

    }
}
