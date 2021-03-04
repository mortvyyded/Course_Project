using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int h, m, s;

        private void button1_Click(object sender, EventArgs e)
        {
            h = Convert.ToInt32(textBox1.Text);
            m = Convert.ToInt32(textBox2.Text);
            s = Convert.ToInt32(textBox3.Text);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1;
            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }
            if (m == -1)
            {
                h = h - 1;
                m = 59;
            }

            if (h==0 && m==0 && s==0)
            {
                timer1.Stop();
                MessageBox.Show("Время вышло!");
            }

            label1.Text = Convert.ToString(h);
            label3.Text = Convert.ToString(m);
            label5.Text = Convert.ToString(s);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Text = "0";
            label3.Text = "0";
            label5.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            h = Convert.ToInt32(textBox4.Text);
            m = Convert.ToInt32(textBox5.Text);
            s = Convert.ToInt32(textBox6.Text);

            timer2.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            label9.Text = "0";
            label11.Text = "0";
            label13.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            s = s - 1;
            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }
            if (m == -1)
            {
                h = h - 1;
                m = 59;
            }

            if (h == 0 && m == 0 && s == 0)
            {
                timer2.Stop();
                MessageBox.Show("Время вышло!");
            }

            label9.Text = Convert.ToString(h);
            label11.Text = Convert.ToString(m);
            label13.Text = Convert.ToString(s);
        }
    }
}
