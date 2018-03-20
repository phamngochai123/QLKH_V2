namespace QLKH_v3.UI
{
    partial class uc_LichSuTraTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_LichSuTraTien));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelheader = new DevExpress.XtraEditors.PanelControl();
            this.radio_type_paid = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_phone = new DevExpress.XtraEditors.TextEdit();
            this.numeric_money = new System.Windows.Forms.NumericUpDown();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_cmnd = new DevExpress.XtraEditors.TextEdit();
            this.btn_cancel_historypaid = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add_historypaid = new DevExpress.XtraEditors.SimpleButton();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.txt_ghi_chu = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grcHistoryPaid = new DevExpress.XtraGrid.GridControl();
            this.grvHistoryPaid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_chitiet = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelheader)).BeginInit();
            this.panelheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radio_type_paid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_phone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_money)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cmnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ghi_chu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcHistoryPaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHistoryPaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_chitiet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelheader
            // 
            this.panelheader.Controls.Add(this.radio_type_paid);
            this.panelheader.Controls.Add(this.labelControl5);
            this.panelheader.Controls.Add(this.txt_phone);
            this.panelheader.Controls.Add(this.numeric_money);
            this.panelheader.Controls.Add(this.labelControl4);
            this.panelheader.Controls.Add(this.labelControl3);
            this.panelheader.Controls.Add(this.txt_cmnd);
            this.panelheader.Controls.Add(this.btn_cancel_historypaid);
            this.panelheader.Controls.Add(this.btn_add_historypaid);
            this.panelheader.Controls.Add(this.btn_them);
            this.panelheader.Controls.Add(this.txt_ghi_chu);
            this.panelheader.Controls.Add(this.labelControl2);
            this.panelheader.Controls.Add(this.labelControl1);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(923, 273);
            this.panelheader.TabIndex = 5;
            // 
            // radio_type_paid
            // 
            this.radio_type_paid.EditValue = "<Null>";
            this.radio_type_paid.Enabled = false;
            this.radio_type_paid.Location = new System.Drawing.Point(123, 11);
            this.radio_type_paid.Name = "radio_type_paid";
            this.radio_type_paid.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.radio_type_paid.Properties.Appearance.Options.UseBackColor = true;
            this.radio_type_paid.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radio_type_paid.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("0", "Tiền gốc"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("1", "Tiền lãi")});
            this.radio_type_paid.Size = new System.Drawing.Size(190, 25);
            this.radio_type_paid.TabIndex = 66;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(14, 138);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(84, 16);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Số điện thoại";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(123, 135);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Properties.Appearance.Options.UseFont = true;
            this.txt_phone.Properties.ReadOnly = true;
            this.txt_phone.Size = new System.Drawing.Size(281, 22);
            this.txt_phone.TabIndex = 12;
            // 
            // numeric_money
            // 
            this.numeric_money.Location = new System.Drawing.Point(123, 48);
            this.numeric_money.Name = "numeric_money";
            this.numeric_money.ReadOnly = true;
            this.numeric_money.Size = new System.Drawing.Size(120, 21);
            this.numeric_money.TabIndex = 11;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(14, 53);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 16);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Số tiền";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(14, 94);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 16);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Số CMND";
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.Location = new System.Drawing.Point(123, 91);
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cmnd.Properties.Appearance.Options.UseFont = true;
            this.txt_cmnd.Properties.ReadOnly = true;
            this.txt_cmnd.Size = new System.Drawing.Size(281, 22);
            this.txt_cmnd.TabIndex = 7;
            // 
            // btn_cancel_historypaid
            // 
            this.btn_cancel_historypaid.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_historypaid.Appearance.Options.UseFont = true;
            this.btn_cancel_historypaid.Enabled = false;
            this.btn_cancel_historypaid.Location = new System.Drawing.Point(502, 237);
            this.btn_cancel_historypaid.Name = "btn_cancel_historypaid";
            this.btn_cancel_historypaid.Size = new System.Drawing.Size(81, 30);
            this.btn_cancel_historypaid.TabIndex = 6;
            this.btn_cancel_historypaid.Text = "Hủy";
            this.btn_cancel_historypaid.Click += new System.EventHandler(this.btn_cancel_historypaid_Click);
            // 
            // btn_add_historypaid
            // 
            this.btn_add_historypaid.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_historypaid.Appearance.Options.UseFont = true;
            this.btn_add_historypaid.Enabled = false;
            this.btn_add_historypaid.Location = new System.Drawing.Point(414, 237);
            this.btn_add_historypaid.Name = "btn_add_historypaid";
            this.btn_add_historypaid.Size = new System.Drawing.Size(82, 30);
            this.btn_add_historypaid.TabIndex = 5;
            this.btn_add_historypaid.Text = "xác nhận";
            this.btn_add_historypaid.Click += new System.EventHandler(this.btn_add_historypaid_Click);
            // 
            // btn_them
            // 
            this.btn_them.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Appearance.Options.UseFont = true;
            this.btn_them.Location = new System.Drawing.Point(119, 237);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(118, 30);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Nộp tiền";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_ghi_chu
            // 
            this.txt_ghi_chu.Location = new System.Drawing.Point(571, 13);
            this.txt_ghi_chu.Name = "txt_ghi_chu";
            this.txt_ghi_chu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ghi_chu.Properties.Appearance.Options.UseFont = true;
            this.txt_ghi_chu.Properties.ReadOnly = true;
            this.txt_ghi_chu.Size = new System.Drawing.Size(285, 71);
            this.txt_ghi_chu.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(466, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Ghi chú";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(14, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Kiểu thanh toán";
            // 
            // grcHistoryPaid
            // 
            this.grcHistoryPaid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcHistoryPaid.Location = new System.Drawing.Point(0, 273);
            this.grcHistoryPaid.MainView = this.grvHistoryPaid;
            this.grcHistoryPaid.Name = "grcHistoryPaid";
            this.grcHistoryPaid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btn_chitiet});
            this.grcHistoryPaid.Size = new System.Drawing.Size(923, 237);
            this.grcHistoryPaid.TabIndex = 6;
            this.grcHistoryPaid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvHistoryPaid});
            // 
            // grvHistoryPaid
            // 
            this.grvHistoryPaid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.col1,
            this.col2,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn5,
            this.gridColumn4,
            this.gridColumn6});
            this.grvHistoryPaid.GridControl = this.grcHistoryPaid;
            this.grvHistoryPaid.Name = "grvHistoryPaid";
            this.grvHistoryPaid.OptionsFind.AlwaysVisible = true;
            this.grvHistoryPaid.OptionsFind.FindNullPrompt = "Search...";
            this.grvHistoryPaid.OptionsFind.ShowClearButton = false;
            this.grvHistoryPaid.OptionsFind.ShowFindButton = false;
            this.grvHistoryPaid.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Id";
            this.gridColumn3.FieldName = "id";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            // 
            // col1
            // 
            this.col1.Caption = "Tên khách hàng";
            this.col1.FieldName = "NameCustomer";
            this.col1.Name = "col1";
            this.col1.OptionsColumn.AllowEdit = false;
            this.col1.OptionsColumn.ReadOnly = true;
            this.col1.Visible = true;
            this.col1.VisibleIndex = 0;
            // 
            // col2
            // 
            this.col2.Caption = "Số CMND";
            this.col2.FieldName = "IdCard";
            this.col2.Name = "col2";
            this.col2.OptionsColumn.AllowEdit = false;
            this.col2.OptionsColumn.ReadOnly = true;
            this.col2.Visible = true;
            this.col2.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ngày trả";
            this.gridColumn1.DisplayFormat.FormatString = "dd-MM-yyyy HH:mm:ss";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn1.FieldName = "PaidDate";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Số tiền trả";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn2.FieldName = "PaidMoney";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Kiểu thanh toán";
            this.gridColumn5.FieldName = "TypePaid";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Người tiếp nhận";
            this.gridColumn4.FieldName = "CreatedByUser";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Ngày tạo";
            this.gridColumn6.FieldName = "CreatedAtHistory";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            // 
            // btn_chitiet
            // 
            this.btn_chitiet.AutoHeight = false;
            this.btn_chitiet.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btn_chitiet.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.btn_chitiet.Name = "btn_chitiet";
            this.btn_chitiet.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // uc_LichSuTraTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grcHistoryPaid);
            this.Controls.Add(this.panelheader);
            this.Name = "uc_LichSuTraTien";
            this.Size = new System.Drawing.Size(923, 510);
            this.Load += new System.EventHandler(this.uc_Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelheader)).EndInit();
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radio_type_paid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_phone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_money)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cmnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ghi_chu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcHistoryPaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvHistoryPaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_chitiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelheader;
        private DevExpress.XtraEditors.SimpleButton btn_cancel_historypaid;
        private DevExpress.XtraEditors.SimpleButton btn_add_historypaid;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private DevExpress.XtraEditors.MemoEdit txt_ghi_chu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grcHistoryPaid;
        private DevExpress.XtraGrid.Views.Grid.GridView grvHistoryPaid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn col1;
        private DevExpress.XtraGrid.Columns.GridColumn col2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_chitiet;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_phone;
        private System.Windows.Forms.NumericUpDown numeric_money;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_cmnd;
        private DevExpress.XtraEditors.RadioGroup radio_type_paid;

    }
}
