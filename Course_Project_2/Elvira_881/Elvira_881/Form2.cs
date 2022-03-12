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
    public partial class Form2 : Form
    {
        public string s;

        public Form2()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            DB1 db = new DB1();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `info` ORDER BY `id`", db.getConnection());

            db.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }

            reader.Close();

            db.closeConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ind = dataGridView1.SelectedCells[0].RowIndex;
            s = dataGridView1[0, ind].Value.ToString();

            DB1 db = new DB1();

            MySqlCommand command = new MySqlCommand("UPDATE `info` SET `Подтверждение`=1 WHERE `id` =" + s, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }

            reader.Close();

            db.closeConnection();

            dataGridView1.Rows.RemoveAt(ind);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ind = dataGridView1.SelectedCells[0].RowIndex;
            String s = dataGridView1[0, ind].Value.ToString();

            DB1 db = new DB1();

            MySqlCommand command = new MySqlCommand("DELETE FROM `info` WHERE `id` =" + s, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Remove(new string[6]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }

            reader.Close();

            db.closeConnection();

            dataGridView1.Rows.RemoveAt(ind);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
