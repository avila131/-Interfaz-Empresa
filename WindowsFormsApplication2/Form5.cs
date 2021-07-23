using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.IO;

// Listened to this while coding https://www.youtube.com/watch?v=AVK0BIVqLLc

/*                                           Explicación breve del código
 * La idea es utilizar dos listas. Una para recibir la consulta inicial que hace el constructor Form5 y otra para almacenar
 * los registros filtrados por una expresión regular. En el constructor se hace que la lista de registros filtrados empiece
 * igual que la lista recibida por SELECT * FROM tipoensayo. Luego, dependiendo de la búsqueda ingresada por el usuario se
 * irán modificando las listas. Se implementa de esta forma para evitar llamar demasiadas veces la misma instrucción SELECT
 * y almacenar cada registro en un nuevo objeto(luego de algunas consultas se tendrían muchísimos objetos). De esta forma
 * el código es más óptimo. Además se manejan algunas excepciones para que el usuario vea errores comprensibles cuando no
 * se puede ejecutar alguna instrucción del código. 
 * Las búsquedas se manejan con expresiones regulares.
 * */


namespace WindowsFormsApplication2
{
    public partial class Form5 : Form
    {
        public List<TipoEnsayo> tiposEnsayo = new List<TipoEnsayo>();
        public List<TipoEnsayo> tiposEnsayoFiltrados = new List<TipoEnsayo>();
        public int currentTipoEnsayoIndex = 0;
        public MySqlDataReader reader;
        public bool actualizando, agregando;

        /// <summary>
        /// Prepara el formato de un objeto para ser ingresado en una consulta de MySQL.
        /// </summary>
        /// <param name="objeto">Cadena recibida para ingresar a la consulta</param>
        /// <param name="tipo">0 si es cadena o fecha. 1 si es un número.</param>
        /// <returns></returns>
        private String Evaluar(String objeto, int tipo = 0)
        {
            if (objeto == null || objeto == "")
                return "NULL";
            if (tipo == 0)
                return "'" + objeto + "'";
            return objeto;
        }

        public Form5()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Imagenes\\logoEmpresa.png"));
            groupBox2.Show();
            if (Program.rolActual == "empleadoLaboratorista")
            {
                groupBox2.Visible = false;
            }
            string query = "SELECT * FROM tipoEnsayo";
            MySqlCommand commandDatabase = new MySqlCommand(query, Program.databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        TipoEnsayo nuevoTipoEnsayo = new TipoEnsayo();
                        nuevoTipoEnsayo.tip_idTipoEnsayo = !reader.IsDBNull(0) ? reader.GetString(0) : "";
                        nuevoTipoEnsayo.tip_nombreTipoEnsayo = !reader.IsDBNull(1) ? reader.GetString(1) : "";
                        tiposEnsayo.Add(nuevoTipoEnsayo);
                    }
                    textBox1.Text = tiposEnsayo[0].tip_nombreTipoEnsayo;

