﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Form2 = new Form1();
            Form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            Form5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 Form6 = new Form6();
            Form6.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
