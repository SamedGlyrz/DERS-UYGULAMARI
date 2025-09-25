using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace uygulama4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi, indirimli, indirim;
            sayi = Convert.ToDouble(textBox1.Text);
            indirim =sayi * 0.10;
            indirimli = sayi - indirim;
            label3.Text = indirimli.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi, indirimli, indirim;
            sayi = Convert.ToDouble(textBox1.Text);
            indirim = sayi * 0.25;
            indirimli = sayi - indirim;
            label3.Text = indirimli.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi, indirimli, indirim;
            sayi = Convert.ToDouble(textBox1.Text);
            indirim = sayi * 0.50;
            indirimli = sayi - indirim;
            label3.Text = indirimli.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi, indirimli, indirim;
            sayi = Convert.ToDouble(textBox1.Text);
            indirim = sayi * 0.75;
            indirimli = sayi - indirim;
            label3.Text = indirimli.ToString();
        }
    }
    }

