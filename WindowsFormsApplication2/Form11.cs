using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form11 : Form
    {
        public MySqlDataReader reader;

        public string Perforacion_ID, Muestra_ID,
            tipoEnsayo_ID, ensayoMuestra_ID,
            Proyecto_ID;


        private void MostrarDatosActualizadosEnPantalla()
        {
            txtNombreProyectoSeleccionado.Text = obtenerNombreProyectoActual();
            txtNombrePerforacionSeleccionada.Text = obtenerNombrePerforacionActual();
            txtNumeroMuestraSeleccionada.Text = obtenerNumeroMuestraActual();
            txtTipoEnsayoSeleccionado.Text = obtenerNombreTipoEnsayoActual();
            txtEstadoEnsayoMuestraSeleccionado.Text = obtenerEstadoEnsayoMuestraActual();
        }



        private string obtenerNombreProyectoActual()
        {
            string query = "SELECT NombreProyecto FROM vw_idProyecto_nombreProyecto_estadoProyecto WHERE ID = " + Proyecto_ID + ";";
            return ExecuteScalarReader(query);
        }


        private void btnSiguientePerforacion_Click(object sender, EventArgs e)
        {
            string query = "select per_idPerforacion from perforacion where per_idPerforacion = (select min(per_idPerforacion) from perforacion where per_idPerforacion > " + Perforacion_ID + " AND pro_idProyecto =" + Proyecto_ID + ");";  // Obtener id siguiente perforación
            if (ExecuteScalarReader(query) == "-1")  // Se sale de los límites
                return;
            Perforacion_ID = ExecuteScalarReader(query);

            actualizar_ID_Muestra();
            actualizar_ID_TipoEnsayo();

            query = "SELECT per_nombrePerforacion FROM perforacion WHERE per_idPerforacion = " + Perforacion_ID + ";";
            MostrarDatosActualizadosEnPantalla();
        }

        private string ExecuteScalarReader(string given_query)
        {
            MySqlCommand command = Program.getNewMySqlCommand(given_query);
            try
            { return command.ExecuteScalar().ToString(); }
            catch
            { return "-1"; }
        }

        private string obtenerNombrePerforacionActual()
        {
            string query = "SELECT per_nombrePerforacion FROM perforacion WHERE per_idPerforacion = "+ Perforacion_ID + ";";
            string nombreObtenido = ExecuteScalarReader(query);
            return nombreObtenido != "-1" ? nombreObtenido : "";
        }

        private string obtenerNombreTipoEnsayoActual()
        {
            string query = "SELECT tip_nombreTipoEnsayo FROM tipoensayo WHERE tip_idTipoEnsayo = " + tipoEnsayo_ID + ";";
            string nombreObtenido = ExecuteScalarReader(query);
            return nombreObtenido != "-1" ? nombreObtenido : "";
        }

        private void btnAnteriorPerforacion_Click(object sender, EventArgs e)
        {
            string query = "select per_idPerforacion from perforacion where per_idPerforacion = (select max(per_idPerforacion) from perforacion where per_idPerforacion < " + Perforacion_ID + " AND pro_idProyecto =" + Proyecto_ID + ");";  // Obtener id anterior perforación
            if (ExecuteScalarReader(query) == "-1")
                return;
            Perforacion_ID = ExecuteScalarReader(query);

            actualizar_ID_Muestra();
            actualizar_ID_TipoEnsayo();

            MostrarDatosActualizadosEnPantalla();
        }

        private void btnAnteriorMuestra_Click(object sender, EventArgs e)
        {
            string query = "select mue_idMuestra from muestra where mue_idMuestra = (select max(mue_idMuestra) from muestra where mue_idMuestra < " + Muestra_ID + " AND per_idPerforacion = " + Proyecto_ID + ");";
            if (ExecuteScalarReader(query) == "-1")  // Se sale de los límites
                return;

            Muestra_ID = ExecuteScalarReader(query);
            actualizar_ID_TipoEnsayo();

            MostrarDatosActualizadosEnPantalla();
        }

        private void btnSiguienteMuestra_Click(object sender, EventArgs e)
        {
            string query = "select mue_idMuestra from muestra where mue_idMuestra = (select min(mue_idMuestra) from muestra where mue_idMuestra > " + Muestra_ID + ");";
            if (ExecuteScalarReader(query) == "-1")  // Se sale de los límites
                return;
            Muestra_ID = ExecuteScalarReader(query);
            actualizar_ID_TipoEnsayo();

            MostrarDatosActualizadosEnPantalla();
        }

        private void actualizar_ID_Muestra()
        {
            string query = "SELECT mue_idMuestra FROM muestra WHERE per_idPerforacion = " + Perforacion_ID + " ORDER BY mue_idMuestra LIMIT 1;";
            MySqlCommand command = Program.getNewMySqlCommand(query);
            try
            { Muestra_ID = command.ExecuteScalar().ToString(); }
            catch (NullReferenceException)
            { Muestra_ID = "-1"; }
        }

        private void actualizar_ID_EnsayoMuestra()
        {
            string query = "SELECT ens_idEnsayoMuestra FROM ensayomuestra WHERE mue_idMuestra = " + Muestra_ID + " ORDER BY ens_idEnsayoMuestra LIMIT 1;";
            MySqlCommand command = Program.getNewMySqlCommand(query);
            try
            { ensayoMuestra_ID = command.ExecuteScalar().ToString(); }
            catch (NullReferenceException)
            { ensayoMuestra_ID = "-1"; }
        }


        private void btnSiguienteEnsayo_Click(object sender, EventArgs e)
        {
            string query = "select tip_idTipoEnsayo from tipoensayo NATURAL JOIN ensayomuestra where tip_idTipoEnsayo = (select min(tip_idTipoEnsayo) from tipoensayo where tip_idTipoEnsayo > " + tipoEnsayo_ID + ") AND mue_idMuestra = " + Muestra_ID + ";";
            if (ExecuteScalarReader(query) == "-1")  // Se sale de los límites
                return;
            tipoEnsayo_ID = ExecuteScalarReader(query);
            MostrarDatosActualizadosEnPantalla();
        }

        private void actualizar_ID_TipoEnsayo()
        {
            string query = "SELECT tip_idTipoEnsayo FROM ensayomuestra NATURAL JOIN tipoensayo WHERE mue_idMuestra =" + Muestra_ID + " ORDER BY tip_idTipoEnsayo LIMIT 1;";
            MySqlCommand command = Program.getNewMySqlCommand(query);
            try
            { tipoEnsayo_ID = command.ExecuteScalar().ToString(); }
            catch (NullReferenceException)
            { tipoEnsayo_ID = "-1"; }
        }

        private string obtenerNumeroMuestraActual()
        {   
            string query = "SELECT mue_numeroMuestra FROM muestra WHERE mue_idMuestra = " + Muestra_ID + ";";
            string nombreObtenido = ExecuteScalarReader(query);
            return nombreObtenido != "-1" ? nombreObtenido : "";
        }

        private string obtenerEstadoEnsayoMuestraActual()
        {
            string query = "select ens_estado FROM ensayomuestra WHERE ens_idEnsayoMuestra = " + ensayoMuestra_ID +";";
            string nombreObtenido = ExecuteScalarReader(query);
            return nombreObtenido != "-1" ? nombreObtenido : "";
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            MostrarDatosActualizadosEnPantalla();
        }

        public Form11(string given_muestra_ID, string given_perforacion_ID, string given_proyecto_ID)
        {
            Muestra_ID = given_muestra_ID;
            Perforacion_ID = given_perforacion_ID;
            Proyecto_ID = given_proyecto_ID;
            actualizar_ID_TipoEnsayo();
            actualizar_ID_Muestra();
            actualizar_ID_EnsayoMuestra();
            InitializeComponent();
        }
    }
}