using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3Ngay21
{
    
    public partial class Form1 : Form
    {
        double gia = 0;
        string hinhthuc = "";
        List<double> Dthu = new List<double>();
        List<string> Hten = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Ban co muon thoat khong", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if(chon == DialogResult.OK)
                this.Close();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            txtHoten.Text = " ";
            txtGiaDT.Text = " ";
            txtTien.Text = " ";
            rdbCangay.Checked = false;
            rdbNuangay.Checked = false;
            cmbChon.SelectedIndex = -1;
            cmbSL.SelectedIndex = -1;
            txtHoten.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbChon.Items.Add("Coca cola");
            cmbChon.Items.Add("Pepsi");
            cmbChon.Items.Add("Seven up");
            for(int i = 1; i <= 10; i++)
            {
                cmbSL.Items.Add(i.ToString());
            }
            txtGiaDT.Enabled = false;
            txtTien.Enabled = false;
        }

        private void rdbNuangay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNuangay.Checked == true)
            { txtGiaDT.Text = "100"; hinhthuc = "nua ngay"; }
        }

        private void rdbCangay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCangay.Checked == true)
            { txtGiaDT.Text = "200"; hinhthuc = "ca ngay"; }
        }

        private void cmbChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbChon.SelectedIndex)
            {
                case 0:
                    {
                        gia = 0.5; break;
                    }
                case 1:
                    {
                        gia = 0.8; break;
                    }
                case 2:
                    {
                        gia = 1.0; break;
                    }
            }
        }

        private void cmbSL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChon.SelectedIndex > -1)
                if (cmbSL.SelectedIndex > -1)
                    txtTien.Text = (gia * int.Parse(cmbSL.SelectedItem.ToString())).ToString();
        }

        private void btnThemDS_Click(object sender, EventArgs e)
        {
            string item;
            if (txtHoten.Text != " " && (rdbCangay.Checked = true) || (rdbNuangay.Checked = true) && cmbChon.SelectedIndex > -1 && cmbSL.SelectedIndex > -1)
            {
                string giadt = txtGiaDT.Text;
                string tiendouong = txtTien.Text;
                item = txtHoten.Text + "|" + hinhthuc + "|" + giadt + "$ do uong" + tiendouong + "$|" + "tong" + (int.Parse(giadt) + Convert.ToDouble(tiendouong)).ToString() + "$";
                Hten.Add(txtHoten.Text);
                Dthu.Add(int.Parse(giadt) + Convert.ToDouble(tiendouong));
                lstDS.Items.Add(item);
            }
            else MessageBox.Show("Hay nhap du du lieu");
        }
    }
}
Test num ber 2