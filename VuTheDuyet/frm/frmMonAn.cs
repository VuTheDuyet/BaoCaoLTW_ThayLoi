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
    public partial class frmMonAn : Form
    {
        MonAnDAO monAnDAO = new MonAnDAO();
        PhanLoaiSanPhamDAO phanLoaiSanPhamDAO = new PhanLoaiSanPhamDAO();
        int rowchoose = -1;
        string addupdate = "";
        public frmMonAn()
        {
            InitializeComponent();
        }

        private void loadMonAn()
        {
            dgvSanPham.DataSource = monAnDAO.getList();
        }

        private void loadPhanLoaiMA()
        {
            cbxPhanLoaiMA.DataSource = phanLoaiSanPhamDAO.getList();
           // cbxPhanLoaiMA.DisplayMember = "TenPhanLoaiMonAn";
           cbxPhanLoaiMA.DisplayMember = "TenPhanLoaiMonAn";
            cbxPhanLoaiMA.ValueMember = "MaPhanLoaiMonAn";
            cbxPhanLoaiMA.SelectedItem = 0;

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmMonAn_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnThem.Enabled = true;
            btnXoaSP.Enabled = false;
            loadMonAn();
            loadPhanLoaiMA();
            moNut();
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            try
            {
                MonAnDAO monAnDAO2 = new MonAnDAO();
                MonAn monAn = monAnDAO.GetRow(txtMaMA.Text);
                if(monAn==null)
                {
                    throw new Exception("Món ăn không tồn tại!");
                }
                monAnDAO2.delete(txtMaMA.Text);
                loadMonAn();
                MessageBox.Show("Xóa thành công", "Thông Báo!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if(rowindex == -1 || rowindex >= dgvSanPham.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn món ăn!");
                }
               
                txtMaMA.Text = dgvSanPham.Rows[rowindex].Cells["MaMonAn"].Value.ToString();
                txtTenMA.Text = dgvSanPham.Rows[rowindex].Cells["TenMonAn"].Value.ToString();
                cbxPhanLoaiMA.Text = dgvSanPham.Rows[rowindex].Cells["MaPhanLoaiMonAn"].Value.ToString();

                txtGiaMA.Text = dgvSanPham.Rows[rowindex].Cells["Gia"].Value.ToString();
                btnXoaSP.Enabled = true;
                btnSua.Enabled = true;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(int.Parse(txtGiaMA.Text) <= 0)
                {
                    throw new Exception("giá món ăn phải lơn hơn 0!");
                }
               MonAn monAn = new MonAn();
                monAn.TenMonAn = txtTenMA.Text;
                monAn.MaMonAn = txtMaMA.Text;
                monAn.Gia = float.Parse(txtGiaMA.Text);
                monAn.MaPhanLoaiMonAn = int.Parse(cbxPhanLoaiMA.SelectedValue.ToString());
                MonAnDAO monAnDAO = new MonAnDAO();
                monAnDAO.add(monAn);
                loadMonAn();
              //  monAn.MaPhanLoaiMonAn = cbxPhanLoaiMA.SelectedValue.ToString();
            }catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void moNut()
        {
            if (txtTenMA.Text.Length != 0 && txtMaMA.Text.Length != 0)
            {
                btnThem.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtGiaMA.Text) <= 0)
                {
                    throw new Exception("giá món ăn phải lơn hơn 0!");
                }
                //ThanhVien thanhVien = frmMain.thanhvien;
                MonAnDAO monAnDAO = new MonAnDAO();
                MonAn monAn = monAnDAO.GetRow(txtMaMA.Text);
                monAn.TenMonAn = txtTenMA.Text;
                monAn.MaMonAn = txtMaMA.Text;
                monAn.Gia = float.Parse(txtGiaMA.Text);
                monAn.MaPhanLoaiMonAn = int.Parse(cbxPhanLoaiMA.SelectedValue.ToString());
                monAnDAO.update(monAn);
                dgvSanPham.DataSource = monAnDAO.getList();
                MessageBox.Show("Cập nhật thành công!", "Thông Báo!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        private void txtGiaMA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
