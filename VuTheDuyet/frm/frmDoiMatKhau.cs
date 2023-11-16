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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                ThanhVien thanhVien = frmMain.thanhvien;
                if (txtMKC.Text != thanhVien.MatKhau)
                {
                    throw new Exception("Mật khẩu cũ không chính xác!");
                }
                if (string.IsNullOrEmpty(txtMKM.Text) || string.IsNullOrEmpty(txtNLMKM.Text))
                {
                    throw new Exception("Mật khẩu mới không được để trống!");
                }
                if (txtNLMKM.Text != txtMKM.Text)
                {
                    throw new Exception("Mật khẩu mới không chính xác!");
                }
                string matkhau = txtMKM.Text;
                thanhVien.MatKhau = matkhau;
                ThanhVienDAO thanhVienDAO = new ThanhVienDAO();
                thanhVienDAO.update(thanhVien);
                frmMain.thanhvien = thanhVien;
                MessageBox.Show("Cập nhật thành công!","Thông Báo!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Thông Báo");
            }
            
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
