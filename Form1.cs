using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_1302220101
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String kiri = "";
        int hasil = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hasil == 0)
            {
                label1.Text += "1";
            } else
            {
                label1.Text = "1";
                hasil = 0;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (hasil == 0)
            {
                label1.Text += "2";
            }
            else
            {
                label1.Text = "2";
                hasil = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (hasil == 0)
            {
                label1.Text += "3";
            }
            else
            {
                label1.Text = "3";
                hasil = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (hasil == 0)
            {
                label1.Text += "4";
            }
            else
            {
                label1.Text = "4";
                hasil = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (hasil == 0)
            {
                label1.Text += "5";
            }
            else
            {
                label1.Text = "5";
                hasil = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (hasil == 0)
            {
                label1.Text += "6";
            }
            else
            {
                label1.Text = "6";
                hasil = 0;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (hasil == 0)
            {
                label1.Text += "7";
            }
            else
            {
                label1.Text = "7";
                hasil = 0;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (hasil == 0)
            {
                label1.Text += "8";
            }
            else
            {
                label1.Text = "8";
                hasil = 0;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (hasil == 0)
            {
                label1.Text += "9";
            }
            else
            {
                label1.Text = "9";
                hasil = 0;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (hasil == 0)
            {
                label1.Text += "0";
            }
            else
            {
                label1.Text = "0";
                hasil = 0;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            kiri = label1.Text;
            label2.Text = kiri;
            label1.Text = "";
            hasil = 0;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            hasil = Int32.Parse(kiri) + Int32.Parse(label1.Text);
            label1.Text = hasil.ToString();
            label2.Text = "";
        }
    }
}
