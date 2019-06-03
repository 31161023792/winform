namespace UI
{
    partial class frm_QLPNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QLPNhap));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.bt_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.bt_Sua = new DevExpress.XtraEditors.SimpleButton();
            this.dt_qlpn = new System.Windows.Forms.DataGridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnall = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.rd_mapn = new System.Windows.Forms.RadioButton();
            this.tb_manv = new System.Windows.Forms.TextBox();
            this.tb_mapn = new System.Windows.Forms.TextBox();
            this.rd_manv = new System.Windows.Forms.RadioButton();
            this.bt_timkiem = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_xoapn = new DevExpress.XtraEditors.SimpleButton();
            this.lb_mpn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_qlpn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.dt_qlpn);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Location = new System.Drawing.Point(12, 44);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(776, 402);
            this.panelControl1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thông tin phiếu nhập";
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl3.Controls.Add(this.bt_thoat);
            this.panelControl3.Controls.Add(this.bt_Xoa);
            this.panelControl3.Controls.Add(this.txt_timkiem);
            this.panelControl3.Controls.Add(this.bt_Sua);
            this.panelControl3.Location = new System.Drawing.Point(7, 82);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(764, 49);
            this.panelControl3.TabIndex = 11;
            // 
            // bt_thoat
            // 
            this.bt_thoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bt_thoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.Appearance.Options.UseFont = true;
            this.bt_thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_thoat.ImageOptions.Image")));
            this.bt_thoat.Location = new System.Drawing.Point(658, 5);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(104, 38);
            this.bt_thoat.TabIndex = 12;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bt_Xoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Xoa.Appearance.Options.UseFont = true;
            this.bt_Xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_Xoa.ImageOptions.Image")));
            this.bt_Xoa.Location = new System.Drawing.Point(103, 5);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(97, 38);
            this.bt_Xoa.TabIndex = 11;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(206, 12);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(446, 26);
            this.txt_timkiem.TabIndex = 6;
            this.txt_timkiem.Text = "Nhập tên hàng hóa ở chi tiết cần tìm";
            this.txt_timkiem.Click += new System.EventHandler(this.txt_timkiem_Click);
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            this.txt_timkiem.Leave += new System.EventHandler(this.txt_timkiem_Leave);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bt_Sua.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sua.Appearance.Options.UseFont = true;
            this.bt_Sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_Sua.ImageOptions.Image")));
            this.bt_Sua.Location = new System.Drawing.Point(0, 5);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(97, 38);
            this.bt_Sua.TabIndex = 10;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // dt_qlpn
            // 
            this.dt_qlpn.AllowUserToAddRows = false;
            this.dt_qlpn.AllowUserToDeleteRows = false;
            this.dt_qlpn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_qlpn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_qlpn.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dt_qlpn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_qlpn.Location = new System.Drawing.Point(5, 137);
            this.dt_qlpn.Name = "dt_qlpn";
            this.dt_qlpn.ReadOnly = true;
            this.dt_qlpn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_qlpn.Size = new System.Drawing.Size(764, 260);
            this.dt_qlpn.TabIndex = 7;
            this.dt_qlpn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_qlpn_CellContentClick);
            this.dt_qlpn.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_qlpn_RowEnter);
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.btnall);
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Controls.Add(this.bt_timkiem);
            this.panelControl2.Location = new System.Drawing.Point(5, 5);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(766, 39);
            this.panelControl2.TabIndex = 0;
            // 
            // btnall
            // 
            this.btnall.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnall.Appearance.Options.UseFont = true;
            this.btnall.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnall.ImageOptions.Image")));
            this.btnall.Location = new System.Drawing.Point(4, 0);
            this.btnall.Margin = new System.Windows.Forms.Padding(2);
            this.btnall.Name = "btnall";
            this.btnall.Size = new System.Drawing.Size(107, 35);
            this.btnall.TabIndex = 13;
            this.btnall.Text = "Xem hết";
            this.btnall.Click += new System.EventHandler(this.btnall_Click);
            // 
            // panelControl4
            // 
            this.panelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelControl4.Controls.Add(this.rd_mapn);
            this.panelControl4.Controls.Add(this.tb_manv);
            this.panelControl4.Controls.Add(this.tb_mapn);
            this.panelControl4.Controls.Add(this.rd_manv);
            this.panelControl4.Location = new System.Drawing.Point(131, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(523, 36);
            this.panelControl4.TabIndex = 14;
            // 
            // rd_mapn
            // 
            this.rd_mapn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rd_mapn.AutoSize = true;
            this.rd_mapn.Location = new System.Drawing.Point(5, 13);
            this.rd_mapn.Name = "rd_mapn";
            this.rd_mapn.Size = new System.Drawing.Size(14, 13);
            this.rd_mapn.TabIndex = 1;
            this.rd_mapn.TabStop = true;
            this.rd_mapn.UseVisualStyleBackColor = true;
            this.rd_mapn.Click += new System.EventHandler(this.rd_mapn_Click);
            // 
            // tb_manv
            // 
            this.tb_manv.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tb_manv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_manv.Location = new System.Drawing.Point(307, 6);
            this.tb_manv.Name = "tb_manv";
            this.tb_manv.Size = new System.Drawing.Size(211, 26);
            this.tb_manv.TabIndex = 5;
            this.tb_manv.Text = "Tìm kiếm theo mã nhân viên";
            this.tb_manv.Click += new System.EventHandler(this.tb_manv_Click);
            this.tb_manv.Leave += new System.EventHandler(this.tb_manv_Leave);
            // 
            // tb_mapn
            // 
            this.tb_mapn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_mapn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mapn.Location = new System.Drawing.Point(25, 6);
            this.tb_mapn.Name = "tb_mapn";
            this.tb_mapn.Size = new System.Drawing.Size(209, 26);
            this.tb_mapn.TabIndex = 4;
            this.tb_mapn.Text = "Tìm kiếm theo mã phiếu nhập";
            this.tb_mapn.Click += new System.EventHandler(this.tb_mapn_Click);
            this.tb_mapn.Leave += new System.EventHandler(this.tb_mapn_Leave);
            // 
            // rd_manv
            // 
            this.rd_manv.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rd_manv.AutoSize = true;
            this.rd_manv.Location = new System.Drawing.Point(282, 13);
            this.rd_manv.Name = "rd_manv";
            this.rd_manv.Size = new System.Drawing.Size(14, 13);
            this.rd_manv.TabIndex = 2;
            this.rd_manv.TabStop = true;
            this.rd_manv.UseVisualStyleBackColor = true;
            this.rd_manv.Click += new System.EventHandler(this.rd_manv_Click);
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bt_timkiem.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_timkiem.Appearance.Options.UseFont = true;
            this.bt_timkiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_timkiem.ImageOptions.Image")));
            this.bt_timkiem.Location = new System.Drawing.Point(660, 0);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(104, 38);
            this.bt_timkiem.TabIndex = 0;
            this.bt_timkiem.Text = "Tìm kiếm";
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý phiếu nhập";
            // 
            // bt_xoapn
            // 
            this.bt_xoapn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_xoapn.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoapn.Appearance.Options.UseFont = true;
            this.bt_xoapn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_xoapn.ImageOptions.Image")));
            this.bt_xoapn.Location = new System.Drawing.Point(676, 2);
            this.bt_xoapn.Name = "bt_xoapn";
            this.bt_xoapn.Size = new System.Drawing.Size(112, 38);
            this.bt_xoapn.TabIndex = 13;
            this.bt_xoapn.Text = "Xóa phiếu";
            this.bt_xoapn.Click += new System.EventHandler(this.bt_xoapn_Click);
            // 
            // lb_mpn
            // 
            this.lb_mpn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_mpn.AutoSize = true;
            this.lb_mpn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mpn.Location = new System.Drawing.Point(637, 9);
            this.lb_mpn.Name = "lb_mpn";
            this.lb_mpn.Size = new System.Drawing.Size(21, 19);
            this.lb_mpn.TabIndex = 14;
            this.lb_mpn.Text = "...";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(569, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã phiếu:";
            // 
            // frm_QLPNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_mpn);
            this.Controls.Add(this.bt_xoapn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frm_QLPNhap";
            this.Text = "Quản lý phiếu nhập";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_qlpn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton bt_timkiem;
        private System.Windows.Forms.TextBox tb_manv;
        private System.Windows.Forms.TextBox tb_mapn;
        private System.Windows.Forms.RadioButton rd_mapn;
        private System.Windows.Forms.RadioButton rd_manv;
        private System.Windows.Forms.DataGridView dt_qlpn;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton bt_thoat;
        private DevExpress.XtraEditors.SimpleButton bt_Xoa;
        private DevExpress.XtraEditors.SimpleButton bt_Sua;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton bt_xoapn;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private System.Windows.Forms.Label lb_mpn;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnall;
    }
}