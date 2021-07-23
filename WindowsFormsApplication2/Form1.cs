using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public List<Cliente> clientes = new List<Cliente>();
        public int currentClientIndex;
        public Boolean clientsExist;
        public List<Proyecto> proyectos = new List<Proyecto>();
        public int currentProyectoIndex;
        public Boolean projectsExist;
        public MySqlDataReader reader;
        private Boolean agregando, actualizando, agregandoPro, actualizandoPro;
        public Form1()
        {
            agregando = false;
            actualizando = false;
            agregandoPro = false;
            actualizandoPro = false;
            InitializeComponent();
            groupBox1.Controls.Remove(button13);
            this.Controls.Add(button13);
            groupBox2.Controls.Remove(button14);
            this.Controls.Add(button14);
            groupBox2.Visible = false;
            button13.Location = new System.Drawing.Point(12, 24);
            button14.Location = new System.Drawing.Point(12, 238);
            button13.BringToFront();
            button14.BringToFront();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            textBox14.Text = "";
            upd_clientes("SELECT * FROM Cliente");
        }


        /// <summary>
        /// Muestra un cliente en pantalla dado su id 
        /// <param name="given_index">indíce para mostrar</param>
        /// </summary> 
        private void setClienteValue(int given_index)
        {
            textBox1.Text = clientes[given_index].NIT;
            textBox2.Text = clientes[given_index].razonSocial;
            textBox4.Text = clientes[given_index].telefono;
            textBox5.Text = clientes[given_index].sede;
            textBox6.Text = clientes[given_index].ccc;
            textBox7.Text = clientes[given_index].nContacto;
            textBox8.Text = clientes[given_index].aContacto;
            textBox9.Text = clientes[given_index].eContacto;
            label24.Text = "Cliente " + (given_index + 1).ToString() + " de " +
                        clientes.Count;
        }


        /// <summary>
        /// Muestra un proyecto en pantalla dado su id 
        /// <param name="given_index">indíce para mostrar</param>
        /// </summary> 
        private void setProyectoValue(int given_index)
        {
            textBox3.Text = proyectos[currentProyectoIndex].nombre;
            textBox10.Text = proyectos[currentProyectoIndex].cantidadEnsayos;
            textBox11.Text = proyectos[currentProyectoIndex].valorTotal;
            textBox13.Text = proyectos[currentProyectoIndex].fechaInicio;
            textBox15.Text = proyectos[currentProyectoIndex].fechaFin;
            textBox16.Text = proyectos[currentProyectoIndex].valorAbonado;
            textBox17.Text = proyectos[currentProyectoIndex].fechaAbono;
            textBox18.Text = proyectos[currentProyectoIndex].fechaPagoTotal;
            label25.Text = "Proyecto " + (given_index + 1).ToString() + " de " +
                        proyectos.Count;
        }


        /// <summary>
        /// Elimina el texto de todos las cajas de texto de la sección cliente
        /// </summary> 
        private void emptyClienteTextBoxes()
        {
            foreach (TextBox box in groupBox1.Controls.OfType<TextBox>())
                box.Text = "";
            label24.Text = "No se encontraron clientes";
        }

        /// <summary>
        /// Elimina el texto de todos las cajas de texto de la sección proyecto
        /// </summary> 
        private void emptyProyectoTextBoxes()
        {
            foreach (TextBox box in groupBox2.Controls.OfType<TextBox>())
                if (!box.Equals(textBox12) && !box.Equals(textBox19) && !box.Equals(textBox21))
                    box.Text = "";
            label25.Text = "No se encontraron proyectos";
        }

        /// <summary>
        /// Elimina el texto de todos las cajas de texto de la sección estadoPago
        /// </summary>
        private void emptyEstadoPagoTextBoxes()
        {
            foreach (TextBox box in groupBox3.Controls.OfType<TextBox>())
                box.Text = "";
        }

        /// <summary>
        /// Permite o restringe la lectura de las cajas de texto de la sección cliente
        /// <param name="enabled">false para permitir escritura, true para restringirla</param>
        /// </summary>
        private void readOnlyClienteTextBoxes(bool enabled)
        {
            foreach (TextBox box in groupBox1.Controls.OfType<TextBox>())
                box.ReadOnly = enabled;

            textBox14.ReadOnly = false;
        }

        /// <summary>
        /// Permite o restringe la lectura de las cajas de texto de la sección proyecto
        /// <param name="enabled">false para permitir escritura, true para restringirla</param>
        /// </summary>
        private void readOnlyProyectoTextBoxes(bool enabled)
        {
            foreach (TextBox box in groupBox2.Controls.OfType<TextBox>())
                box.ReadOnly = enabled;
            textBox12.ReadOnly = false;
        }

        /// <summary>
        /// Permite o restringe la lectura de las cajas de texto de la sección estadoPago
        /// <param name="enabled">false para permitir escritura, true para restringirla</param>
        /// </summary>
        private void readOnlyEstadoPagoTextBoxes(bool enabled)
        {
            foreach (TextBox box in groupBox3.Controls.OfType<TextBox>())
                box.ReadOnly = enabled;
        }

        /// <summary>
        /// Muestra el menu ocultando las secciones de proyecto y estado pago para actualizar o modificar un cliente.
        /// <param name="enabled">false para mantener la vista normal, true para abrir esta vista</param>
        /// </summary>
        private void menuAddUpdateCliente(bool enabled)
        {
            if (enabled)
            {
                button12.Visible = true;
                label15.Visible = false;
                textBox14.Visible = false;
                button8.Visible = false;
                //groupBox2.Visible = false;
                button2.Visible = false;
                button1.Visible = false;
                button6.Visible = false;
                button5.Text = "Aceptar";
                button7.Text = "Cancelar";
                comboBox1.Visible = false;
                label13.Visible = false;
                button13.Enabled = false;
                button14.Enabled = false;
                label24.Visible = false;
            }
            else
            {
                label15.Visible = true;
                textBox14.Visible = true;
                button8.Visible = true;
                //groupBox2.Visible = true;
                button2.Visible = true;
                button1.Visible = true;
                button6.Visible = true;
                comboBox1.Visible = true;
                label13.Visible = true;
                button13.Enabled = true;
                button14.Enabled = true;
                label24.Visible = true;
            }
        }

        /// <summary>
        /// Muestra la interfaz para actualizar o modificar un proyecto.
        /// <param name="enabled">false para mantener la vista normal, true para abrir esta vista</param>
        /// </summary>
        private void menuAddUpdateProyecto(bool enabled)
        {
            if (enabled)
            {
                button3.Text = "Aceptar";
                button4.Text = "Cancelar";
                button10.Visible = false;
                button9.Visible = false;
                button11.Visible = false;
                groupBox1.Enabled = false;
                button8.Enabled = false;
                label20.Visible = false;
                comboBox2.Visible = false;
                label25.Visible = false;
                comboBox2_SelectedIndexChanged_1(null, null);
            }
            else
            {
                button3.Text = "Siguiente";
                button4.Text = "Anterior";
                button10.Visible = true;
                button9.Visible = true;
                button11.Visible = true;
                button8.Enabled = true;
                label20.Visible = true;
                comboBox2.Visible = true;
                label25.Visible = true;
                comboBox2_SelectedIndexChanged_1(null, null);
            }
        }


        /// <summary>
        /// Obtiene información sobre el siguiente cliente y lo muestra en pantalla
        /// </summary> 
        private void button2_Click(object sender, EventArgs e)
        {
            if (currentClientIndex - 1 < 0 || !clientsExist)
                MessageBox.Show("No puede retroceder mas :O");
            else
            {
                currentClientIndex--;
                setClienteValue(currentClientIndex);
                upd_proyectos();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentClientIndex + 1 >= clientes.Count || !clientsExist)
                MessageBox.Show("No puede avanzar mas :O");
            else
            {
                currentClientIndex++;
                setClienteValue(currentClientIndex);
                upd_proyectos();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void Window_Closing(object sender, CancelEventArgs e)
        {
            Program.databaseConnection.Close();
            if (reader != null)
                reader.Close();
        }

        /// <summary>
        /// Muestra en pantalla los proyectos para un cliente dado
        /// </summary>
        private void upd_proyectos()
        {
            proyectos.Clear();
            currentProyectoIndex = 0;
            if (clientsExist)
            {
                string filtrado = "";
                switch (comboBox2.SelectedIndex)
                {
                    case 0:
                        filtrado = " AND pro_nombreProyecto LIKE " + Program.Evaluar(textBox12.Text, 3);
                        break;
                    case 1:
                        filtrado = " AND pro_FechaInicioProyecto BETWEEN " + Program.Evaluar(textBox19.Text) +
                            " AND " + Program.Evaluar(textBox21.Text);
                        break;
                    case 2:
                        filtrado = " AND pro_FechaFinalizacionProyecto BETWEEN " + Program.Evaluar(textBox19.Text) +
                            " AND " + Program.Evaluar(textBox21.Text);
                        break;
                    case 3:
                        filtrado = " AND esp_fechaPagoTotal = NULL";
                        break;
                }
                string query = "SELECT pro_idProyecto, pro_cantidadEnsayos, pro_valorTotal, pro_nombreProyecto," +
                    " DATE_FORMAT(pro_FechaInicioProyecto,'%Y/%m/%d')," +
                    " DATE_FORMAT(pro_FechaFinalizacionProyecto,'%Y/%m/%d')," +
                    " cli_NIT, esp_valorAbonado," +
                    " DATE_FORMAT(esp_fechaAbono,'%Y/%m/%d')," +
                    " DATE_FORMAT(esp_fechaPagoTotal,'%Y/%m/%d') " +
                    "FROM Proyecto NATURAL LEFT JOIN EstadoPago WHERE cli_NIT = "
                    + clientes[currentClientIndex].NIT +
                    filtrado;
                Console.WriteLine(query);
                MySqlCommand commandDatabase = new MySqlCommand(query, Program.databaseConnection);
                commandDatabase.CommandTimeout = 60;
                try
                {
                    reader = commandDatabase.ExecuteReader();
                    if (reader.HasRows)
                    {
                        projectsExist = true;
                        while (reader.Read())
                        {
                            Proyecto nuevo = new Proyecto();
                            nuevo.id = !reader.IsDBNull(0) ? reader.GetString(0) : "";
                            nuevo.cantidadEnsayos = !reader.IsDBNull(1) ? reader.GetString(1) : "";
                            nuevo.valorTotal = !reader.IsDBNull(2) ? reader.GetString(2) : "";
                            nuevo.nombre = !reader.IsDBNull(3) ? reader.GetString(3) : "";
                            nuevo.fechaInicio = !reader.IsDBNull(4) ? reader.GetString(4) : "";

                            nuevo.fechaFin = !reader.IsDBNull(5) ? reader.GetString(5) : "";
                            nuevo.NIT = !reader.IsDBNull(6) ? reader.GetString(6) : "";
                            nuevo.valorAbonado = !reader.IsDBNull(7) ? reader.GetString(7) : "";
                            nuevo.fechaAbono = !reader.IsDBNull(8) ? reader.GetString(8) : "";
                            nuevo.fechaPagoTotal = !reader.IsDBNull(9) ? reader.GetString(9) : "";
                            proyectos.Add(nuevo);
                        }
                        setProyectoValue(currentProyectoIndex);
                    }
                    else
                    {
                        projectsExist = false;
                        emptyProyectoTextBoxes();
                        emptyEstadoPagoTextBoxes();
                        Console.WriteLine("No se encontraron datos.");
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    if (reader != null)
                        reader.Close();
                    MessageBox.Show(e.Message);
                }
            }
        }


        public void upd_clientes(String consulta)
        {
            string query = consulta;
            MySqlCommand commandDatabase = new MySqlCommand(query, Program.databaseConnection);
            clientes.Clear();
            commandDatabase.CommandTimeout = 60;
            try
            {
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    clientsExist = true;
                    while (reader.Read())
                    {
                        Cliente nuevo = new Cliente();
                        nuevo.NIT = !reader.IsDBNull(0) ? reader.GetString(0) : "";
                        nuevo.razonSocial = !reader.IsDBNull(1) ? reader.GetString(1) : "";
                        nuevo.telefono = !reader.IsDBNull(2) ? reader.GetString(2) : "";
                        nuevo.sede = !reader.IsDBNull(3) ? reader.GetString(3) : "";
                        nuevo.ccc = !reader.IsDBNull(4) ? reader.GetString(4) : "";
                        nuevo.nContacto = !reader.IsDBNull(5) ? reader.GetString(5) : "";
                        nuevo.aContacto = !reader.IsDBNull(6) ? reader.GetString(6) : "";
                        nuevo.eContacto = !reader.IsDBNull(7) ? reader.GetString(7) : "";
                        clientes.Add(nuevo);
                    }
                    setClienteValue(0);
                    reader.Close();
                    upd_proyectos();
                }
                else
                {
                    reader.Close();
                    clientsExist = false;
                    emptyClienteTextBoxes();
                    emptyProyectoTextBoxes();
                    emptyEstadoPagoTextBoxes();
                    Console.WriteLine("No se encontraron datos.");
                }
            }
            catch (Exception ex)
            {
                if (reader != null)
                    reader.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!agregandoPro && !actualizandoPro)
            {
                if (currentProyectoIndex + 1 >= proyectos.Count || !projectsExist)
                    MessageBox.Show("No puede avanzar mas :O");
                else
                {
                    currentProyectoIndex++;
                    setProyectoValue(currentProyectoIndex);
                }
            }
            else if (agregandoPro)
            {
                string con = "SELECT MAX(pro_idProyecto) FROM Proyecto";
                MySqlCommand cmAux = new MySqlCommand(con, Program.databaseConnection);
                try
                {
                    int m_indice = Int32.Parse(cmAux.ExecuteScalar().ToString());
                    string query =
                        "INSERT INTO Proyecto VALUES (" + (m_indice + 1).ToString() + "," +
                        Program.Evaluar(textBox10.Text, 1) +
                        "," + Program.Evaluar(textBox11.Text) +
                        "," + Program.Evaluar(textBox3.Text) +
                        "," + Program.Evaluar(textBox13.Text) +
                        "," + Program.Evaluar(textBox15.Text) +
                        "," + Program.Evaluar(textBox1.Text) +
                        ");";
                    MySqlCommand commandDatabase = new MySqlCommand(query, Program.databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    try
                    {
                        commandDatabase.ExecuteNonQuery();
                        MessageBox.Show("Agregado correctamente un proyecto");
                        query =
                        "INSERT INTO EstadoPago VALUES(" + (m_indice + 1).ToString() + "," +
                        Program.Evaluar(textBox16.Text) + "," +
                        Program.Evaluar(textBox17.Text) + "," + Program.Evaluar(textBox18.Text)
                        + ");";
                        commandDatabase = new MySqlCommand(query, Program.databaseConnection);
                        commandDatabase.CommandTimeout = 60;
                        MessageBox.Show(query);
                        try
                        {
                            commandDatabase.ExecuteNonQuery();
                            MessageBox.Show("Agregado correctamente un estado de pago");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                groupBox1.Enabled = true;
                readOnlyProyectoTextBoxes(true);
                readOnlyEstadoPagoTextBoxes(true);
                menuAddUpdateProyecto(false);
                agregandoPro = false;
                upd_proyectos();
            }
            else
            {
                string query =
                    "UPDATE Proyecto SET pro_nombreProyecto = " + Program.Evaluar(textBox3.Text) + "," +
                    "pro_cantidadEnsayos = " + Program.Evaluar(textBox10.Text, 1) + "," +
                    "pro_valorTotal = " + Program.Evaluar(textBox11.Text, 1) + "," +
                    "pro_FechaInicioProyecto = " + Program.Evaluar(textBox13.Text) + "," +
                    "pro_FechaFinalizacionProyecto = " + Program.Evaluar(textBox15.Text) + " " +
                    "WHERE pro_idProyecto = " + proyectos[currentProyectoIndex].id + ";";
                MySqlCommand commandDatabase = new MySqlCommand(query, Program.databaseConnection);
                commandDatabase.CommandTimeout = 60;
                try
                {
                    commandDatabase.ExecuteNonQuery();
                    MessageBox.Show("Actualizado correctamente un proyecto");
                    query =
                        "UPDATE EstadoPago SET esp_valorAbonado = " +
                        Program.Evaluar(textBox16.Text, 1) + "," +
                        "esp_fechaAbono = " + Program.Evaluar(textBox17.Text) + "," +
                        "esp_fechaPagoTotal = " + Program.Evaluar(textBox18.Text) + " " +
                        "WHERE pro_idProyecto = " + proyectos[currentProyectoIndex].id + ";";
                    commandDatabase = new MySqlCommand(query, Program.databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    try
                    {
                        commandDatabase.ExecuteNonQuery();
                        MessageBox.Show("Actualizado correctamente un estado de pago");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                groupBox1.Enabled = true;
                readOnlyProyectoTextBoxes(true);
                readOnlyEstadoPagoTextBoxes(true);
                menuAddUpdateProyecto(false);
                actualizandoPro = false;
                upd_proyectos();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!agregandoPro && !actualizandoPro)
            {
                if (currentProyectoIndex - 1 < 0 || !projectsExist)
                    MessageBox.Show("No puede retroceder mas :O");
                else
                {
                    currentProyectoIndex--;
                    setProyectoValue(currentProyectoIndex);
                }
            }
            else
            {
                groupBox1.Enabled = true;
                readOnlyProyectoTextBoxes(true);
                readOnlyEstadoPagoTextBoxes(true);
                menuAddUpdateProyecto(false);
                agregandoPro = false;
                actualizandoPro = false;
                upd_proyectos();
            }
        }


        private void label5_Click(object sender, EventArgs e)
        { }

        private void label11_Click(object sender, EventArgs e)
        { }

        private void label15_Click(object sender, EventArgs e)
        { }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void label17_Click(object sender, EventArgs e)
        { }

        private void label18_Click(object sender, EventArgs e)
        { }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                upd_clientes("SELECT * FROM Cliente WHERE cli_razonSocial LIKE '%" + textBox14.Text + "%'");
            }
            else
            {
                upd_clientes("SELECT * FROM Cliente WHERE CONVERT(cli_NIT,CHAR(50)) LIKE '%" + textBox14.Text + "%'");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!agregando && !actualizando)
            {
                agregando = true;
                emptyClienteTextBoxes();
                readOnlyClienteTextBoxes(false);
                menuAddUpdateCliente(true);
                button5.Text = "Aceptar";
                button7.Text = "Cancelar";
            }
            else if (!actualizando)
            {
                string query =
                    "INSERT INTO Cliente VALUES (" +
                    Program.Evaluar(textBox1.Text, 1) +
                    "," + Program.Evaluar(textBox2.Text) +
                    "," + Program.Evaluar(textBox4.Text) +
                    "," + Program.Evaluar(textBox5.Text) +
                    "," + Program.Evaluar(textBox6.Text, 2) +
                    "," + Program.Evaluar(textBox7.Text) +
                    "," + Program.Evaluar(textBox8.Text) +
                    "," + Program.Evaluar(textBox9.Text) +
                    ");";
                MySqlCommand commandDatabase = new MySqlCommand(query, Program.databaseConnection);
                commandDatabase.CommandTimeout = 60;
                try
                {
                    commandDatabase.ExecuteNonQuery();
                    MessageBox.Show("Agregado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                agregando = false;
                menuAddUpdateCliente(false);
                readOnlyClienteTextBoxes(true);
                button12.Visible = false;
                button5.Text = "Nuevo";
                button7.Text = "Eliminar";
                upd_clientes("SELECT * FROM Cliente");
            }
            else //Osea actualizando :D
            {
                string query =
                    "UPDATE Cliente SET cli_razonSocial = " + Program.Evaluar(textBox2.Text) + "," +
                    "cli_telefono = " + Program.Evaluar(textBox4.Text) + "," +
                    "cli_sede = " + Program.Evaluar(textBox5.Text) + "," +
                    "cli_certificadoCamaraComercio = " + Program.Evaluar(textBox6.Text, 2) + "," +
                    "cli_nombreContacto = " + Program.Evaluar(textBox7.Text) + "," +
                    "cli_apellidoContacto = " + Program.Evaluar(textBox8.Text) + "," +
                    "cli_emailContacto = " + Program.Evaluar(textBox9.Text) + " WHERE cli_NIT = " +
                    textBox1.Text + ";";
                MySqlCommand commandDatabase = new MySqlCommand(query, Program.databaseConnection);
                commandDatabase.CommandTimeout = 60;
                try
                {
                    commandDatabase.ExecuteNonQuery();
                    MessageBox.Show("Actualizado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                actualizando = false;
                readOnlyClienteTextBoxes(true);
                button12.Visible = false;
                menuAddUpdateCliente(false);
                button5.Text = "Nuevo";
                button7.Text = "Eliminar";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (agregando && !actualizando)
            {
                agregando = false;
                menuAddUpdateCliente(false);
                readOnlyClienteTextBoxes(true);
                button12.Visible = false;
                button5.Text = "Nuevo";
                button7.Text = "Eliminar";
                upd_clientes("SELECT * FROM Cliente");
            }
            else if (!agregando && !actualizando)
            {
                string query = "DELETE FROM Cliente WHERE cli_NIT = " + textBox1.Text;
                MySqlCommand commandDatabase = new MySqlCommand(query, Program.databaseConnection);
                commandDatabase.CommandTimeout = 60;
                try
                {
                    commandDatabase.ExecuteNonQuery();
                    MessageBox.Show("Borrado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                upd_clientes("SELECT * FROM Cliente");
            }
            else //Actualizando
            {
                actualizando = false;
                readOnlyClienteTextBoxes(true);
                button12.Visible = false;
                menuAddUpdateCliente(false);
                button5.Text = "Nuevo";
                button7.Text = "Eliminar";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!actualizando)
            {
                actualizando = true;
                readOnlyClienteTextBoxes(false);
                menuAddUpdateCliente(true);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            emptyProyectoTextBoxes();
            emptyEstadoPagoTextBoxes();
            readOnlyProyectoTextBoxes(false);
            readOnlyEstadoPagoTextBoxes(false);
            menuAddUpdateProyecto(true);
            agregandoPro = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog()
            {
                FileName = "Seleccione un archivo",
                Filter = "PDF Files (*.pdf)|*.pdf",
                Title = "Seleccione el archivo pdf del certificado"
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

        private void textBox17_TextChanged(object sender, EventArgs e)
        { }

        private void button10_Click(object sender, EventArgs e)
        {
            readOnlyProyectoTextBoxes(false);
            readOnlyEstadoPagoTextBoxes(false);
            menuAddUpdateProyecto(true);
            actualizandoPro = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM EstadoPago WHERE pro_idProyecto = " +
                proyectos[currentProyectoIndex].id; ;
            MySqlCommand commandDatabase = new MySqlCommand(query, Program.databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                commandDatabase.ExecuteNonQuery();
                query = "DELETE FROM Proyecto WHERE pro_idProyecto = " +
                proyectos[currentProyectoIndex].id;
                commandDatabase = new MySqlCommand(query, Program.databaseConnection);
                commandDatabase.CommandTimeout = 60;
                try
                {
                    commandDatabase.ExecuteNonQuery();
                    MessageBox.Show("Borrado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            upd_proyectos();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.Text == "Cliente +")
            {
                esconderProyecto();
            }
            else
            {
                esconderCliente();
            }
        }
        private void esconderCliente()
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            button13.Text = "Cliente +";
            button14.Text = "Proyecto -";
            button14.Location = new System.Drawing.Point(12, 73);
            groupBox2.Location = new System.Drawing.Point(14, 73);
        }
        private void esconderProyecto()
        {
            groupBox2.Visible = false;
            groupBox1.Visible = true;
            button13.Text = "Cliente -";
            button14.Text = "Proyecto +";
            button14.Location = new System.Drawing.Point(12, 248);
            groupBox2.Location = new System.Drawing.Point(14, 248);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (button13.Text == "Cliente +")
            {
                esconderProyecto();
            }
            else
            {
                esconderCliente();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyCode.ToString());
            if (!agregando && !agregandoPro && !actualizando && !actualizandoPro)
            {
                if (e.KeyCode == Keys.Left)
                {
                    if (currentClientIndex - 1 < 0 || !clientsExist)
                        MessageBox.Show("No puede retroceder mas :O");
                    else
                    {
                        currentClientIndex--;
                        setClienteValue(currentClientIndex);
                        upd_proyectos();
                    }
                }
                else if (e.KeyCode == Keys.Right)
                {
                    if (currentClientIndex + 1 >= clientes.Count || !clientsExist)
                        MessageBox.Show("No puede avanzar mas :O");
                    else
                    {
                        currentClientIndex++;
                        setClienteValue(currentClientIndex);
                        upd_proyectos();
                    }
                }
            }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int ind = comboBox2.SelectedIndex;
            if (ind == 0)
            {
                textBox19.Visible = false;
                textBox21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                textBox12.Visible = true;
                label21.Visible = true;
            }
            else if (ind == 1 || ind == 2)
            {
                textBox19.Visible = true;
                textBox21.Visible = true;
                label22.Visible = true;
                label23.Visible = true;
                textBox12.Visible = false;
                label21.Visible = false;
            }
            else
            {
                textBox19.Visible = false;
                textBox21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                textBox12.Visible = false;
                label21.Visible = false;
            }
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            upd_proyectos();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
