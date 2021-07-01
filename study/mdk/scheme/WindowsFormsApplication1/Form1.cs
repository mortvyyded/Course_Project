using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y, z;
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            z = Convert.ToInt32(textBox3.Text);
            bool x1, y2, z3, all;
            x1 = Convert.ToBoolean(x | y);
            textBox5.Text = Convert.ToString(x1);
            y2 = Convert.ToBoolean(y | z);
            textBox6.Text = Convert.ToString(y2);
            z3 = Convert.ToBoolean(z | x);
            textBox7.Text = Convert.ToString(z3);
            all = (x1 & y2 & z3);
            textBox8.Text = Convert.ToString(all);
            all = !all;
            textBox9.Text = Convert.ToString(all);
            if (all == true) { textBox4.Text = "5v";
                textBox4.BackColor = Color.Yellow;
            }
            else { textBox4.Text = "0v";
                textBox4.BackColor = Color.Gray;
            }
        }
    }
}
