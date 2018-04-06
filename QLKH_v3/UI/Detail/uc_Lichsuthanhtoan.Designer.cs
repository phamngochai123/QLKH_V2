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
            this.date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.money = new DevExpress.XtraGrid.Columns.GridColumn();
            this.type = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.date,
            this.money,
            this.type});
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
            // date
            // 
            this.date.Caption = "Ngày thanh toán";
            this.date.FieldName = "CreatedAtHistory";
            this.date.Name = "date";
            this.date.OptionsColumn.AllowEdit = false;
            this.date.OptionsColumn.ReadOnly = true;
            this.date.Visible = true;
            this.date.VisibleIndex = 1;
            // 
            // money
            // 
            this.money.Caption = "Số tiền";
            this.money.DisplayFormat.FormatString = "c0";
            this.money.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.money.FieldName = "PaidMoney";
            this.money.Name = "money";
            this.money.OptionsColumn.AllowEdit = false;
            this.money.OptionsColumn.ReadOnly = true;
            this.money.Visible = true;
            this.money.VisibleIndex = 2;
            // 
            // type
            // 
            this.type.Caption = "Kiểu thanh toán";
            this.type.FieldName = "TypePaid";
            this.type.Name = "type";
            this.type.OptionsColumn.AllowEdit = false;
            this.type.OptionsColumn.ReadOnly = true;
            this.type.Visible = true;
            this.type.VisibleIndex = 3;
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
        private DevExpress.XtraGrid.Columns.GridColumn date;
        private DevExpress.XtraGrid.Columns.GridColumn money;
        private DevExpress.XtraGrid.Columns.GridColumn type;
    }
}
