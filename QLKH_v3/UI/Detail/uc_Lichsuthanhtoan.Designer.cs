namespace QLKH_v3.UI.Detail
{
    partial class uc_Lichsuthanhtoan
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grcLichsu = new DevExpress.XtraGrid.GridControl();
            this.grvLichsu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fullname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcLichsu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLichsu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.grcLichsu);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(463, 389);
            this.groupControl2.TabIndex = 90;
            this.groupControl2.Text = "Lịch sử thanh toán";
            // 
            // grcLichsu
            // 
            this.grcLichsu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcLichsu.Location = new System.Drawing.Point(2, 26);
            this.grcLichsu.MainView = this.grvLichsu;
            this.grcLichsu.Name = "grcLichsu";
            this.grcLichsu.Size = new System.Drawing.Size(459, 361);
            this.grcLichsu.TabIndex = 86;
            this.grcLichsu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvLichsu});
            // 
            // grvLichsu
            // 
            this.grvLichsu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.fullname,
            this.rela,
            this.phone,
            this.gridColumn10});
            this.grvLichsu.GridControl = this.grcLichsu;
            this.grvLichsu.Name = "grvLichsu";
            this.grvLichsu.OptionsView.ShowGroupPanel = false;
            // 
            // fullname
            // 
            this.fullname.Caption = "Họ tên";
            this.fullname.FieldName = "NameCustomer";
            this.fullname.Name = "fullname";
            this.fullname.OptionsColumn.AllowEdit = false;
            this.fullname.OptionsColumn.ReadOnly = true;
            this.fullname.Visible = true;
            this.fullname.VisibleIndex = 0;
            // 
            // rela
            // 
            this.rela.Caption = "Ngày thanh toán";
            this.rela.FieldName = "CreatedAtHistory";
            this.rela.Name = "rela";
            this.rela.OptionsColumn.AllowEdit = false;
            this.rela.OptionsColumn.ReadOnly = true;
            this.rela.Visible = true;
            this.rela.VisibleIndex = 1;
            // 
            // phone
            // 
            this.phone.Caption = "Số tiền";
            this.phone.FieldName = "PaidMoney";
            this.phone.Name = "phone";
            this.phone.OptionsColumn.AllowEdit = false;
            this.phone.OptionsColumn.ReadOnly = true;
            this.phone.Visible = true;
            this.phone.VisibleIndex = 2;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Kiểu thanh toán";
            this.gridColumn10.FieldName = "TypePaid";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.OptionsColumn.ReadOnly = true;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 3;
            // 
            // uc_Lichsuthanhtoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Name = "uc_Lichsuthanhtoan";
            this.Size = new System.Drawing.Size(463, 389);
            this.Load += new System.EventHandler(this.uc_Lichsuthanhtoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcLichsu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLichsu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl grcLichsu;
        private DevExpress.XtraGrid.Views.Grid.GridView grvLichsu;
        private DevExpress.XtraGrid.Columns.GridColumn fullname;
        private DevExpress.XtraGrid.Columns.GridColumn rela;
        private DevExpress.XtraGrid.Columns.GridColumn phone;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
    }
}
