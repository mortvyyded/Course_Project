using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Dmitry_Maltsev_881
{
    public partial class Form3 : Form
    {
        public string d;
        public string n1;
        public bool n2;
        public Form3()
        {
            n2 = false;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(n2)
            {
                n2 = false;
                textBox1.Text = "0";
            }
            Button b = (Button)sender; 
            if (textBox1.Text == "0")
                textBox1.Text = b.Text;
            else
                textBox1.Text = textBox1.Text + b.Text;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            Button b = (Button)sender;
            d = b.Text;
            n1 = textBox1.Text;
            n2 = true;
           
            textBox2.Text = b.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            Button b = (Button)sender;
            double dn1;
            double dn2;
            double res = 0;
            dn1 = Convert.ToDouble(n1);
            dn2 = Convert.ToDouble(textBox1.Text);
            if (d == "+")
            {
                res = dn1 + dn2;
            }
            if (d == "-")
            {
                res = dn1 - dn2;
            }
            if (d == "*")
            {
                res = dn1 * dn2;
            }
            if (d == "/")
            {
                res = dn1 / dn2;
            }
            if (d == "√")
            {
                res = Math.Sqrt(dn2);
            }
            if (d == "lg")
            {
                res = Math.Log10(dn2);
            }
            if (d == "X^")
            {
                res = Math.Pow(dn1, dn2);
            }
            if (d == "sin")
            {               
                res = Math.Sin(dn2);
            }
            if (d == "cos")
            {               
                res = Math.Cos(dn2);
            }
            if (d == "tan")
            {
                res = Math.Sin(dn2);
            }
            if (d == "asin")
            {
                res = Math.Asin(dn2);
            }
            if (d == "acos")
            {
                res = Math.Acos(dn2);
            }
            if (d == "atan")
            {
                res = Math.Atan(dn2);
            }
            d = "=";
            n2 = true;
            textBox1.Text = res.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }
    }
}
