namespace QLKH_v3.UI
{
    partial class uc_Category
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
            this.grcCategory = new DevExpress.XtraGrid.GridControl();
            this.grvCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelheader = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.txt_ghi_chu = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_name_category = new DevExpress.XtraEditors.TextEdit();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).BeginInit();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelheader)).BeginInit();
            this.panelheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ghi_chu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name_category.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.grcCategory);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 175);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(893, 304);
            this.panelBody.TabIndex = 5;
            // 
            // grcCategory
            // 
            this.grcCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcCategory.Location = new System.Drawing.Point(2, 2);
            this.grcCategory.MainView = this.grvCategory;
            this.grcCategory.Name = "grcCategory";
            this.grcCategory.Size = new System.Drawing.Size(889, 300);
            this.grcCategory.TabIndex = 0;
            this.grcCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCategory});
            // 
            // grvCategory
            // 
            this.grvCategory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.col1,
            this.col2,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn5,
            this.gridColumn4});
            this.grvCategory.GridControl = this.grcCategory;
            this.grvCategory.Name = "grvCategory";
            this.grvCategory.OptionsFind.AlwaysVisible = true;
            this.grvCategory.OptionsFind.FindNullPrompt = "Search...";
            this.grvCategory.OptionsFind.ShowClearButton = false;
            this.grvCategory.OptionsFind.ShowFindButton = false;
            this.grvCategory.OptionsView.ShowGroupPanel = false;
            this.grvCategory.DoubleClick += new System.EventHandler(this.grvCategory_DoubleClick);
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
            this.col1.Caption = "Tên danh mục";
            this.col1.FieldName = "Name";
            this.col1.Name = "col1";
            this.col1.OptionsColumn.AllowEdit = false;
            this.col1.OptionsColumn.ReadOnly = true;
            this.col1.Visible = true;
            this.col1.VisibleIndex = 0;
            // 
            // col2
            // 
            this.col2.Caption = "Ghi chú";
            this.col2.FieldName = "Note";
            this.col2.Name = "col2";
            this.col2.OptionsColumn.AllowEdit = false;
            this.col2.OptionsColumn.ReadOnly = true;
            this.col2.Visible = true;
            this.col2.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ngày tạo";
            this.gridColumn1.DisplayFormat.FormatString = "dd-MM-yyyy HH:mm:ss";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn1.FieldName = "CreatedAt";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ngày sửa";
            this.gridColumn2.DisplayFormat.FormatString = "dd-MM-yyyy HH:mm:ss";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn2.FieldName = "UpdatedAt";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Người tạo";
            this.gridColumn5.FieldName = "CreatedBy";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Người sửa";
            this.gridColumn4.FieldName = "UpdatedBy";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // panelheader
            // 
            this.panelheader.Controls.Add(this.simpleButton2);
            this.panelheader.Controls.Add(this.simpleButton1);
            this.panelheader.Controls.Add(this.btn_them);
            this.panelheader.Controls.Add(this.txt_ghi_chu);
            this.panelheader.Controls.Add(this.labelControl2);
            this.panelheader.Controls.Add(this.labelControl1);
            this.panelheader.Controls.Add(this.txt_name_category);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(893, 175);
            this.panelheader.TabIndex = 4;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(502, 130);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(81, 30);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Hủy";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(414, 130);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(82, 30);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "xác nhận";
            // 
            // btn_them
            // 
            this.btn_them.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Appearance.Options.UseFont = true;
            this.btn_them.Location = new System.Drawing.Point(119, 130);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(118, 30);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Thêm danh mục";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_ghi_chu
            // 
            this.txt_ghi_chu.Location = new System.Drawing.Point(119, 43);
            this.txt_ghi_chu.Name = "txt_ghi_chu";
            this.txt_ghi_chu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ghi_chu.Properties.Appearance.Options.UseFont = true;
            this.txt_ghi_chu.Size = new System.Drawing.Size(464, 71);
            this.txt_ghi_chu.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(14, 44);
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
            this.labelControl1.Size = new System.Drawing.Size(89, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tên danh mục";
            // 
            // txt_name_category
            // 
            this.txt_name_category.Location = new System.Drawing.Point(119, 11);
            this.txt_name_category.Name = "txt_name_category";
            this.txt_name_category.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_category.Properties.Appearance.Options.UseFont = true;
            this.txt_name_category.Size = new System.Drawing.Size(464, 22);
            this.txt_name_category.TabIndex = 0;
            // 
            // Status
            // 
            this.Status.Caption = "Trạng thái";
            this.Status.DisplayFormat.FormatString = "d";
            this.Status.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Status.FieldName = "Status";
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 4;
            // 
            // uc_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelheader);
            this.Name = "uc_Category";
            this.Size = new System.Drawing.Size(893, 479);
            this.Load += new System.EventHandler(this.uc_Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).EndInit();
            this.panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelheader)).EndInit();
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ghi_chu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name_category.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelBody;
        private DevExpress.XtraGrid.GridControl grcCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCategory;
        private DevExpress.XtraEditors.PanelControl panelheader;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private DevExpress.XtraEditors.MemoEdit txt_ghi_chu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_name_category;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.Columns.GridColumn col1;
        private DevExpress.XtraGrid.Columns.GridColumn col2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
