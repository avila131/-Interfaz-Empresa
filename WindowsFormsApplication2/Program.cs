using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

public class Cliente
{
    public String NIT { get; set; }
    public String razonSocial { get; set; }
    public String telefono { get; set; }
    public String sede { get; set; }
    public String ccc { get; set; }
    public String nContacto { get; set; }
    public String aContacto { get; set; }
    public String eContacto { get; set; }
}
public class Proyecto
{
    public String id { get; set; }
    public String cantidadEnsayos { get; set; }
    public String valorTotal { get; set; }
    public String nombre { get; set; }
    public String fechaInicio { get; set; }
    public String fechaFin { get; set; }
    public String NIT { get; set; }
    public String valorAbonado { get; set; }
    public String fechaAbono { get; set; }
    public String fechaPagoTotal { get; set; }
}
public class TipoEnsayo
{
    public String tip_idTipoEnsayo { get; set; }
    public String tip_nombreTipoEnsayo { get; set; }
}

public class Empleado
{
    public String emp_idEmpleado { get; set; }
    public String emp_nombreEmpleado { get; set; }
    public String emp_apellidoEmpleado { get; set; }
    public String emp_oficioEmpleado { get; set; }
    public String emp_salario { get; set; }
    public String emp_nombreUsuario { get; set; }
    public String emp_nombreEPS { get; set; }
    public String emp_nombreARL { get; set; }
    public String emp_nombreFondoPension { get; set; }
}

public class EnsayoMuestra
{
    public String ens_idEnsayoMuestra { get; set; }
    public String ens_fechaEnsayoMuestra { get; set; }
    public String ens_hayResiduo { get; set; }
    public String ens_condicionesParticularesEstudio { get; set; }
    public String emp_idEmpleado { get; set; }
    public String mue_idMuestra { get; set; }
    public String tip_idTipoEnsayo { get; set; }
    public String ens_estado { get; set; }
    //Auxiliares
    public String tip_nombreTipoEnsayo { get; set; }
    public String mue_numeroMuestra { get; set; }
}


public class Muestra
{
    public String mue_idMuestra { get; set; }
    public String mue_numeroMuestra { get; set; }
    public String mue_condicionEmpaque { get; set; }
    public String mue_tipoMuestra { get; set; }
    public String mue_ubicacionBodega { get; set; }
    public String mue_tipoExploracion { get; set; }
    public String mue_descripcionMuestra { get; set; }
    public String per_idPerforacion { get; set; }
    public String mue_profundidad { get; set; }
}


public class Perforacion
{
    public String per_idPerforacion { get; set; }
    public String per_nombrePerforacion { get; set; }
    public String per_localizacion { get; set; }
    public String per_latitud { get; set; }
    public String per_longitud { get; set; }
    public String pro_idProyecto { get; set; }
}


public class ArchivoResultado
{
    public String ens_idEnsayoMuestra { get; set; }
    public String ens_rutaArchivo { get; set; }
    public String pro_idProyecto { get; set; }
}

public class InformeFinal
{
    public String inf_fechaRemisionInforme { get; set; }
    public String inf_observacionesInforme { get; set; }
    public String pro_idProyecto { get; set; }
    public String inf_rutaInformeFinal { get; set; }
}


public class EstadoPago
{
    public String pro_idProyecto { get; set; }
    public String esp_valorAbonado { get; set; }
    public String esp_fechaAbono { get; set; }
    public String esp_fechaPagoTotal { get; set; }
}


public class ComboboxItem
{
    public string Text { get; set; }
    public int Value { get; set; }
    public override string ToString()
    {
        return this.Text;
    }

}
namespace WindowsFormsApplication2
{
    static class Program
    {
        public static Form MenSelection = null;
        public static MySqlConnection databaseConnection;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>

