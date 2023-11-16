using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VuTheDuyet.models;
using VuTheDuyet.frm;

namespace VuTheDuyet.frm
{
    public partial class frmMain : Form
    {
        public static ThanhVien thanhvien = null;
        public static TabControl mainTabControll = null;
        public frmMain()
        {
            InitializeComponent();
        }
        private bool ExitsTabPage(TabControl tabControl,string tabPage)
        {
            bool check = false;
            for(int i = 0; i < tabControl.Controls.Count; i++)
            {
                if (tabControl.TabPages[i].Name == tabPage)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void QuanLySanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ExitsTabPage(tabControlMain, "tpSanPham"))
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "Quản lý sản phẩm";
                tabPage.Name = "tpSanPham";
                tabPage.ImageIndex = 0;
                Form frm = new frmMonAn();
                frm.TopLevel = false;
                frm.Parent = tabPage;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();
                tabControlMain.TabPages.Add(tabPage);
            }
            else
            {
                tabControlMain.SelectedTab = tabControlMain.TabPages["tpSanPham"];
            }
        }

        private void QuanLyLoaiSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ExitsTabPage(tabControlMain, "tpLoaiSanPham"))
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "Quản lý loại sản phẩm";
                tabPage.Name = "tpLoaiSanPham";
                tabPage.ImageIndex = 0;
                Form frm = new frmDanhMuc();
                frm.TopLevel = false;
                frm.Parent = tabPage;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();
                tabControlMain.TabPages.Add(tabPage);
            }
            else
            {
                tabControlMain.SelectedTab = tabControlMain.TabPages["tpLoaiSanPham"];
            }
        }

        private void QuanLyDonHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ExitsTabPage(tabControlMain, "tpDonHang"))
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "Quản lý đơn hàng";
                tabPage.Name = "tpDonHang";
                tabPage.ImageIndex = 0;
                Form frm = new frmDoanhThu();
                frm.TopLevel = false;
                frm.Parent = tabPage;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();
                tabControlMain.TabPages.Add(tabPage);
            }
            else
            {
                tabControlMain.SelectedTab = tabControlMain.TabPages["tpDonHang"];
            }
        }

        private void QuanLyThanhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ExitsTabPage(tabControlMain, "tpThanhVien"))
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "Quản lý thành vien";
                tabPage.Name = "tpThanhVien";
                tabPage.ImageIndex = 0;
                Form frm = new frmQLThanhVien();
                frm.TopLevel = false;
                frm.Parent = tabPage;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();
                tabControlMain.TabPages.Add(tabPage);
            }
            else
            {
                tabControlMain.SelectedTab = tabControlMain.TabPages["tpThanhVien"];
            }
        }

        private void TroGiupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ExitsTabPage(tabControlMain, "tpTroGiup"))
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "Trợ giúp";
                tabPage.Name = "tpTroGiup";
                tabPage.ImageIndex = 0;
                Form frm = new frmMonAn();
                frm.TopLevel = false;
                frm.Parent = tabPage;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();
                tabControlMain.TabPages.Add(tabPage);
            }
            else
            {
                tabControlMain.SelectedTab = tabControlMain.TabPages["tpTroGiup"];
            }
        }

        private void HeThongToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ThongTinThanhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ExitsTabPage(tabControlMain, "tpThongTinTV"))
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "Thông tin thành viên";
                tabPage.Name = "tpThongTinTV";
                tabPage.ImageIndex = 0;
                Form frm = new frmThongTinThanhVien();
                frm.TopLevel = false;
                frm.Parent = tabPage;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();
                tabControlMain.TabPages.Add(tabPage);
            }
            else
            {
                tabControlMain.SelectedTab = tabControlMain.TabPages["tpThongTinTV"];
            }
        }

        private void DoiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ExitsTabPage(tabControlMain, "tpDoiMK"))
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "Đổi mật khẩu";
                tabPage.Name = "tpDoiMK";
                tabPage.ImageIndex = 0;
                Form frm = new frmDoiMatKhau();
                frm.TopLevel = false;
                frm.Parent = tabPage;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();
                tabControlMain.TabPages.Add(tabPage);
            }
            else
            {
                tabControlMain.SelectedTab = tabControlMain.TabPages["tpDoiMK"];
            }
        }

        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmMain();
            frmMain.thanhvien = null;
            frmMain.ActiveForm.Hide();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(thanhvien== null)
            {
                Form frm = new frmDangNhap();
                frm .ShowDialog();
            }
            mainTabControll = tabControlMain;
        }
    }
}