                    // Inicializa la lista filtrada como una referencia
                    foreach (var objeto in tiposEnsayo)
                        tiposEnsayoFiltrados.Add(objeto);  // Shallow copy
                }
                else
                {
                    reader.Close();
                    Console.WriteLine("No se encontraron datos.");
                }
            }
            catch (Exception ex)
            {
                if (reader != null) reader.Close();
                MessageBox.Show(ex.Message);
            }
            reader.Close();
            menuNormal();
        }

        /// <summary>
        /// Distribución gráfica a la hora de actualizar un registro
        /// </summary>
        private void menuUpdate()
        {
            button4.Text = "Cancelar";
            button3.Text = "Aceptar";
            textBox11.ReadOnly = true;
            /*button10.Visible = false;
            button9.Visible = false;
            button11.Visible = false;*/
            textBox1.ReadOnly = false;
            groupBox2.Visible = false;
            btnBuscar.Enabled = false;

        }

        /// <summary>
        /// Distribución gráfica normal de los registros, donde no hay operaciones de 
        /// agregar o eliminar en ejecución.
        /// </summary>
        private void menuNormal()
        {
            /*button10.Visible = true;*/
            textBox11.ReadOnly = false;
            textBox1.ReadOnly = true;
            /*button9.Visible = true;
            button11.Visible = true;*/
            if (Program.rolActual != "empleadoLaboratorista")
            {
                groupBox2.Visible = true;
            }
            btnBuscar.Enabled = true;
            button4.Text = "Anterior";
            button3.Text = "Siguiente";
            textBox1.Text = tiposEnsayoFiltrados[currentTipoEnsayoIndex].tip_nombreTipoEnsayo;
        }
        /// <summary>
        /// Distribución gráfica a la hora de agregar un registro
        /// </summary>
        private void menuAdd()
        {
            menuUpdate();
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (actualizando || agregando)  // Cancela la operación
            {
                menuNormal();
                actualizando = false;
                agregando = false;
            }
            else if (currentTipoEnsayoIndex - 1 < 0)  // Revisa límites del arreglo
                MessageBox.Show("No puede retroceder más :O");
            else
            {
                currentTipoEnsayoIndex--;  // Seleccionar el tipo de ensayo anterior
                textBox1.Text = tiposEnsayoFiltrados[currentTipoEnsayoIndex].tip_nombreTipoEnsayo;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (actualizando)
            {
                if (tiposEnsayo.Count <= 0)
                {
                    MessageBox.Show("No existe algún tipo de ensayo para actualizar");
                    return;
                }
                DialogResult ds = MessageBox.Show("¿Desea actualizar el tipo de ensayo?",
                    "Importante", MessageBoxButtons.YesNo);
                if (ds != DialogResult.Yes) return;
                string query = "UPDATE tipoensayo SET tip_nombreTipoEnsayo = " + Evaluar(textBox1.Text) +
                    " WHERE tip_idTipoEnsayo = " + tiposEnsayoFiltrados[currentTipoEnsayoIndex].tip_idTipoEnsayo + " ;";
                MySqlCommand commandDatabase = new MySqlCommand(query, Program.databaseConnection);
                commandDatabase.CommandTimeout = 60;
                try
                {
                    commandDatabase.ExecuteNonQuery();
                    MessageBox.Show("Actualizado correctamente");

                    // Actualizar lista tiposEnsayo
                    // Al hacer esto también se actualiza la lista de referencia
                    tiposEnsayoFiltrados[currentTipoEnsayoIndex].tip_nombreTipoEnsayo = textBox1.Text;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al actualizar: " + ex);
                }
                actualizando = false;
                menuNormal();
            }
            else if (agregando)
            {
                DialogResult ds = MessageBox.Show("¿Desea agregar el tipo de ensayo?",
                    "Importante", MessageBoxButtons.YesNo);
                if (ds != DialogResult.Yes) return;
                string query = "INSERT INTO tipoensayo(tip_nombreTipoEnsayo) VALUES(" + Evaluar(textBox1.Text) + ");";
                MySqlCommand commandDatabase = new MySqlCommand(query, Program.databaseConnection);
                commandDatabase.CommandTimeout = 60;
                try
                {
                    commandDatabase.ExecuteNonQuery();
                    MessageBox.Show("Agregado correctamente");
                    TipoEnsayo nuevoTipoEnsayo = new TipoEnsayo();
                    nuevoTipoEnsayo.tip_idTipoEnsayo = tiposEnsayo.Count.ToString();
                    nuevoTipoEnsayo.tip_nombreTipoEnsayo = textBox1.Text;
                    // Agregarlo a la lista de filtrado si se ajusta a la expresión regular
                    Regex rgx = new Regex("^" + textBox11.Text);
                    if (rgx.IsMatch(textBox1.Text))
                        tiposEnsayoFiltrados.Add(nuevoTipoEnsayo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar: " + ex);
                }
                agregando = false;
                menuNormal();
            }
            else if (currentTipoEnsayoIndex + 1 >= tiposEnsayoFiltrados.Count)
                MessageBox.Show("No puede avanzar más :O");
            else
            {
                currentTipoEnsayoIndex++;  // Seleccionar el tipo de ensayo siguiente
                textBox1.Text = tiposEnsayoFiltrados[currentTipoEnsayoIndex].tip_nombreTipoEnsayo;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            agregando = true;
            menuAdd();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tiposEnsayo.Count <= 0)
            {
                MessageBox.Show("No existe algún tipo de ensayo para borrar");
                return;
            }
            DialogResult ds = MessageBox.Show("¿Desea borrar el tipo de ensayo?",
                    "Importante", MessageBoxButtons.YesNo);
            if (ds != DialogResult.Yes) return;
            
            string query = "DELETE FROM tipoensayo WHERE tip_idTipoEnsayo = " +
                tiposEnsayoFiltrados[currentTipoEnsayoIndex].tip_idTipoEnsayo + ";";
            MySqlCommand commandDatabase = new MySqlCommand(query, Program.databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                commandDatabase.ExecuteNonQuery();
                MessageBox.Show("Eliminado correctamente");
                //  Actualizar lista tiposEnsayo
                int id_paraEliminar = Int32.Parse(tiposEnsayoFiltrados[currentTipoEnsayoIndex].tip_idTipoEnsayo);
                tiposEnsayoFiltrados.RemoveAt(currentTipoEnsayoIndex);
                // Eliminar objeto tipo de ensayo en la lista base
                tiposEnsayo.RemoveAll(tipoEnsayo => Int32.Parse(tipoEnsayo.tip_idTipoEnsayo) == id_paraEliminar);

                // Mueve el índice si se borra el primer o último registro.
                if (currentTipoEnsayoIndex == 0)
                    currentTipoEnsayoIndex++;
                if (currentTipoEnsayoIndex == tiposEnsayoFiltrados.Count)
                    currentTipoEnsayoIndex--;
                menuNormal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Regex rgx = new Regex("^" + textBox11.Text.ToUpper());  // Regex: Que empiecen por el texto ingresado
            tiposEnsayoFiltrados.Clear();

            // Añade los tipos de ensayo que empiezan por el texto ingresado
            foreach (var tipoEnsayo in tiposEnsayo)
                if (rgx.IsMatch(tipoEnsayo.tip_nombreTipoEnsayo.ToUpper()))
                    tiposEnsayoFiltrados.Add(tipoEnsayo);
            currentTipoEnsayoIndex = 0;
            try
            {
                textBox1.Text = tiposEnsayoFiltrados[currentTipoEnsayoIndex].tip_nombreTipoEnsayo;
            }
            catch (ArgumentOutOfRangeException)  // No se encuentran registros que coincidan con la expresión regular
            {
                MessageBox.Show("No hay tipos de ensayo que coincidan con el nombre " + textBox11.Text);
                // Inicializa la lista filtrada como una referencia
                foreach (var objeto in tiposEnsayo)
                    tiposEnsayoFiltrados.Add(objeto);  // Shallow copy
                textBox11.Text = "";  // Limpia el texto ingresado que no tiene coincidencias
                menuNormal();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            actualizando = true;
            menuUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.GuardarCambios();
        }
    }
}
