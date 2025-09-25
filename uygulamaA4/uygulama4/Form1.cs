using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double td, ty,tn,sd, sy,sn, md, my,mn, fd, fy,fn;
            td = Convert.ToDouble(textBox1.Text);
            ty = Convert.ToDouble(textBox5.Text);
            tn = td-(ty/4);
            textBox9.Text = tn.ToString();

            sd = Convert.ToDouble(textBox2.Text);
            sy = Convert.ToDouble(textBox6.Text);
            sn = sd - (sy / 4);
            textBox10.Text = sn.ToString();

            md = Convert.ToDouble(textBox3.Text);
            my = Convert.ToDouble(textBox7.Text);
            mn = md - (my / 4);
            textBox11.Text = mn.ToString();

            fd = Convert.ToDouble(textBox4.Text);
            fy = Convert.ToDouble(textBox8.Text);
            fn = fd - (fy / 4);
            textBox12.Text = fn.ToString();
        }
    }
}
