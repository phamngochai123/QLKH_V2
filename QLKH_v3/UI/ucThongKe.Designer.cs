namespace QLKH_v3.UI
{
    partial class ucThongKe
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_interset_money = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_total_paid_money = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_total_money = new DevExpress.XtraEditors.TextEdit();
            this.chart_customer_by_month = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_interset_money.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_total_paid_money.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_total_money.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_customer_by_month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(18, 171);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(125, 16);
            this.labelControl6.TabIndex = 23;
            this.labelControl6.Text = "Số tiền lãi thu được";
            // 
            // txt_interset_money
            // 
            this.txt_interset_money.Location = new System.Drawing.Point(194, 165);
            this.txt_interset_money.Name = "txt_interset_money";
            this.txt_interset_money.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_interset_money.Properties.Appearance.Options.UseFont = true;
            this.txt_interset_money.Properties.ReadOnly = true;
            this.txt_interset_money.Size = new System.Drawing.Size(193, 22);
            this.txt_interset_money.TabIndex = 22;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(18, 117);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(134, 16);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "Số tiền gốc thu được";
            // 
            // txt_total_paid_money
            // 
            this.txt_total_paid_money.Location = new System.Drawing.Point(194, 114);
            this.txt_total_paid_money.Name = "txt_total_paid_money";
            this.txt_total_paid_money.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_paid_money.Properties.Appearance.Options.UseFont = true;
            this.txt_total_paid_money.Properties.ReadOnly = true;
            this.txt_total_paid_money.Size = new System.Drawing.Size(193, 22);
            this.txt_total_paid_money.TabIndex = 24;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(18, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(154, 16);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "Tổng số tiền đã cho vay";
            // 
            // txt_total_money
            // 
            this.txt_total_money.Location = new System.Drawing.Point(194, 64);
            this.txt_total_money.Name = "txt_total_money";
            this.txt_total_money.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_money.Properties.Appearance.Options.UseFont = true;
            this.txt_total_money.Properties.ReadOnly = true;
            this.txt_total_money.Size = new System.Drawing.Size(193, 22);
            this.txt_total_money.TabIndex = 26;
            // 
            // chart_customer_by_month
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chart_customer_by_month.Diagram = xyDiagram1;
            this.chart_customer_by_month.Legend.Name = "Default Legend";
            this.chart_customer_by_month.Location = new System.Drawing.Point(430, 49);
            this.chart_customer_by_month.Name = "chart_customer_by_month";
            series1.Name = "Series 1";
            this.chart_customer_by_month.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart_customer_by_month.Size = new System.Drawing.Size(422, 200);
            this.chart_customer_by_month.TabIndex = 28;
            // 
            // ucThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart_customer_by_month);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_total_money);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_total_paid_money);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txt_interset_money);
            this.Name = "ucThongKe";
            this.Size = new System.Drawing.Size(960, 476);
            this.Load += new System.EventHandler(this.uc_Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_interset_money.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_total_paid_money.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_total_money.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_customer_by_month)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_interset_money;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_total_paid_money;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_total_money;
        private DevExpress.XtraCharts.ChartControl chart_customer_by_month;
    }
}