        public static String Evaluar(String objeto, int tipo = 0)
        {
            /*
             * Tipo 0 = cadena = fecha
             * Tipo 1 = entero
             * Tipo 2 = ruta de archivo
             * Tipo 3 = cadena estilo LIKE %*%
             * */
            if ((objeto == null || objeto == "") && tipo != 3) //Si es like debe quedarse como ""
                return "NULL";
            if (tipo == 0)
                return "'" + objeto + "'";
            if (tipo == 2)
                return "'" + objeto.Replace("\\", "\\\\") + "'";
            if (tipo == 3)
                return "'%" + objeto + "%'";
            objeto = objeto.Replace(",", "."); //Para evitar problemas con decimales
            return objeto;
        }

        public static MySqlCommand getNewMySqlCommand(string query)
        {
            MySqlCommand commandDatabase = new MySqlCommand(query, Program.databaseConnection);
            commandDatabase.CommandTimeout = 60;
            return commandDatabase;
        }
        public static string ExecuteScalarReader(string given_query)
        {
            MySqlCommand command = Program.getNewMySqlCommand(given_query);
            try
            { return command.ExecuteScalar().ToString(); }
            catch
            { return "NULL"; }
        }


        public static string obtenerNumeroMuestraDadoID(string muestra_id_dado)
        {
            string query = "SELECT mue_numeroMuestra FROM muestra WHERE mue_idMuestra = " + muestra_id_dado + ";";
            return Program.ExecuteScalarReader(query);
        }


        public static string obtenerNombreProyectoDadoID(string proyecto_id_dado)
        {
            string query = "SELECT NombreProyecto FROM vw_idProyecto_nombreProyecto_estadoProyecto WHERE ID = " + proyecto_id_dado + ";";
            return Program.ExecuteScalarReader(query);
        }


        public static string obtenerNombrePerforacionDadoID(string perforacion_id_dado)
        {
            string query = "SELECT per_nombrePerforacion FROM perforacion WHERE per_idPerforacion = " + perforacion_id_dado + ";";
            return Program.ExecuteScalarReader(query);
        }


        public static string obtenerNombreTipoEnsayoDadoID(string tipoEnsayo_id_dado)
        {
            string query = "SELECT tip_nombreTipoEnsayo FROM tipoensayo WHERE tip_idTipoEnsayo = " + tipoEnsayo_id_dado + ";";
            return Program.ExecuteScalarReader(query);
        }


        public static string obtenerIDTipoEnsayoDadoNombre(string nombreTipoEnsayo)
        {
            string query = "SELECT tip_idTipoEnsayo FROM tipoensayo WHERE tip_nombreTipoEnsayo = '" + nombreTipoEnsayo + "';";
            return Program.ExecuteScalarReader(query);
        }


        public static string obtenerEstadoEnsayoMuestraDadoID(string ensayoMuestra_id_dado)
        {
            string query = "select ens_estado FROM ensayomuestra WHERE ens_idEnsayoMuestra = " + ensayoMuestra_id_dado + ";";
            string jose = Program.ExecuteScalarReader(query);
            return Program.ExecuteScalarReader(query);
        }


        public static string obtenerDateTimeFechaEjecucion(string ensayoMuestra_id_dado)
        {
            string query = "SELECT ens_fechaEnsayoMuestra FROM ensayoMuestra WHERE ens_idEnsayoMuestra = " + ensayoMuestra_id_dado + ";";
            return ExecuteScalarReader(query);
        }


        public static string obtenerNombreEjecutorEnsayoMuestra(string ensayoMuestra_id_dado)
        {
            string idEjecutor = obtenerID_EjecutorEnsayoMuestra(ensayoMuestra_id_dado);
            return obtenerNombreEmpleadoDadoID(idEjecutor);
        }


        public static string hayResiduoMuestra(string ensayoMuestra_id_dado)
        {
            string query = "SELECT ens_hayResiduo FROM ensayomuestra WHERE ens_idEnsayoMuestra = " + ensayoMuestra_id_dado + ";";
            return ExecuteScalarReader(query) == "SI" ? "1" : "2";  // por el enum declarado en mysql
        }


