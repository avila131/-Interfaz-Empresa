using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form14 : Form
    {

        public void displayEmptyGridView()
        {
                lblEmptyDataGridView.Visible = true;
                dataGridView1.Visible = false;
        }

        public void display()
        {
            dataGridView1.Visible = true;
            lblEmptyDataGridView.Visible = false;
            string nombreTablaHistorialSeleccionadaComboBox = comboBoxSeleccionHistorial.Text;
            string nombreTablaHistorial = nombreTablaHistorialSeleccionadaComboBox == "Historial EnsayoMuestra" ? "historialEnsayoMuestra" :
                                   nombreTablaHistorialSeleccionadaComboBox == "Historial Muestras" ? "historialMuestra" : "historialPerforacion";
            try
            {
                DataTable dt = new DataTable();
                string query = "SELECT * FROM " + nombreTablaHistorial + ";";
                MySqlCommand commandDatabase = Program.getNewMySqlCommand(query);
                commandDatabase.ExecuteNonQuery();
                MySqlDataAdapter adpt = new MySqlDataAdapter(commandDatabase);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                if (dataGridView1.Rows.Count <= 1)
                    displayEmptyGridView();
            }
            catch (Exception)
            {}
        }


        public Form14()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Imagenes\\logoEmpresa.png"));
            pictureBox2.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Imagenes\\png-transparent-computer-icons-arrow-back-angle-triangle-monochrome.png"));
            dataGridView1.Visible = true;
            lblEmptyDataGridView.Visible = false;
            display();       
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            dataGridView1.Update();
            dataGridView1.Update();
            dataGridView1.Visible = true;
            lblEmptyDataGridView.Visible = false;
            dataGridView1.Refresh();
            dataGridView1.Update();
            dataGridView1.Update();
            dataGridView1.Update();
            dataGridView1.Update();
            dataGridView1.Update();
            dataGridView1.Refresh();
            display();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Program.closed_by_user = false;
            Program.MenSelection = new Form8();
            this.Close();
        }
    }
}