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
            UI.ucQLLaiSuat ucQLLaiSuat = new UI.ucQLLaiSuat();
            ucQLLaiSuat.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucQLLaiSuat);
        }

        private void btnQLDanhMuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI.uc_Category uc_Category = new UI.uc_Category();
            uc_Category.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uc_Category);
        }

    }
}