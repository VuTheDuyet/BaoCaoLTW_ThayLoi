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
    public partial class frmQLThanhVien : Form
    {
        ThanhVienDAO thanhVienDAO = new ThanhVienDAO();
        string[] quyen = { "admin", "nhan vien" };
        public frmQLThanhVien()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dataGridViewds.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn thanhf vien!");
                }
                textBoxTDN.Text = dataGridViewds.Rows[rowindex].Cells["TenDangNhap"].Value.ToString();
                textBoxHVT.Text = dataGridViewds.Rows[rowindex].Cells["HoVaTen"].Value.ToString();
                textBoxSDT.Text = dataGridViewds.Rows[rowindex].Cells["MatKhau"].Value.ToString();
                textBoxMK.Text = dataGridViewds.Rows[rowindex].Cells["SDT"].Value.ToString();
                comboBoxQUYEN.Text = dataGridViewds.Rows[rowindex].Cells["Quyen"].Value.ToString();
                textBoxGM.Text = dataGridViewds.Rows[rowindex].Cells["Email"].Value.ToString();
                buttonXoa.Enabled = true;
                buttonThoat.Enabled = true;
                buttonCapnhat.Enabled = true;
                buttonThem.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void load_ds()
        {
            dataGridViewds.DataSource = thanhVienDAO.getList();
            comboBoxQUYEN.DataSource = quyen;
            comboBoxQUYEN.SelectedItem = 0;
        }
        private void frmQLThanhVien_Load(object sender, EventArgs e)
        {
            load_ds();
            buttonCapnhat.Enabled = false;
            buttonXoa.Enabled = false;
            buttonThoat.Enabled = false;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                ThanhVien monAn = new ThanhVien();
                if (textBoxSDT == null && textBoxTDN == null && textBoxHVT == null && textBoxGM == null && textBoxMK == null)
                {
                    MessageBox.Show("bạn cần nhập đầy đủ thông tin");
                }
                monAn.TenDangNhap = textBoxTDN.Text;
                monAn.SDT = textBoxSDT.Text;
                monAn.HoVaTen = textBoxHVT.Text;
                monAn.HoVaTen = textBoxHVT.Text;
                monAn.MatKhau = textBoxMK.Text;
                monAn.Quyen = comboBoxQUYEN.Text;
                monAn.Email = textBoxGM.Text;
                ThanhVienDAO monAnDAO = new ThanhVienDAO();
                monAnDAO.add(monAn);
                load_ds();
                //  monAn.MaPhanLoaiMonAn = cbxPhanLoaiMA.SelectedValue.ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                //ThanhVien thanhVien = frmMain.thanhvien;
                ThanhVienDAO monAnDAO = new ThanhVienDAO();
                ThanhVien monAn = monAnDAO.getRow(textBoxSDT.Text);
                if(textBoxSDT == null && textBoxTDN == null&&textBoxHVT==null&&textBoxGM==null&&textBoxMK==null)
                {
                    MessageBox.Show("bạn cần nhập đầy đủ thông tin");
                }
                monAn.TenDangNhap = textBoxTDN.Text;
                monAn.SDT = textBoxSDT.Text;
                monAn.HoVaTen = textBoxHVT.Text;
                monAn.HoVaTen = textBoxHVT.Text;
                monAn.MatKhau = textBoxMK.Text;
                monAn.Quyen = comboBoxQUYEN.Text;
                monAn.Email = textBoxGM.Text;
                monAnDAO.update(monAn);
                load_ds();
                MessageBox.Show("Cập nhật thành công!", "Thông Báo!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {

            try
            {
                ThanhVienDAO monAnDAO = new ThanhVienDAO();
                ThanhVien monAn = monAnDAO.getRow(textBoxSDT.Text);
                if (monAn == null)
                {
                    throw new Exception("Thanhf viene không tồn tại!");
                }
                monAnDAO.delete(textBoxSDT.Text);
                load_ds();
                MessageBox.Show("Xóa thành công", "Thông Báo!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
