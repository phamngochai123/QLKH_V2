namespace QLKH_v3.UI
{
    partial class ucQLLaiSuat
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
            this.panelBody = new DevExpress.XtraEditors.PanelControl();
            this.grcLaiSuat = new DevExpress.XtraGrid.GridControl();
            this.grvLaiSuat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelheader = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_cancel_interest = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add_interest = new DevExpress.XtraEditors.SimpleButton();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.date_start = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ghi_chu = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_percent = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).BeginInit();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcLaiSuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLaiSuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelheader)).BeginInit();
            this.panelheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_start.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_start.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ghi_chu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_percent.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.grcLaiSuat);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 192);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(914, 316);
            this.panelBody.TabIndex = 3;
            // 
            // grcLaiSuat
            // 
            this.grcLaiSuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcLaiSuat.Location = new System.Drawing.Point(2, 2);
            this.grcLaiSuat.MainView = this.grvLaiSuat;
            this.grcLaiSuat.Name = "grcLaiSuat";
            this.grcLaiSuat.Size = new System.Drawing.Size(910, 312);
            this.grcLaiSuat.TabIndex = 0;
            this.grcLaiSuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvLaiSuat});
            // 
            // grvLaiSuat
            // 
            this.grvLaiSuat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn6,
            this.gridColumn5});
            this.grvLaiSuat.GridControl = this.grcLaiSuat;
            this.grvLaiSuat.Name = "grvLaiSuat";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên lãi xuất";
            this.gridColumn1.FieldName = "NameInterestRate";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ngày bắt đầu";
            this.gridColumn2.FieldName = "StartDateHistory";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tỷ lệ lãi suất (%)";
            this.gridColumn3.FieldName = "Percents";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Trạng thái";
            this.gridColumn4.FieldName = "StatusHistory";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Ngày tạo";
            this.gridColumn6.FieldName = "CreateAtHisgory";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Người tạo";
            this.gridColumn5.FieldName = "CreatedBy";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // panelheader
            // 
            this.panelheader.Controls.Add(this.groupControl1);
            this.panelheader.Controls.Add(this.date_start);
            this.panelheader.Controls.Add(this.labelControl5);
            this.panelheader.Controls.Add(this.txt_ghi_chu);
            this.panelheader.Controls.Add(this.labelControl4);
            this.panelheader.Controls.Add(this.labelControl3);
            this.panelheader.Controls.Add(this.labelControl2);
            this.panelheader.Controls.Add(this.txt_percent);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(914, 192);
            this.panelheader.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btn_cancel_interest);
            this.groupControl1.Controls.Add(this.btn_add_interest);
            this.groupControl1.Controls.Add(this.btn_them);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(2, 117);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(910, 73);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "Chức năng";
            // 
            // btn_cancel_interest
            // 
            this.btn_cancel_interest.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_interest.Appearance.Options.UseFont = true;
            this.btn_cancel_interest.Enabled = false;
            this.btn_cancel_interest.Location = new System.Drawing.Point(475, 26);
            this.btn_cancel_interest.Name = "btn_cancel_interest";
            this.btn_cancel_interest.Size = new System.Drawing.Size(81, 30);
            this.btn_cancel_interest.TabIndex = 15;
            this.btn_cancel_interest.Text = "Hủy";
            this.btn_cancel_interest.Click += new System.EventHandler(this.btn_cancel_interest_Click);
            // 
            // btn_add_interest
            // 
            this.btn_add_interest.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_interest.Appearance.Options.UseFont = true;
            this.btn_add_interest.Enabled = false;
            this.btn_add_interest.Location = new System.Drawing.Point(387, 26);
            this.btn_add_interest.Name = "btn_add_interest";
            this.btn_add_interest.Size = new System.Drawing.Size(82, 30);
            this.btn_add_interest.TabIndex = 14;
            this.btn_add_interest.Text = "xác nhận";
            this.btn_add_interest.Click += new System.EventHandler(this.btn_add_interest_Click);
            // 
            // btn_them
            // 
            this.btn_them.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Appearance.Options.UseFont = true;
            this.btn_them.Location = new System.Drawing.Point(132, 26);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(118, 30);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Lãi suất mới";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // date_start
            // 
            this.date_start.EditValue = null;
            this.date_start.Enabled = false;
            this.date_start.Location = new System.Drawing.Point(129, 10);
            this.date_start.Name = "date_start";
            this.date_start.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_start.Properties.Appearance.Options.UseFont = true;
            this.date_start.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_start.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_start.Size = new System.Drawing.Size(217, 22);
            this.date_start.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(5, 13);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(86, 16);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Ngày bắt đầu";
            // 
            // txt_ghi_chu
            // 
            this.txt_ghi_chu.Location = new System.Drawing.Point(461, 8);
            this.txt_ghi_chu.Name = "txt_ghi_chu";
            this.txt_ghi_chu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ghi_chu.Properties.Appearance.Options.UseFont = true;
            this.txt_ghi_chu.Properties.ReadOnly = true;
            this.txt_ghi_chu.Size = new System.Drawing.Size(320, 84);
            this.txt_ghi_chu.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(397, 13);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 16);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Ghi chú";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(258, 43);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(26, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "(%)";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(5, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(118, 16);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Phần trăm lãi suất";
            // 
            // txt_percent
            // 
            this.txt_percent.EditValue = "";
            this.txt_percent.Location = new System.Drawing.Point(129, 40);
            this.txt_percent.Name = "txt_percent";
            this.txt_percent.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_percent.Properties.Appearance.Options.UseFont = true;
            this.txt_percent.Properties.ReadOnly = true;
            this.txt_percent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_percent.Size = new System.Drawing.Size(123, 22);
            this.txt_percent.TabIndex = 4;
            // 
            // ucQLLaiSuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelheader);
            this.Name = "ucQLLaiSuat";
            this.Size = new System.Drawing.Size(914, 508);
            this.Load += new System.EventHandler(this.ucQLLaiSuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).EndInit();
            this.panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcLaiSuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLaiSuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelheader)).EndInit();
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.date_start.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_start.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ghi_chu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_percent.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelBody;
        private DevExpress.XtraGrid.GridControl grcLaiSuat;
        private DevExpress.XtraGrid.Views.Grid.GridView grvLaiSuat;
        private DevExpress.XtraEditors.PanelControl panelheader;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_percent;
        private DevExpress.XtraEditors.DateEdit date_start;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.MemoEdit txt_ghi_chu;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.SimpleButton btn_cancel_interest;
        private DevExpress.XtraEditors.SimpleButton btn_add_interest;
    }
}
