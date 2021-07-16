
namespace WindowsFormsApplication2
{
    partial class Form12
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labeProyecto = new System.Windows.Forms.Label();
            this.labelPerforacion = new System.Windows.Forms.Label();
            this.labelMuestra = new System.Windows.Forms.Label();
            this.labelTipoEnsayo = new System.Windows.Forms.Label();
            this.txtPerforacion = new System.Windows.Forms.TextBox();
            this.txtMuestra = new System.Windows.Forms.TextBox();
            this.comboBoxTipoEnsayo = new System.Windows.Forms.ComboBox();
            this.groupBoxEnsayoMuestraRealizado = new System.Windows.Forms.GroupBox();
            this.groupBoxCondicionesParticulares = new System.Windows.Forms.GroupBox();
            this.labelCondicionesParticulares = new System.Windows.Forms.Label();
            this.txtCondicionesParticulares = new System.Windows.Forms.TextBox();
            this.groupBoxFechaEjecucion = new System.Windows.Forms.GroupBox();
            this.labelFechaEjecucion = new System.Windows.Forms.Label();
            this.dateTimePickerFechaEjecucion = new System.Windows.Forms.DateTimePicker();
            this.groupBoxEmpleado = new System.Windows.Forms.GroupBox();
            this.labelEjecutor = new System.Windows.Forms.Label();
            this.txtEjecutor = new System.Windows.Forms.TextBox();
            this.btnSeleccionarEmpleado = new System.Windows.Forms.Button();
            this.groupBoxResiduo = new System.Windows.Forms.GroupBox();
            this.radioBtnHayResiduo_NO = new System.Windows.Forms.RadioButton();
            this.radioBtnHayResiduo_SI = new System.Windows.Forms.RadioButton();
            this.labelResiduo = new System.Windows.Forms.Label();
            this.btnCambiarMuestra = new System.Windows.Forms.Button();
            this.txtProyecto = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnConfirmarEnsayoMuestra = new System.Windows.Forms.Button();
            this.lblEstadoEnsayo = new System.Windows.Forms.Label();
            this.comboBoxEstadoEnsayo = new System.Windows.Forms.ComboBox();
            this.groupBoxEstadoEnsayo = new System.Windows.Forms.GroupBox();
            this.groupBoxTipoEnsayo = new System.Windows.Forms.GroupBox();
            this.groupBoxParametrosMuestra = new System.Windows.Forms.GroupBox();
            this.textBoxReadOnlyTipoEnsayo = new System.Windows.Forms.TextBox();
            this.txtEstadoEnsayoReadOnly = new System.Windows.Forms.TextBox();
            this.groupBoxEnsayoMuestraRealizado.SuspendLayout();
            this.groupBoxCondicionesParticulares.SuspendLayout();
            this.groupBoxFechaEjecucion.SuspendLayout();
            this.groupBoxEmpleado.SuspendLayout();
            this.groupBoxResiduo.SuspendLayout();
            this.groupBoxEstadoEnsayo.SuspendLayout();
            this.groupBoxTipoEnsayo.SuspendLayout();
            this.groupBoxParametrosMuestra.SuspendLayout();
            this.SuspendLayout();
            // 
            // labeProyecto
            // 
            this.labeProyecto.AutoSize = true;
            this.labeProyecto.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeProyecto.Location = new System.Drawing.Point(9, 34);
            this.labeProyecto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeProyecto.Name = "labeProyecto";
            this.labeProyecto.Size = new System.Drawing.Size(112, 30);
            this.labeProyecto.TabIndex = 1;
            this.labeProyecto.Text = "Proyecto";
            // 
            // labelPerforacion
            // 
            this.labelPerforacion.AutoSize = true;
            this.labelPerforacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerforacion.Location = new System.Drawing.Point(9, 108);
            this.labelPerforacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPerforacion.Name = "labelPerforacion";
            this.labelPerforacion.Size = new System.Drawing.Size(147, 30);
            this.labelPerforacion.TabIndex = 2;
            this.labelPerforacion.Text = "Perforación:";
            // 
            // labelMuestra
            // 
            this.labelMuestra.AutoSize = true;
            this.labelMuestra.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMuestra.Location = new System.Drawing.Point(510, 108);
            this.labelMuestra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMuestra.Name = "labelMuestra";
            this.labelMuestra.Size = new System.Drawing.Size(110, 30);
            this.labelMuestra.TabIndex = 4;
            this.labelMuestra.Text = "Muestra:";
            // 
            // labelTipoEnsayo
            // 
            this.labelTipoEnsayo.AutoSize = true;
            this.labelTipoEnsayo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoEnsayo.Location = new System.Drawing.Point(-6, 38);
            this.labelTipoEnsayo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipoEnsayo.Name = "labelTipoEnsayo";
            this.labelTipoEnsayo.Size = new System.Drawing.Size(97, 30);
            this.labelTipoEnsayo.TabIndex = 5;
            this.labelTipoEnsayo.Text = "Ensayo:";
            // 
            // txtPerforacion
            // 
            this.txtPerforacion.Location = new System.Drawing.Point(164, 108);
            this.txtPerforacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPerforacion.Name = "txtPerforacion";
            this.txtPerforacion.Size = new System.Drawing.Size(228, 26);
            this.txtPerforacion.TabIndex = 6;
            // 
            // txtMuestra
            // 
            this.txtMuestra.Location = new System.Drawing.Point(628, 111);
            this.txtMuestra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMuestra.Name = "txtMuestra";
            this.txtMuestra.Size = new System.Drawing.Size(228, 26);
            this.txtMuestra.TabIndex = 7;
            // 
            // comboBoxTipoEnsayo
            // 
            this.comboBoxTipoEnsayo.FormattingEnabled = true;
            this.comboBoxTipoEnsayo.Items.AddRange(new object[] {
            "Triaxial UU",
            "Triaxial CU",
            "Triaxial CD",
            "Compresión inconfinada",
            "Corte directo",
            "Triaxial cíclico",
            "Columna resonante",
            "Bender element",
            "Consolidación",
            "Expansión libre ",
            "Expansión controlada ",
            "Consolidación en succión controlada",
            "Humedad",
            "Límites",
            "Peso unitario",
            "Granulometría",
            "Hidrometría"});
            this.comboBoxTipoEnsayo.Location = new System.Drawing.Point(148, 43);
            this.comboBoxTipoEnsayo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxTipoEnsayo.Name = "comboBoxTipoEnsayo";
            this.comboBoxTipoEnsayo.Size = new System.Drawing.Size(228, 28);
            this.comboBoxTipoEnsayo.TabIndex = 8;
            // 
            // groupBoxEnsayoMuestraRealizado
            // 
            this.groupBoxEnsayoMuestraRealizado.Controls.Add(this.groupBoxCondicionesParticulares);
            this.groupBoxEnsayoMuestraRealizado.Controls.Add(this.groupBoxFechaEjecucion);
            this.groupBoxEnsayoMuestraRealizado.Controls.Add(this.groupBoxEmpleado);
            this.groupBoxEnsayoMuestraRealizado.Controls.Add(this.groupBoxResiduo);
            this.groupBoxEnsayoMuestraRealizado.Controls.Add(this.labelResiduo);
            this.groupBoxEnsayoMuestraRealizado.Location = new System.Drawing.Point(24, 245);
            this.groupBoxEnsayoMuestraRealizado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxEnsayoMuestraRealizado.Name = "groupBoxEnsayoMuestraRealizado";
            this.groupBoxEnsayoMuestraRealizado.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxEnsayoMuestraRealizado.Size = new System.Drawing.Size(1158, 572);
            this.groupBoxEnsayoMuestraRealizado.TabIndex = 9;
            this.groupBoxEnsayoMuestraRealizado.TabStop = false;
            this.groupBoxEnsayoMuestraRealizado.Text = "EnsayoMuestraRealizado";
            // 
            // groupBoxCondicionesParticulares
            // 
            this.groupBoxCondicionesParticulares.Controls.Add(this.labelCondicionesParticulares);
            this.groupBoxCondicionesParticulares.Controls.Add(this.txtCondicionesParticulares);
            this.groupBoxCondicionesParticulares.Location = new System.Drawing.Point(472, 197);
            this.groupBoxCondicionesParticulares.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxCondicionesParticulares.Name = "groupBoxCondicionesParticulares";
            this.groupBoxCondicionesParticulares.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxCondicionesParticulares.Size = new System.Drawing.Size(663, 366);
            this.groupBoxCondicionesParticulares.TabIndex = 17;
            this.groupBoxCondicionesParticulares.TabStop = false;
            this.groupBoxCondicionesParticulares.Text = "groupBoxCondicionesParticulares";
            // 
            // labelCondicionesParticulares
            // 
            this.labelCondicionesParticulares.AutoSize = true;
            this.labelCondicionesParticulares.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCondicionesParticulares.Location = new System.Drawing.Point(36, 25);
            this.labelCondicionesParticulares.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCondicionesParticulares.Name = "labelCondicionesParticulares";
            this.labelCondicionesParticulares.Size = new System.Drawing.Size(286, 30);
            this.labelCondicionesParticulares.TabIndex = 10;
            this.labelCondicionesParticulares.Text = "Condiciones particulares";
            // 
            // txtCondicionesParticulares
            // 
            this.txtCondicionesParticulares.Location = new System.Drawing.Point(42, 78);
            this.txtCondicionesParticulares.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCondicionesParticulares.Multiline = true;
            this.txtCondicionesParticulares.Name = "txtCondicionesParticulares";
            this.txtCondicionesParticulares.Size = new System.Drawing.Size(598, 244);
            this.txtCondicionesParticulares.TabIndex = 13;
            // 
            // groupBoxFechaEjecucion
            // 
            this.groupBoxFechaEjecucion.Controls.Add(this.labelFechaEjecucion);
            this.groupBoxFechaEjecucion.Controls.Add(this.dateTimePickerFechaEjecucion);
            this.groupBoxFechaEjecucion.Location = new System.Drawing.Point(36, 72);
            this.groupBoxFechaEjecucion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxFechaEjecucion.Name = "groupBoxFechaEjecucion";
            this.groupBoxFechaEjecucion.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxFechaEjecucion.Size = new System.Drawing.Size(540, 97);
            this.groupBoxFechaEjecucion.TabIndex = 16;
            this.groupBoxFechaEjecucion.TabStop = false;
            this.groupBoxFechaEjecucion.Text = "groupBoxFechaEjecucion";
            // 
            // labelFechaEjecucion
            // 
            this.labelFechaEjecucion.AutoSize = true;
            this.labelFechaEjecucion.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaEjecucion.Location = new System.Drawing.Point(9, 25);
            this.labelFechaEjecucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFechaEjecucion.Name = "labelFechaEjecucion";
            this.labelFechaEjecucion.Size = new System.Drawing.Size(189, 30);
            this.labelFechaEjecucion.TabIndex = 10;
            this.labelFechaEjecucion.Text = "Fecha ejecución";
            // 
            // dateTimePickerFechaEjecucion
            // 
            this.dateTimePickerFechaEjecucion.Location = new System.Drawing.Point(225, 25);
            this.dateTimePickerFechaEjecucion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerFechaEjecucion.Name = "dateTimePickerFechaEjecucion";
            this.dateTimePickerFechaEjecucion.Size = new System.Drawing.Size(298, 26);
            this.dateTimePickerFechaEjecucion.TabIndex = 11;
            // 
            // groupBoxEmpleado
            // 
            this.groupBoxEmpleado.Controls.Add(this.labelEjecutor);
            this.groupBoxEmpleado.Controls.Add(this.txtEjecutor);
            this.groupBoxEmpleado.Controls.Add(this.btnSeleccionarEmpleado);
            this.groupBoxEmpleado.Location = new System.Drawing.Point(632, 72);
            this.groupBoxEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxEmpleado.Name = "groupBoxEmpleado";
            this.groupBoxEmpleado.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxEmpleado.Size = new System.Drawing.Size(477, 91);
            this.groupBoxEmpleado.TabIndex = 15;
            this.groupBoxEmpleado.TabStop = false;
            this.groupBoxEmpleado.Text = "groupBoxEmpleado";
            // 
            // labelEjecutor
            // 
            this.labelEjecutor.AutoSize = true;
            this.labelEjecutor.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEjecutor.Location = new System.Drawing.Point(24, 25);
            this.labelEjecutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEjecutor.Name = "labelEjecutor";
            this.labelEjecutor.Size = new System.Drawing.Size(104, 30);
            this.labelEjecutor.TabIndex = 10;
            this.labelEjecutor.Text = "Ejecutor";
            // 
            // txtEjecutor
            // 
            this.txtEjecutor.Location = new System.Drawing.Point(136, 26);
            this.txtEjecutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEjecutor.Name = "txtEjecutor";
            this.txtEjecutor.Size = new System.Drawing.Size(166, 26);
            this.txtEjecutor.TabIndex = 14;
            // 
            // btnSeleccionarEmpleado
            // 
            this.btnSeleccionarEmpleado.Location = new System.Drawing.Point(334, 26);
            this.btnSeleccionarEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSeleccionarEmpleado.Name = "btnSeleccionarEmpleado";
            this.btnSeleccionarEmpleado.Size = new System.Drawing.Size(112, 35);
            this.btnSeleccionarEmpleado.TabIndex = 10;
            this.btnSeleccionarEmpleado.Text = "Seleccionar";
            this.btnSeleccionarEmpleado.UseVisualStyleBackColor = true;
            this.btnSeleccionarEmpleado.Click += new System.EventHandler(this.btnSeleccionarEmpleado_Click);
            // 
            // groupBoxResiduo
            // 
            this.groupBoxResiduo.Controls.Add(this.radioBtnHayResiduo_NO);
            this.groupBoxResiduo.Controls.Add(this.radioBtnHayResiduo_SI);
            this.groupBoxResiduo.Location = new System.Drawing.Point(56, 298);
            this.groupBoxResiduo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxResiduo.Name = "groupBoxResiduo";
            this.groupBoxResiduo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxResiduo.Size = new System.Drawing.Size(300, 154);
            this.groupBoxResiduo.TabIndex = 12;
            this.groupBoxResiduo.TabStop = false;
            this.groupBoxResiduo.Text = "Residuo";
            // 
            // radioBtnHayResiduo_NO
            // 
            this.radioBtnHayResiduo_NO.AutoSize = true;
            this.radioBtnHayResiduo_NO.Location = new System.Drawing.Point(32, 94);
            this.radioBtnHayResiduo_NO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBtnHayResiduo_NO.Name = "radioBtnHayResiduo_NO";
            this.radioBtnHayResiduo_NO.Size = new System.Drawing.Size(54, 24);
            this.radioBtnHayResiduo_NO.TabIndex = 1;
            this.radioBtnHayResiduo_NO.TabStop = true;
            this.radioBtnHayResiduo_NO.Text = "No";
            this.radioBtnHayResiduo_NO.UseVisualStyleBackColor = true;
            // 
            // radioBtnHayResiduo_SI
            // 
            this.radioBtnHayResiduo_SI.AutoSize = true;
            this.radioBtnHayResiduo_SI.Location = new System.Drawing.Point(32, 43);
            this.radioBtnHayResiduo_SI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBtnHayResiduo_SI.Name = "radioBtnHayResiduo_SI";
            this.radioBtnHayResiduo_SI.Size = new System.Drawing.Size(48, 24);
            this.radioBtnHayResiduo_SI.TabIndex = 0;
            this.radioBtnHayResiduo_SI.TabStop = true;
            this.radioBtnHayResiduo_SI.Text = "Sí";
            this.radioBtnHayResiduo_SI.UseVisualStyleBackColor = true;
            // 
            // labelResiduo
            // 
            this.labelResiduo.AutoSize = true;
            this.labelResiduo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResiduo.Location = new System.Drawing.Point(30, 263);
            this.labelResiduo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResiduo.Name = "labelResiduo";
            this.labelResiduo.Size = new System.Drawing.Size(187, 30);
            this.labelResiduo.TabIndex = 10;
            this.labelResiduo.Text = "¿Hubo residuo?";
            // 
            // btnCambiarMuestra
            // 
            this.btnCambiarMuestra.Location = new System.Drawing.Point(944, 88);
            this.btnCambiarMuestra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCambiarMuestra.Name = "btnCambiarMuestra";
            this.btnCambiarMuestra.Size = new System.Drawing.Size(189, 35);
            this.btnCambiarMuestra.TabIndex = 10;
            this.btnCambiarMuestra.Text = "Cambiar Muestra";
            this.btnCambiarMuestra.UseVisualStyleBackColor = true;
            this.btnCambiarMuestra.Click += new System.EventHandler(this.btnCambiarMuestra_Click);
            // 
            // txtProyecto
            // 
            this.txtProyecto.Location = new System.Drawing.Point(164, 32);
            this.txtProyecto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProyecto.Name = "txtProyecto";
            this.txtProyecto.Size = new System.Drawing.Size(356, 26);
            this.txtProyecto.TabIndex = 11;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(986, 162);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(112, 35);
            this.btnRegresar.TabIndex = 12;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnConfirmarEnsayoMuestra
            // 
            this.btnConfirmarEnsayoMuestra.Location = new System.Drawing.Point(872, 200);
            this.btnConfirmarEnsayoMuestra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmarEnsayoMuestra.Name = "btnConfirmarEnsayoMuestra";
            this.btnConfirmarEnsayoMuestra.Size = new System.Drawing.Size(112, 35);
            this.btnConfirmarEnsayoMuestra.TabIndex = 13;
            this.btnConfirmarEnsayoMuestra.Text = "Confirmar";
            this.btnConfirmarEnsayoMuestra.UseVisualStyleBackColor = true;
            this.btnConfirmarEnsayoMuestra.Click += new System.EventHandler(this.btnConfirmarEnsayoMuestra_Click);
            // 
            // lblEstadoEnsayo
            // 
            this.lblEstadoEnsayo.AutoSize = true;
            this.lblEstadoEnsayo.Location = new System.Drawing.Point(9, 35);
            this.lblEstadoEnsayo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoEnsayo.Name = "lblEstadoEnsayo";
            this.lblEstadoEnsayo.Size = new System.Drawing.Size(64, 20);
            this.lblEstadoEnsayo.TabIndex = 14;
            this.lblEstadoEnsayo.Text = "Estado:";
            // 
            // comboBoxEstadoEnsayo
            // 
            this.comboBoxEstadoEnsayo.FormattingEnabled = true;
            this.comboBoxEstadoEnsayo.Location = new System.Drawing.Point(134, 31);
            this.comboBoxEstadoEnsayo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxEstadoEnsayo.Name = "comboBoxEstadoEnsayo";
            this.comboBoxEstadoEnsayo.Size = new System.Drawing.Size(180, 28);
            this.comboBoxEstadoEnsayo.TabIndex = 15;
            // 
            // groupBoxEstadoEnsayo
            // 
            this.groupBoxEstadoEnsayo.Controls.Add(this.comboBoxEstadoEnsayo);
            this.groupBoxEstadoEnsayo.Controls.Add(this.lblEstadoEnsayo);
            this.groupBoxEstadoEnsayo.Controls.Add(this.txtEstadoEnsayoReadOnly);
            this.groupBoxEstadoEnsayo.Location = new System.Drawing.Point(489, 162);
            this.groupBoxEstadoEnsayo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxEstadoEnsayo.Name = "groupBoxEstadoEnsayo";
            this.groupBoxEstadoEnsayo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxEstadoEnsayo.Size = new System.Drawing.Size(326, 88);
            this.groupBoxEstadoEnsayo.TabIndex = 18;
            this.groupBoxEstadoEnsayo.TabStop = false;
            this.groupBoxEstadoEnsayo.Text = "groupBoxEstadoEnsayo";
            // 
            // groupBoxTipoEnsayo
            // 
            this.groupBoxTipoEnsayo.Controls.Add(this.labelTipoEnsayo);
            this.groupBoxTipoEnsayo.Controls.Add(this.comboBoxTipoEnsayo);
            this.groupBoxTipoEnsayo.Controls.Add(this.textBoxReadOnlyTipoEnsayo);
            this.groupBoxTipoEnsayo.Location = new System.Drawing.Point(24, 132);
            this.groupBoxTipoEnsayo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxTipoEnsayo.Name = "groupBoxTipoEnsayo";
            this.groupBoxTipoEnsayo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxTipoEnsayo.Size = new System.Drawing.Size(417, 103);
            this.groupBoxTipoEnsayo.TabIndex = 19;
            this.groupBoxTipoEnsayo.TabStop = false;
            this.groupBoxTipoEnsayo.Text = "groupBoxTipoEnsayo";
            // 
            // groupBoxParametrosMuestra
            // 
            this.groupBoxParametrosMuestra.Controls.Add(this.labeProyecto);
            this.groupBoxParametrosMuestra.Controls.Add(this.labelPerforacion);
            this.groupBoxParametrosMuestra.Controls.Add(this.labelMuestra);
            this.groupBoxParametrosMuestra.Controls.Add(this.txtPerforacion);
            this.groupBoxParametrosMuestra.Controls.Add(this.txtProyecto);
            this.groupBoxParametrosMuestra.Controls.Add(this.txtMuestra);
            this.groupBoxParametrosMuestra.Location = new System.Drawing.Point(3, -3);
            this.groupBoxParametrosMuestra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxParametrosMuestra.Name = "groupBoxParametrosMuestra";
            this.groupBoxParametrosMuestra.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxParametrosMuestra.Size = new System.Drawing.Size(873, 155);
            this.groupBoxParametrosMuestra.TabIndex = 20;
            this.groupBoxParametrosMuestra.TabStop = false;
            this.groupBoxParametrosMuestra.Text = "groupBoxParametrosMuestra";
            // 
            // textBoxReadOnlyTipoEnsayo
            // 
            this.textBoxReadOnlyTipoEnsayo.Location = new System.Drawing.Point(148, 41);
            this.textBoxReadOnlyTipoEnsayo.Name = "textBoxReadOnlyTipoEnsayo";
            this.textBoxReadOnlyTipoEnsayo.Size = new System.Drawing.Size(228, 26);
            this.textBoxReadOnlyTipoEnsayo.TabIndex = 9;
            // 
            // txtEstadoEnsayoReadOnly
            // 
            this.txtEstadoEnsayoReadOnly.Location = new System.Drawing.Point(134, 32);
            this.txtEstadoEnsayoReadOnly.Name = "txtEstadoEnsayoReadOnly";
            this.txtEstadoEnsayoReadOnly.Size = new System.Drawing.Size(180, 26);
            this.txtEstadoEnsayoReadOnly.TabIndex = 16;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 862);
            this.Controls.Add(this.groupBoxParametrosMuestra);
            this.Controls.Add(this.groupBoxTipoEnsayo);
            this.Controls.Add(this.groupBoxEstadoEnsayo);
            this.Controls.Add(this.btnConfirmarEnsayoMuestra);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnCambiarMuestra);
            this.Controls.Add(this.groupBoxEnsayoMuestraRealizado);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form12";
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.Form12_Load);
            this.groupBoxEnsayoMuestraRealizado.ResumeLayout(false);
            this.groupBoxEnsayoMuestraRealizado.PerformLayout();
            this.groupBoxCondicionesParticulares.ResumeLayout(false);
            this.groupBoxCondicionesParticulares.PerformLayout();
            this.groupBoxFechaEjecucion.ResumeLayout(false);
            this.groupBoxFechaEjecucion.PerformLayout();
            this.groupBoxEmpleado.ResumeLayout(false);
            this.groupBoxEmpleado.PerformLayout();
            this.groupBoxResiduo.ResumeLayout(false);
            this.groupBoxResiduo.PerformLayout();
            this.groupBoxEstadoEnsayo.ResumeLayout(false);
            this.groupBoxEstadoEnsayo.PerformLayout();
            this.groupBoxTipoEnsayo.ResumeLayout(false);
            this.groupBoxTipoEnsayo.PerformLayout();
            this.groupBoxParametrosMuestra.ResumeLayout(false);
            this.groupBoxParametrosMuestra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labeProyecto;
        private System.Windows.Forms.Label labelPerforacion;
        private System.Windows.Forms.Label labelMuestra;
        private System.Windows.Forms.Label labelTipoEnsayo;
        private System.Windows.Forms.TextBox txtPerforacion;
        private System.Windows.Forms.TextBox txtMuestra;
        private System.Windows.Forms.ComboBox comboBoxTipoEnsayo;
        private System.Windows.Forms.GroupBox groupBoxEnsayoMuestraRealizado;
        private System.Windows.Forms.TextBox txtCondicionesParticulares;
        private System.Windows.Forms.GroupBox groupBoxResiduo;
        private System.Windows.Forms.RadioButton radioBtnHayResiduo_NO;
        private System.Windows.Forms.RadioButton radioBtnHayResiduo_SI;
        private System.Windows.Forms.Button btnSeleccionarEmpleado;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaEjecucion;
        private System.Windows.Forms.Label labelCondicionesParticulares;
        private System.Windows.Forms.Label labelEjecutor;
        private System.Windows.Forms.Label labelResiduo;
        private System.Windows.Forms.Label labelFechaEjecucion;
        private System.Windows.Forms.Button btnCambiarMuestra;
        private System.Windows.Forms.TextBox txtEjecutor;
        private System.Windows.Forms.TextBox txtProyecto;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnConfirmarEnsayoMuestra;
        private System.Windows.Forms.GroupBox groupBoxCondicionesParticulares;
        private System.Windows.Forms.GroupBox groupBoxFechaEjecucion;
        private System.Windows.Forms.GroupBox groupBoxEmpleado;
        private System.Windows.Forms.Label lblEstadoEnsayo;
        private System.Windows.Forms.ComboBox comboBoxEstadoEnsayo;
        private System.Windows.Forms.GroupBox groupBoxEstadoEnsayo;
        private System.Windows.Forms.GroupBox groupBoxTipoEnsayo;
        private System.Windows.Forms.GroupBox groupBoxParametrosMuestra;
        private System.Windows.Forms.TextBox textBoxReadOnlyTipoEnsayo;
        private System.Windows.Forms.TextBox txtEstadoEnsayoReadOnly;
    }
}