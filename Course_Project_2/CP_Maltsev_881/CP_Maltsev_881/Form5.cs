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

            LoadData();
        }

        private void LoadData()
        {
            DataBase2 database = new DataBase2();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `orderprogs` ORDER BY `id`", database.getConnection());

            database.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }

            reader.Close();

            database.closeConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBase2 database = new DataBase2();

            MySqlCommand command = new MySqlCommand("INSERT INTO `orderprogs` (`Программа`, `Количество`) VALUES (@prog, @count)", database.getConnection());

            command.Parameters.Add("@prog", MySqlDbType.VarChar).Value = comboBox1.Text;
            command.Parameters.Add("@count", MySqlDbType.VarChar).Value = textBox1.Text;

            database.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Добавлено");
            else
                MessageBox.Show("Ошибка!");

            database.closeConnection();

            dataGridView1.Rows.Add();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form4 = new Form4();
            form4.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ind = dataGridView1.SelectedCells[0].RowIndex;
            String s = dataGridView1[0, ind].Value.ToString();

            DataBase2 database = new DataBase2();

            MySqlCommand command = new MySqlCommand("DELETE FROM `orderprogs` WHERE `id` =" + s, database.getConnection());

            database.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Remove(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }

            reader.Close();

            database.closeConnection();

            dataGridView1.Rows.RemoveAt(ind);
        }
    }
}
