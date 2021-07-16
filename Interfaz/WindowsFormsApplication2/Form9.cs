using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form9 : Form
    {
        public bool UserSuccessfullyAuthenticated { get; private set; }
        public string userRole, userName;

        public MySqlDataReader reader;
        public Form9()
        {
            InitializeComponent();
        }

        public bool canOpenConnection()
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username='" + textBox1.Text
                    + "';password='" + textBox2.Text + "';database=mydb;";
                Program.databaseConnection = new MySqlConnection(connectionString);
                Program.databaseConnection.Open();
                return true;
            }
            catch { return false; }
        }
        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;port=3306;username='" + textBox1.Text
                + "';password='" + textBox2.Text + "';database=mydb;convert zero datetime=True";
            if (canOpenConnection())
            {
                userName = textBox1.Text;
                UserSuccessfullyAuthenticated = true;
                MessageBox.Show("Conexión exitosa");
                try
                {
                    string query = "SELECT CURRENT_ROLE()";
                    MySqlCommand commandDatabase = Program.getNewMySqlCommand(query);
                    string receivedRole = (String)commandDatabase.ExecuteScalar();
                    if (receivedRole.Contains("Laboratorista"))
                        userRole = "Laboratorista";
                    else
                        userRole = "Administrador";
                }
                catch
                {
                    MessageBox.Show("No se pudo hacer la lectura del rol del usuario");
                }
            }   
            else
                MessageBox.Show("Usuario o contraseña incorrectos");
            this.Close();
        }
    }
}