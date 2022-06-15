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
    public partial class FormClientAdd : Form
    {
        public FormClientAdd()
        {
            InitializeComponent();
        }

        private void FormClientAdd_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBase1 database = new DataBase1();

            MySqlCommand command = new MySqlCommand("INSERT INTO `clients` (`Наименование предприятия`, `ФИО клиента`, `Номер телефона`, `Адрес электронной почты`) VALUES (@company, @name, @number, @mail)", database.getConnection());

            command.Parameters.Add("@company", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@number", MySqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = textBox4.Text;

            database.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Добавлено");
            else
                MessageBox.Show("Ошибка!");

            database.closeConnection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formclients = new FormClients();
            formclients.Show();
            this.Close();
        }
    }
}
