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

            MySqlCommand command = new MySqlCommand("INSERT INTO `info` (`ФИО клиента`, `Дата принятия заказа`, `Программа`, `Телефон`, `Адрес подразделения`, `Адрес электронной почты`, `Сообщение`, `Оформление`) VALUES (@client, @date, @prog, @number, @address, @mail, @wishes, 0)", database.getConnection());

            command.Parameters.Add("@client", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@date", MySqlDbType.Date).Value = dateTimePicker1.Value;
            command.Parameters.Add("@prog", MySqlDbType.VarChar).Value = comboBox1.Text;
            command.Parameters.Add("@number", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = textBox4.Text;
            command.Parameters.Add("@wishes", MySqlDbType.Text).Value = textBox5.Text;

            database.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Добавлено");
            else
                MessageBox.Show("Ошибка!");

            database.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}
