using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP_Maltsev_881
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBase1 database = new DataBase1();

            MySqlCommand command = new MySqlCommand("INSERT INTO `progs` (`Программа`, `Количество`) VALUES (@prog, @count)", database.getConnection());

            command.Parameters.Add("@prog", MySqlDbType.VarChar).Value = comboBox1.Text;
            command.Parameters.Add("@count", MySqlDbType.VarChar).Value = textBox1.Text;

            database.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Добавлено");
            else
                MessageBox.Show("Ошибка!");

            database.closeConnection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form4 = new Form4();
            form4.Show();
            this.Close();
        }
    }
}
