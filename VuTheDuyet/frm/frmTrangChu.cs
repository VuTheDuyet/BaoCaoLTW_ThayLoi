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

namespace VuTheDuyet.frm
{
    public partial class frmTrangChu : Form
    {
        public static ThanhVien thanhVien = null;
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            if (thanhVien == null)
            {
                //mo from ddang nhap
                Form frm = new frmDangNhap();
                frm.ShowDialog();
            }
            txtusername.Text = thanhVien.TenDangNhap;
            //load hinh
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ExistTabPage(tabControlMain, "tpBanHang"))
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "Quản lý bán hàng";
                tabPage.Name = "tpBanHang";
                tabPage.ImageIndex = 0;
                Form frm = new frmBanHang();
                frm.TopLevel = false;
                frm.Parent = tabPage;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();
                tabPage.Controls.Add(frm);
                tabControlMain.TabPages.Add(tabPage);
            }
            else
            {
                tabControlMain.SelectedTab = tabControlMain.TabPages["tpBanHang"];
            }
        }
        private bool ExistTabPage(TabControl tabControl, string tabPageName)
        {
            return tabControl.TabPages.ContainsKey(tabPageName);
        }

        private void buttonPhanLoai_Click(object sender, EventArgs e)
        {
            if (!ExistTabPage(tabControlMain, "tpPhanLoai"))
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "Quản lý Phân loại món ăn";
                tabPage.Name = "tpPhanLoai";
                tabPage.ImageIndex = 0;
                Form frm = new frmDanhMuc();
                frm.TopLevel = false;
                frm.Parent = tabPage;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();
                tabPage.Controls.Add(frm);
                tabControlMain.TabPages.Add(tabPage);
            }
            else
            {
                tabControlMain.SelectedTab = tabControlMain.TabPages["tpPhanLoai"];
            }
        }

        private void btnQLMonAn_Click(object sender, EventArgs e)
        {
            if (!ExistTabPage(tabControlMain, "tpMonAn"))
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "Quản lý món ăn";
                tabPage.Name = "tpMonAn";
                tabPage.ImageIndex = 0;
                Form frm = new frmMonAn();
                frm.TopLevel = false;
                frm.Parent = tabPage;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();
                tabPage.Controls.Add(frm);
                tabControlMain.TabPages.Add(tabPage);
            }
            else
            {
                tabControlMain.SelectedTab = tabControlMain.TabPages["tpMonAn"];
            }
        }

        private void btnQLBan_Click(object sender, EventArgs e)
        {
            if (!ExistTabPage(tabControlMain, "tpBan"))
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "Quản lý bàn";
                tabPage.Name = "tpBan";
                tabPage.ImageIndex = 0;
                Form frm = new frmBan();
                frm.TopLevel = false;
                frm.Parent = tabPage;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();
                tabPage.Controls.Add(frm);
                tabControlMain.TabPages.Add(tabPage);
            }
            else
            {
                tabControlMain.SelectedTab = tabControlMain.TabPages["tpBan"];
            }
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            if (!ExistTabPage(tabControlMain, "tpDoanhThu"))
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "Quản lý Doanh Thu";
                tabPage.Name = "tpDoanhThu";
                tabPage.ImageIndex = 0;
                Form frm = new frmDoanhThu();
                frm.TopLevel = false;
                frm.Parent = tabPage;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();
                tabPage.Controls.Add(frm);
                tabControlMain.TabPages.Add(tabPage);
            }
            else
            {
                tabControlMain.SelectedTab = tabControlMain.TabPages["tpDoanhThu"];
            }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if (!ExistTabPage(tabControlMain, "tpKho"))
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "Quản lý Kho";
                tabPage.Name = "tpKho";
                tabPage.ImageIndex = 0;
                Form frm = new frmNhapHang();
                frm.TopLevel = false;
                frm.Parent = tabPage;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();
                tabPage.Controls.Add(frm);
                tabControlMain.TabPages.Add(tabPage);
            }
            else
            {
                tabControlMain.SelectedTab = tabControlMain.TabPages["tpKho"];
            }
        }
    }
}
