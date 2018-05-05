namespace QLKH_v3.UI
{
    partial class ucKhachHangBaoTruoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucKhachHangBaoTruoc));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_export_excel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnFilter = new DevExpress.XtraEditors.SimpleButton();
            this.numberDay = new System.Windows.Forms.NumericUpDown();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.grcKhachHangBaoTruoc = new DevExpress.XtraGrid.GridControl();
            this.grvKhachHangBaoTruoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btn_thanh_toan = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btn_lich_su_thanh_toan = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcKhachHangBaoTruoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKhachHangBaoTruoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_thanh_toan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_lich_su_thanh_toan)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(QLKH_v3.category);
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.simpleButton1);
            this.panelControl4.Controls.Add(this.btn_export_excel);
            this.panelControl4.Controls.Add(this.labelControl1);
            this.panelControl4.Controls.Add(this.btnFilter);
            this.panelControl4.Controls.Add(this.numberDay);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(0, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1241, 85);
            this.panelControl4.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(407, 30);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "Tất cả";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_export_excel
            // 
            this.btn_export_excel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export_excel.Appearance.Options.UseFont = true;
            this.btn_export_excel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_export_excel.Image = ((System.Drawing.Image)(resources.GetObject("btn_export_excel.Image")));
            this.btn_export_excel.Location = new System.Drawing.Point(1090, 2);
            this.btn_export_excel.Name = "btn_export_excel";
            this.btn_export_excel.Size = new System.Drawing.Size(149, 81);
            this.btn_export_excel.TabIndex = 14;
            this.btn_export_excel.Text = "Xuất excel";
            this.btn_export_excel.Click += new System.EventHandler(this.btn_export_excel_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(5, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(152, 14);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Nhập số ngày báo trước:";
            // 
            // btnFilter
            // 
            this.btnFilter.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilter.Appearance.Options.UseFont = true;
            this.btnFilter.Location = new System.Drawing.Point(308, 30);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // numberDay
            // 
            this.numberDay.Location = new System.Drawing.Point(169, 30);
            this.numberDay.Name = "numberDay";
            this.numberDay.Size = new System.Drawing.Size(120, 21);
            this.numberDay.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.grcKhachHangBaoTruoc);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 85);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1241, 545);
            this.panelControl1.TabIndex = 4;
            // 
            // grcKhachHangBaoTruoc
            // 
            this.grcKhachHangBaoTruoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcKhachHangBaoTruoc.Location = new System.Drawing.Point(2, 2);
            this.grcKhachHangBaoTruoc.MainView = this.grvKhachHangBaoTruoc;
            this.grcKhachHangBaoTruoc.Name = "grcKhachHangBaoTruoc";
            this.grcKhachHangBaoTruoc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.btn_thanh_toan,
            this.btn_lich_su_thanh_toan});
            this.grcKhachHangBaoTruoc.Size = new System.Drawing.Size(1237, 541);
            this.grcKhachHangBaoTruoc.TabIndex = 3;
            this.grcKhachHangBaoTruoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvKhachHangBaoTruoc});
            // 
            // grvKhachHangBaoTruoc
            // 
            this.grvKhachHangBaoTruoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn12,
            this.gridColumn16,
            this.gridColumn4,
            this.gridColumn5});
            this.grvKhachHangBaoTruoc.GridControl = this.grcKhachHangBaoTruoc;
            this.grvKhachHangBaoTruoc.Name = "grvKhachHangBaoTruoc";
            this.grvKhachHangBaoTruoc.OptionsFind.AlwaysVisible = true;
            this.grvKhachHangBaoTruoc.OptionsFind.FindNullPrompt = "Tìm kiếm";
            this.grvKhachHangBaoTruoc.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Họ tên";
            this.gridColumn1.FieldName = "FullName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "CMND";
            this.gridColumn2.FieldName = "IdCard";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Số điện thoại";
            this.gridColumn3.FieldName = "PhoneNumber";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Ngày sinh";
            this.gridColumn12.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.gridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn12.FieldName = "BirthDay";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.OptionsColumn.ReadOnly = true;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 3;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Giới tính";
            this.gridColumn16.FieldName = "SexString";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.OptionsColumn.AllowEdit = false;
            this.gridColumn16.OptionsColumn.ReadOnly = true;
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 5;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Địa chỉ";
            this.gridColumn4.FieldName = "Address";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ngày vay";
            this.gridColumn5.DisplayFormat.FormatString = "dd-MM-yyyy HH:mm:ss";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn5.FieldName = "CreatedAt";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit1.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btn_thanh_toan
            // 
            this.btn_thanh_toan.AutoHeight = false;
            this.btn_thanh_toan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btn_thanh_toan.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, true)});
            this.btn_thanh_toan.Name = "btn_thanh_toan";
            this.btn_thanh_toan.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btn_lich_su_thanh_toan
            // 
            this.btn_lich_su_thanh_toan.AutoHeight = false;
            this.btn_lich_su_thanh_toan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btn_lich_su_thanh_toan.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", null, null, true)});
            this.btn_lich_su_thanh_toan.Name = "btn_lich_su_thanh_toan";
            this.btn_lich_su_thanh_toan.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // ucKhachHangBaoTruoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl4);
            this.Name = "ucKhachHangBaoTruoc";
            this.Size = new System.Drawing.Size(1241, 630);
            this.Load += new System.EventHandler(this.ucKhachHangBaoTruoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcKhachHangBaoTruoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKhachHangBaoTruoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_thanh_toan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_lich_su_thanh_toan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource categoryBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnFilter;
        private System.Windows.Forms.NumericUpDown numberDay;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl grcKhachHangBaoTruoc;
        private DevExpress.XtraGrid.Views.Grid.GridView grvKhachHangBaoTruoc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_thanh_toan;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_lich_su_thanh_toan;
        private DevExpress.XtraEditors.SimpleButton btn_export_excel;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;

    }
}
