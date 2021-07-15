using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form3 : Form
    {
        public MySqlDataReader reader;
        public List<Perforacion> perforaciones = new List<Perforacion>();
        public List<Muestra> muestras = new List<Muestra>();
        public static int id_proyectoRecibido;
        public static string nombre_proyectoRecibido;
        public string mascaraBusquedaPerforacion = "", filtroBusquedaPerforacion = "per_idPerforacion";
        public string mascaraBusquedaMuestra = "", filtroBusquedaMuestra = "mue_idMuestra";
        public static int currentPerforacionIndex = 0, currentMuestraIndex = 0;
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
            finally { reader.Close(); }
        }
        private void mostrarDatosPerforacion(int given_index)
        {
            textBoxNombrePerforacion.Text = perforaciones[given_index].per_nombrePerforacion;
            textBoxLatitudPerforacion.Text = perforaciones[given_index].per_latitud;
            textBoxLongitudPerforacion.Text = perforaciones[given_index].per_longitud;
            textBoxLocalizacionPerforacion.Text = perforaciones[given_index].per_localizacion;
        }


        private void llenarListaPerforaciones()
        {
            perforaciones.Clear();  // Vaciar lista para ingresar nuevos valores
            string queryFiltrado = "SELECT * FROM Perforacion WHERE (" + filtroBusquedaPerforacion +
                " LIKE '" + mascaraBusquedaPerforacion + "%') AND (pro_idProyecto = " + id_proyectoRecibido + ");";
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
                    llenarListaPerforaciones();  // Como no se encontraron registros, regresa a los valores iniciales que sí existen
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { reader.Close(); }
        }


        private void menuNormalPerforacion()
        {
            btnAnteriorPerforacion.Text = "Anterior";
            btnSiguientePerforacion.Text = "Siguiente";
            groupBoxAdminPerforacion.Visible = true;
            foreach (TextBox box in groupBoxPerforacion.Controls.OfType<TextBox>())
                box.ReadOnly = true;
            groupBoxFiltroPerforacion.Visible = true;
        }


        private void menuUpdatePerforacion()
        {
            btnAnteriorPerforacion.Text = "Cancelar";
            btnSiguientePerforacion.Text = "Aceptar";
            groupBoxAdminPerforacion.Visible = false;
            foreach (TextBox box in groupBoxPerforacion.Controls.OfType<TextBox>())
                box.ReadOnly = false;
            groupBoxFiltroPerforacion.Visible = false;
        }


        private void menuAddPerforacion()
        {
            menuUpdatePerforacion();
            foreach (TextBox box in groupBoxPerforacion.Controls.OfType<TextBox>())
                box.Text = "";
        }


        private void btnActualizarPerforacion_Click(object sender, EventArgs e)
        {
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
            }
            else if (agregandoPerforacion)
            {
                // INSERT INTO Perforacion VALUES(NUll, 'PZ-9', 'La Vega', 54.221321, -32.99832, 2);
                string query =
                        "INSERT INTO perforacion VALUES (NULL, " + Program.Evaluar(textBoxNombrePerforacion.Text) + "," +
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
                menuNormalPerforacion();
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
            var form = new Form10();
            form.ShowDialog();
            id_proyectoRecibido = form.id_asignado;
            nombre_proyectoRecibido = form.nombre_asignado;
            currentPerforacionIndex = 0;
            currentMuestraIndex = 0;
            txtNombreProyecto.Text = nombre_proyectoRecibido;
            llenarListaPerforaciones();
            llenarListaMuestras();
            mostrarDatosMuestra(currentMuestraIndex);
        }

        /////// /////////////////////////  Muestra   ////////////////////////////////////////////////


        private void llenarListaMuestras()
        {
            string id_perforacion_actual = perforaciones[currentPerforacionIndex].per_idPerforacion;
            muestras.Clear();  // Vaciar lista para ingresar nuevos valores
            string queryFiltrado = "SELECT * FROM Muestra WHERE (" + filtroBusquedaMuestra +
                " LIKE '" + mascaraBusquedaMuestra + "%') AND (per_idPerforacion = " + id_perforacion_actual + ");";
            MySqlCommand commandDatabase = Program.getNewMySqlCommand(queryFiltrado);
            try
            {
                reader = commandDatabase.ExecuteReader();
                if (reader.Read())
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
                    return; // Regresa el control para evitar un ciclo infinito donde busca datos pero no encuentra
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { reader.Close(); }
        }


        private void btnFiltrarMuestra_Click(object sender, EventArgs e)
        {
            foreach (TextBox box in groupBoxMuestra.Controls.OfType<TextBox>())
                box.Text = "";  // Vaciar las cajas de texto para los nuevos valores filtrados
            mascaraBusquedaMuestra = txtMascaraMuestra.Text;
            filtroBusquedaMuestra = comboBoxFiltroMuestra.Text == "Número de muestra" ? "mue_numeroMuestra" : "mue_profundidad";
            llenarListaPerforaciones();  // llenar con los nuevos valores filtrados
        }


        private void menuNormalMuestra()
        {
            btnAnteriorMuestra.Text = "Anterior";
            btnSiguienteMuestra.Text = "Siguiente";
            groupBoxAdminMuestra.Visible = true;
            foreach (TextBox box in groupBoxMuestra.Controls.OfType<TextBox>())
                box.ReadOnly = true;
            groupBoxFiltroMuestra.Visible = true;
        }


        private void menuUpdateMuestra()
        {
            btnAnteriorMuestra.Text = "Cancelar";
            btnSiguienteMuestra.Text = "Aceptar";
            groupBoxAdminMuestra.Visible = false;
            foreach (TextBox box in groupBoxMuestra.Controls.OfType<TextBox>())
                box.ReadOnly = false;
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
                foreach (TextBox box in groupBoxMuestra.Controls.OfType<TextBox>())
                    box.Text = "";
                foreach (ComboBox box in groupBoxMuestra.Controls.OfType<ComboBox>())
                    box.Text = "";
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

        private void btnCrearEnsayoMuestra_Click(object sender, EventArgs e)
        {
            String_ID_MuestraActual = muestras[currentMuestraIndex].mue_idMuestra;
            String_ID_PerforacionActual = perforaciones[currentPerforacionIndex].per_idPerforacion;
            var form = new Form11(String_ID_MuestraActual, String_ID_PerforacionActual, id_proyectoRecibido.ToString());
            this.Hide();     
            form.ShowDialog();
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
            string id_perforacion_actual = perforaciones[currentPerforacionIndex].per_idPerforacion;
            if (actualizandoMuestra)
            {
                string query =
                    "UPDATE muestra SET mue_numeroMuestra = " + Program.Evaluar(txtNumeroMuestra.Text) + "," +
                    "mue_condicionEmpaque = " + Program.Evaluar(CondicionDeEmpaque, 1) + "," +
                    "mue_tipoMuestra = " + Program.Evaluar(tipoDeMuestra, 1) + "," +
                    "mue_ubicacionBodega = " + Program.Evaluar(txtUbicacionBodega.Text, 1) + "," +
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
                    Console.WriteLine("Error al actualizar: " + ex);
                }
                actualizandoMuestra = false;
                llenarListaMuestras();
                mostrarDatosMuestra(currentMuestraIndex);
                menuNormalMuestra();
            }
            else if (agregandoMuestra)
            {
                // INSERT INTO Perforacion VALUES(NUll, 'PZ-9', 'La Vega', 54.221321, -32.99832, 2);
                string query =
                        "INSERT INTO muestra VALUES (NULL, " + Program.Evaluar(txtNumeroMuestra.Text) + "," +
                        Program.Evaluar(CondicionDeEmpaque, 1) +
                        "," + Program.Evaluar(tipoDeMuestra, 1) +
                        "," + Program.Evaluar(txtUbicacionBodega.Text, 1) +
                        "," + Program.Evaluar(tipoDeExploracion, 1) +
                        "," + Program.Evaluar(txtDescripcionMuestra.Text) +
                        "," + Program.Evaluar(id_perforacion_actual, 1) +
                        "," + Program.Evaluar(txtUbicacionBodega.Text, 1) +
                        "," + Program.Evaluar(txtProfundidadMuestra.Text, 1) + ");";
                MySqlCommand commandDatabase = Program.getNewMySqlCommand(query);
                try
                {
                    commandDatabase.ExecuteNonQuery();
                    llenarListaMuestras();
                    mostrarDatosMuestra(currentMuestraIndex);
                    MessageBox.Show("Agregado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar: " + ex);
                }
                agregandoMuestra = false;
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

        public Form3()
        {
            InitializeComponent();
            inicializarProyectoFiltro();
            txtNombreProyecto.Text = nombre_proyectoRecibido;
            llenarListaPerforaciones();
            mostrarDatosPerforacion(currentPerforacionIndex);
            llenarListaMuestras();
            mostrarDatosMuestra(0);
            menuNormalPerforacion();
        }
    }
}