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
    public partial class FormClients : Form
    {
        public FormClients()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            DataBase1 database = new DataBase1();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `clients` ORDER BY `id`", database.getConnection());

            database.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            reader.Close();

            database.closeConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void FormClients_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formclientadd = new FormClientAdd();
            formclientadd.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ind = dataGridView1.SelectedCells[0].RowIndex;
            String s = dataGridView1[0, ind].Value.ToString();

            DataBase1 database = new DataBase1();

            MySqlCommand command = new MySqlCommand("DELETE FROM `clients` WHERE `id` =" + s, database.getConnection());

            database.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Remove(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }

            reader.Close();

            database.closeConnection();

            dataGridView1.Rows.RemoveAt(ind);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}
