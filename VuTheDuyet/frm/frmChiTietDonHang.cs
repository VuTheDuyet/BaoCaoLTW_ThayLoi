﻿using System;
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
    public partial class frmChiTietDonHang : Form
    {
        public static int thanhvien;
        ChiTietHoaDonDAO chiTietHoaDonDAO = new ChiTietHoaDonDAO();
        public frmChiTietDonHang()
        {
            InitializeComponent();
            

            // Thực hiện các bước đểLoadChiTietDonHang();
        }
        
        private void frmChiTietDonHang_Load(object sender, EventArgs e)
        {
           // dataGridView1.DataSource = chiTietHoaDonDAO.seachanhinput(thanhvien);
        }
    }
}
