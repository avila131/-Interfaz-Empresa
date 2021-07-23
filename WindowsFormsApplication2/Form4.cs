using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form4 : Form
    {
        public List<Empleado> empleados = new List<Empleado>();
        public int currentEmpleadoIndex = 0;
        public MySqlDataReader reader;
        public bool actualizando, agregando;
        public string mascaraBusqueda = "", filtroBusqueda = "emp_idEmpleado";

        private void menuNormal()
        {
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            foreach (TextBox box in groupBox1.Controls.OfType<TextBox>())
                box.ReadOnly = true;
            textBox11.Text = "";
            comboBox1.SelectedIndex = -1;
            button4.Text = "Anterior";
            button3.Text = "Siguiente";
        }


        private void menuUpdate()
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            foreach (TextBox box in groupBox1.Controls.OfType<TextBox>())
                box.ReadOnly = false;  // Permitir inserción de datos
            textBox1.ReadOnly = true;  // Evita modificación de llave primaria
            button4.Text = "Cancelar";
            button3.Text = "Aceptar";
        }


        private void menuAdd()
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            foreach (TextBox box in groupBox1.Controls.OfType<TextBox>())
            {
                box.Text = "";
                box.ReadOnly = false;
            }
            button4.Text = "Cancelar";
            button3.Text = "Aceptar";
        }

        /// <summary>
        /// Rellena las cajas de texto con los datos de un empleado dado su índice.
        /// </summary>
        /// <param name="given_index">Índice en la tabla de empleadosFiltrados</param>
        private void mostrarDatosEmpleado(int given_index)
        {
            textBox1.Text = empleados[given_index].emp_idEmpleado;
            textBox2.Text = empleados[given_index].emp_nombreEmpleado;
            textBox4.Text = empleados[given_index].emp_apellidoEmpleado;
            textBox5.Text = empleados[given_index].emp_oficioEmpleado;
            textBox6.Text = empleados[given_index].emp_salario;
            textBox7.Text = empleados[given_index].emp_nombreUsuario;
            textBox8.Text = empleados[given_index].emp_nombreEPS;
            textBox9.Text = empleados[given_index].emp_nombreARL;
            textBox10.Text = empleados[given_index].emp_nombreFondoPension;
        }


        private void actualizarListaEmpleados()
        {
            empleados.Clear();  // Vaciar lista para ingresar nuevos valores
            string queryFiltrado = "SELECT * FROM Empleado WHERE " + filtroBusqueda +
                " LIKE '" + mascaraBusqueda + "%';";
            MySqlCommand commandDatabase = Program.getNewMySqlCommand(queryFiltrado);
            try
            {
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                    while (reader.Read())
                    {
                        Empleado nuevoEmpleado = new Empleado();
                        nuevoEmpleado.emp_idEmpleado = reader.GetString(0);
                        nuevoEmpleado.emp_nombreEmpleado = reader.GetString(1);
                        nuevoEmpleado.emp_apellidoEmpleado = reader.GetString(2);
                        nuevoEmpleado.emp_oficioEmpleado = reader.GetString(3);
                        nuevoEmpleado.emp_salario = reader.GetString(4);
                        nuevoEmpleado.emp_nombreUsuario = reader.GetString(5);
                        nuevoEmpleado.emp_nombreEPS = reader.GetString(6);
                        nuevoEmpleado.emp_nombreARL = reader.GetString(7);
                        nuevoEmpleado.emp_nombreFondoPension = reader.GetString(8);
                        empleados.Add(nuevoEmpleado);
                    }
                else
                {
                    MessageBox.Show("No hay registros que cumplan su criterio de búsqueda");
                    mascaraBusqueda = "";
                    filtroBusqueda = "emp_idEmpleado";
                    actualizarListaEmpleados();  // Como no se encontraron registros, regresa a los valores iniciales que sí existen
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { reader.Close(); }
        }


        /// <summary>
        /// Actualiza los atributos de un empleado tomando los valores escritos en las cajas de texto
        /// </summary>
        /// <param name="given_index">Índice en la tabla de empleados</param>
        private void actualizarDatosEmpleado(int given_index)
        {
            empleados[given_index].emp_idEmpleado = textBox1.Text;
            empleados[given_index].emp_nombreEmpleado = textBox2.Text;
            empleados[given_index].emp_apellidoEmpleado = textBox4.Text;
            empleados[given_index].emp_oficioEmpleado = textBox5.Text;
            empleados[given_index].emp_salario = textBox6.Text;
            empleados[given_index].emp_nombreUsuario = textBox7.Text;
            empleados[given_index].emp_nombreEPS = textBox8.Text;
            empleados[given_index].emp_nombreARL = textBox9.Text;
            empleados[given_index].emp_nombreFondoPension = textBox10.Text;
        }


        public Form4()
        {
            InitializeComponent();
            actualizarListaEmpleados();
            mostrarDatosEmpleado(currentEmpleadoIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (actualizando || agregando)  // Cancela la operación
            {
                menuNormal();
                actualizando = false;
                agregando = false;
            }
            else if (currentEmpleadoIndex - 1 < 0)  // Revisa límites del arreglo
                MessageBox.Show("No puede retroceder más");
            else
                mostrarDatosEmpleado(--currentEmpleadoIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (actualizando)
            {
                string query =
                    "UPDATE empleado SET emp_idEmpleado = " + Program.Evaluar(textBox1.Text, 1) + "," +
                    "emp_nombreEmpleado = " + Program.Evaluar(textBox2.Text) + "," +
                    "emp_apellidoEmpleado = " + Program.Evaluar(textBox4.Text) + "," +
                    "emp_oficioEmpleado = " + Program.Evaluar(textBox5.Text) + "," +
                    "emp_salario = " + Program.Evaluar(textBox6.Text, 1) + "," +
                    "emp_nombreUsuario = " + Program.Evaluar(textBox7.Text) + "," +
                    "emp_nombreEPS = " + Program.Evaluar(textBox8.Text) + "," +
                    "emp_nombreARL = " + Program.Evaluar(textBox9.Text) + "," +
                    "emp_nombreFondoPension = " + Program.Evaluar(textBox10.Text) + " " +
                    "WHERE emp_idEmpleado = " + empleados[currentEmpleadoIndex].emp_idEmpleado + ";";
                MySqlCommand commandDatabase = Program.getNewMySqlCommand(query);
                try
                {
                    commandDatabase.ExecuteNonQuery();
                    actualizarDatosEmpleado(currentEmpleadoIndex);
                    MessageBox.Show("Actualizado correctamente");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al actualizar: " + ex);
                }
                actualizando = false;
                actualizarListaEmpleados();
                mostrarDatosEmpleado(currentEmpleadoIndex);
                menuNormal();
            }
            else if (agregando)
            {
                string query =
                        "INSERT INTO Empleado VALUES (" + Program.Evaluar(textBox1.Text, 1) + "," +
                        Program.Evaluar(textBox2.Text) +
                        "," + Program.Evaluar(textBox4.Text) +
                        "," + Program.Evaluar(textBox5.Text) +
                        "," + Program.Evaluar(textBox6.Text) +
                        "," + Program.Evaluar(textBox7.Text) +
                        "," + Program.Evaluar(textBox8.Text) +
                        "," + Program.Evaluar(textBox9.Text) +
                        "," + Program.Evaluar(textBox10.Text) +
                        ");";
                MySqlCommand commandDatabase = Program.getNewMySqlCommand(query);
                try
                {
                    commandDatabase.ExecuteNonQuery();
                    actualizarListaEmpleados();
                    mostrarDatosEmpleado(currentEmpleadoIndex);
                    MessageBox.Show("Agregado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar: " + ex);
                }
                agregando = false;
                menuNormal();
            }
            else if (currentEmpleadoIndex + 1 >= empleados.Count)
                MessageBox.Show("No puede avanzar más");
            else
                mostrarDatosEmpleado(++currentEmpleadoIndex);
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            foreach (TextBox box in groupBox1.Controls.OfType<TextBox>())
                box.Text = "";  // Vaciar las cajas de texto para los nuevos valores filtrados
            mascaraBusqueda = textBox11.Text;
            filtroBusqueda = comboBox1.Text == "Cédula" ? "emp_idEmpleado" :
                             comboBox1.Text == "Nombre" ? "emp_nombreEmpleado" :
                             comboBox1.Text == "Apellido" ? "emp_apellidoEmpleado" :
                             comboBox1.Text == "Oficio" ? "emp_oficioEmpleado" :
                             comboBox1.Text == "Salario" ? "emp_salario" :
                             comboBox1.Text == "EPS" ? "emp_nombreEPS" :
                             comboBox1.Text == "ARL" ? "emp_nombreARL" :
                             comboBox1.Text == "Fondo de pensión" ? "emp_nombreFondoPension" :
                             comboBox1.Text == "Nombre de usuario" ? "emp_nombreUsuario" :
                             "emp_idEmpleado";
            actualizarListaEmpleados();
            mostrarDatosEmpleado(currentEmpleadoIndex);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            menuUpdate();
            actualizando = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM EMPLEADO WHERE emp_idEmpleado = " + textBox1.Text + ";";
            MySqlCommand commandDatabase = Program.getNewMySqlCommand(query);
            try
            {
                commandDatabase.ExecuteNonQuery();
                MessageBox.Show("Eliminado correctamente");
                if (currentEmpleadoIndex == empleados.Count - 1)
                    currentEmpleadoIndex--;
                actualizarListaEmpleados();
                mostrarDatosEmpleado(currentEmpleadoIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            menuAdd();
            agregando = true;
        }

        private void Form4_Load(object sender, EventArgs e)
        { }
    }
}