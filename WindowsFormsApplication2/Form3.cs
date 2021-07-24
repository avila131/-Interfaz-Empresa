﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
namespace WindowsFormsApplication2
{
    public partial class Form3 : Form
    {
        public MySqlDataReader reader;
        public List<Perforacion> perforaciones = new List<Perforacion>();
        public List<Muestra> muestras = new List<Muestra>();
        public int id_proyectoRecibido;
        public string nombre_proyectoRecibido;
        public string mascaraBusquedaPerforacion = "", filtroBusquedaPerforacion = "per_idPerforacion";
        public string mascaraBusquedaMuestra = "", filtroBusquedaMuestra = "mue_idMuestra";
        public int currentPerforacionIndex = 0, currentMuestraIndex = 0;
        public bool actualizandoPerforacion, agregandoPerforacion;
        public bool actualizandoMuestra, agregandoMuestra;

        public static string String_ID_MuestraActual, String_ID_PerforacionActual,
                            String_ID_ProyectoActual;

        public bool creandoEnsayoMuestra;

        /////// /////////////////////////  Perforación   ////////////////////////////////////////////////

        private void inicializarProyectoFiltro()
        {
            string query = "SELECT ID, NombreProyecto FROM vw_idProyecto_nombreProyecto_estadoProyecto ORDER BY ID ASC LIMIT 1;";
            MySqlCommand commandDatabase = Program.getNewMySqlCommand(query);
            try
            {
                reader = commandDatabase.ExecuteReader();
                reader.Read();
                id_proyectoRecibido = Int32.Parse(reader.GetString(0));
                nombre_proyectoRecibido = reader.GetString(1);


            }
            catch (Exception)
            {
                MessageBox.Show("Al parecer no existen proyectos...");
            }
            finally { if(reader!=null)reader.Close(); }
        }
        private void mostrarDatosPerforacion(int given_index)
        {
            if (perforaciones.Count > 0)
            {
                textBoxNombrePerforacion.Text = perforaciones[given_index].per_nombrePerforacion;
                textBoxLatitudPerforacion.Text = perforaciones[given_index].per_latitud;
                textBoxLongitudPerforacion.Text = perforaciones[given_index].per_longitud;
                textBoxLocalizacionPerforacion.Text = perforaciones[given_index].per_localizacion;
            }
        }

        private void vaciarPerforacion()
        {
            textBoxNombrePerforacion.Text = "";
            textBoxLatitudPerforacion.Text = "";
            textBoxLongitudPerforacion.Text = "";
            textBoxLocalizacionPerforacion.Text = "";
        }
       

