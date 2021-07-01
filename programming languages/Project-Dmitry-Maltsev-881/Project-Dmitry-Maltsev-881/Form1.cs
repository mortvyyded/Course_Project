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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(_keyboardEvent);
            
        }
        Form2 f2;
        Form3 f3;
        Form4 f4;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void _keyboardEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                f2 = new Form2();
                f2.Show();
            }
            else if (e.KeyCode == Keys.F3)
            {
                f3 = new Form3();
                f3.Show();
            }
            else if (e.KeyCode == Keys.F4)
            {
                f4 = new Form4();
                f4.Show();
            }
        }

        private void разработчикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дмитрий Мальцев, 881 группа");
        }

        private void проектыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void инженерныйКалькуляторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3 = new Form3();
            f3.Show();
        }

        private void калькуляторToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.Show();
        }

        private void ИнтерфейсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4 = new Form4();
            f4.Show();
        }
    }
}