        public static string obtenerCondicionesParticularesEnsayoMuestra(string ensayoMuestra_id_dado)
        {
            string query = "SELECT ens_condicionesParticulares FROM ensayomuestra WHERE ens_idEnsayoMuestra = " + ensayoMuestra_id_dado + ";";
            return ExecuteScalarReader(query);
        }


        public static string obtenerNombreEmpleadoDadoID(string empleado_id)
        {
            string query = "SELECT nombre FROM vw_nombreEmpleado_vs_idEmpleado WHERE id = " + empleado_id + ";";
            return ExecuteScalarReader(query);
        }

        public static string obtenerID_EjecutorEnsayoMuestra(string ensayoMuestra_id_dado)
        {
            string query = "SELECT Ejecutor FROM vw_ejecutorEnsayoMuestra WHERE ensayoMuestra_id = " + ensayoMuestra_id_dado + ";";
            return ExecuteScalarReader(query);
        }


        public static string obtenerEstadoEnsayoDadoID(string ensayoMuestra_id_dado)
        {
            string query = "SELECT ens_estado FROM ensayomuestra WHERE ens_idEnsayoMuestra = " + ensayoMuestra_id_dado + ";";
            return ExecuteScalarReader(query);
        }

        public static string obtenerIDEmpleadoDadoNombreUsuario(string nombreUsuario)
        {
            string query = "SELECT emp_idEmpleado FROM vw_idEmpleado_vs_nombreUsuario WHERE emp_nombreUsuario = '"
                + nombreUsuario + "';";
            return ExecuteScalarReader(query);
        }


        public static IList<T> GetAllControls<T>(Control control) where T : Control
        {
            var lst = new List<T>();
            foreach (Control item in control.Controls)
            {
                var ctr = item as T;
                if (ctr != null)
                    lst.Add(ctr);
                else
                    lst.AddRange(GetAllControls<T>(item));
            }
            return lst;
        }


        public static void quitarValoresNulosCajasDeTextoEnFormularioCompleto(Form FormularioRecibido)
        {
            var allTextBoxes = GetAllControls<TextBox>(FormularioRecibido);
            foreach (TextBox box in allTextBoxes)
                if (box.Text == "NULL")
                    box.Text = "Sin valor para mostrar";
        }

        public static void GuardarCambios()
        {
            string query = "COMMIT";
            MySqlCommand nuevo = getNewMySqlCommand(query);
            try
            {
                nuevo.ExecuteNonQuery();
                MessageBox.Show("Guardado correctamente");
                query = "START TRANSACTION";
                nuevo = getNewMySqlCommand(query);
                try
                {
                    nuevo.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static string rolActual, idEmpleadoRegistrado, nombreUsuarioActual;
        public static Boolean closed_by_user = true;
        public static Boolean loop_logueo = true;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (loop_logueo)
            {
                loop_logueo = false;
                Form9 loginForm = new Form9();
                Application.Run(loginForm);
                rolActual = loginForm.userRole;
                nombreUsuarioActual = loginForm.userName;
                idEmpleadoRegistrado = obtenerIDEmpleadoDadoNombreUsuario(nombreUsuarioActual);
                if (loginForm.UserSuccessfullyAuthenticated)
                {
                    GuardarCambios();
                    Form menuForm;
                    if (loginForm.userRole == "empleadoLaboratorista")
                    {
                        menuForm = new Form7();
                        Application.Run(menuForm);
                    }
                    else
                    {
                        menuForm = new Form8();
                        Application.Run(menuForm);
                    }

                    while (MenSelection != null)
                    {
                        closed_by_user = true;
                        Application.Run(MenSelection);
                        if (closed_by_user)
                            break;
                    }


                    DialogResult ds = MessageBox.Show("¿Desea guardar los cambios realizados?",
                        "Importante", MessageBoxButtons.YesNo);
                    string query;
                    if (ds == DialogResult.Yes)
                    {
                        query = "COMMIT";
                    }
                    else
                    {
                        query = "ROLLBACK";
                    }
                    MySqlCommand comando = getNewMySqlCommand(query);
                    try
                    {
                        comando.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al terminar transaccion: " + ex);
                    }

                }
            }
        }
    }
}
