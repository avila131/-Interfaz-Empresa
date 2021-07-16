using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form11 : Form
    {
        public MySqlDataReader reader;
        public string Perforacion_ID, Muestra_ID, tipoEnsayo_ID, ensayoMuestra_ID, Proyecto_ID;


        private void MostrarDatosActualizadosEnPantalla()
        {
            txtNombreProyectoSeleccionado.Text = Program.obtenerNombreProyectoDadoID(Proyecto_ID);
            txtNombrePerforacionSeleccionada.Text = Program.obtenerNombrePerforacionDadoID(Perforacion_ID);
            txtNumeroMuestraSeleccionada.Text = Program.obtenerNumeroMuestraDadoID(Muestra_ID);
            txtTipoEnsayoSeleccionado.Text = Program.obtenerNombreTipoEnsayoDadoID(tipoEnsayo_ID);
            txtEstadoEnsayoMuestraSeleccionado.Text = Program.obtenerEstadoEnsayoMuestraDadoID(ensayoMuestra_ID);
            Program.quitarValoresNulosCajasDeTextoEnFormularioCompleto(this);
        }


        private void btnSiguientePerforacion_Click(object sender, EventArgs e)
        {
            string query = "select per_idPerforacion from perforacion where per_idPerforacion = (select min(per_idPerforacion) from perforacion where per_idPerforacion > " + Perforacion_ID + " AND pro_idProyecto =" + Proyecto_ID + ");";  // Obtener id siguiente perforación
            if (Program.ExecuteScalarReader(query) == "NULL")  // Se sale de los límites
                return;
            Perforacion_ID = Program.ExecuteScalarReader(query);

            actualizar_ID_Muestra();
            actualizar_ID_TipoEnsayo();
            actualizar_ID_EnsayoMuestra();

            query = "SELECT per_nombrePerforacion FROM perforacion WHERE per_idPerforacion = " + Perforacion_ID + ";";
            MostrarDatosActualizadosEnPantalla();
        }


        private void btnAnteriorPerforacion_Click(object sender, EventArgs e)
        {
            string query = "select per_idPerforacion from perforacion where per_idPerforacion = (select max(per_idPerforacion) from perforacion where per_idPerforacion < " + Perforacion_ID + " AND pro_idProyecto =" + Proyecto_ID + ");";  // Obtener id anterior perforación
            if (Program.ExecuteScalarReader(query) == "NULL")
                return;
            Perforacion_ID = Program.ExecuteScalarReader(query);
            actualizar_ID_Muestra();
            actualizar_ID_TipoEnsayo();
            actualizar_ID_EnsayoMuestra();
            MostrarDatosActualizadosEnPantalla();
        }


        private void btnAnteriorMuestra_Click(object sender, EventArgs e)
        {
            string query = "select mue_idMuestra from muestra where mue_idMuestra = (select max(mue_idMuestra) from muestra where mue_idMuestra < " + Muestra_ID + " AND per_idPerforacion = " + Proyecto_ID + ");";
            if (Program.ExecuteScalarReader(query) == "NULL")  // Se sale de los límites
                return;
            Muestra_ID = Program.ExecuteScalarReader(query);
            actualizar_ID_TipoEnsayo();
            actualizar_ID_EnsayoMuestra();
            MostrarDatosActualizadosEnPantalla();
        }


        private void btnSiguienteMuestra_Click(object sender, EventArgs e)
        {
            string query = "select mue_idMuestra from muestra where mue_idMuestra = (select min(mue_idMuestra) from muestra where mue_idMuestra > " + Muestra_ID + ");";
            if (Program.ExecuteScalarReader(query) == "NULL")  // Se sale de los límites
                return;
            Muestra_ID = Program.ExecuteScalarReader(query);
            actualizar_ID_TipoEnsayo();
            actualizar_ID_EnsayoMuestra();

            MostrarDatosActualizadosEnPantalla();
        }


        private void actualizar_ID_Muestra()
        {
            string query = "SELECT mue_idMuestra FROM muestra WHERE per_idPerforacion = " + Perforacion_ID + " ORDER BY mue_idMuestra LIMIT 1;";
            Muestra_ID = Program.ExecuteScalarReader(query);
        }


        private void actualizar_ID_EnsayoMuestra()
        {
            string query = "SELECT ens_idEnsayoMuestra FROM ensayomuestra WHERE mue_idMuestra = " + Muestra_ID + " ORDER BY ens_idEnsayoMuestra LIMIT 1;";
            ensayoMuestra_ID = Program.ExecuteScalarReader(query);
        }



        private void btnSiguienteEnsayo_Click(object sender, EventArgs e)
        {
            string query = "select tip_idTipoEnsayo from tipoensayo NATURAL JOIN ensayomuestra where tip_idTipoEnsayo = (select min(tip_idTipoEnsayo) from tipoensayo where tip_idTipoEnsayo > " + tipoEnsayo_ID + ") AND mue_idMuestra = " + Muestra_ID + ";";
            if (Program.ExecuteScalarReader(query) == "NULL")  // Se sale de los límites
                return;
            tipoEnsayo_ID = Program.ExecuteScalarReader(query);
            MostrarDatosActualizadosEnPantalla();
        }

        private void btnMostrarDetalles_Click(object sender, EventArgs e)
        {
            Form12 formularioDetalles = new Form12(Proyecto_ID, Perforacion_ID, Muestra_ID, ensayoMuestra_ID, tipoEnsayo_ID, "Leer");
            this.Hide();
            formularioDetalles.Show();
        }

        private void btnActualizaEnsayoMuestra_Click(object sender, EventArgs e)
        {
            Form12 formularioActualizar = new Form12(Proyecto_ID, Perforacion_ID, Muestra_ID, ensayoMuestra_ID, tipoEnsayo_ID, "Actualizar");
            this.Hide();
            formularioActualizar.Show();
        }

        private void btnAgregarSinRealizar_Click(object sender, EventArgs e)
        {
            Form12 formularioAgregarSinRealizar = new Form12(Proyecto_ID, Perforacion_ID, Muestra_ID, ensayoMuestra_ID, tipoEnsayo_ID, "AgregarSinRealizar");
            this.Hide();
            formularioAgregarSinRealizar.Show();
        }

        private void btnAgregarEnsayoRealizado_Click(object sender, EventArgs e)
        {
            Form12 formularioAgregarEnsayoMuestraRealizado = new Form12(Proyecto_ID, Perforacion_ID, Muestra_ID, ensayoMuestra_ID, tipoEnsayo_ID, "Agregar");
            this.Hide();
            formularioAgregarEnsayoMuestraRealizado.Show();
        }

        private void actualizar_ID_TipoEnsayo()
        {
            string query = "SELECT tip_idTipoEnsayo FROM ensayomuestra NATURAL JOIN tipoensayo WHERE mue_idMuestra =" + Muestra_ID + " ORDER BY tip_idTipoEnsayo LIMIT 1;";
            tipoEnsayo_ID = Program.ExecuteScalarReader(query);
        }


        private void btnAnteriorEnsayo_Click(object sender, EventArgs e)
        {
            string query = "select tip_idTipoEnsayo from tipoensayo NATURAL JOIN ensayomuestra where tip_idTipoEnsayo = (select max(tip_idTipoEnsayo) from tipoensayo where tip_idTipoEnsayo < " + tipoEnsayo_ID + ") AND mue_idMuestra = " + Muestra_ID + ";";
            if (Program.ExecuteScalarReader(query) == "NULL")  // Se sale de los límites
                return;
            tipoEnsayo_ID = Program.ExecuteScalarReader(query);
            MostrarDatosActualizadosEnPantalla();
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
            actualizar_ID_EnsayoMuestra();
            InitializeComponent();
        }
    }
}