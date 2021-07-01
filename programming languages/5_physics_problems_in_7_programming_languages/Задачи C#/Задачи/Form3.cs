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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Double t, S, v;

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            S = Convert.ToDouble(textBox2.Text);
            v = Convert.ToDouble(textBox3.Text);
            
            t = S / v;
            textBox1.Text = Convert.ToString(t);
        }
    }
}
