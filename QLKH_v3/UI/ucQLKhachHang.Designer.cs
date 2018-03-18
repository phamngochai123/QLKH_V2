namespace QLKH_v3.UI
{
    partial class ucQLKhachHang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grcKhachHang = new DevExpress.XtraGrid.GridControl();
            this.grvKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelBody = new DevExpress.XtraEditors.PanelControl();
            this.panelheader = new DevExpress.XtraEditors.PanelControl();
            this.date_birthday = new DevExpress.XtraEditors.DateEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txt_phone_family = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txt_money = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txt_interest = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txt_sex_user = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_address_customer = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_phone_customer = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_idCard_customer = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.txt_ghi_chu = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_fullname = new DevExpress.XtraEditors.TextEdit();
            this.cbx_category_customer = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grcKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).BeginInit();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelheader)).BeginInit();
            this.panelheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_birthday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_birthday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_phone_family.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_money.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_interest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sex_user.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_address_customer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_phone_customer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_idCard_customer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ghi_chu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_fullname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grcKhachHang
            // 
            this.grcKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcKhachHang.Location = new System.Drawing.Point(2, 2);
            this.grcKhachHang.MainView = this.grvKhachHang;
            this.grcKhachHang.Name = "grcKhachHang";
            this.grcKhachHang.Size = new System.Drawing.Size(934, 123);
            this.grcKhachHang.TabIndex = 0;
            this.grcKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvKhachHang});
            // 
            // grvKhachHang
            // 
            this.grvKhachHang.GridControl = this.grcKhachHang;
            this.grvKhachHang.Name = "grvKhachHang";
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.grcKhachHang);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 323);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(938, 127);
            this.panelBody.TabIndex = 5;
            // 
            // panelheader
            // 
            this.panelheader.Controls.Add(this.cbx_category_customer);
            this.panelheader.Controls.Add(this.date_birthday);
            this.panelheader.Controls.Add(this.labelControl9);
            this.panelheader.Controls.Add(this.labelControl11);
            this.panelheader.Controls.Add(this.txt_phone_family);
            this.panelheader.Controls.Add(this.labelControl12);
            this.panelheader.Controls.Add(this.txt_money);
            this.panelheader.Controls.Add(this.labelControl13);
            this.panelheader.Controls.Add(this.txt_interest);
            this.panelheader.Controls.Add(this.labelControl10);
            this.panelheader.Controls.Add(this.txt_sex_user);
            this.panelheader.Controls.Add(this.labelControl5);
            this.panelheader.Controls.Add(this.txt_address_customer);
            this.panelheader.Controls.Add(this.labelControl6);
            this.panelheader.Controls.Add(this.labelControl4);
            this.panelheader.Controls.Add(this.txt_phone_customer);
            this.panelheader.Controls.Add(this.labelControl3);
            this.panelheader.Controls.Add(this.txt_idCard_customer);
            this.panelheader.Controls.Add(this.simpleButton2);
            this.panelheader.Controls.Add(this.simpleButton1);
            this.panelheader.Controls.Add(this.btn_them);
            this.panelheader.Controls.Add(this.txt_ghi_chu);
            this.panelheader.Controls.Add(this.labelControl2);
            this.panelheader.Controls.Add(this.labelControl1);
            this.panelheader.Controls.Add(this.txt_fullname);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(938, 323);
            this.panelheader.TabIndex = 4;
            // 
            // date_birthday
            // 
            this.date_birthday.EditValue = null;
            this.date_birthday.Location = new System.Drawing.Point(112, 107);
            this.date_birthday.Name = "date_birthday";
            this.date_birthday.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_birthday.Properties.Appearance.Options.UseFont = true;
            this.date_birthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_birthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_birthday.Size = new System.Drawing.Size(273, 22);
            this.date_birthday.TabIndex = 61;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(407, 110);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(48, 16);
            this.labelControl9.TabIndex = 59;
            this.labelControl9.Text = "Đồ cầm";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Location = new System.Drawing.Point(407, 80);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(138, 16);
            this.labelControl11.TabIndex = 57;
            this.labelControl11.Text = "Số điện thoại gia đình";
            // 
            // txt_phone_family
            // 
            this.txt_phone_family.Location = new System.Drawing.Point(551, 74);
            this.txt_phone_family.Name = "txt_phone_family";
            this.txt_phone_family.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone_family.Properties.Appearance.Options.UseFont = true;
            this.txt_phone_family.Size = new System.Drawing.Size(273, 22);
            this.txt_phone_family.TabIndex = 56;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Location = new System.Drawing.Point(407, 45);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(73, 16);
            this.labelControl12.TabIndex = 55;
            this.labelControl12.Text = "Số tiền vay";
            // 
            // txt_money
            // 
            this.txt_money.Location = new System.Drawing.Point(551, 42);
            this.txt_money.Name = "txt_money";
            this.txt_money.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_money.Properties.Appearance.Options.UseFont = true;
            this.txt_money.Size = new System.Drawing.Size(273, 22);
            this.txt_money.TabIndex = 54;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Location = new System.Drawing.Point(407, 14);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(55, 16);
            this.labelControl13.TabIndex = 53;
            this.labelControl13.Text = "Kiểu vay";
            // 
            // txt_interest
            // 
            this.txt_interest.Location = new System.Drawing.Point(551, 11);
            this.txt_interest.Name = "txt_interest";
            this.txt_interest.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_interest.Properties.Appearance.Options.UseFont = true;
            this.txt_interest.Size = new System.Drawing.Size(273, 22);
            this.txt_interest.TabIndex = 52;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(407, 142);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(51, 16);
            this.labelControl10.TabIndex = 51;
            this.labelControl10.Text = "Giới tính";
            // 
            // txt_sex_user
            // 
            this.txt_sex_user.Location = new System.Drawing.Point(551, 136);
            this.txt_sex_user.Name = "txt_sex_user";
            this.txt_sex_user.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sex_user.Properties.Appearance.Options.UseFont = true;
            this.txt_sex_user.Size = new System.Drawing.Size(273, 22);
            this.txt_sex_user.TabIndex = 50;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(5, 142);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(43, 16);
            this.labelControl5.TabIndex = 47;
            this.labelControl5.Text = "Địa chỉ";
            // 
            // txt_address_customer
            // 
            this.txt_address_customer.Location = new System.Drawing.Point(112, 139);
            this.txt_address_customer.Name = "txt_address_customer";
            this.txt_address_customer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address_customer.Properties.Appearance.Options.UseFont = true;
            this.txt_address_customer.Size = new System.Drawing.Size(273, 22);
            this.txt_address_customer.TabIndex = 46;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(7, 110);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(62, 16);
            this.labelControl6.TabIndex = 45;
            this.labelControl6.Text = "Ngày sinh";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(5, 80);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(84, 16);
            this.labelControl4.TabIndex = 43;
            this.labelControl4.Text = "Số điện thoại";
            // 
            // txt_phone_customer
            // 
            this.txt_phone_customer.Location = new System.Drawing.Point(112, 74);
            this.txt_phone_customer.Name = "txt_phone_customer";
            this.txt_phone_customer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone_customer.Properties.Appearance.Options.UseFont = true;
            this.txt_phone_customer.Size = new System.Drawing.Size(273, 22);
            this.txt_phone_customer.TabIndex = 42;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(5, 48);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 16);
            this.labelControl3.TabIndex = 41;
            this.labelControl3.Text = "CMND";
            // 
            // txt_idCard_customer
            // 
            this.txt_idCard_customer.Location = new System.Drawing.Point(112, 42);
            this.txt_idCard_customer.Name = "txt_idCard_customer";
            this.txt_idCard_customer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idCard_customer.Properties.Appearance.Options.UseFont = true;
            this.txt_idCard_customer.Size = new System.Drawing.Size(273, 22);
            this.txt_idCard_customer.TabIndex = 40;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(495, 289);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(81, 30);
            this.simpleButton2.TabIndex = 13;
            this.simpleButton2.Text = "Hủy";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(407, 289);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(82, 30);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "xác nhận";
            // 
            // btn_them
            // 
            this.btn_them.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Appearance.Options.UseFont = true;
            this.btn_them.Location = new System.Drawing.Point(112, 289);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(118, 30);
            this.btn_them.TabIndex = 11;
            this.btn_them.Text = "Thêm khách hàng";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_ghi_chu
            // 
            this.txt_ghi_chu.Location = new System.Drawing.Point(114, 182);
            this.txt_ghi_chu.Name = "txt_ghi_chu";
            this.txt_ghi_chu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ghi_chu.Properties.Appearance.Options.UseFont = true;
            this.txt_ghi_chu.Size = new System.Drawing.Size(271, 71);
            this.txt_ghi_chu.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(7, 183);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 16);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Ghi chú";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(7, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 16);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Họ tên";
            // 
            // txt_fullname
            // 
            this.txt_fullname.Location = new System.Drawing.Point(112, 11);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fullname.Properties.Appearance.Options.UseFont = true;
            this.txt_fullname.Size = new System.Drawing.Size(273, 22);
            this.txt_fullname.TabIndex = 7;
            // 
            // cbx_category_customer
            // 
            this.cbx_category_customer.DataSource = this.categoryBindingSource;
            this.cbx_category_customer.DisplayMember = "Name";
            this.cbx_category_customer.FormattingEnabled = true;
            this.cbx_category_customer.Location = new System.Drawing.Point(551, 105);
            this.cbx_category_customer.Name = "cbx_category_customer";
            this.cbx_category_customer.Size = new System.Drawing.Size(273, 21);
            this.cbx_category_customer.TabIndex = 62;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(QLKH_v3.category);
            // 
            // ucQLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelheader);
            this.Name = "ucQLKhachHang";
            this.Size = new System.Drawing.Size(938, 450);
            ((System.ComponentModel.ISupportInitialize)(this.grcKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).EndInit();
            this.panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelheader)).EndInit();
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_birthday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_birthday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_phone_family.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_money.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_interest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sex_user.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_address_customer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_phone_customer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_idCard_customer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ghi_chu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_fullname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView grvKhachHang;
        private DevExpress.XtraEditors.PanelControl panelBody;
        private DevExpress.XtraEditors.PanelControl panelheader;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private DevExpress.XtraEditors.MemoEdit txt_ghi_chu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_fullname;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txt_sex_user;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_address_customer;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_phone_customer;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_idCard_customer;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txt_phone_family;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txt_money;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txt_interest;
        private DevExpress.XtraEditors.DateEdit date_birthday;
        private System.Windows.Forms.ComboBox cbx_category_customer;
        private System.Windows.Forms.BindingSource categoryBindingSource;
    }
}
