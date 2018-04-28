namespace QLKH_v3.UI
{
    partial class uc_QLDanhSachKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_QLDanhSachKhachHang));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grcDanhSachKhachHang = new DevExpress.XtraGrid.GridControl();
            this.grvDanhSachKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnFriend = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn27 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnPaid = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn28 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnTransaction = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_export_excel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_total_customer = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_total_money = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_tien_thu = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhSachKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSachKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnPaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_total_customer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_total_money.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tien_thu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(QLKH_v3.category);
            // 
            // grcDanhSachKhachHang
            // 
            this.grcDanhSachKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcDanhSachKhachHang.Location = new System.Drawing.Point(2, 2);
            this.grcDanhSachKhachHang.MainView = this.grvDanhSachKhachHang;
            this.grcDanhSachKhachHang.Name = "grcDanhSachKhachHang";
            this.grcDanhSachKhachHang.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.columnFriend,
            this.columnPaid,
            this.columnTransaction});
            this.grcDanhSachKhachHang.Size = new System.Drawing.Size(1266, 386);
            this.grcDanhSachKhachHang.TabIndex = 1;
            this.grcDanhSachKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDanhSachKhachHang});
            // 
            // grvDanhSachKhachHang
            // 
            this.grvDanhSachKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn10,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn21,
            this.gridColumn22,
            this.gridColumn23,
            this.gridColumn24,
            this.gridColumn26,
            this.gridColumn27,
            this.gridColumn28,
            this.gridColumn1,
            this.gridColumn2});
            this.grvDanhSachKhachHang.GridControl = this.grcDanhSachKhachHang;
            this.grvDanhSachKhachHang.Name = "grvDanhSachKhachHang";
            this.grvDanhSachKhachHang.OptionsFind.AlwaysVisible = true;
            this.grvDanhSachKhachHang.OptionsFind.FindNullPrompt = "Tìm kiếm";
            this.grvDanhSachKhachHang.OptionsView.ShowGroupPanel = false;
            this.grvDanhSachKhachHang.DoubleClick += new System.EventHandler(this.grvDanhSachKhachHang_DoubleClick);
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Họ tên";
            this.gridColumn10.FieldName = "FullName";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.OptionsColumn.ReadOnly = true;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 0;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "CMND";
            this.gridColumn13.FieldName = "IdCard";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.OptionsColumn.ReadOnly = true;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 1;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Số điện thoại";
            this.gridColumn14.FieldName = "PhoneNumber";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.OptionsColumn.ReadOnly = true;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 2;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Ngày sinh";
            this.gridColumn15.FieldName = "BirthDay";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 3;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Giới tính";
            this.gridColumn17.FieldName = "SexString";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 5;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Địa chỉ";
            this.gridColumn18.FieldName = "Address";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.OptionsColumn.AllowEdit = false;
            this.gridColumn18.OptionsColumn.ReadOnly = true;
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 4;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "Ngày vay";
            this.gridColumn19.FieldName = "CreatedAt";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.OptionsColumn.AllowEdit = false;
            this.gridColumn19.OptionsColumn.ReadOnly = true;
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 6;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "Số tiền vay";
            this.gridColumn20.DisplayFormat.FormatString = "c0";
            this.gridColumn20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn20.FieldName = "Money";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.OptionsColumn.AllowEdit = false;
            this.gridColumn20.OptionsColumn.ReadOnly = true;
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 7;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "Số tiền gốc còn phải trả";
            this.gridColumn21.DisplayFormat.FormatString = "c0";
            this.gridColumn21.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn21.FieldName = "AfterMoney";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.OptionsColumn.AllowEdit = false;
            this.gridColumn21.OptionsColumn.ReadOnly = true;
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 8;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "Số tiền lãi";
            this.gridColumn22.DisplayFormat.FormatString = "c0";
            this.gridColumn22.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn22.FieldName = "InterestMoney";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.OptionsColumn.AllowEdit = false;
            this.gridColumn22.OptionsColumn.ReadOnly = true;
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 10;
            // 
            // gridColumn23
            // 
            this.gridColumn23.Caption = "Số ngày chậm lãi";
            this.gridColumn23.FieldName = "AfterDate";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.OptionsColumn.AllowEdit = false;
            this.gridColumn23.OptionsColumn.ReadOnly = true;
            this.gridColumn23.Visible = true;
            this.gridColumn23.VisibleIndex = 11;
            // 
            // gridColumn24
            // 
            this.gridColumn24.Caption = "Id";
            this.gridColumn24.FieldName = "id";
            this.gridColumn24.Name = "gridColumn24";
            this.gridColumn24.OptionsColumn.AllowEdit = false;
            this.gridColumn24.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn26
            // 
            this.gridColumn26.Caption = "Danh sách bạn bè";
            this.gridColumn26.ColumnEdit = this.columnFriend;
            this.gridColumn26.Name = "gridColumn26";
            this.gridColumn26.Visible = true;
            this.gridColumn26.VisibleIndex = 13;
            // 
            // columnFriend
            // 
            this.columnFriend.AutoHeight = false;
            this.columnFriend.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("columnFriend.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.columnFriend.Name = "columnFriend";
            this.columnFriend.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.columnFriend.Click += new System.EventHandler(this.columnFriend_Click);
            // 
            // gridColumn27
            // 
            this.gridColumn27.Caption = "Thanh toán";
            this.gridColumn27.ColumnEdit = this.columnPaid;
            this.gridColumn27.Name = "gridColumn27";
            this.gridColumn27.Visible = true;
            this.gridColumn27.VisibleIndex = 14;
            // 
            // columnPaid
            // 
            this.columnPaid.AutoHeight = false;
            this.columnPaid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("columnPaid.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.columnPaid.Name = "columnPaid";
            this.columnPaid.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.columnPaid.Click += new System.EventHandler(this.columnPaid_Click);
            // 
            // gridColumn28
            // 
            this.gridColumn28.Caption = "Lịch sử thanh toán";
            this.gridColumn28.ColumnEdit = this.columnTransaction;
            this.gridColumn28.Name = "gridColumn28";
            this.gridColumn28.Visible = true;
            this.gridColumn28.VisibleIndex = 15;
            // 
            // columnTransaction
            // 
            this.columnTransaction.AutoHeight = false;
            this.columnTransaction.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("columnTransaction.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.columnTransaction.Name = "columnTransaction";
            this.columnTransaction.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.columnTransaction.Click += new System.EventHandler(this.columnTransaction_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Chu kỳ đóng lãi";
            this.gridColumn1.FieldName = "Cycle";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 9;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ngày đóng lãi tiếp theo";
            this.gridColumn2.FieldName = "NextDay";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 12;
            // 
            // gridColumn25
            // 
            this.gridColumn25.Caption = "Danh sách bạn bè";
            this.gridColumn25.Name = "gridColumn25";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txt_tien_thu);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txt_total_customer);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txt_total_money);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.btn_them);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1270, 73);
            this.panelControl1.TabIndex = 87;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.btn_export_excel);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(1068, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(200, 69);
            this.panelControl2.TabIndex = 14;
            // 
            // btn_export_excel
            // 
            this.btn_export_excel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export_excel.Appearance.Options.UseFont = true;
            this.btn_export_excel.Image = ((System.Drawing.Image)(resources.GetObject("btn_export_excel.Image")));
            this.btn_export_excel.Location = new System.Drawing.Point(46, 13);
            this.btn_export_excel.Name = "btn_export_excel";
            this.btn_export_excel.Size = new System.Drawing.Size(149, 40);
            this.btn_export_excel.TabIndex = 13;
            this.btn_export_excel.Text = "Xuất excel";
            this.btn_export_excel.Click += new System.EventHandler(this.btn_export_excel_Click);
            // 
            // btn_them
            // 
            this.btn_them.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Appearance.Options.UseFont = true;
            this.btn_them.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.Location = new System.Drawing.Point(2, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(184, 69);
            this.btn_them.TabIndex = 11;
            this.btn_them.Text = "Thêm khách hàng";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.grcDanhSachKhachHang);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 73);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1270, 390);
            this.panelControl3.TabIndex = 89;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(204, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(133, 16);
            this.labelControl2.TabIndex = 38;
            this.labelControl2.Text = "Tổng số khách hàng:";
            // 
            // txt_total_customer
            // 
            this.txt_total_customer.Location = new System.Drawing.Point(343, 24);
            this.txt_total_customer.Name = "txt_total_customer";
            this.txt_total_customer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_customer.Properties.Appearance.Options.UseFont = true;
            this.txt_total_customer.Properties.ReadOnly = true;
            this.txt_total_customer.Size = new System.Drawing.Size(127, 22);
            this.txt_total_customer.TabIndex = 37;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(503, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 16);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "Số vốn đã xuất:";
            // 
            // txt_total_money
            // 
            this.txt_total_money.Location = new System.Drawing.Point(611, 24);
            this.txt_total_money.Name = "txt_total_money";
            this.txt_total_money.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_money.Properties.Appearance.Options.UseFont = true;
            this.txt_total_money.Properties.ReadOnly = true;
            this.txt_total_money.Size = new System.Drawing.Size(135, 22);
            this.txt_total_money.TabIndex = 35;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(766, 27);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(95, 16);
            this.labelControl3.TabIndex = 40;
            this.labelControl3.Text = "Số vốn đã thu:";
            // 
            // txt_tien_thu
            // 
            this.txt_tien_thu.Location = new System.Drawing.Point(867, 24);
            this.txt_tien_thu.Name = "txt_tien_thu";
            this.txt_tien_thu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tien_thu.Properties.Appearance.Options.UseFont = true;
            this.txt_tien_thu.Properties.ReadOnly = true;
            this.txt_tien_thu.Size = new System.Drawing.Size(123, 22);
            this.txt_tien_thu.TabIndex = 39;
            // 
            // uc_QLDanhSachKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Name = "uc_QLDanhSachKhachHang";
            this.Size = new System.Drawing.Size(1270, 463);
            this.Load += new System.EventHandler(this.ucQLDanhSachKhachHang_Load);
            this.DoubleClick += new System.EventHandler(this.grvDanhSachKhachHang_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhSachKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSachKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnPaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_total_customer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_total_money.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tien_thu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource categoryBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn25;
        private DevExpress.XtraGrid.GridControl grcDanhSachKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDanhSachKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn26;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit columnFriend;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn27;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit columnPaid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn28;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit columnTransaction;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_export_excel;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_total_customer;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_total_money;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_tien_thu;
    }
}
