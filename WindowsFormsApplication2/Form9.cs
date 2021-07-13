using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form9 : Form
    {
        public MySqlDataReader reader;
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;port=3306;username='" + textBox1.Text
                + "';password='" + textBox2.Text + "';database=mydb;";
            using (Program.databaseConnection = new MySqlConnection(connectionString));
            try
            {
                Program.databaseConnection.Open();
                MessageBox.Show("Conexión exitosa");

                string query = "SELECT CURRENT_ROLE()";
                MySqlCommand commandDatabase = new MySqlCommand(query, Program.databaseConnection);
                commandDatabase.CommandTimeout = 60;
                String reader = (String)commandDatabase.ExecuteScalar();

                if (reader == "`empleadoLaboratorista`@`%`") 
                {
                    Form1 ventana = new Form1();
                    ventana.Show();
                    this.Hide();
                }
                else
                {
                    Form1 ventana = new Form1();
                    ventana.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
