using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Maltsev_Dmitry_group_881
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 f2;
        Form3 f3;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void разработчикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мальцев Дмитрий, 881 группа");
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
    }
}
