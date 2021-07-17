using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form13 : Form
    {
        public string id_asignado { get; set; }
        public string nombre_asignado { get; set; }
        public void display()
        {
            try
            {
                DataTable dt = new DataTable();
                string query = "SELECT emp_nombreEmpleado AS Empleado FROM empleado;";
                MySqlCommand commandDatabase = Program.getNewMySqlCommand(query);
                commandDatabase.ExecuteNonQuery();
                MySqlDataAdapter adpt = new MySqlDataAdapter(commandDatabase);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            { }
        }


        public Form13()
        {
            InitializeComponent();
            display();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "SELECT emp_idEmpleado FROM empleado ORDER BY emp_idEmpleado LIMIT " + e.RowIndex.ToString() + " ,1;";
            try
            {
                MySqlCommand commandDatabase = Program.getNewMySqlCommand(query);
                this.id_asignado = commandDatabase.ExecuteScalar().ToString();
                this.nombre_asignado = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.Close();
            }
            catch (Exception)
            { }
        }
    }
}