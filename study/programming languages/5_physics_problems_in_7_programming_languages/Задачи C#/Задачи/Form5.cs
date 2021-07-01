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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        double S1, S2, t, v1, v2;

        private void button1_Click(object sender, EventArgs e)
        {
            t = Convert.ToDouble(textBox2.Text);
            v1 = Convert.ToDouble(textBox1.Text);
            v2 = Convert.ToDouble(textBox4.Text);
            S1 = v1 * t;
            S2 = v2 * t;

            textBox3.Text = Convert.ToString(S1);
            textBox5.Text = Convert.ToString(S2);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }
    }
}
