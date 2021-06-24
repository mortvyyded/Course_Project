using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задачи
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        double F, a, m, v0, vк, t;

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            v0 = Convert.ToDouble(textBox2.Text);
            vк = Convert.ToDouble(textBox3.Text);
            t = Convert.ToDouble(textBox4.Text);
            m = Convert.ToDouble(textBox6.Text);
            a = (vк - v0) / t;
            F = m * a;


            textBox1.Text = Convert.ToString(F);
            textBox5.Text = Convert.ToString(a);
        }
    }
}
