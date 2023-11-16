namespace VuTheDuyet.frm
{
    partial class frmMain
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.HeThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongTinThanhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DoiMatKhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLySanPhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyLoaiSanPhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyDonHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyThanhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TroGiupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HeThongToolStripMenuItem,
            this.QuanLySanPhamToolStripMenuItem,
            this.QuanLyLoaiSanPhamToolStripMenuItem,
            this.QuanLyDonHangToolStripMenuItem,
            this.QuanLyThanhVienToolStripMenuItem,
            this.TroGiupToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(800, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // HeThongToolStripMenuItem
            // 
            this.HeThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThongTinThanhVienToolStripMenuItem,
            this.DoiMatKhauToolStripMenuItem,
            this.DangXuatToolStripMenuItem});
            this.HeThongToolStripMenuItem.Name = "HeThongToolStripMenuItem";
            this.HeThongToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.HeThongToolStripMenuItem.Text = "Hệ thống";
            this.HeThongToolStripMenuItem.Click += new System.EventHandler(this.HeThongToolStripMenuItem_Click);
            // 
            // ThongTinThanhVienToolStripMenuItem
            // 
            this.ThongTinThanhVienToolStripMenuItem.Name = "ThongTinThanhVienToolStripMenuItem";
            this.ThongTinThanhVienToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.ThongTinThanhVienToolStripMenuItem.Text = "Thông tin thành viên";
            this.ThongTinThanhVienToolStripMenuItem.Click += new System.EventHandler(this.ThongTinThanhVienToolStripMenuItem_Click);
            // 
            // DoiMatKhauToolStripMenuItem
            // 
            this.DoiMatKhauToolStripMenuItem.Name = "DoiMatKhauToolStripMenuItem";
            this.DoiMatKhauToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.DoiMatKhauToolStripMenuItem.Text = "\tĐổi mật khẩu";
            this.DoiMatKhauToolStripMenuItem.Click += new System.EventHandler(this.DoiMatKhauToolStripMenuItem_Click);
            // 
            // DangXuatToolStripMenuItem
            // 
            this.DangXuatToolStripMenuItem.Name = "DangXuatToolStripMenuItem";
            this.DangXuatToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.DangXuatToolStripMenuItem.Text = "Đăng xuất";
            this.DangXuatToolStripMenuItem.Click += new System.EventHandler(this.DangXuatToolStripMenuItem_Click);
            // 
            // QuanLySanPhamToolStripMenuItem
            // 
            this.QuanLySanPhamToolStripMenuItem.Name = "QuanLySanPhamToolStripMenuItem";
            this.QuanLySanPhamToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.QuanLySanPhamToolStripMenuItem.Text = "Quản lý sản phẩm";
            this.QuanLySanPhamToolStripMenuItem.Click += new System.EventHandler(this.QuanLySanPhamToolStripMenuItem_Click);
            // 
            // QuanLyLoaiSanPhamToolStripMenuItem
            // 
            this.QuanLyLoaiSanPhamToolStripMenuItem.Name = "QuanLyLoaiSanPhamToolStripMenuItem";
            this.QuanLyLoaiSanPhamToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.QuanLyLoaiSanPhamToolStripMenuItem.Text = "Quản lý loại sản phẩm";
            this.QuanLyLoaiSanPhamToolStripMenuItem.Click += new System.EventHandler(this.QuanLyLoaiSanPhamToolStripMenuItem_Click);
            // 
            // QuanLyDonHangToolStripMenuItem
            // 
            this.QuanLyDonHangToolStripMenuItem.Name = "QuanLyDonHangToolStripMenuItem";
            this.QuanLyDonHangToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.QuanLyDonHangToolStripMenuItem.Text = "Quản lý đơn hàng";
            this.QuanLyDonHangToolStripMenuItem.Click += new System.EventHandler(this.QuanLyDonHangToolStripMenuItem_Click);
            // 
            // QuanLyThanhVienToolStripMenuItem
            // 
            this.QuanLyThanhVienToolStripMenuItem.Name = "QuanLyThanhVienToolStripMenuItem";
            this.QuanLyThanhVienToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.QuanLyThanhVienToolStripMenuItem.Text = "Quản lý thành viên";
            this.QuanLyThanhVienToolStripMenuItem.Click += new System.EventHandler(this.QuanLyThanhVienToolStripMenuItem_Click);
            // 
            // TroGiupToolStripMenuItem
            // 
            this.TroGiupToolStripMenuItem.Name = "TroGiupToolStripMenuItem";
            this.TroGiupToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.TroGiupToolStripMenuItem.Text = "Trợ giúp";
            this.TroGiupToolStripMenuItem.Click += new System.EventHandler(this.TroGiupToolStripMenuItem_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(800, 25);
            this.toolStripMain.TabIndex = 1;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // statusStripMain
            // 
            this.statusStripMain.Location = new System.Drawing.Point(0, 428);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(800, 22);
            this.statusStripMain.TabIndex = 2;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 49);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(800, 379);
            this.tabControlMain.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "frmMain";
            this.Text = "me";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripMenuItem HeThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThongTinThanhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DoiMatKhauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DangXuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuanLySanPhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuanLyLoaiSanPhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuanLyDonHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuanLyThanhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TroGiupToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlMain;
    }
}