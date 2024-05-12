using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal subtotal))
            {
                decimal discountPercent = 0m;

                if (subtotal >= 500)
                {
                    discountPercent = .2m;
                }
                else if (subtotal < 500 && subtotal >= 350)
                {
                    discountPercent = .15m;
                }
                else if (subtotal < 350 & subtotal >= 200)
                {
                    discountPercent = .1m;
                }
                else
                {
                    discountPercent = 0m;
                }

                decimal discountAmount = subtotal * discountPercent;
                decimal total = subtotal - discountAmount;

                textBox2.Text = (discountPercent * 100).ToString("0.00") + "%";
                textBox3.Text = discountAmount.ToString("C");
                textBox4.Text = total.ToString("C");
            }
            else
            {
                MessageBox.Show("Please enter a valid input.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
