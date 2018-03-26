namespace QLKH_v3.UI
{
    partial class uc_thongkedoanhthu
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_total_money = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_total_paid_money = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_interset_money = new DevExpress.XtraEditors.TextEdit();
            this.grcStatistic = new DevExpress.XtraGrid.GridControl();
            this.grvStatistic = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fullname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbb_statistic_year = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_total_money.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_total_paid_money.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_interset_money.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcStatistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvStatistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_statistic_year.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(3, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(154, 16);
            this.labelControl2.TabIndex = 34;
            this.labelControl2.Text = "Tổng số tiền đã cho vay";
            // 
            // txt_total_money
            // 
            this.txt_total_money.Location = new System.Drawing.Point(179, 42);
            this.txt_total_money.Name = "txt_total_money";
            this.txt_total_money.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_money.Properties.Appearance.Options.UseFont = true;
            this.txt_total_money.Properties.ReadOnly = true;
            this.txt_total_money.Size = new System.Drawing.Size(193, 22);
            this.txt_total_money.TabIndex = 33;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(3, 95);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(134, 16);
            this.labelControl1.TabIndex = 32;
            this.labelControl1.Text = "Số tiền gốc thu được";
            // 
            // txt_total_paid_money
            // 
            this.txt_total_paid_money.Location = new System.Drawing.Point(179, 92);
            this.txt_total_paid_money.Name = "txt_total_paid_money";
            this.txt_total_paid_money.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_paid_money.Properties.Appearance.Options.UseFont = true;
            this.txt_total_paid_money.Properties.ReadOnly = true;
            this.txt_total_paid_money.Size = new System.Drawing.Size(193, 22);
            this.txt_total_paid_money.TabIndex = 31;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(3, 149);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(125, 16);
            this.labelControl6.TabIndex = 30;
            this.labelControl6.Text = "Số tiền lãi thu được";
            // 
            // txt_interset_money
            // 
            this.txt_interset_money.Location = new System.Drawing.Point(179, 143);
            this.txt_interset_money.Name = "txt_interset_money";
            this.txt_interset_money.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_interset_money.Properties.Appearance.Options.UseFont = true;
            this.txt_interset_money.Properties.ReadOnly = true;
            this.txt_interset_money.Size = new System.Drawing.Size(193, 22);
            this.txt_interset_money.TabIndex = 29;
            // 
            // grcStatistic
            // 
            this.grcStatistic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grcStatistic.Location = new System.Drawing.Point(0, 184);
            this.grcStatistic.MainView = this.grvStatistic;
            this.grcStatistic.Name = "grcStatistic";
            this.grcStatistic.Size = new System.Drawing.Size(1225, 281);
            this.grcStatistic.TabIndex = 87;
            this.grcStatistic.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvStatistic});
            // 
            // grvStatistic
            // 
            this.grvStatistic.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.fullname,
            this.rela,
            this.phone,
            this.gridColumn10,
            this.gridColumn1});
            this.grvStatistic.GridControl = this.grcStatistic;
            this.grvStatistic.Name = "grvStatistic";
            this.grvStatistic.OptionsView.ShowGroupPanel = false;
            // 
            // fullname
            // 
            this.fullname.Caption = "Tháng";
            this.fullname.FieldName = "Month";
            this.fullname.Name = "fullname";
            this.fullname.OptionsColumn.AllowEdit = false;
            this.fullname.OptionsColumn.ReadOnly = true;
            this.fullname.Visible = true;
            this.fullname.VisibleIndex = 0;
            // 
            // rela
            // 
            this.rela.Caption = "Số khách hàng";
            this.rela.FieldName = "NumCustomer";
            this.rela.Name = "rela";
            this.rela.OptionsColumn.AllowEdit = false;
            this.rela.OptionsColumn.ReadOnly = true;
            this.rela.Visible = true;
            this.rela.VisibleIndex = 1;
            // 
            // phone
            // 
            this.phone.Caption = "Số tiền cho vay";
            this.phone.DisplayFormat.FormatString = "c0";
            this.phone.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.phone.FieldName = "NumMoney";
            this.phone.Name = "phone";
            this.phone.OptionsColumn.AllowEdit = false;
            this.phone.OptionsColumn.ReadOnly = true;
            this.phone.Visible = true;
            this.phone.VisibleIndex = 2;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Số vốn thu hồi";
            this.gridColumn10.DisplayFormat.FormatString = "c0";
            this.gridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn10.FieldName = "NumReturnMoney";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.OptionsColumn.ReadOnly = true;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 3;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Số lãi thu được";
            this.gridColumn1.DisplayFormat.FormatString = "c0";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.FieldName = "NumInterestMoney";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // cbb_statistic_year
            // 
            this.cbb_statistic_year.Location = new System.Drawing.Point(179, 3);
            this.cbb_statistic_year.Name = "cbb_statistic_year";
            this.cbb_statistic_year.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_statistic_year.Properties.Appearance.Options.UseFont = true;
            this.cbb_statistic_year.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_statistic_year.Size = new System.Drawing.Size(193, 22);
            this.cbb_statistic_year.TabIndex = 106;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(3, 6);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(48, 16);
            this.labelControl9.TabIndex = 105;
            this.labelControl9.Text = "Đồ cầm";
            // 
            // uc_thongkedoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbb_statistic_year);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.grcStatistic);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_total_money);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_total_paid_money);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txt_interset_money);
            this.Name = "uc_thongkedoanhthu";
            this.Size = new System.Drawing.Size(1225, 465);
            this.Load += new System.EventHandler(this.uc_thongkedoanhthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_total_money.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_total_paid_money.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_interset_money.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcStatistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvStatistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_statistic_year.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_total_money;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_total_paid_money;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_interset_money;
        private DevExpress.XtraGrid.GridControl grcStatistic;
        private DevExpress.XtraGrid.Views.Grid.GridView grvStatistic;
        private DevExpress.XtraGrid.Columns.GridColumn fullname;
        private DevExpress.XtraGrid.Columns.GridColumn rela;
        private DevExpress.XtraGrid.Columns.GridColumn phone;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbb_statistic_year;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}