        private void llenarListaPerforaciones()
        {
            perforaciones.Clear();  // Vaciar lista para ingresar nuevos valores
            string queryFiltrado = "SELECT * FROM Perforacion WHERE (" + filtroBusquedaPerforacion +
                " LIKE '" + mascaraBusquedaPerforacion + "%' AND pro_idProyecto = " + id_proyectoRecibido + ");";
            MySqlCommand commandDatabase = Program.getNewMySqlCommand(queryFiltrado);
            try
            {
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                    while (reader.Read())
                    {
                        Perforacion nuevaPerforacion = new Perforacion();
                        nuevaPerforacion.per_idPerforacion = reader.GetString(0);
                        nuevaPerforacion.per_nombrePerforacion = reader.GetString(1);
                        nuevaPerforacion.per_localizacion = reader.GetString(2);
                        nuevaPerforacion.per_latitud = reader.GetString(3);
                        nuevaPerforacion.per_longitud = reader.GetString(4);
                        nuevaPerforacion.pro_idProyecto = reader.GetString(5);
                        perforaciones.Add(nuevaPerforacion);
                    }
                else
                {
                    MessageBox.Show("No hay registros que cumplan su criterio de búsqueda");
                    mascaraBusquedaPerforacion = "";
                    filtroBusquedaPerforacion = "per_idPerforacion";
                    reader.Close();
                    vaciarPerforacion();
                    vaciarMuestra(); // Como no se encontraron registros, regresa a los valores iniciales que sí existen
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { if(reader!=null) reader.Close(); }
            currentPerforacionIndex = 0;
        }


        private void menuNormalPerforacion()
        {
            btnAnteriorPerforacion.Text = "Anterior";
            btnSiguientePerforacion.Text = "Siguiente";
            if (Program.rolActual != "Laboratorista")
            {
                groupBoxAdminPerforacion.Visible = true;
            }
            foreach (TextBox box in groupBoxPerforacion.Controls.OfType<TextBox>())
                box.ReadOnly = true;
            groupBoxFiltroPerforacion.Visible = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            btnCrearEnsayoMuestra.Enabled = true;
        }


        private void menuUpdatePerforacion()
        {
            btnAnteriorPerforacion.Text = "Cancelar";
            btnSiguientePerforacion.Text = "Aceptar";
            groupBoxAdminPerforacion.Visible = false;
            foreach (TextBox box in groupBoxPerforacion.Controls.OfType<TextBox>())
                box.ReadOnly = false;
            groupBoxFiltroPerforacion.Visible = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            btnCrearEnsayoMuestra.Enabled = false;
        }


        private void menuAddPerforacion()
        {
            menuUpdatePerforacion();
            foreach (TextBox box in groupBoxPerforacion.Controls.OfType<TextBox>())
                box.Text = "";
        }


        private void btnActualizarPerforacion_Click(object sender, EventArgs e)
        {
            if (perforaciones.Count <= 0)
            {
                MessageBox.Show("No existe una perforación que actualizar");
                return;
            }
            menuUpdatePerforacion();
            actualizandoPerforacion = true;
        }


        private void btnNuevaPerforacion_Click(object sender, EventArgs e)
        {

            menuAddPerforacion();
            agregandoPerforacion = true;
        }


        private void btnFiltrarPerforacion_Click(object sender, EventArgs e)
        {
            foreach (TextBox box in groupBoxPerforacion.Controls.OfType<TextBox>())
                box.Text = "";  // Vaciar las cajas de texto para los nuevos valores filtrados
            mascaraBusquedaPerforacion = txtMascaraPerforacion.Text;
            filtroBusquedaPerforacion = comboBoxFiltroProyecto.Text == "Nombre Perforación" ? "per_nombrePerforacion" : "per_localizacion";
            llenarListaPerforaciones();
            mostrarDatosPerforacion(currentPerforacionIndex);
        }


        private void btnSiguientePerforacion_Click(object sender, EventArgs e)
        {
            if (actualizandoPerforacion)
            {
                DialogResult ds = MessageBox.Show("¿Desea actualizar la perforacion?",
                    "Importante", MessageBoxButtons.YesNo);
                if (ds != DialogResult.Yes) return;
                
                string query =
                    "UPDATE perforacion SET per_nombrePerforacion = " + Program.Evaluar(textBoxNombrePerforacion.Text) + "," +
                    "per_localizacion = " + Program.Evaluar(textBoxLocalizacionPerforacion.Text) + "," +
                    "per_latitud = " + Program.Evaluar(textBoxLatitudPerforacion.Text, 1) + "," +
                    "per_longitud = " + Program.Evaluar(textBoxLongitudPerforacion.Text, 1) + " " +
                    "WHERE per_idPerforacion = " + perforaciones[currentPerforacionIndex].per_idPerforacion + ";";
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
                actualizandoPerforacion = false;
                llenarListaPerforaciones();
                mostrarDatosPerforacion(currentPerforacionIndex);
                menuNormalPerforacion();
                llenarListaMuestras();
                mostrarDatosMuestra(currentMuestraIndex);
            }
            else if (agregandoPerforacion)
            {
                DialogResult ds = MessageBox.Show("¿Desea agregar la perforacion?",
                    "Importante", MessageBoxButtons.YesNo);
                if (ds != DialogResult.Yes) return;
                // INSERT INTO Perforacion VALUES(NUll, 'PZ-9', 'La Vega', 54.221321, -32.99832, 2);
                string con = "SELECT MAX(per_idPerforacion) FROM Perforacion";
                MySqlCommand cmAux = Program.getNewMySqlCommand(con);
                try
                {
                    int m_indice = Int32.Parse(cmAux.ExecuteScalar().ToString());
                    string query =
                            "INSERT INTO perforacion VALUES ("+(m_indice+1).ToString()+", " + Program.Evaluar(textBoxNombrePerforacion.Text) + "," +
                            Program.Evaluar(textBoxLocalizacionPerforacion.Text) +
                            "," + Program.Evaluar(textBoxLatitudPerforacion.Text, 1) +
                            "," + Program.Evaluar(textBoxLongitudPerforacion.Text, 1) +
                            "," + id_proyectoRecibido.ToString() + ");";
                    MySqlCommand commandDatabase = Program.getNewMySqlCommand(query);
                    try
                    {
                        commandDatabase.ExecuteNonQuery();
                        llenarListaPerforaciones();
                        mostrarDatosPerforacion(currentPerforacionIndex);
                        MessageBox.Show("Agregado correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar: " + ex);
                    }
                    agregandoPerforacion = false;
                    llenarListaPerforaciones();
                    mostrarDatosPerforacion(currentPerforacionIndex);
                    menuNormalPerforacion();
                    llenarListaMuestras();
                    mostrarDatosMuestra(currentMuestraIndex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar: " + ex);
                }
            }
            else if (currentPerforacionIndex + 1 >= perforaciones.Count)
                MessageBox.Show("No puede avanzar más");
            else
            {
                mostrarDatosPerforacion(++currentPerforacionIndex);  // Seleccionar la siguiente perforación
                llenarListaMuestras();
                mostrarDatosMuestra(currentMuestraIndex);
            }
        }


        private void btnAnteriorPerforacion_Click(object sender, EventArgs e)
        {
            if (actualizandoPerforacion || agregandoPerforacion)  // Cancela la operación
            {
                menuNormalPerforacion();
                actualizandoPerforacion = false;
                agregandoPerforacion = false;
            }
            else if (currentPerforacionIndex - 1 < 0)  // Revisa límites del arreglo
                MessageBox.Show("No puede retroceder más");
            else
            {
                mostrarDatosPerforacion(--currentPerforacionIndex);
                llenarListaMuestras();
                mostrarDatosMuestra(currentMuestraIndex);
            }
        }



        private void groupBox2_Enter(object sender, EventArgs e)
        { }


        private void button3_Click(object sender, EventArgs e)
        {
            id_proyectoRecibido = -1;
            var form = new Form10();
            form.ShowDialog();
            id_proyectoRecibido = form.id_asignado;
            nombre_proyectoRecibido = form.nombre_asignado;
            currentPerforacionIndex = 0;
            currentMuestraIndex = 0;
            txtNombreProyecto.Text = nombre_proyectoRecibido;
            if (id_proyectoRecibido == -1)
            {
                groupBoxPerforacion.Enabled = false;
                groupBoxMuestra.Enabled = false;
            }
            else
            {
                groupBoxPerforacion.Enabled = true;
                groupBoxMuestra.Enabled = true;
            }
            llenarListaPerforaciones();
            llenarListaMuestras();
            mostrarDatosPerforacion(currentPerforacionIndex);
            mostrarDatosMuestra(currentMuestraIndex);
        }

        /////// /////////////////////////  Muestra   ////////////////////////////////////////////////


        private void llenarListaMuestras()
        {
            muestras.Clear();
            currentMuestraIndex = 0;
            if (perforaciones.Count <= 0)
            {
                vaciarMuestra();
                return;
            }
            string id_perforacion_actual = perforaciones[currentPerforacionIndex].per_idPerforacion;
            muestras.Clear();  // Vaciar lista para ingresar nuevos valores
            string queryFiltrado = "SELECT * FROM Muestra WHERE (" + filtroBusquedaMuestra +
                " LIKE '" + mascaraBusquedaMuestra + "%' AND per_idPerforacion = " + id_perforacion_actual + ");";
            MySqlCommand commandDatabase = Program.getNewMySqlCommand(queryFiltrado);
            try
            {
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Muestra nuevaMuestra = new Muestra();
                        nuevaMuestra.mue_idMuestra = reader.GetString(0);
                        nuevaMuestra.mue_numeroMuestra = reader.GetString(1);
                        nuevaMuestra.mue_condicionEmpaque = reader.GetString(2);
                        nuevaMuestra.mue_tipoMuestra = reader.GetString(3);
                        nuevaMuestra.mue_ubicacionBodega = reader.GetString(4);
                        nuevaMuestra.mue_tipoExploracion = reader.GetString(5);
                        nuevaMuestra.mue_descripcionMuestra = reader.GetString(6);
                        nuevaMuestra.per_idPerforacion = reader.GetString(7);
                        nuevaMuestra.mue_profundidad = reader.GetString(8);
                        muestras.Add(nuevaMuestra);
                    }
                }
                else
                {
                    MessageBox.Show("No hay muestras para esta perforación");
                    mascaraBusquedaMuestra = "";
                    filtroBusquedaMuestra = "mue_idMuestra";
                    vaciarMuestra();
                    return; // Regresa el control para evitar un ciclo infinito donde busca datos pero no encuentra
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { reader.Close(); }
            
        }

        public void vaciarMuestra()
        {
            foreach (TextBox box in groupBoxMuestra.Controls.OfType<TextBox>())
                box.Text = "";
            foreach (ComboBox box in groupBoxMuestra.Controls.OfType<ComboBox>())
                box.Text = "";
        }


        private void btnFiltrarMuestra_Click(object sender, EventArgs e)
        {
            mascaraBusquedaMuestra = txtMascaraMuestra.Text;
            filtroBusquedaMuestra = comboBoxFiltroMuestra.Text == "Número de muestra" ? "mue_numeroMuestra" : "mue_profundidad";
            llenarListaMuestras();  // llenar con los nuevos valores filtrados
            mostrarDatosMuestra(currentMuestraIndex);
        }


        private void menuNormalMuestra()
        {
            btnAnteriorMuestra.Text = "Anterior";
            btnSiguienteMuestra.Text = "Siguiente";
            if (Program.rolActual != "Laboratorista")
                groupBoxAdminMuestra.Visible = true;
            foreach (TextBox box in groupBoxMuestra.Controls.OfType<TextBox>())
                box.ReadOnly = true;
            comboBoxTipoMuestra.Enabled = false;
            comboBoxTipoExploracion.Enabled = false;
            comboBoxCondicionEmpaque.Enabled = false;
            groupBoxFiltroMuestra.Visible = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            btnCrearEnsayoMuestra.Enabled = true;
        }


        private void menuUpdateMuestra()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            btnCrearEnsayoMuestra.Enabled = false;
            btnAnteriorMuestra.Text = "Cancelar";
            btnSiguienteMuestra.Text = "Aceptar";
            groupBoxAdminMuestra.Visible = false;
            foreach (TextBox box in groupBoxMuestra.Controls.OfType<TextBox>())
                box.ReadOnly = false;
            comboBoxTipoMuestra.Enabled = true;
            comboBoxTipoExploracion.Enabled = true;
            comboBoxCondicionEmpaque.Enabled = true;
            groupBoxFiltroMuestra.Visible = false;
        }


        private void menuAddMuestra()
        {
            menuUpdateMuestra();  // Aplica este formato
            foreach (TextBox box in groupBoxMuestra.Controls.OfType<TextBox>())
                box.Text = "";
        }


        private void mostrarDatosMuestra(int given_index)
        {
            if (muestras.Count == 0)
            {
                vaciarMuestra();
            }
            else
            {
                txtNumeroMuestra.Text = muestras[given_index].mue_numeroMuestra;
                txtProfundidadMuestra.Text = muestras[given_index].mue_profundidad;
                txtUbicacionBodega.Text = muestras[given_index].mue_ubicacionBodega;
                txtDescripcionMuestra.Text = muestras[given_index].mue_descripcionMuestra;
                comboBoxTipoMuestra.Text = muestras[given_index].mue_tipoMuestra;
                comboBoxTipoExploracion.Text = muestras[given_index].mue_tipoExploracion;
                comboBoxCondicionEmpaque.Text = muestras[given_index].mue_condicionEmpaque;
            }
        }


        private void btnAnteriorMuestra_Click(object sender, EventArgs e)
        {
            if (actualizandoMuestra || agregandoMuestra)  // Cancela la operación
            {
                menuNormalMuestra();
                actualizandoMuestra = false;
                agregandoMuestra = false;
            }
            else if (currentMuestraIndex - 1 < 0)  // Revisa límites del arreglo
                MessageBox.Show("No puede retroceder más");
            else
                mostrarDatosMuestra(--currentMuestraIndex);  // Seleccionar el tipo de ensayo anterior
        }


        private void btnSiguienteMuestra_Click(object sender, EventArgs e)
        {
            string tipoDeMuestra = comboBoxTipoMuestra.Text == "ALTERADA" ? "1" : "2";
            string CondicionDeEmpaque = comboBoxCondicionEmpaque.Text == "TUBO" ? "1" :
                                        comboBoxCondicionEmpaque.Text == "BOLSA" ? "2" : "3";
            string tipoDeExploracion = comboBoxTipoExploracion.Text == "SONDEO" ? "1" : "2";
            if (actualizandoMuestra)
            {
                DialogResult ds = MessageBox.Show("¿Desea actualizar la muestra?",
                    "Importante", MessageBoxButtons.YesNo);
                if (ds != DialogResult.Yes) return;
                if (muestras.Count <= 0)
                {
                    MessageBox.Show("No existe una muestra para actualizar");
                    return;
                }
                string id_perforacion_actual = perforaciones[currentPerforacionIndex].per_idPerforacion;
                string query =
                    "UPDATE muestra SET mue_numeroMuestra = " + Program.Evaluar(txtNumeroMuestra.Text,1) + "," +
                    "mue_condicionEmpaque = " + Program.Evaluar(CondicionDeEmpaque, 1) + "," +
                    "mue_tipoMuestra = " + Program.Evaluar(tipoDeMuestra, 1) + "," +
                    "mue_ubicacionBodega = " + Program.Evaluar(txtUbicacionBodega.Text) + "," +
                    "mue_descripcionMuestra = " + Program.Evaluar(txtDescripcionMuestra.Text) + "," +
                    "mue_tipoExploracion = " + Program.Evaluar(tipoDeExploracion, 1) + "," +
                    "per_idPerforacion = " + Program.Evaluar(id_perforacion_actual, 1) + "," +
                    "mue_profundidad = " + Program.Evaluar(txtProfundidadMuestra.Text, 1) + " " +
                    "WHERE mue_idMuestra = " + muestras[currentMuestraIndex].mue_idMuestra + ";";
                MySqlCommand commandDatabase = Program.getNewMySqlCommand(query);
                try
                {
                    commandDatabase.ExecuteNonQuery();
                    MessageBox.Show("Actualizado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar: " + ex.Message);
                }
                actualizandoMuestra = false;
                llenarListaMuestras();
                mostrarDatosMuestra(currentMuestraIndex);
                menuNormalMuestra();
            }
            else if (agregandoMuestra)
            {
                DialogResult ds = MessageBox.Show("¿Desea agregar la muestra?",
                    "Importante", MessageBoxButtons.YesNo);
                if (ds != DialogResult.Yes) return;
                if (perforaciones.Count <= 0)
                {
                    MessageBox.Show("No existe una perforacion padre para esta muestra.\nInserte una perforacion primero");
                    return;
                }
                string id_perforacion_actual = perforaciones[currentPerforacionIndex].per_idPerforacion;
                // INSERT INTO Perforacion VALUES(NUll, 'PZ-9', 'La Vega', 54.221321, -32.99832, 2);
                string con = "SELECT MAX(mue_idMuestra) FROM Muestra";
                MySqlCommand cmAux = Program.getNewMySqlCommand(con);
                try
                {
                    int m_indice = Int32.Parse(cmAux.ExecuteScalar().ToString());
                    string query =
                        "INSERT INTO muestra VALUES ( " + (m_indice + 1).ToString() +
                        "," + Program.Evaluar(txtNumeroMuestra.Text) +
                        "," + Program.Evaluar(CondicionDeEmpaque, 1) +
                        "," + Program.Evaluar(tipoDeMuestra, 1) +
                        "," + Program.Evaluar(txtUbicacionBodega.Text) +
                        "," + Program.Evaluar(tipoDeExploracion, 1) +
                        "," + Program.Evaluar(txtDescripcionMuestra.Text) +
                        "," + Program.Evaluar(id_perforacion_actual, 1) +
                        "," + Program.Evaluar(txtProfundidadMuestra.Text, 1) + ");";
                    MySqlCommand commandDatabase = Program.getNewMySqlCommand(query);
                    try
                    {
                        commandDatabase.ExecuteNonQuery();
                        MessageBox.Show("Agregado correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar: " + ex.Message);
                }
                agregandoMuestra = false;
                llenarListaMuestras();
                mostrarDatosMuestra(currentMuestraIndex);
                menuNormalMuestra();

            }
            else if (currentMuestraIndex + 1 >= muestras.Count)
                MessageBox.Show("No puede avanzar más");
            else
                mostrarDatosMuestra(++currentMuestraIndex); // Seleccionar la siguiente muestra
        }


        private void btnActualizarMuestra_Click(object sender, EventArgs e)
        {
            menuUpdateMuestra();
            actualizandoMuestra = true;
        }


        private void btnNuevaMuestra_Click(object sender, EventArgs e)
        {
            menuAddMuestra();
            agregandoMuestra = true;
        }

        private void btnCrearEnsayoMuestra_Click(object sender, EventArgs e)
        {
            String_ID_MuestraActual = muestras[currentMuestraIndex].mue_idMuestra;
            String_ID_PerforacionActual = perforaciones[currentPerforacionIndex].per_idPerforacion;
            Program.closed_by_user = false;
            Program.MenSelection = new Form11(String_ID_MuestraActual, String_ID_PerforacionActual,
                id_proyectoRecibido.ToString());
            this.Close();
        }

        public Form3()
        {
            id_proyectoRecibido = -1;
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Imagenes\\logoEmpresa.png"));
            pictureBox2.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Imagenes\\png-transparent-computer-icons-arrow-back-angle-triangle-monochrome.png"));
            inicializarProyectoFiltro();
            if(Program.rolActual == "Laboratorista")
            {
                groupBoxAdminPerforacion.Visible = false;
                groupBoxAdminMuestra.Visible = false;
            }
            txtNombreProyecto.Text = nombre_proyectoRecibido;

            llenarListaPerforaciones();
            mostrarDatosPerforacion(currentPerforacionIndex);
            llenarListaMuestras();
            mostrarDatosMuestra(0);
            menuNormalPerforacion();
            menuNormalMuestra();

            if (id_proyectoRecibido == -1)
            {
                groupBoxPerforacion.Enabled = false;
                groupBoxMuestra.Enabled = false;
            }
            else
            {
                groupBoxPerforacion.Enabled = true;
                groupBoxMuestra.Enabled = true;
            }

            groupBoxPerforacion.Controls.Remove(button1);
            this.Controls.Add(button1);
            groupBoxMuestra.Controls.Remove(button2);
            this.Controls.Add(button2);

            button1.Location = new System.Drawing.Point(9, 140);
            button2.Location = new System.Drawing.Point(9, 355);

            button1.BringToFront();
            button2.BringToFront();

            groupBoxMuestra.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Perforación +")
            {
                esconderMuestra();
            }
            else
            {
                esconderPerforacion();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Perforación +")
            {
                esconderMuestra();
            }
            else
            {
                esconderPerforacion();
            }
        }
        private void esconderPerforacion()
        {
            groupBoxPerforacion.Visible = false;
            groupBoxMuestra.Visible = true;
            button1.Text = "Perforación +";
            button2.Text = "Muestra -";
            button2.Location = new System.Drawing.Point(9, 160);
            groupBoxMuestra.Location = new System.Drawing.Point(9, 160);
        }
        private void esconderMuestra()
        {
            groupBoxMuestra.Visible = false;
            groupBoxPerforacion.Visible = true;
            button1.Text = "Perforación -";
            button2.Text = "Muestra +";
            button2.Location = new System.Drawing.Point(9, 355);
            groupBoxMuestra.Location = new System.Drawing.Point(9, 355);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Program.MenSelection = null;
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreProyecto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarPerforacion_Click(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("¿Desea eliminar la perforacion?",
                    "Importante", MessageBoxButtons.YesNo);
            if (ds != DialogResult.Yes) return;
            if (perforaciones.Count <= 0)
            {
                MessageBox.Show("No hay perforaciones para borrar");
                return;
            }

            string query = "DELETE FROM Perforacion WHERE per_idPerforacion = " + 
                perforaciones[currentPerforacionIndex].per_idPerforacion;
            MySqlCommand commandDatabase = Program.getNewMySqlCommand(query);
            try
            {
                commandDatabase.ExecuteNonQuery();
                MessageBox.Show("Borrado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            llenarListaPerforaciones();
            llenarListaMuestras();
            mostrarDatosMuestra(currentMuestraIndex);
            mostrarDatosPerforacion(currentPerforacionIndex);
        }

        private void btnEliminarMuestra_Click(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("¿Desea eliminar la muestra?",
                    "Importante", MessageBoxButtons.YesNo);
            if (ds != DialogResult.Yes) return;
            if (muestras.Count <= 0)
            {
                MessageBox.Show("No hay muestras para borrar");
                return;
            }

            string query = "DELETE FROM Muestra WHERE mue_idMuestra = " +
                muestras[currentMuestraIndex].mue_idMuestra;
            MySqlCommand commandDatabase = Program.getNewMySqlCommand(query);
            try
            {
                commandDatabase.ExecuteNonQuery();
                MessageBox.Show("Borrado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            llenarListaMuestras();
            mostrarDatosMuestra(currentMuestraIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.GuardarCambios();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (perforaciones.Count > 0)
            {
                string query = "CALL proc_proyectos_cerca_de("+
                    Program.Evaluar(perforaciones[currentPerforacionIndex].per_latitud,1)+ ","+
                    Program.Evaluar(perforaciones[currentPerforacionIndex].per_longitud,1)+ ",10);";
                MySqlCommand mc = Program.getNewMySqlCommand(query);
                try
                {
                    string response = "";
                    MySqlDataReader rd = mc.ExecuteReader();
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            if (!rd.IsDBNull(0) && !rd.IsDBNull(1))
                            {
                                response += rd.GetString(0) + "     ";
                                response += rd.GetString(1) + "\n\n";
                            }
                        }
                        MessageBox.Show("Se muestran los resultados Proyecto -- Localizacion\n" +
                            response);
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron proyectos cerca");
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Primer navegue hacia una perforacion");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Program.closed_by_user = false;
            if (Program.rolActual == "Laboratorista")
            {
                Program.MenSelection = new Form7();
            }else
                Program.MenSelection = new Form8();
            this.Close();
        }
    }
} 