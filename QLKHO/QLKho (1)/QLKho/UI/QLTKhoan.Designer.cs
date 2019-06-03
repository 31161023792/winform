namespace UI
{
    partial class frm_QLTKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QLTKhoan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rd_khong = new System.Windows.Forms.RadioButton();
            this.rd_co = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_kiemtra = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.bt_huy = new DevExpress.XtraEditors.SimpleButton();
            this.bt_luu = new DevExpress.XtraEditors.SimpleButton();
            this.bt_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.bt_sua = new DevExpress.XtraEditors.SimpleButton();
            this.bt_them = new DevExpress.XtraEditors.SimpleButton();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dt_qlnd = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_qlnd)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_userid
            // 
            this.txt_userid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_userid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userid.Location = new System.Drawing.Point(129, 7);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.ReadOnly = true;
            this.txt_userid.Size = new System.Drawing.Size(75, 26);
            this.txt_userid.TabIndex = 15;
            // 
            // txt_tennv
            // 
            this.txt_tennv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tennv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tennv.Location = new System.Drawing.Point(123, 4);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.ReadOnly = true;
            this.txt_tennv.Size = new System.Drawing.Size(651, 26);
            this.txt_tennv.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.txt_tennv);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(6, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 34);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên nhân viên";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 19);
            this.label16.TabIndex = 10;
            this.label16.Text = "Mã nhân viên";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_matkhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.Location = new System.Drawing.Point(392, 5);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(383, 26);
            this.txt_matkhau.TabIndex = 14;
            // 
            // txt_manv
            // 
            this.txt_manv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_manv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_manv.Location = new System.Drawing.Point(124, 5);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(189, 26);
            this.txt_manv.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(319, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mật khẩu";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txt_matkhau);
            this.panel1.Controls.Add(this.txt_manv);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(5, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 35);
            this.panel1.TabIndex = 9;
            // 
            // rd_khong
            // 
            this.rd_khong.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rd_khong.AutoSize = true;
            this.rd_khong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_khong.Location = new System.Drawing.Point(299, 4);
            this.rd_khong.Name = "rd_khong";
            this.rd_khong.Size = new System.Drawing.Size(68, 23);
            this.rd_khong.TabIndex = 18;
            this.rd_khong.TabStop = true;
            this.rd_khong.Text = "Không";
            this.rd_khong.UseVisualStyleBackColor = true;
            // 
            // rd_co
            // 
            this.rd_co.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rd_co.AutoSize = true;
            this.rd_co.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_co.Location = new System.Drawing.Point(154, 4);
            this.rd_co.Name = "rd_co";
            this.rd_co.Size = new System.Drawing.Size(46, 23);
            this.rd_co.TabIndex = 17;
            this.rd_co.TabStop = true;
            this.rd_co.Text = "Có";
            this.rd_co.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Quyền admin:";
            // 
            // bt_kiemtra
            // 
            this.bt_kiemtra.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bt_kiemtra.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_kiemtra.Appearance.Options.UseFont = true;
            this.bt_kiemtra.Enabled = false;
            this.bt_kiemtra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_kiemtra.ImageOptions.Image")));
            this.bt_kiemtra.Location = new System.Drawing.Point(673, 5);
            this.bt_kiemtra.Name = "bt_kiemtra";
            this.bt_kiemtra.Size = new System.Drawing.Size(107, 31);
            this.bt_kiemtra.TabIndex = 17;
            this.bt_kiemtra.Text = "Kiểm tra";
            this.bt_kiemtra.Click += new System.EventHandler(this.bt_kiemtra_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rd_khong);
            this.panel3.Controls.Add(this.rd_co);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(211, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 32);
            this.panel3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tài khoản thứ";
            // 
            // bt_thoat
            // 
            this.bt_thoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bt_thoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.Appearance.Options.UseFont = true;
            this.bt_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_thoat.ImageOptions.Image")));
            this.bt_thoat.Location = new System.Drawing.Point(693, 6);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(90, 34);
            this.bt_thoat.TabIndex = 22;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_huy
            // 
            this.bt_huy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bt_huy.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_huy.Appearance.Options.UseFont = true;
            this.bt_huy.Enabled = false;
            this.bt_huy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_huy.ImageOptions.Image")));
            this.bt_huy.Location = new System.Drawing.Point(6, 6);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(87, 34);
            this.bt_huy.TabIndex = 21;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bt_luu.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_luu.Appearance.Options.UseFont = true;
            this.bt_luu.Enabled = false;
            this.bt_luu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_luu.ImageOptions.Image")));
            this.bt_luu.Location = new System.Drawing.Point(99, 6);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(83, 34);
            this.bt_luu.TabIndex = 20;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bt_xoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Appearance.Options.UseFont = true;
            this.bt_xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_xoa.ImageOptions.Image")));
            this.bt_xoa.Location = new System.Drawing.Point(389, 6);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(90, 34);
            this.bt_xoa.TabIndex = 18;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bt_sua.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Appearance.Options.UseFont = true;
            this.bt_sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_sua.ImageOptions.Image")));
            this.bt_sua.Location = new System.Drawing.Point(291, 6);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(92, 34);
            this.bt_sua.TabIndex = 17;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bt_them.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.Appearance.Options.UseFont = true;
            this.bt_them.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_them.ImageOptions.Image")));
            this.bt_them.Location = new System.Drawing.Point(187, 6);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(98, 34);
            this.bt_them.TabIndex = 16;
            this.bt_them.Text = "Thêm";
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_timkiem.Location = new System.Drawing.Point(485, 11);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(201, 26);
            this.txt_timkiem.TabIndex = 9;
            this.txt_timkiem.Text = "Nhập mã nhân viên cần tìm";
            this.txt_timkiem.Click += new System.EventHandler(this.txt_timkiem_Click);
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            this.txt_timkiem.Enter += new System.EventHandler(this.txt_timkiem_Enter);
            this.txt_timkiem.Leave += new System.EventHandler(this.txt_timkiem_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(275, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Quản lý tài khoản người dùng";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.bt_thoat);
            this.panel4.Controls.Add(this.bt_huy);
            this.panel4.Controls.Add(this.bt_luu);
            this.panel4.Controls.Add(this.bt_xoa);
            this.panel4.Controls.Add(this.bt_sua);
            this.panel4.Controls.Add(this.bt_them);
            this.panel4.Controls.Add(this.txt_timkiem);
            this.panel4.Location = new System.Drawing.Point(8, 152);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(788, 45);
            this.panel4.TabIndex = 16;
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.bt_kiemtra);
            this.panelControl2.Controls.Add(this.txt_userid);
            this.panelControl2.Controls.Add(this.panel3);
            this.panelControl2.Controls.Add(this.panel1);
            this.panelControl2.Controls.Add(this.panel2);
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Location = new System.Drawing.Point(8, 33);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(788, 118);
            this.panelControl2.TabIndex = 15;
            // 
            // dt_qlnd
            // 
            this.dt_qlnd.AllowUserToDeleteRows = false;
            this.dt_qlnd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_qlnd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_qlnd.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dt_qlnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_qlnd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dt_qlnd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_qlnd.DefaultCellStyle = dataGridViewCellStyle5;
            this.dt_qlnd.Location = new System.Drawing.Point(8, 204);
            this.dt_qlnd.Name = "dt_qlnd";
            this.dt_qlnd.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_qlnd.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dt_qlnd.RowHeadersVisible = false;
            this.dt_qlnd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_qlnd.Size = new System.Drawing.Size(788, 239);
            this.dt_qlnd.TabIndex = 17;
            this.dt_qlnd.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_qlnd_RowEnter);
            // 
            // frm_QLTKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 445);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.dt_qlnd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_QLTKhoan";
            this.Text = "Quản lý tài khoản phần mềm";
            this.Load += new System.EventHandler(this.QLTKhoan_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_qlnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_userid;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rd_khong;
        private System.Windows.Forms.RadioButton rd_co;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton bt_kiemtra;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton bt_thoat;
        private DevExpress.XtraEditors.SimpleButton bt_huy;
        private DevExpress.XtraEditors.SimpleButton bt_luu;
        private DevExpress.XtraEditors.SimpleButton bt_xoa;
        private DevExpress.XtraEditors.SimpleButton bt_sua;
        private DevExpress.XtraEditors.SimpleButton bt_them;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.DataGridView dt_qlnd;
    }
}