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
    public partial class frmDanhMuc : Form
    {
        PhanLoaiSanPhamDAO phanLoaiSanPhamDAO = new PhanLoaiSanPhamDAO();
        public frmDanhMuc()
        {
            InitializeComponent();
        }
        private void load_ds()
        {
            dataGridViewds.DataSource = phanLoaiSanPhamDAO.getList();
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                PhanLoaiMonAn monAn = new PhanLoaiMonAn();
                monAn.MaPhanLoaiMonAn = int.Parse(textBoxMaPLSP.Text);
                monAn.TenPhanLoaiMonAn = textBoxTenPLSP.Text;
                PhanLoaiSanPhamDAO monAnDAO = new PhanLoaiSanPhamDAO();
                monAnDAO.add(monAn);
                load_ds();
                //  monAn.MaPhanLoaiMonAn = cbxPhanLoaiMA.SelectedValue.ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            buttonCapnhat.Enabled = false;
            buttonThem.Enabled = true;
            buttonXoa.Enabled = false;
            buttonThoat.Enabled = true;
            load_ds();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                PhanLoaiSanPhamDAO phanLoaiSanPhamDAO= new PhanLoaiSanPhamDAO();
                PhanLoaiMonAn monAn = phanLoaiSanPhamDAO.GetRow(int.Parse(textBoxMaPLSP.Text));
                if(monAn==null)
                {
                    throw new Exception("Phân loại không tồn tại!");
                }
                phanLoaiSanPhamDAO.delete(int.Parse(textBoxMaPLSP.Text));
                load_ds();
                MessageBox.Show("Xóa thành công", "Thông Báo!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dataGridViewds.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn PHÂN LOẠI món ăn!");
                }
                textBoxMaPLSP.Text = dataGridViewds.Rows[rowindex].Cells["MaPhanLoaiMonAn"].Value.ToString();
                textBoxTenPLSP.Text = dataGridViewds.Rows[rowindex].Cells["TenPhanLoaiMonAn"].Value.ToString();
                buttonXoa.Enabled = true;
                textBoxMaPLSP.Enabled = false;
                buttonCapnhat.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                //ThanhVien thanhVien = frmMain.thanhvien;
                PhanLoaiSanPhamDAO monAnDAO = new PhanLoaiSanPhamDAO();
                PhanLoaiMonAn monAn = monAnDAO.GetRow(int.Parse(textBoxMaPLSP.Text));              
                monAn.MaPhanLoaiMonAn = int.Parse(textBoxMaPLSP.Text);
                monAn.TenPhanLoaiMonAn = textBoxTenPLSP.Text;
                monAnDAO.update(monAn);
                dataGridViewds.DataSource = monAnDAO.getList();
                MessageBox.Show("Cập nhật thành công!", "Thông Báo!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        private void textBoxMaPLSP_TextChanged(object sender, EventArgs e)
        {

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
