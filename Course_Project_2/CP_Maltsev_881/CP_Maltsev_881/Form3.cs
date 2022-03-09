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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBase1 database = new DataBase1();

            MySqlCommand command = new MySqlCommand("INSERT INTO `info` (`ФИО`, `Программа`, `Телефон`, `Адрес подразделения`) VALUES (@name, @prog, @number, @address)", database.getConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@prog", MySqlDbType.VarChar).Value = comboBox1.Text;
            command.Parameters.Add("@number", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = textBox3.Text;

            database.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Добавлено");
            else
                MessageBox.Show("Ошибка!");

            database.closeConnection();
        }
    }
}
