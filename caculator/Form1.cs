using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caculator
{
   
    public partial class Form1 : Form
    {
        double nho;
        string dau;
        bool dec;
        bool nhapmoi;
        public Form1()
        {
            InitializeComponent();
            nho = 0;
            dau = "";
            dec = false;
            nhapmoi = false;
        }
        void tinhToan()
        {
            switch (dau)
            {
                case "+": nho += double.Parse(txtResult.Text); break;
                case "-": nho -= double.Parse(txtResult.Text); break;
                case "*": nho *= double.Parse(txtResult.Text); break;
                case "/": nho /= double.Parse(txtResult.Text); break;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            if (dau == "")
            {
                nho = double.Parse(txtResult.Text);
            }
            else
            {
                tinhToan();
            }
            txtResult.Text = nho.ToString();
            dau = x.Text;
            nhapmoi = true;
            txtResult.Focus();
            //
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            tinhToan();
            txtResult.Text = nho.ToString();
            nho = 0;
            dau = "";
        
        }

        private void btnCLS_Click(object sender, EventArgs e)
        {
            tinhToan();
            txtResult.Text = nho.ToString();
            nho = 0;
            dau = "";
            dec = false;
            nhapmoi = false;
            txtResult.Focus();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            if(txtResult.Text == "0" || nhapmoi == true)
            {
                txtResult.Text = x.Text;
                nhapmoi = false;

            }
            else
            {
                txtResult.Text += x.Text;
            }
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            if (dec == false)
            {
                txtResult.Text += ".";
                dec = true;
            }
           
        }
    }
}
