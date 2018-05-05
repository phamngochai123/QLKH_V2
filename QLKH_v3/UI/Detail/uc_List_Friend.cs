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
        public user _user { set; get; }
        Util.Util Util = new Util.Util();
        DAL.DAL_QLCustomer DAL_QLCustomer = new DAL.DAL_QLCustomer();
        DAL.DAL_QLFriend DAL_QLFriend = new DAL.DAL_QLFriend();
        Variable.Variable Variable = new Variable.Variable();
        Message.Message Message = new Message.Message();
        public uc_List_Friend()
        {
            InitializeComponent();
        }

        public bool CheckValidate()
        {
            DataTable datasource = (DataTable)grcFriend.DataSource;
            List<Model.Friend> list_friend = datasource.AsEnumerable()
                                .Select(m => new Model.Friend()
                                {
                                    PhoneNumber = m.Field<string>("PhoneNumber"),
                                    FullName = m.Field<string>("FullName"),
                                    Relationship = m.Field<string>("Relationship"),
                                    Note = m.Field<string>("Note")
                                }).ToList();
            if (list_friend == null || list_friend.Count == 0)
            {
                Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập bạn bè");
                return false;
            }
            for (int i = 0; i < list_friend.Count; i++)
            {
                if (list_friend[i].PhoneNumber == null || list_friend[i].PhoneNumber == "")
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập số điện thoại cho bạn số " + (i + 1));
                    return false;
                }
                if (list_friend[i].FullName == null || list_friend[i].FullName == "")
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập họ tên cho bạn số " + (i + 1));
                    return false;
                }
                if (list_friend[i].Relationship == null || list_friend[i].Relationship == "")
                {
                    Util.Show_Message_Notification(Message.msg_notification, "Vui lòng nhập mối quan hệ cho bạn số " + (i + 1));
                    return false;
                }
            }
            return true;
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckValidate())
                {
                    if (Util.Show_Message_YesNo(Message.msg_notification, "Chắc chắn sửa ?"))
                    {
                        DataTable datasource = (DataTable)grcFriend.DataSource;
                        List<Model.Friend> list_friend = datasource.AsEnumerable()
                            .Select(m => new Model.Friend()
                            {
                                PhoneNumber = m.Field<string>("PhoneNumber"),
                                FullName = m.Field<string>("FullName"),
                                Relationship = m.Field<string>("Relationship"),
                                Note = m.Field<string>("Note"),
                                Id = m.Field<int>("Id")
                            }).ToList();
                        int count = 0;
                        foreach (var friend in list_friend)
                        {
                            friend friends = new friend();
                            friends.FullName = friend.FullName;
                            friends.PhoneNumber = friend.PhoneNumber;
                            friends.Relationship = friend.Relationship;
                            friends.Note = friend.Note;
                            friends.UpdatedBy = _user.id;
                            friends.id = friend.Id;
                            bool check = DAL_QLFriend.Add_and_Edit_Friend(friends, Variable.action_status.is_update);
                            if (check)
                            {
                                count++;
                            }

                            else
                            {
                                Util.Show_Message_Error(Message.msg_error, Message.msg_error_edit_data);
                                ((Form)this.TopLevelControl).Close();
                                break;
                            }
                            if (count == list_friend.Count)
                            {
                                Util.Show_Message_Notification(Message.msg_notification, Message.msg_success_edit_data);
                                ((Form)this.TopLevelControl).Close();
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                Util.Show_Message_Notification(Message.msg_notification, "Có lỗi xảy ra");
            }
        }

    }
}
