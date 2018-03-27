namespace QLKH_v3.UI.Detail
{
    partial class uc_ChangePassword
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
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txt_password = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_new_password = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_confirm_password = new DevExpress.XtraEditors.TextEdit();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_change_password = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_new_password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_confirm_password.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(102, 180);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(79, 16);
            this.labelControl8.TabIndex = 76;
            this.labelControl8.Text = "Mật khẩu cũ";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(236, 177);
            this.txt_password.Name = "txt_password";
            this.txt_password.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Properties.Appearance.Options.UseFont = true;
            this.txt_password.Size = new System.Drawing.Size(177, 22);
            this.txt_password.TabIndex = 75;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(102, 212);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(86, 16);
            this.labelControl7.TabIndex = 74;
            this.labelControl7.Text = "Mật khẩu mới";
            // 
            // txt_new_password
            // 
            this.txt_new_password.Location = new System.Drawing.Point(236, 209);
            this.txt_new_password.Name = "txt_new_password";
            this.txt_new_password.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_new_password.Properties.Appearance.Options.UseFont = true;
            this.txt_new_password.Size = new System.Drawing.Size(177, 22);
            this.txt_new_password.TabIndex = 73;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(102, 248);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(124, 16);
            this.labelControl3.TabIndex = 72;
            this.labelControl3.Text = "Xác nhận mật khẩu";
            // 
            // txt_confirm_password
            // 
            this.txt_confirm_password.Location = new System.Drawing.Point(236, 242);
            this.txt_confirm_password.Name = "txt_confirm_password";
            this.txt_confirm_password.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirm_password.Properties.Appearance.Options.UseFont = true;
            this.txt_confirm_password.Size = new System.Drawing.Size(177, 22);
            this.txt_confirm_password.TabIndex = 71;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Appearance.Options.UseFont = true;
            this.btn_cancel.Location = new System.Drawing.Point(262, 324);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(118, 30);
            this.btn_cancel.TabIndex = 78;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_change_password
            // 
            this.btn_change_password.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change_password.Appearance.Options.UseFont = true;
            this.btn_change_password.Location = new System.Drawing.Point(108, 324);
            this.btn_change_password.Name = "btn_change_password";
            this.btn_change_password.Size = new System.Drawing.Size(118, 30);
            this.btn_change_password.TabIndex = 77;
            this.btn_change_password.Text = "Xác nhận";
            this.btn_change_password.Click += new System.EventHandler(this.btn_change_password_Click);
            // 
            // uc_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_change_password);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txt_new_password);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_confirm_password);
            this.Name = "uc_ChangePassword";
            this.Size = new System.Drawing.Size(520, 548);
            ((System.ComponentModel.ISupportInitialize)(this.txt_password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_new_password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_confirm_password.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txt_password;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_new_password;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_confirm_password;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
        private DevExpress.XtraEditors.SimpleButton btn_change_password;
    }
}
