using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
﻿using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form6 : Form
    {
        public int id_proyectoRecibido;
        public string nombre_proyectoRecibido;
        int currentEnsayoMuestraindex;
        public List<EnsayoMuestra> ensayos = new List<EnsayoMuestra>();
        public List<ArchivoResultado> archivos = new List<ArchivoResultado>();
        public InformeFinal informe;
        public MySqlDataReader reader;
        public Boolean agregandoInf;
        public Boolean actualizandoInf;
        public Form6()
        {
            InitializeComponent();
            id_proyectoRecibido = -1;

            groupBox5.Controls.Remove(button8);
            this.Controls.Add(button8);
            groupBox3.Controls.Remove(button12);
            this.Controls.Add(button12);

            button8.Location = new System.Drawing.Point(15, 69);
            button12.Location = new System.Drawing.Point(15, 244);

            button8.BringToFront();
            button12.BringToFront();

            groupBox3.Visible = false;
            agregandoInf = false;
            actualizandoInf = false;

            groupBox5.Enabled = false;
            groupBox3.Enabled = false;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void llenarLista(Boolean aviso = true)
        {
            ensayos.Clear();  // Vaciar lista para ingresar nuevos valores
            archivos.Clear();
            informe = null;
            string queryFiltrado = "SELECT ens_idEnsayoMuestra, ens_fechaEnsayoMuestra," +
                "ens_hayResiduo, ens_condicionesParticularesEstudio," +
                "emp_idEmpleado, mue_idMuestra, tip_idTipoEnsayo,ens_estado," +
                "ens_rutaArchivo, pro_idProyecto," +
                "DATE_FORMAT(inf_fechaRemisionInforme,'%Y/%m/%d')," +
                "inf_observacionesInforme, inf_rutaInformeFinal, mue_numeroMuestra, tip_nombreTipoEnsayo" +
                " FROM Muestra" +
                " NATURAL JOIN TipoEnsayo NATURAL JOIN EnsayoMuestra NATURAL LEFT JOIN ArchivoResultado"+
                " NATURAL RIGHT JOIN (" +
                "SELECT * FROM InformeFinal WHERE pro_idProyecto = " +
                id_proyectoRecibido.ToString() + ") as t1";
            MySqlCommand commandDatabase = Program.getNewMySqlCommand(queryFiltrado);
            try
            {
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        EnsayoMuestra nuevoEnsayo = new EnsayoMuestra();
                        nuevoEnsayo.ens_idEnsayoMuestra = !reader.IsDBNull(0) ? reader.GetString(0) : "";
                        nuevoEnsayo.ens_fechaEnsayoMuestra = !reader.IsDBNull(1) ? reader.GetString(1) : "";
                        nuevoEnsayo.ens_hayResiduo = !reader.IsDBNull(2) ? reader.GetString(2) : "";
                        nuevoEnsayo.ens_condicionesParticularesEstudio = !reader.IsDBNull(3) ? reader.GetString(3) : "";
                        nuevoEnsayo.emp_idEmpleado = !reader.IsDBNull(4) ? reader.GetString(4) : "";
                        nuevoEnsayo.mue_idMuestra = !reader.IsDBNull(5) ? reader.GetString(5) : "";
                        nuevoEnsayo.tip_idTipoEnsayo = !reader.IsDBNull(6) ? reader.GetString(6) : "";
                        nuevoEnsayo.ens_estado = !reader.IsDBNull(7) ? reader.GetString(7) : "";
                        nuevoEnsayo.tip_nombreTipoEnsayo = !reader.IsDBNull(14) ? reader.GetString(14) : "";
                        nuevoEnsayo.mue_numeroMuestra = !reader.IsDBNull(13) ? reader.GetString(13) : "";
                        ArchivoResultado archivoRes = new ArchivoResultado();
                        archivoRes.ens_idEnsayoMuestra = !reader.IsDBNull(0) ? reader.GetString(0) : "";
                        archivoRes.ens_rutaArchivo = !reader.IsDBNull(8) ? reader.GetString(8) : "";
                        archivoRes.pro_idProyecto = !reader.IsDBNull(9) ? reader.GetString(9) : "";
                        informe = new InformeFinal();
                        informe.inf_fechaRemisionInforme = !reader.IsDBNull(10) ?  reader.GetString(10) : "";
                        informe.inf_observacionesInforme = !reader.IsDBNull(11) ? reader.GetString(11) : "";
                        informe.pro_idProyecto = !reader.IsDBNull(9) ? reader.GetString(9) : "";
                        informe.inf_rutaInformeFinal = !reader.IsDBNull(12) ? reader.GetString(12) : "";
                        ensayos.Add(nuevoEnsayo);
                        archivos.Add(archivoRes);
                    }
                    groupBox5.Enabled = true;
                    groupBox3.Enabled = true;
                }
                else
                {
                    if (aviso) MessageBox.Show("No hay registros que cumplan su criterio de búsqueda");
                    llenarLista();  // Como no se encontraron registros, regresa a los valores iniciales que sí existen
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (reader != null) reader.Close();
            }
        }

        private void mostrarDatos(int index)
        {
            if (informe != null)
            {
                textBox8.Text = informe.inf_fechaRemisionInforme;
                textBox3.Text = informe.inf_rutaInformeFinal;
                textBox7.Text = informe.inf_observacionesInforme;
                textBox1.Text = ensayos[index].emp_idEmpleado;
                textBox2.Text = ensayos[index].mue_numeroMuestra;
                textBox4.Text = ensayos[index].tip_nombreTipoEnsayo;
                textBox5.Text = ensayos[index].ens_fechaEnsayoMuestra;
                textBox6.Text = archivos[index].ens_rutaArchivo;
            }

        }
        private void button7_Click(object sender, EventArgs e)
        {
            var form = new Form10();
            form.ShowDialog();
            id_proyectoRecibido = form.id_asignado;
            nombre_proyectoRecibido = form.nombre_asignado;
            currentEnsayoMuestraindex = 0;
            txtNombreProyecto.Text = nombre_proyectoRecibido;
            llenarLista();
            mostrarDatos(currentEnsayoMuestraindex);
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentEnsayoMuestraindex + 1 >= ensayos.Count) // Revisa límites del arreglo
                MessageBox.Show("No puede avanzar más");
            else
            {
                mostrarDatos(++currentEnsayoMuestraindex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentEnsayoMuestraindex - 1 < 0)  // Revisa límites del arreglo
                MessageBox.Show("No puede retroceder más");
            else
            {
                mostrarDatos(--currentEnsayoMuestraindex);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "Informe +")
            {
                esconderEnsayo();
            }
            else
            {
                esconderInforme();
            }
        }
        private void esconderInforme()
        {
            groupBox5.Visible = false;
            groupBox3.Visible = true;
            button8.Text = "Informe +";
            button12.Text = "Ensayos -";
            button12.Location = new System.Drawing.Point(15, 119);
            groupBox3.Location = new System.Drawing.Point(15, 119);
        }
        private void esconderEnsayo()
        {
            groupBox3.Visible = false;
            groupBox5.Visible = true;
            button8.Text = "Informe -";
            button12.Text = "Ensayos +";
            button12.Location = new System.Drawing.Point(15, 244);
            groupBox3.Location = new System.Drawing.Point(15, 244);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button8.Text == "Informe +")
            {
                esconderEnsayo();
            }
            else
            {
                esconderInforme();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog()
            {
                Description = "Seleccione la carpeta de destino para los archivos del informe"
            };
            try
            {
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    Console.WriteLine("Pasa");
                    textBox3.Text = folder.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreProyecto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog()
            {
                FileName = "Seleccione un archivo",
                Filter = "Todos los archivos (*.*)|*.*",
                Title = "Seleccione el archivo resultado"
            };
            try
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    Console.WriteLine("Pasa");
                    textBox6.Text = file.FileName;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void actu_add_prep(Boolean enable)
        {
            textBox7.ReadOnly = enable;
            textBox8.ReadOnly = enable;
            button5.Enabled = !enable;
            button8.Enabled = !enable;
            button12.Enabled = !enable;
            button7.Enabled = !enable;
            if (enable)
            {
                button11.Text = "Aceptar";
                button9.Text = "Cancelar";
            }
            else
            {
                button11.Text = "Nuevo";
                button9.Text = "Eliminar";
            }
            button10.Visible = !enable;

        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (agregandoInf)
            {
                string query =
                    "INSERT INTO InformeFinal VALUES(" + Program.Evaluar(textBox8.Text)
                    + "," + Program.Evaluar(textBox7.Text)
                    + "," + id_proyectoRecibido.ToString()
                    + "," + Program.Evaluar(textBox3.Text, 2) + ")";
                MySqlCommand commandDatabase = Program.getNewMySqlCommand(query);
                try
                {
                    commandDatabase.ExecuteNonQuery();
                    MessageBox.Show("Agregado correctamente");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al agregar: " + ex);
                }
                agregandoInf = false;
                actu_add_prep(false);
                llenarLista();
                currentEnsayoMuestraindex = 0;
                mostrarDatos(currentEnsayoMuestraindex);
            }
            else if (actualizandoInf)
            {
                string query =
                    "UPDATE InformeFinal SET inf_fechaRemisionInforme = " + Program.Evaluar(textBox8.Text)
                    + ",inf_observacionesInforme = " + Program.Evaluar(textBox7.Text)
                    + ",inf_rutaInformeFinal = " + Program.Evaluar(textBox3.Text, 2)
                    + " WHERE pro_idProyecto = " + id_proyectoRecibido.ToString();
                MySqlCommand commandDatabase = Program.getNewMySqlCommand(query);
                try
                {
                    commandDatabase.ExecuteNonQuery();
                    MessageBox.Show("Actualizado correctamente");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al actualizar: " + ex);
                }
                actualizandoInf = false;
                actu_add_prep(false);
                llenarLista();
                currentEnsayoMuestraindex = 0;
                mostrarDatos(currentEnsayoMuestraindex);
            }
            else
            {
                if (informe != null)
                {
                    actu_add_prep(true);
                    agregandoInf = true;
                    textBox8.Text = "";
                    textBox3.Text = "";
                    textBox7.Text = "";
                }
                else
                {
                    MessageBox.Show("Ya existe un informe para este proyecto");
                }
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            actu_add_prep(true);
            actualizandoInf = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!agregandoInf && !actualizandoInf)
            {
                string query =
                        "DELETE FROM ArchivoResultado WHERE pro_idProyecto = " +
                        id_proyectoRecibido.ToString();
                MySqlCommand commandDatabase = Program.getNewMySqlCommand(query);
                try
                {
                    commandDatabase.ExecuteNonQuery();
                    MessageBox.Show("Borrados archivos resultado correctamente");
                    query =
                        "DELETE FROM InformeFinal WHERE pro_idProyecto = " +
                        id_proyectoRecibido.ToString();
                    commandDatabase = Program.getNewMySqlCommand(query);
                    try
                    {
                        commandDatabase.ExecuteNonQuery();
                        MessageBox.Show("Borrado informe final correctamente");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al borrar: " + ex);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al borrar: " + ex);
                }
                llenarLista(false);
            }
            else
            {
                actualizandoInf = false;
                agregandoInf = false;
                actu_add_prep(false);
                llenarLista();
            }
            currentEnsayoMuestraindex = 0;
            mostrarDatos(currentEnsayoMuestraindex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (id_proyectoRecibido == -1) return;
            string query = "UPDATE ArchivoResultado SET ens_rutaArchivo = "
                + Program.Evaluar(textBox6.Text, 2)
                + " WHERE ens_idEnsayoMuestra = "+ensayos[currentEnsayoMuestraindex].ens_idEnsayoMuestra;
            MySqlCommand commandDatabase = Program.getNewMySqlCommand(query);
            try
            {
                commandDatabase.ExecuteNonQuery();
                MessageBox.Show("Actualizado archivo resultado");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar: " + ex);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (id_proyectoRecibido == -1) return;
            string query = "DELETE FROM ArchivoResultado"
                + " WHERE ens_idEnsayoMuestra = " + ensayos[currentEnsayoMuestraindex].ens_idEnsayoMuestra;
            MySqlCommand commandDatabase = Program.getNewMySqlCommand(query);
            try
            {
                commandDatabase.ExecuteNonQuery();
                MessageBox.Show("Actualizado archivo resultado");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar: " + ex);
            }
        }
    }
}

