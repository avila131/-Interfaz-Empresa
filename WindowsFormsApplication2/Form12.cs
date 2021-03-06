﻿using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form12 : Form
    {
        public string Proyecto_ID, Perforacion_ID, Muestra_ID, EnsayoMuestra_ID, Empleado_ID, TipoEnsayo_ID, accionSeleccionada;

        private void Form12_Load(object sender, EventArgs e)
        {
            txtEstadoEnsayoReadOnly.ReadOnly = true;
            foreach (TextBox box in groupBoxParametrosMuestra.Controls.OfType<TextBox>())
                box.ReadOnly = true;

            mostrarDatosEnPantalla();
            if (accionSeleccionada == "Actualizar")
                establecerPropiedadesFormularioActualizar();
            else if (accionSeleccionada == "Agregar")
                establecerPropiedadesFormularioAgregar();
            else if (accionSeleccionada == "AgregarSinRealizar")
                establecerPropiedadesFormularioAgregarSinRealizar();
            else if (accionSeleccionada == "Leer")
                menuLectura();
        }


        private void mostrarDatosEnPantalla()
        {
            txtProyecto.Text = Program.obtenerNombreProyectoDadoID(Proyecto_ID);
            txtPerforacion.Text = Program.obtenerNombrePerforacionDadoID(Perforacion_ID);
            txtMuestra.Text = Program.obtenerNumeroMuestraDadoID(Muestra_ID);
            comboBoxTipoEnsayo.Text = Program.obtenerNombreTipoEnsayoDadoID(TipoEnsayo_ID);
            comboBoxEstadoEnsayo.Text = Program.obtenerEstadoEnsayoMuestraDadoID(EnsayoMuestra_ID);
            groupBoxEnsayoMuestraRealizado.Visible = true;
            dateTimePickerFechaEjecucion.Value = Convert.ToDateTime(Program.obtenerDateTimeFechaEjecucion(EnsayoMuestra_ID));
            txtEjecutor.Text = Program.obtenerNombreEjecutorEnsayoMuestra(Empleado_ID);

            if (Program.hayResiduoMuestra(EnsayoMuestra_ID) == "1")
                radioBtnHayResiduo_SI.Checked = true;
            else
                radioBtnHayResiduo_NO.Checked = true;

            txtCondicionesParticulares.Text = Program.obtenerCondicionesParticularesEnsayoMuestra(EnsayoMuestra_ID);
            Program.quitarValoresNulosCajasDeTextoEnFormularioCompleto(this);
        }


        private void menuLectura()
        {
            foreach (TextBox box in groupBoxParametrosMuestra.Controls.OfType<TextBox>())
                box.ReadOnly = true;

            textBoxReadOnlyTipoEnsayo.Text = comboBoxTipoEnsayo.Text;
            comboBoxTipoEnsayo.Visible = false;
            textBoxReadOnlyTipoEnsayo.ReadOnly = true;

            txtEstadoEnsayoReadOnly.Text = comboBoxEstadoEnsayo.Text;
            comboBoxEstadoEnsayo.Visible = false;

            txtCondicionesParticulares.ReadOnly = true;
            radioBtnHayResiduo_NO.AutoCheck = false;
            radioBtnHayResiduo_SI.AutoCheck = false;
            txtEjecutor.ReadOnly = true;
            dateTimePickerFechaEjecucion.Enabled = false;

            btnConfirmarEnsayoMuestra.Visible = false;
            btnSeleccionarEmpleado.Visible = false;
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form11 formularioEnsayoMuestra = new Form11(Muestra_ID, Perforacion_ID, Proyecto_ID);
            this.Hide();
            formularioEnsayoMuestra.Show();
        }


        private void menuUpdateAdministrador()
        {
            comboBoxTipoEnsayo.Visible = true;
            comboBoxEstadoEnsayo.Visible = true;
            dateTimePickerFechaEjecucion.Enabled = true;
            radioBtnHayResiduo_SI.AutoCheck = true;
            radioBtnHayResiduo_NO.AutoCheck = true;
            txtCondicionesParticulares.ReadOnly = false;
            btnSeleccionarEmpleado.Visible = true;
            btnConfirmarEnsayoMuestra.Visible = true;
            txtEjecutor.ReadOnly = true;
        }


        private void menuUpdateLaboratorista()
        {
            menuUpdateAdministrador();
            textBoxReadOnlyTipoEnsayo.Text = comboBoxTipoEnsayo.Text;
            textBoxReadOnlyTipoEnsayo.ReadOnly = true;
            comboBoxTipoEnsayo.Visible = false;
            btnSeleccionarEmpleado.Visible = false;
            txtCondicionesParticulares.ReadOnly = true;
            txtEjecutor.Text = Program.nombreUsuarioActual;
        }



        private void establecerPropiedadesFormularioActualizar()
        {
            if (Program.rolActual == "Administrador")
                menuUpdateAdministrador();
            else
                menuUpdateLaboratorista();
        }


        private void establecerPropiedadesFormularioAgregar()
        {
            establecerPropiedadesFormularioActualizar();
            // Vaciar todo menos llaves foráneas
            foreach (TextBox box in this.Controls.OfType<TextBox>())
                box.Text = "";
            radioBtnHayResiduo_NO.Checked = false;
            radioBtnHayResiduo_SI.Checked = false;
            dateTimePickerFechaEjecucion.Value = DateTime.Now;
            comboBoxTipoEnsayo.Text = "";
            comboBoxEstadoEnsayo.Visible = false;
            txtEstadoEnsayoReadOnly.Text = "REALIZADO";
        }


        private void btnCambiarMuestra_Click(object sender, EventArgs e)
        {
            Form3 formularioPerforacionesMuestras = new Form3();
            this.Hide();
            formularioPerforacionesMuestras.Show();
        }


        private void establecerPropiedadesFormularioAgregarSinRealizar()
        {
            groupBoxEmpleado.Visible = false;
            groupBoxEstadoEnsayo.Visible = false;
            groupBoxFechaEjecucion.Visible = false;
            groupBoxResiduo.Visible = false;
            groupBoxCondicionesParticulares.Location = groupBoxFechaEjecucion.Location;
        }


        private void btnSeleccionarEmpleado_Click(object sender, EventArgs e)
        {
            Form13 formularioSeleccionarEmpleado = new Form13();
            formularioSeleccionarEmpleado.ShowDialog();
            Empleado_ID = formularioSeleccionarEmpleado.id_asignado;
            txtEjecutor.Text = formularioSeleccionarEmpleado.nombre_asignado;
        }


        private void btnConfirmarEnsayoMuestra_Click(object sender, EventArgs e)
        {
            if (accionSeleccionada == "Leer") return;
            string fechaSeleccionada = dateTimePickerFechaEjecucion.Value.ToString("yyyy-MM-dd");
            string hayResiduo = radioBtnHayResiduo_SI.Checked ? "1" : "2";
            string condicionesParticulares = txtCondicionesParticulares.Text == "" ? "NULL" : txtCondicionesParticulares.Text;
            string estadoEnsayo = comboBoxEstadoEnsayo.Text == "PENDIENTE" ? "1" :
                                  comboBoxEstadoEnsayo.Text == "EN CURSO" ? "2" : "3";
            string idTipoEnsayo = Program.obtenerIDTipoEnsayoDadoNombre(comboBoxTipoEnsayo.Text);

            string query = "";
            if (accionSeleccionada == "Actualizar" && Program.rolActual == "Administrador")
                query = "UPDATE ensayomuestra SET ens_fechaEnsayoMuestra = '" + fechaSeleccionada
                    + "', ens_hayResiduo = " + hayResiduo
                    + ", ens_condicionesParticularesEstudio = '" + condicionesParticulares
                    + "', emp_idEmpleado = " + Empleado_ID
                    + ", mue_idMuestra = " + Muestra_ID
                    + ", tip_idTipoEnsayo = " + idTipoEnsayo
                    + ", ens_estado = " + estadoEnsayo
                    + " WHERE ens_idEnsayoMuestra = " + EnsayoMuestra_ID + ";";

            else if (accionSeleccionada == "Actualizar" && Program.rolActual == "Laboratorista")
                query = "UPDATE vw_ensayoMuestra_laboratorista SET ens_fechaEnsayoMuestra = '" + fechaSeleccionada
                    + "', ens_hayResiduo = " + hayResiduo
                    + ", ens_estado = " + estadoEnsayo
                    + " WHERE ens_idEnsayoMuestra = " + EnsayoMuestra_ID + ";";

            else if ((accionSeleccionada == "Agregar" || accionSeleccionada == "AgregarSinRealizar") && Program.rolActual == "Administrador")
                query = "INSERT INTO ensayomuestra(ens_fechaEnsayoMuestra, ens_hayResiduo, ens_condicionesParticularesEstudio, emp_idEmpleado, mue_idMuestra, tip_idTipoEnsayo, ens_estado) VALUES( '" +
                    fechaSeleccionada + "', " + hayResiduo + ", '" + condicionesParticulares
                    + "', " + Empleado_ID + ", " + Muestra_ID + ", " + idTipoEnsayo + ", " + estadoEnsayo + ");";

            else if ((accionSeleccionada == "Agregar" || accionSeleccionada == "AgregarSinRealizar") && Program.rolActual == "Laboratorista")
                query = "INSERT INTO ensayomuestra(ens_fechaEnsayoMuestra, ens_hayResiduo, ens_estado, emp_idEmpleado, mue_idMuestra, tip_idTipoEnsayo, ens_condicionesParticularesEstudio) VALUES('" +
                    fechaSeleccionada + "', " + hayResiduo + ", " + estadoEnsayo + ", "
                    + Empleado_ID + ", " + Muestra_ID + ", " + idTipoEnsayo + ", '" + condicionesParticulares + "');";  // Se agrega Empleado_ID para saber quién hace el ensayoMuestra

            MySqlCommand command = Program.getNewMySqlCommand(query);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Operación ejecutada correctamente");
                Form11 formEnsayoMuestra = new Form11(Muestra_ID, Perforacion_ID, Proyecto_ID);
                this.Hide();
                formEnsayoMuestra.Show();
            }
            catch (Exception)
            { MessageBox.Show("Error en la ejecución de la operación"); }
        }


        public Form12(string id_proyecto, string id_perforacion, string muestra_id, string ensayoMuestra_id, string tipoEnsayo_id, string accion)
        {
            InitializeComponent();
            Proyecto_ID = id_proyecto;
            Perforacion_ID = id_perforacion;
            Muestra_ID = muestra_id;
            EnsayoMuestra_ID = ensayoMuestra_id;
            if (Program.rolActual == "Laboratorista")
                Empleado_ID = Program.idEmpleadoRegistrado;
            else  // root
                Empleado_ID = Program.obtenerID_EjecutorEnsayoMuestra(EnsayoMuestra_ID);
            TipoEnsayo_ID = tipoEnsayo_id;
            accionSeleccionada = accion;
        }
    }
}