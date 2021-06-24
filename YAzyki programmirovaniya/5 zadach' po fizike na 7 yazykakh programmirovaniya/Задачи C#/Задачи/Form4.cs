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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        double S, v, t;

        private void button1_Click(object sender, EventArgs e)
        {
            t = Convert.ToDouble(textBox2.Text);
             v = Convert.ToDouble(textBox3.Text);

            S = v * t;
            textBox4.Text = Convert.ToString(S);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
