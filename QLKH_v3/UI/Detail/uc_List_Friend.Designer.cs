namespace QLKH_v3.UI.Detail
{
    partial class uc_List_Friend
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
            this.grcFriend = new DevExpress.XtraGrid.GridControl();
            this.grvFriend = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fullname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.grcFriend);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(441, 413);
            this.groupControl2.TabIndex = 89;
            this.groupControl2.Text = "Danh sách bạn bè";
            // 
            // grcFriend
            // 
            this.grcFriend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcFriend.Location = new System.Drawing.Point(2, 26);
            this.grcFriend.MainView = this.grvFriend;
            this.grcFriend.Name = "grcFriend";
            this.grcFriend.Size = new System.Drawing.Size(437, 385);
            this.grcFriend.TabIndex = 86;
            this.grcFriend.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvFriend});
            // 
            // grvFriend
            // 
            this.grvFriend.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.fullname,
            this.rela,
            this.phone,
            this.gridColumn10});
            this.grvFriend.GridControl = this.grcFriend;
            this.grvFriend.Name = "grvFriend";
            this.grvFriend.OptionsView.ShowGroupPanel = false;
            // 
            // fullname
            // 
            this.fullname.Caption = "Họ tên";
            this.fullname.FieldName = "FullName";
            this.fullname.Name = "fullname";
            this.fullname.OptionsColumn.AllowEdit = false;
            this.fullname.OptionsColumn.ReadOnly = true;
            this.fullname.Visible = true;
            this.fullname.VisibleIndex = 0;
            // 
            // rela
            // 
            this.rela.Caption = "Mối quan hệ";
            this.rela.FieldName = "Relationship";
            this.rela.Name = "rela";
            this.rela.OptionsColumn.AllowEdit = false;
            this.rela.OptionsColumn.ReadOnly = true;
            this.rela.Visible = true;
            this.rela.VisibleIndex = 1;
            // 
            // phone
            // 
            this.phone.Caption = "Số điện thoại";
            this.phone.FieldName = "PhoneNumber";
            this.phone.Name = "phone";
            this.phone.OptionsColumn.AllowEdit = false;
            this.phone.OptionsColumn.ReadOnly = true;
            this.phone.Visible = true;
            this.phone.VisibleIndex = 2;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Ghi chú";
            this.gridColumn10.FieldName = "Note";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.OptionsColumn.ReadOnly = true;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 3;
            // 
            // uc_List_Friend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Name = "uc_List_Friend";
            this.Size = new System.Drawing.Size(441, 413);
            this.Load += new System.EventHandler(this.uc_List_Friend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvFriend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl grcFriend;
        private DevExpress.XtraGrid.Views.Grid.GridView grvFriend;
        private DevExpress.XtraGrid.Columns.GridColumn fullname;
        private DevExpress.XtraGrid.Columns.GridColumn rela;
        private DevExpress.XtraGrid.Columns.GridColumn phone;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
    }
}
