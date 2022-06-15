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
    public partial class FormStaffAdd : Form
    {
        public FormStaffAdd()
        {
            InitializeComponent();
        }

        private void FormStaffAdd_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBase1 database = new DataBase1();

            MySqlCommand command = new MySqlCommand("INSERT INTO `staff` (`ФИО сотрудника`, `Должность`, `Номер телефона`) VALUES (@name, @post, @number)", database.getConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@post", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@number", MySqlDbType.VarChar).Value = textBox3.Text;

            database.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Добавлено");
            else
                MessageBox.Show("Ошибка!");

            database.closeConnection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formstaff = new FormStaff();
            formstaff.Show();
            this.Close();
        }
    }
}
