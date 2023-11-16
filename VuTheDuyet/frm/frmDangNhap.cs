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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Đặt vị trí để căn giữa màn hình
        }
        
       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
                {
                    throw new Exception("Tên Đang nhập không được để trống!");
                }
                if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
                {
                    throw new Exception("Mật khẩu không được để trống!");
                }
                 string tdn = txtUsername.Text.Trim();
                 string mk = MaHoa.ToMD5(txtPassword.Text.Trim());//sua laij max hoas
            //borr sung e
                ThanhVienDAO thanhVienDAO = new ThanhVienDAO();
                ThanhVien tv = thanhVienDAO.getRow(tdn);
                if(tv == null)
                {
                    throw new Exception("tên đang nhập không tồn tại");
                }
                if (mk != MaHoa.ToMD5(tv.MatKhau))
                {
                    throw new Exception("Mật khẩu không chính xác");
                }
                frmMain.thanhvien = tv;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Thông báo!");
            }
         
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Form frm = new frmMain();
            DialogResult result = MessageBox.Show(

                "Bạn có muốn thoát không",

                "Thông báo",

                MessageBoxButtons.YesNo,

                MessageBoxIcon.Question

            );

            if (result == DialogResult.Yes)

            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new frmDangKi();
        }
    }
}
