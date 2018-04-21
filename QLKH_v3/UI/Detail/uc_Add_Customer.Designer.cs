namespace QLKH_v3.UI.Detail
{
    partial class uc_Add_Customer
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
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fullname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grvAddFriend = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcAddFriend = new DevExpress.XtraGrid.GridControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.date_paid = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_familyphone = new DevExpress.XtraEditors.TextEdit();
            this.cbb_category = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txt_idcard = new DevExpress.XtraEditors.TextEdit();
            this.radio_sex = new DevExpress.XtraEditors.RadioGroup();
            this.birthDay_customer = new DevExpress.XtraEditors.DateEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_phone = new DevExpress.XtraEditors.TextEdit();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_note = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_fullname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txt_address = new DevExpress.XtraEditors.TextEdit();
            this.txt_money = new DevExpress.XtraEditors.TextEdit();
            this.txt_cycle = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grvAddFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcAddFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_paid.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_paid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_familyphone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_category.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_idcard.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radio_sex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthDay_customer.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthDay_customer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_phone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_note.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_fullname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_address.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_money.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cycle.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Ghi chú";
            this.gridColumn10.FieldName = "Note";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 3;
            // 
            // rela
            // 
            this.rela.Caption = "Mối quan hệ";
            this.rela.FieldName = "Relationship";
            this.rela.Name = "rela";
            this.rela.Visible = true;
            this.rela.VisibleIndex = 1;
            // 
            // fullname
            // 
            this.fullname.Caption = "Họ tên";
            this.fullname.FieldName = "FullName";
            this.fullname.Name = "fullname";
            this.fullname.Visible = true;
            this.fullname.VisibleIndex = 0;
            // 
            // grvAddFriend
            // 
            this.grvAddFriend.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.fullname,
            this.rela,
            this.phone,
            this.gridColumn10});
            this.grvAddFriend.GridControl = this.grcAddFriend;
            this.grvAddFriend.Name = "grvAddFriend";
            this.grvAddFriend.OptionsView.ShowGroupPanel = false;
            // 
            // phone
            // 
            this.phone.Caption = "Số điện thoại";
            this.phone.FieldName = "PhoneNumber";
            this.phone.Name = "phone";
            this.phone.Visible = true;
            this.phone.VisibleIndex = 2;
            // 
            // grcAddFriend
            // 
            this.grcAddFriend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcAddFriend.Location = new System.Drawing.Point(2, 26);
            this.grcAddFriend.MainView = this.grvAddFriend;
            this.grcAddFriend.Name = "grcAddFriend";
            this.grcAddFriend.Size = new System.Drawing.Size(420, 210);
            this.grcAddFriend.TabIndex = 86;
            this.grcAddFriend.UseEmbeddedNavigator = true;
            this.grcAddFriend.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvAddFriend});
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.grcAddFriend);
            this.groupControl2.Location = new System.Drawing.Point(605, 25);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(424, 238);
            this.groupControl2.TabIndex = 135;
            this.groupControl2.Text = "Danh sách bạn bè";
            // 
            // date_paid
            // 
            this.date_paid.EditValue = null;
            this.date_paid.Location = new System.Drawing.Point(176, 225);
            this.date_paid.Name = "date_paid";
            this.date_paid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_paid.Properties.Appearance.Options.UseFont = true;
            this.date_paid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_paid.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_paid.Size = new System.Drawing.Size(335, 22);
            this.date_paid.TabIndex = 134;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(54, 231);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 16);
            this.labelControl4.TabIndex = 133;
            this.labelControl4.Text = "Ngày vay";
            // 
            // txt_familyphone
            // 
            this.txt_familyphone.Location = new System.Drawing.Point(176, 371);
            this.txt_familyphone.Name = "txt_familyphone";
            this.txt_familyphone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_familyphone.Properties.Appearance.Options.UseFont = true;
            this.txt_familyphone.Size = new System.Drawing.Size(337, 22);
            this.txt_familyphone.TabIndex = 132;
            // 
            // cbb_category
            // 
            this.cbb_category.Location = new System.Drawing.Point(176, 185);
            this.cbb_category.Name = "cbb_category";
            this.cbb_category.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_category.Properties.Appearance.Options.UseFont = true;
            this.cbb_category.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_category.Size = new System.Drawing.Size(337, 22);
            this.cbb_category.TabIndex = 131;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Location = new System.Drawing.Point(54, 191);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(92, 16);
            this.labelControl11.TabIndex = 130;
            this.labelControl11.Text = "Hồ sơ tín chấp";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(54, 59);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(36, 16);
            this.labelControl8.TabIndex = 129;
            this.labelControl8.Text = "CMND";
            // 
            // txt_idcard
            // 
            this.txt_idcard.Location = new System.Drawing.Point(176, 53);
            this.txt_idcard.Name = "txt_idcard";
            this.txt_idcard.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idcard.Properties.Appearance.Options.UseFont = true;
            this.txt_idcard.Size = new System.Drawing.Size(337, 22);
            this.txt_idcard.TabIndex = 128;
            // 
            // radio_sex
            // 
            this.radio_sex.Location = new System.Drawing.Point(174, 332);
            this.radio_sex.Name = "radio_sex";
            this.radio_sex.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.radio_sex.Properties.Appearance.Options.UseBackColor = true;
            this.radio_sex.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radio_sex.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Nam"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Nữ")});
            this.radio_sex.Size = new System.Drawing.Size(190, 25);
            this.radio_sex.TabIndex = 127;
            // 
            // birthDay_customer
            // 
            this.birthDay_customer.EditValue = null;
            this.birthDay_customer.Location = new System.Drawing.Point(176, 152);
            this.birthDay_customer.Name = "birthDay_customer";
            this.birthDay_customer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDay_customer.Properties.Appearance.Options.UseFont = true;
            this.birthDay_customer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.birthDay_customer.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.birthDay_customer.Size = new System.Drawing.Size(337, 22);
            this.birthDay_customer.TabIndex = 126;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(54, 374);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(70, 16);
            this.labelControl9.TabIndex = 125;
            this.labelControl9.Text = "Số gia đình";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(54, 336);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(51, 16);
            this.labelControl10.TabIndex = 124;
            this.labelControl10.Text = "Giới tính";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(54, 88);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(26, 16);
            this.labelControl7.TabIndex = 123;
            this.labelControl7.Text = "SĐT";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(176, 85);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Properties.Appearance.Options.UseFont = true;
            this.txt_phone.Size = new System.Drawing.Size(337, 22);
            this.txt_phone.TabIndex = 122;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Appearance.Options.UseFont = true;
            this.btn_cancel.Location = new System.Drawing.Point(393, 513);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(118, 30);
            this.btn_cancel.TabIndex = 121;
            this.btn_cancel.Text = "Hủy";
            // 
            // btn_add
            // 
            this.btn_add.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.Location = new System.Drawing.Point(174, 513);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(118, 30);
            this.btn_add.TabIndex = 120;
            this.btn_add.Text = "Xác nhận";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(54, 270);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(73, 16);
            this.labelControl5.TabIndex = 119;
            this.labelControl5.Text = "Số tiền vay";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(56, 158);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(62, 16);
            this.labelControl6.TabIndex = 117;
            this.labelControl6.Text = "Ngày sinh";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(54, 124);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 16);
            this.labelControl3.TabIndex = 116;
            this.labelControl3.Text = "Địa chỉ";
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(174, 412);
            this.txt_note.Name = "txt_note";
            this.txt_note.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_note.Properties.Appearance.Options.UseFont = true;
            this.txt_note.Size = new System.Drawing.Size(337, 69);
            this.txt_note.TabIndex = 114;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(54, 414);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 16);
            this.labelControl2.TabIndex = 113;
            this.labelControl2.Text = "Ghi chú";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(54, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 16);
            this.labelControl1.TabIndex = 112;
            this.labelControl1.Text = "Họ tên";
            // 
            // txt_fullname
            // 
            this.txt_fullname.Location = new System.Drawing.Point(176, 22);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fullname.Properties.Appearance.Options.UseFont = true;
            this.txt_fullname.Size = new System.Drawing.Size(337, 22);
            this.txt_fullname.TabIndex = 111;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Location = new System.Drawing.Point(51, 305);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(97, 16);
            this.labelControl12.TabIndex = 137;
            this.labelControl12.Text = "Chu kỳ đóng lãi";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(176, 118);
            this.txt_address.Name = "txt_address";
            this.txt_address.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Properties.Appearance.Options.UseFont = true;
            this.txt_address.Size = new System.Drawing.Size(337, 22);
            this.txt_address.TabIndex = 115;
            // 
            // txt_money
            // 
            this.txt_money.Location = new System.Drawing.Point(176, 267);
            this.txt_money.Name = "txt_money";
            this.txt_money.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_money.Properties.Appearance.Options.UseFont = true;
            this.txt_money.Size = new System.Drawing.Size(337, 22);
            this.txt_money.TabIndex = 138;
            this.txt_money.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_money_KeyDown);
            this.txt_money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_money_KeyPress);
            this.txt_money.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_money_KeyUp);
            // 
            // txt_cycle
            // 
            this.txt_cycle.Location = new System.Drawing.Point(176, 302);
            this.txt_cycle.Name = "txt_cycle";
            this.txt_cycle.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cycle.Properties.Appearance.Options.UseFont = true;
            this.txt_cycle.Size = new System.Drawing.Size(304, 22);
            this.txt_cycle.TabIndex = 139;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl13.Location = new System.Drawing.Point(486, 305);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(32, 16);
            this.labelControl13.TabIndex = 140;
            this.labelControl13.Text = "Ngày";
            // 
            // uc_Add_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.txt_cycle);
            this.Controls.Add(this.txt_money);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.date_paid);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_familyphone);
            this.Controls.Add(this.cbb_category);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txt_idcard);
            this.Controls.Add(this.radio_sex);
            this.Controls.Add(this.birthDay_customer);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_fullname);
            this.Name = "uc_Add_Customer";
            this.Size = new System.Drawing.Size(1083, 562);
            this.Load += new System.EventHandler(this.uc_Add_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvAddFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcAddFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.date_paid.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_paid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_familyphone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_category.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_idcard.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radio_sex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthDay_customer.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthDay_customer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_phone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_note.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_fullname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_address.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_money.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cycle.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn rela;
        private DevExpress.XtraGrid.Columns.GridColumn fullname;
        private DevExpress.XtraGrid.Views.Grid.GridView grvAddFriend;
        private DevExpress.XtraGrid.Columns.GridColumn phone;
        private DevExpress.XtraGrid.GridControl grcAddFriend;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.DateEdit date_paid;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_familyphone;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbb_category;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txt_idcard;
        private DevExpress.XtraEditors.RadioGroup radio_sex;
        private DevExpress.XtraEditors.DateEdit birthDay_customer;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_phone;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit txt_note;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_fullname;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txt_address;
        private DevExpress.XtraEditors.TextEdit txt_money;
        private DevExpress.XtraEditors.TextEdit txt_cycle;
        private DevExpress.XtraEditors.LabelControl labelControl13;
    }
}
