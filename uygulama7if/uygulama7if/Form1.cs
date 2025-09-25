using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama7if
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fiyat,ot,taksitt;
            fiyat=Convert.ToDouble(textBox1.Text);
            if (radioButton1.Checked==true)
            {
                label5.Text = fiyat.ToString();
                label2.Text = fiyat.ToString();
            }
            else if (radioButton2.Checked==true)
            {
                ot = (fiyat*0.03)+fiyat;
                taksitt = ot / 3;
                label5.Text = ot.ToString();
                label2.Text = taksitt.ToString();
            }
            else
            {
                ot = (fiyat * 0.06) + fiyat;
                taksitt = ot / 6;
                label5.Text = ot.ToString();
                label2.Text = taksitt.ToString();
            }    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
