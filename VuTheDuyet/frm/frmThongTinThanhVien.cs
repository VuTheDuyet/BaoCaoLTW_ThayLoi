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
    public partial class frmThongTinThanhVien : Form
    {
        public frmThongTinThanhVien()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void frmThongTinThanhVien_Load(object sender, EventArgs e)
        {
            ThanhVien thanhVien = frmMain.thanhvien;
            lbHoTen.Text = thanhVien.HoVaTen;
            lbGmail.Text = thanhVien.Email;
            lbSDT.Text = thanhVien.SDT;
            lbTenDN.Text = thanhVien.TenDangNhap;
            lbQuyen.Text = thanhVien.Quyen;
        }

        private void btnDongTTND_Click(object sender, EventArgs e)
        {
            frmMain.mainTabControll.TabPages.Remove(frmMain.mainTabControll.TabPages["tpThonTinTV"]);
        }
    }
}
