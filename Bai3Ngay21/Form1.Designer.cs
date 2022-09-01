namespace Bai3Ngay21
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.btnThemDS = new System.Windows.Forms.Button();
            this.cmbSL = new System.Windows.Forms.ComboBox();
            this.cmbChon = new System.Windows.Forms.ComboBox();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtGiaDT = new System.Windows.Forms.TextBox();
            this.rdbNuangay = new System.Windows.Forms.RadioButton();
            this.rdbCangay = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstDS = new System.Windows.Forms.ListBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTongDt = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemmoi);
            this.groupBox1.Controls.Add(this.btnThemDS);
            this.groupBox1.Controls.Add(this.cmbSL);
            this.groupBox1.Controls.Add(this.cmbChon);
            this.groupBox1.Controls.Add(this.txtTien);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.txtGiaDT);
            this.groupBox1.Controls.Add(this.rdbNuangay);
            this.groupBox1.Controls.Add(this.rdbCangay);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin khách hàng";
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Location = new System.Drawing.Point(190, 330);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(87, 27);
            this.btnThemmoi.TabIndex = 4;
            this.btnThemmoi.Text = "Thêm mới";
            this.btnThemmoi.UseVisualStyleBackColor = true;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // btnThemDS
            // 
            this.btnThemDS.Location = new System.Drawing.Point(18, 330);
            this.btnThemDS.Name = "btnThemDS";
            this.btnThemDS.Size = new System.Drawing.Size(142, 27);
            this.btnThemDS.TabIndex = 4;
            this.btnThemDS.Text = "Thêm vào danh sách";
            this.btnThemDS.UseVisualStyleBackColor = true;
            this.btnThemDS.Click += new System.EventHandler(this.btnThemDS_Click);
            // 
            // cmbSL
            // 
            this.cmbSL.FormattingEnabled = true;
            this.cmbSL.Location = new System.Drawing.Point(166, 288);
            this.cmbSL.Name = "cmbSL";
            this.cmbSL.Size = new System.Drawing.Size(51, 23);
            this.cmbSL.TabIndex = 3;
            this.cmbSL.SelectedIndexChanged += new System.EventHandler(this.cmbSL_SelectedIndexChanged);
            // 
            // cmbChon
            // 
            this.cmbChon.FormattingEnabled = true;
            this.cmbChon.Location = new System.Drawing.Point(19, 288);
            this.cmbChon.Name = "cmbChon";
            this.cmbChon.Size = new System.Drawing.Size(141, 23);
            this.cmbChon.TabIndex = 3;
            this.cmbChon.SelectedIndexChanged += new System.EventHandler(this.cmbChon_SelectedIndexChanged);
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(226, 289);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(116, 22);
            this.txtTien.TabIndex = 2;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(126, 34);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(116, 22);
            this.txtHoten.TabIndex = 2;
            // 
            // txtGiaDT
            // 
            this.txtGiaDT.Location = new System.Drawing.Point(126, 147);
            this.txtGiaDT.Name = "txtGiaDT";
            this.txtGiaDT.Size = new System.Drawing.Size(116, 22);
            this.txtGiaDT.TabIndex = 2;
            // 
            // rdbNuangay
            // 
            this.rdbNuangay.AutoSize = true;
            this.rdbNuangay.Location = new System.Drawing.Point(176, 87);
            this.rdbNuangay.Name = "rdbNuangay";
            this.rdbNuangay.Size = new System.Drawing.Size(75, 19);
            this.rdbNuangay.TabIndex = 1;
            this.rdbNuangay.TabStop = true;
            this.rdbNuangay.Text = "nửa ngày";
            this.rdbNuangay.UseVisualStyleBackColor = true;
            this.rdbNuangay.CheckedChanged += new System.EventHandler(this.rdbNuangay_CheckedChanged);
            // 
            // rdbCangay
            // 
            this.rdbCangay.AutoSize = true;
            this.rdbCangay.Location = new System.Drawing.Point(19, 87);
            this.rdbCangay.Name = "rdbCangay";
            this.rdbCangay.Size = new System.Drawing.Size(67, 19);
            this.rdbCangay.TabIndex = 1;
            this.rdbCangay.TabStop = true;
            this.rdbCangay.Text = "cả ngày";
            this.rdbCangay.UseVisualStyleBackColor = true;
            this.rdbCangay.CheckedChanged += new System.EventHandler(this.rdbCangay_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(352, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(260, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tiền";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chọn đồ uống";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(260, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giá du thuyền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstDS);
            this.groupBox2.Location = new System.Drawing.Point(418, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 389);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // lstDS
            // 
            this.lstDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDS.FormattingEnabled = true;
            this.lstDS.ItemHeight = 15;
            this.lstDS.Location = new System.Drawing.Point(3, 18);
            this.lstDS.Name = "lstDS";
            this.lstDS.Size = new System.Drawing.Size(416, 368);
            this.lstDS.TabIndex = 5;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(750, 416);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 27);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTongDt
            // 
            this.btnTongDt.Location = new System.Drawing.Point(421, 420);
            this.btnTongDt.Name = "btnTongDt";
            this.btnTongDt.Size = new System.Drawing.Size(142, 23);
            this.btnTongDt.TabIndex = 5;
            this.btnTongDt.Text = "Tổng doanh thu";
            this.btnTongDt.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(605, 420);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnTongDt);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Công ty du thuyền";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.Button btnThemDS;
        private System.Windows.Forms.ComboBox cmbSL;
        private System.Windows.Forms.ComboBox cmbChon;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtGiaDT;
        private System.Windows.Forms.RadioButton rdbNuangay;
        private System.Windows.Forms.RadioButton rdbCangay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstDS;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTongDt;
        private System.Windows.Forms.Button btnTimKiem;
    }
}

