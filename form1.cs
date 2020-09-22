using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void tbNhap_TextChanged(object sender, EventArgs e)
        {
     
            if (!tbNhap.Text.Equals("") )
            {
                if (!double.TryParse(tbNhap.Text, out double n))
                {
                    MessageBox.Show("Ban kinh phai la mot so!");
                
                }

            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbNhap.Clear();
            tbChuVi.Clear();
            tbDienTich.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double r = double.Parse(tbNhap.Text);
            double s = (3.14 * r * r);
            tbDienTich.Text = s.ToString();
            s = 3.14 * 2 * r;
            tbChuVi.Text = s.ToString();
        }
    }
}
