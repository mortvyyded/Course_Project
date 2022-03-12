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

namespace Elvira_881
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB1 db = new DB1();

            MySqlCommand command = new MySqlCommand("INSERT INTO `info` (`ФИО`, `Номер телефона`, `Услуга`, `Дата для записи`) VALUES (@name, @number, @service, @date)", db.getConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@service", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@date", MySqlDbType.DateTime).Value = dateTimePicker1.Value;
            command.Parameters.Add("@number", MySqlDbType.VarChar).Value = textBox3.Text;


            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Добавлено");

            }
                
            else
                MessageBox.Show("Ошибка!");

            db.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}
