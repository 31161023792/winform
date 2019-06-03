namespace UI
{
    partial class QLPXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLPXuat));
            this.label3 = new System.Windows.Forms.Label();
            this.bt_xoapn = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rd_mapn = new System.Windows.Forms.RadioButton();
            this.tb_manv = new System.Windows.Forms.TextBox();
            this.tb_mapn = new System.Windows.Forms.TextBox();
            this.rd_manv = new System.Windows.Forms.RadioButton();
            this.lb_mpn = new System.Windows.Forms.Label();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.dt_qlpx = new System.Windows.Forms.DataGridView();
            this.bt_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.bt_timkiem = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnall = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_qlpx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(707, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mã phiếu:";
            // 
            // bt_xoapn
            // 
            this.bt_xoapn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_xoapn.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoapn.Appearance.Options.UseFont = true;
            this.bt_xoapn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_xoapn.ImageOptions.Image")));
            this.bt_xoapn.Location = new System.Drawing.Point(901, 4);
            this.bt_xoapn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_xoapn.Name = "bt_xoapn";
            this.bt_xoapn.Size = new System.Drawing.Size(149, 47);
            this.bt_xoapn.TabIndex = 18;
            this.bt_xoapn.Text = "Xóa phiếu";
            this.bt_xoapn.Click += new System.EventHandler(this.bt_xoapn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Quản lý phiếu xuất";
            // 
            // rd_mapn
            // 
            this.rd_mapn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rd_mapn.AutoSize = true;
            this.rd_mapn.Location = new System.Drawing.Point(7, 16);
            this.rd_mapn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rd_mapn.Name = "rd_mapn";
            this.rd_mapn.Size = new System.Drawing.Size(17, 16);
            this.rd_mapn.TabIndex = 1;
            this.rd_mapn.TabStop = true;
            this.rd_mapn.UseVisualStyleBackColor = true;
            this.rd_mapn.Click += new System.EventHandler(this.rd_mapn_Click);
            // 
            // tb_manv
            // 
            this.tb_manv.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tb_manv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_manv.Location = new System.Drawing.Point(533, 7);
            this.tb_manv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_manv.Name = "tb_manv";
            this.tb_manv.Size = new System.Drawing.Size(280, 30);
            this.tb_manv.TabIndex = 5;
            this.tb_manv.Text = "Tìm kiếm theo mã nhân viên";
            this.tb_manv.Click += new System.EventHandler(this.tb_manv_Click);
            this.tb_manv.Leave += new System.EventHandler(this.tb_manv_Leave);
            // 
            // tb_mapn
            // 
            this.tb_mapn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_mapn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mapn.Location = new System.Drawing.Point(33, 7);
            this.tb_mapn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_mapn.Name = "tb_mapn";
            this.tb_mapn.Size = new System.Drawing.Size(277, 30);
            this.tb_mapn.TabIndex = 4;
            this.tb_mapn.Text = "Tìm kiếm theo mã phiếu nhập";
            this.tb_mapn.Click += new System.EventHandler(this.tb_mapn_Click);
            this.tb_mapn.Leave += new System.EventHandler(this.tb_mapn_Leave);
            // 
            // rd_manv
            // 
            this.rd_manv.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rd_manv.AutoSize = true;
            this.rd_manv.Location = new System.Drawing.Point(502, 16);
            this.rd_manv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rd_manv.Name = "rd_manv";
            this.rd_manv.Size = new System.Drawing.Size(17, 16);
            this.rd_manv.TabIndex = 2;
            this.rd_manv.TabStop = true;
            this.rd_manv.UseVisualStyleBackColor = true;
            this.rd_manv.Click += new System.EventHandler(this.rd_manv_Click);
            // 
            // lb_mpn
            // 
            this.lb_mpn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_mpn.AutoSize = true;
            this.lb_mpn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mpn.Location = new System.Drawing.Point(797, 12);
            this.lb_mpn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_mpn.Name = "lb_mpn";
            this.lb_mpn.Size = new System.Drawing.Size(25, 22);
            this.lb_mpn.TabIndex = 19;
            this.lb_mpn.Text = "...";
            // 
            // panelControl4
            // 
            this.panelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelControl4.Controls.Add(this.rd_mapn);
            this.panelControl4.Controls.Add(this.tb_manv);
            this.panelControl4.Controls.Add(this.tb_mapn);
            this.panelControl4.Controls.Add(this.rd_manv);
            this.panelControl4.Location = new System.Drawing.Point(7, 0);
            this.panelControl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(821, 44);
            this.panelControl4.TabIndex = 14;
            // 
            // dt_qlpx
            // 
            this.dt_qlpx.AllowUserToAddRows = false;
            this.dt_qlpx.AllowUserToDeleteRows = false;
            this.dt_qlpx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_qlpx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_qlpx.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dt_qlpx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_qlpx.Location = new System.Drawing.Point(7, 114);
            this.dt_qlpx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dt_qlpx.Name = "dt_qlpx";
            this.dt_qlpx.ReadOnly = true;
            this.dt_qlpx.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_qlpx.Size = new System.Drawing.Size(1019, 374);
            this.dt_qlpx.TabIndex = 7;
            // 
            // bt_thoat
            // 
            this.bt_thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_thoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.Appearance.Options.UseFont = true;
            this.bt_thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_thoat.ImageOptions.Image")));
            this.bt_thoat.Location = new System.Drawing.Point(889, 60);
            this.bt_thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(139, 47);
            this.bt_thoat.TabIndex = 12;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bt_timkiem.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_timkiem.Appearance.Options.UseFont = true;
            this.bt_timkiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_timkiem.ImageOptions.Image")));
            this.bt_timkiem.Location = new System.Drawing.Point(880, 0);
            this.bt_timkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(139, 47);
            this.bt_timkiem.TabIndex = 0;
            this.bt_timkiem.Text = "Tìm kiếm";
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chi tiết phiếu xuất";
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Controls.Add(this.bt_timkiem);
            this.panelControl2.Location = new System.Drawing.Point(7, 6);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1021, 48);
            this.panelControl2.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.btnall);
            this.panelControl1.Controls.Add(this.bt_thoat);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.dt_qlpx);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Location = new System.Drawing.Point(16, 55);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1035, 495);
            this.panelControl1.TabIndex = 16;
            // 
            // btnall
            // 
            this.btnall.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnall.Appearance.Options.UseFont = true;
            this.btnall.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnall.ImageOptions.Image")));
            this.btnall.Location = new System.Drawing.Point(7, 62);
            this.btnall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnall.Name = "btnall";
            this.btnall.Size = new System.Drawing.Size(143, 43);
            this.btnall.TabIndex = 14;
            this.btnall.Text = "Xem hết";
            this.btnall.Click += new System.EventHandler(this.btnall_Click);
            // 
            // QLPXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_xoapn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_mpn);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QLPXuat";
            this.Text = "QLPXuat";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_qlpx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton bt_xoapn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rd_mapn;
        private System.Windows.Forms.TextBox tb_manv;
        private System.Windows.Forms.TextBox tb_mapn;
        private System.Windows.Forms.RadioButton rd_manv;
        private System.Windows.Forms.Label lb_mpn;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private System.Windows.Forms.DataGridView dt_qlpx;
        private DevExpress.XtraEditors.SimpleButton bt_thoat;
        private DevExpress.XtraEditors.SimpleButton bt_timkiem;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnall;
    }
}