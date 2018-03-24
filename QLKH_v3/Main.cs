using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;


namespace QLKH_v3
{
    public partial class Main : RibbonForm
    {
        public user _user { set; get; }
        //public int _userId { set; get; }
        public Main()
        {
            InitializeComponent();
            InitSkinGallery();

        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void ribbonControl_SelectedPageChanged(object sender, EventArgs e)
        {
            if (ribbonControl.SelectedPage == tabQuanLy)
            {
                UI.ucQLKhachHang ucQLKhachHang = new UI.ucQLKhachHang();
                ucQLKhachHang.Dock = DockStyle.Fill;
                panelMain.Controls.Clear();
                panelMain.Controls.Add(ucQLKhachHang);

                //GroupQLTang.Enabled = true;
                //GroupQLPhong.Enabled = true;
                //GroupQLTaiKhoan.Enabled = true;
                //groupQLToaNha.Enabled = false;
            }
            if (ribbonControl.SelectedPage == tabQuanTri)
            {
                UI.ucQLLaiSuat ucQLLaiSuat = new UI.ucQLLaiSuat();
                ucQLLaiSuat.Dock = DockStyle.Fill;
                panelMain.Controls.Clear();
                panelMain.Controls.Add(ucQLLaiSuat);

                //GroupQLTang.Enabled = true;
                //GroupQLPhong.Enabled = true;
                //GroupQLTaiKhoan.Enabled = true;
                //groupQLToaNha.Enabled = false;
            }
        }

        private void btnQLLaiSuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI.ucQLLaiSuat ucQLLaiSuat = new UI.ucQLLaiSuat();
            ucQLLaiSuat.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucQLLaiSuat);
            ucQLLaiSuat._user = _user;
        }

        private void btnQLUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI.ucQLUser ucQLUser = new UI.ucQLUser();
            ucQLUser.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucQLUser);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            _user = login._user;
            //_userId = login._userId;
            if (_user != null)
            {
                this.Show();
                UI.ucQLLaiSuat ucQLLaiSuat = new UI.ucQLLaiSuat();
                ucQLLaiSuat.Dock = DockStyle.Fill;
                panelMain.Controls.Clear();
                ucQLLaiSuat._user = _user;
                panelMain.Controls.Add(ucQLLaiSuat);
            }
            else
            {
                Application.Exit();
            }
            
        }

        private void btnQLDanhMuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI.uc_Category uc_Category = new UI.uc_Category();
            uc_Category.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uc_Category);
            uc_Category._user = _user;
            //uc_Category._userId = _userId;
        }

        private void btnQLKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI.ucQLKhachHang uc_Customer = new UI.ucQLKhachHang();
            uc_Customer.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uc_Customer);
            uc_Customer._user = _user;
        }

        private void btnLichSuThanhToan_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI.uc_LichSuTraTien uc_HistoryPaid = new UI.uc_LichSuTraTien();
            uc_HistoryPaid.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uc_HistoryPaid);
            uc_HistoryPaid._user = _user;
        }

        private void btnQLBanBe_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI.ucThongKe uc_ThongKe = new UI.ucThongKe();
            uc_ThongKe.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uc_ThongKe);
            //uc_ThongKe._user = _user;
        }

    }
}