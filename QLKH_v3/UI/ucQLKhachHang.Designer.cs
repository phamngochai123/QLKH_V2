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
            this.grcKhachHang = new DevExpress.XtraGrid.GridControl();
            this.grvKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelBody = new DevExpress.XtraEditors.PanelControl();
            this.panelheader = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grcKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).BeginInit();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelheader)).BeginInit();
            this.SuspendLayout();
            // 
            // grcKhachHang
            // 
            this.grcKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcKhachHang.Location = new System.Drawing.Point(2, 2);
            this.grcKhachHang.MainView = this.grvKhachHang;
            this.grcKhachHang.Name = "grcKhachHang";
            this.grcKhachHang.Size = new System.Drawing.Size(586, 185);
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
            this.panelBody.Location = new System.Drawing.Point(0, 130);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(590, 189);
            this.panelBody.TabIndex = 5;
            // 
            // panelheader
            // 
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(590, 130);
            this.panelheader.TabIndex = 4;
            // 
            // ucQLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelheader);
            this.Name = "ucQLKhachHang";
            this.Size = new System.Drawing.Size(590, 319);
            ((System.ComponentModel.ISupportInitialize)(this.grcKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).EndInit();
            this.panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelheader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView grvKhachHang;
        private DevExpress.XtraEditors.PanelControl panelBody;
        private DevExpress.XtraEditors.PanelControl panelheader;
    }
}
