using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_ChuviDientichHTron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnCV_Click(object sender, EventArgs e)
        {
            Double Chuvi, bankinh;
            bankinh = Convert.ToDouble(txtBK.Text);
            Chuvi = bankinh * 2 * Math.PI;
            txtKQ.Text = Chuvi.ToString();
        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            Double Dientich, bankinh;
            bankinh = Convert.ToDouble(txtBK.Text);
            Dientich = bankinh * bankinh * Math.PI;
            txtKQ.Text = Dientich.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBK.Text= ("5.9");
        }

        private void rdbCV_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rdbDT_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTinhL1_Click(object sender, EventArgs e)
            
        {
            double bankinh = Convert.ToDouble(txtBK.Text);
            if (rdbCV.Checked) {
                double chuvi = bankinh * 2 * Math.PI;
                string thongbao = " Chu vi " + Convert.ToString(chuvi);
                MessageBox.Show(thongbao, " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
             if (rdbDT.Checked)
            {
                double dientich = bankinh * bankinh * Math.PI;
                string thongbao = " Diện tích " + Convert.ToString(dientich);
                MessageBox.Show(thongbao, " Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }

        private void btnTinhL2_Click(object sender, EventArgs e)
        {
            double bankinh = Convert.ToDouble(txtBK.Text);
            string thongbao = "";
            if (chkCV.Checked)
            {
                double chuvi = bankinh * 2 * Math.PI;
                thongbao = thongbao + " Chu vi " + Convert.ToString(chuvi) + Environment.NewLine;
            }
            if (chkbDT.Checked)
            {
                double dientich = bankinh * bankinh * Math.PI;
                thongbao = thongbao + " Diện tích " + Convert.ToString(dientich) + Environment.NewLine;
            }
            if (thongbao.Length > 0)
            {
                MessageBox.Show(thongbao, " Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information );
            }
            else
            {
                MessageBox.Show(" Vui lòng chọn tính năng " , " thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error );
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
