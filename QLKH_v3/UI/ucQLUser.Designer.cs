namespace QLKH_v3.UI
{
    partial class ucQLUser
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
            this.panelheader = new DevExpress.XtraEditors.PanelControl();
            this.panelBody = new DevExpress.XtraEditors.PanelControl();
            this.grcUser = new DevExpress.XtraGrid.GridControl();
            this.grvUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelheader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).BeginInit();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelheader
            // 
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(685, 130);
            this.panelheader.TabIndex = 0;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.grcUser);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 130);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(685, 195);
            this.panelBody.TabIndex = 1;
            // 
            // grcUser
            // 
            this.grcUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcUser.Location = new System.Drawing.Point(2, 2);
            this.grcUser.MainView = this.grvUser;
            this.grcUser.Name = "grcUser";
            this.grcUser.Size = new System.Drawing.Size(681, 191);
            this.grcUser.TabIndex = 0;
            this.grcUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvUser});
            // 
            // grvUser
            // 
            this.grvUser.GridControl = this.grcUser;
            this.grvUser.Name = "grvUser";
            // 
            // ucQLUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelheader);
            this.Name = "ucQLUser";
            this.Size = new System.Drawing.Size(685, 325);
            this.Load += new System.EventHandler(this.ucQLUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelheader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).EndInit();
            this.panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelheader;
        private DevExpress.XtraEditors.PanelControl panelBody;
        private DevExpress.XtraGrid.GridControl grcUser;
        private DevExpress.XtraGrid.Views.Grid.GridView grvUser;
    }
}
