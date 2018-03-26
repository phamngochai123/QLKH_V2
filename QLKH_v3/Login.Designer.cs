namespace QLKH_v3
{
    partial class Login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.txt_login_password = new DevExpress.XtraEditors.TextEdit();
            this.txt_login_username = new DevExpress.XtraEditors.TextEdit();
            this.label_error = new DevExpress.XtraEditors.LabelControl();
            this.lbl_error = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_login_password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_login_username.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(74, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(189, 19);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.labelControl1.UseWaitCursor = true;
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(178, 149);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 30);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogin.Location = new System.Drawing.Point(42, 149);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(118, 30);
            this.btnLogin.TabIndex = 22;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txt_login_password
            // 
            this.txt_login_password.EditValue = "";
            this.txt_login_password.Location = new System.Drawing.Point(42, 86);
            this.txt_login_password.Name = "txt_login_password";
            this.txt_login_password.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login_password.Properties.Appearance.Options.UseFont = true;
            this.txt_login_password.Size = new System.Drawing.Size(255, 26);
            this.txt_login_password.TabIndex = 24;
            // 
            // txt_login_username
            // 
            this.txt_login_username.EditValue = "";
            this.txt_login_username.Location = new System.Drawing.Point(42, 54);
            this.txt_login_username.Name = "txt_login_username";
            this.txt_login_username.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login_username.Properties.Appearance.Options.UseFont = true;
            this.txt_login_username.Size = new System.Drawing.Size(254, 26);
            this.txt_login_username.TabIndex = 23;
            // 
            // label_error
            // 
            this.label_error.Location = new System.Drawing.Point(134, 5);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(0, 13);
            this.label_error.TabIndex = 27;
            // 
            // lbl_error
            // 
            this.lbl_error.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(57, 121);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(221, 17);
            this.lbl_error.TabIndex = 28;
            this.lbl_error.Text = "Sai tên tài khoản hoặc mật khẩu";
            this.lbl_error.UseWaitCursor = true;
            this.lbl_error.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLKH_v3.Properties.Resources.loginBackgroundIPadLandscape_2x;
            this.ClientSize = new System.Drawing.Size(339, 218);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txt_login_password);
            this.Controls.Add(this.txt_login_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.txt_login_password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_login_username.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.TextEdit txt_login_password;
        private DevExpress.XtraEditors.TextEdit txt_login_username;
        private DevExpress.XtraEditors.LabelControl label_error;
        private DevExpress.XtraEditors.LabelControl lbl_error;




    }
}