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
    public partial class frmDoanhThu : Form
    {
        HoaDonDAO hoaDonDAO = new HoaDonDAO();
        HoaDon thanhvien = null;
        public frmDoanhThu()
        {
            InitializeComponent();
        }

        private void dataGridViewdsDH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã nhấp vào dòng có dữ liệu hay không
                if (e.RowIndex >= 0 && e.RowIndex < dataGridViewdsDH.Rows.Count - 1)
                {
                    // Lấy dữ liệu từ ô được chọn và hiển thị lên các điều khiển nhập liệu
                    textBoxMaDH.Text = dataGridViewdsDH.Rows[e.RowIndex].Cells["MaHoaDon"].Value.ToString();
                    dateTimePicker1.Value = DateTime.Parse(dataGridViewdsDH.Rows[e.RowIndex].Cells["Ngay"].Value?.ToString());
                    textBoxGia.Text = dataGridViewdsDH.Rows[e.RowIndex].Cells["SoTien"].Value.ToString();
                    buttonXoa.Enabled = true;
                    buttonXemCT.Enabled = true;

                    // Hiển thị chi tiết hóa đơn bằng cách gọi hàm hiển thị chi tiết
                    //HienThiChiTietHoaDon(int.Parse(txtMaHoaDon.Text));
                }
                else
                {
                    // Người dùng đã nhấp vào dòng không có dữ liệu hoặc header
                    throw new Exception("Chưa chọn đơn hàng!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void loadds()
        {
            dataGridViewdsDH.DataSource = hoaDonDAO.getList();
        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            loadds();
            buttonXoa.Enabled = false;
            buttonXemCT.Enabled = false;
        }

        private void buttonXemCT_Click(object sender, EventArgs e)
        {
            try
            {
                
                ChiTietHoaDonDAO thanhVienDAO = new ChiTietHoaDonDAO();
                ChiTietHoaDon tv = thanhVienDAO.getRow(int.Parse(textBoxMaDH.Text));
                if (tv == null)
                {
                    throw new Exception("Dơn hàng không tồn tại");
                }
                int madonhang = tv.MaHoaDon.Value;
                frmChiTietDonHang.thanhvien = madonhang;
                Form form = new frmChiTietDonHang();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
            }

        }
        // Phương thức để xem chi tiết đơn hàng
        

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi button được nhấn
            // Gọi phương thức Xoa trong HoaDonDAO để xóa đơn hàng
            

            // Hiển thị thông báo hoặc cập nhật giao diện nếu cần
            try
            {
                // Gọi phương thức Xoa trong HoaDonDAO để xóa đơn hàng
                int maHoaDon = int.Parse(textBoxMaDH.Text);// Lấy mã đơn hàng từ nguồn dữ liệu của bạn
                HoaDonDAO hoaDonDAO = new HoaDonDAO();
                hoaDonDAO.delete(maHoaDon);
                loadds();
                // Hiển thị thông báo khi đơn hàng được xoá thành công
                MessageBox.Show("Đơn hàng đã được xoá thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật giao diện hoặc thực hiện bất kỳ công việc nào khác sau khi xoá thành công
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi khi xảy ra lỗi
                MessageBox.Show("Đã xảy ra lỗi khi xoá đơn hàng:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
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
    }
}
