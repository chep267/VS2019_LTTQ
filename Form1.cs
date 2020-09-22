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
            //if(e == tinh)
            //{
           //     MessageBox.Show("Tinh!");
           // }
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
            if (tbNhap.Text.Equals(""))
            {
                MessageBox.Show("Ban chua nhap ban kinh! ");
            }
            else
            {
                tbDienTich.Text = (3.14 * double.Parse(tbNhap.Text) * double.Parse(tbNhap.Text)).ToString();
                tbChuVi.Text = (3.14 * 2 * double.Parse(tbNhap.Text)).ToString();
            }
            
        }

        //KeyEventArgs tinh = new KeyEventArgs(Keys.Control | Keys.A);

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Alt | Keys.T))
            {
                this.AcceptButton = btnTinh;
                btnTinh.PerformClick();
            }
            if (e.KeyData == (Keys.Alt | Keys.L))
            {
                this.AcceptButton = button1;
                button1.PerformClick();
            }
            if (e.KeyData == (Keys.Alt | Keys.H))
            {
                this.AcceptButton = button3;
                button3.PerformClick();
            }
        }
    }
}
