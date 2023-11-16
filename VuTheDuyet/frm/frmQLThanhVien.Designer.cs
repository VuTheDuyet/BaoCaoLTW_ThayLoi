namespace VuTheDuyet.frm
{
    partial class frmQLThanhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewds = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonCapnhat = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxGM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTDN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHVT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxQUYEN = new System.Windows.Forms.ComboBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewds)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewds);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 246);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(800, 204);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách";
            // 
            // dataGridViewds
            // 
            this.dataGridViewds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewds.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewds.Name = "dataGridViewds";
            this.dataGridViewds.Size = new System.Drawing.Size(794, 185);
            this.dataGridViewds.TabIndex = 0;
            this.dataGridViewds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewds_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonThoat);
            this.groupBox3.Controls.Add(this.buttonXoa);
            this.groupBox3.Controls.Add(this.buttonCapnhat);
            this.groupBox3.Controls.Add(this.buttonThem);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 77);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(672, 27);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 31);
            this.buttonThoat.TabIndex = 3;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(476, 27);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 31);
            this.buttonXoa.TabIndex = 2;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonCapnhat
            // 
            this.buttonCapnhat.Location = new System.Drawing.Point(227, 27);
            this.buttonCapnhat.Name = "buttonCapnhat";
            this.buttonCapnhat.Size = new System.Drawing.Size(75, 31);
            this.buttonCapnhat.TabIndex = 1;
            this.buttonCapnhat.Text = "Cập nhật";
            this.buttonCapnhat.UseVisualStyleBackColor = true;
            this.buttonCapnhat.Click += new System.EventHandler(this.buttonCapnhat_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(25, 27);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 31);
            this.buttonThem.TabIndex = 0;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxQUYEN);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxSDT);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxMK);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxHVT);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxGM);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxTDN);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 105);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // textBoxGM
            // 
            this.textBoxGM.Location = new System.Drawing.Point(126, 64);
            this.textBoxGM.Name = "textBoxGM";
            this.textBoxGM.Size = new System.Drawing.Size(142, 20);
            this.textBoxGM.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email :";
            // 
            // textBoxTDN
            // 
            this.textBoxTDN.Location = new System.Drawing.Point(126, 27);
            this.textBoxTDN.Name = "textBoxTDN";
            this.textBoxTDN.Size = new System.Drawing.Size(142, 20);
            this.textBoxTDN.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đang nhập:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 64);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý thành viên";
            // 
            // textBoxMK
            // 
            this.textBoxMK.Location = new System.Drawing.Point(388, 65);
            this.textBoxMK.Name = "textBoxMK";
            this.textBoxMK.Size = new System.Drawing.Size(142, 20);
            this.textBoxMK.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mật khẩu";
            // 
            // textBoxHVT
            // 
            this.textBoxHVT.Location = new System.Drawing.Point(388, 28);
            this.textBoxHVT.Name = "textBoxHVT";
            this.textBoxHVT.Size = new System.Drawing.Size(142, 20);
            this.textBoxHVT.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Họ và tên :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(566, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Quyền :";
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Location = new System.Drawing.Point(646, 28);
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(142, 20);
            this.textBoxSDT.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(566, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Số điện thoại :";
            // 
            // comboBoxQUYEN
            // 
            this.comboBoxQUYEN.FormattingEnabled = true;
            this.comboBoxQUYEN.Location = new System.Drawing.Point(646, 68);
            this.comboBoxQUYEN.Name = "comboBoxQUYEN";
            this.comboBoxQUYEN.Size = new System.Drawing.Size(121, 21);
            this.comboBoxQUYEN.TabIndex = 13;
            // 
            // frmQLThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQLThanhVien";
            this.Text = "frmQLThanhVien";
            this.Load += new System.EventHandler(this.frmQLThanhVien_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewds)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewds;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonCapnhat;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxGM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTDN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHVT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxQUYEN;
    }
}