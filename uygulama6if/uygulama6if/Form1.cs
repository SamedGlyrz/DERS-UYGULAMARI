﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama6if
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            if (radioButton1.Checked == true)
            {
                label3.Text = (sayi1 + sayi2).ToString();
            }
            if (radioButton2.Checked == true)
            {
                label3.Text = (sayi1 - sayi2).ToString();
            }
            if (radioButton3.Checked == true)
            {
                label3.Text = (sayi1 * sayi2).ToString();
            }
            if (radioButton4.Checked == true)
            {
                label3.Text = (sayi1 / sayi2).ToString();
            }
        }
    }
}
