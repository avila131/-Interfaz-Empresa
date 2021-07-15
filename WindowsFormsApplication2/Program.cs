using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            return objeto;
        }

        public static MySqlCommand getNewMySqlCommand(string query)
        {
            MySqlCommand commandDatabase = new MySqlCommand(query, Program.databaseConnection);
            commandDatabase.CommandTimeout = 60;
            return commandDatabase;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form9 loginForm = new Form9();
            Application.Run(loginForm);

            if (loginForm.UserSuccessfullyAuthenticated)
            {
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
                if(MenSelection != null){
                    Application.Run(MenSelection);
                }

            }
        }
    }
}
