﻿﻿
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
            this.txtEstadoEnsayoReadOnly = new System.Windows.Forms.TextBox();
            this.groupBoxTipoEnsayo = new System.Windows.Forms.GroupBox();
            this.textBoxReadOnlyTipoEnsayo = new System.Windows.Forms.TextBox();
            this.groupBoxParametrosMuestra = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBoxEnsayoMuestraRealizado.SuspendLayout();
            this.groupBoxCondicionesParticulares.SuspendLayout();
            this.groupBoxFechaEjecucion.SuspendLayout();
            this.groupBoxEmpleado.SuspendLayout();
            this.groupBoxResiduo.SuspendLayout();
            this.groupBoxEstadoEnsayo.SuspendLayout();
            this.groupBoxTipoEnsayo.SuspendLayout();
            this.groupBoxParametrosMuestra.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labeProyecto
            // 
            this.labeProyecto.AutoSize = true;
            this.labeProyecto.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeProyecto.Location = new System.Drawing.Point(6, 22);
            this.labeProyecto.Name = "labeProyecto";
            this.labeProyecto.Size = new System.Drawing.Size(74, 23);
            this.labeProyecto.TabIndex = 1;
            this.labeProyecto.Text = "Proyecto";
            // 
            // labelPerforacion
            // 
            this.labelPerforacion.AutoSize = true;
            this.labelPerforacion.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.labelPerforacion.Location = new System.Drawing.Point(6, 70);
            this.labelPerforacion.Name = "labelPerforacion";
            this.labelPerforacion.Size = new System.Drawing.Size(100, 23);
            this.labelPerforacion.TabIndex = 2;
            this.labelPerforacion.Text = "Perforación:";
            // 
            // labelMuestra
            // 
            this.labelMuestra.AutoSize = true;
            this.labelMuestra.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.labelMuestra.Location = new System.Drawing.Point(340, 70);
            this.labelMuestra.Name = "labelMuestra";
            this.labelMuestra.Size = new System.Drawing.Size(76, 23);
            this.labelMuestra.TabIndex = 4;
            this.labelMuestra.Text = "Muestra:";
            // 
            // labelTipoEnsayo
            // 
            this.labelTipoEnsayo.AutoSize = true;
            this.labelTipoEnsayo.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.labelTipoEnsayo.Location = new System.Drawing.Point(-4, 25);
            this.labelTipoEnsayo.Name = "labelTipoEnsayo";
            this.labelTipoEnsayo.Size = new System.Drawing.Size(65, 23);
            this.labelTipoEnsayo.TabIndex = 5;
            this.labelTipoEnsayo.Text = "Ensayo:";
            // 
            // txtPerforacion
            // 
            this.txtPerforacion.Location = new System.Drawing.Point(109, 70);
            this.txtPerforacion.Name = "txtPerforacion";
            this.txtPerforacion.Size = new System.Drawing.Size(153, 20);
            this.txtPerforacion.TabIndex = 6;
            // 
            // txtMuestra
            // 
            this.txtMuestra.Location = new System.Drawing.Point(419, 72);
            this.txtMuestra.Name = "txtMuestra";
            this.txtMuestra.Size = new System.Drawing.Size(153, 20);
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
            this.comboBoxTipoEnsayo.Location = new System.Drawing.Point(109, 25);
            this.comboBoxTipoEnsayo.Name = "comboBoxTipoEnsayo";
            this.comboBoxTipoEnsayo.Size = new System.Drawing.Size(153, 21);
            this.comboBoxTipoEnsayo.TabIndex = 8;
            // 
            // groupBoxEnsayoMuestraRealizado
            // 
            this.groupBoxEnsayoMuestraRealizado.Controls.Add(this.groupBoxCondicionesParticulares);
            this.groupBoxEnsayoMuestraRealizado.Controls.Add(this.groupBoxFechaEjecucion);
            this.groupBoxEnsayoMuestraRealizado.Controls.Add(this.groupBoxEmpleado);
            this.groupBoxEnsayoMuestraRealizado.Controls.Add(this.groupBoxResiduo);
            this.groupBoxEnsayoMuestraRealizado.Controls.Add(this.labelResiduo);
            this.groupBoxEnsayoMuestraRealizado.Location = new System.Drawing.Point(22, 275);
            this.groupBoxEnsayoMuestraRealizado.Name = "groupBoxEnsayoMuestraRealizado";
            this.groupBoxEnsayoMuestraRealizado.Size = new System.Drawing.Size(772, 366);
            this.groupBoxEnsayoMuestraRealizado.TabIndex = 9;
            this.groupBoxEnsayoMuestraRealizado.TabStop = false;
            // 
            // groupBoxCondicionesParticulares
            // 
            this.groupBoxCondicionesParticulares.Controls.Add(this.labelCondicionesParticulares);
            this.groupBoxCondicionesParticulares.Controls.Add(this.txtCondicionesParticulares);
            this.groupBoxCondicionesParticulares.Location = new System.Drawing.Point(309, 118);
            this.groupBoxCondicionesParticulares.Name = "groupBoxCondicionesParticulares";
            this.groupBoxCondicionesParticulares.Size = new System.Drawing.Size(442, 238);
            this.groupBoxCondicionesParticulares.TabIndex = 17;
            this.groupBoxCondicionesParticulares.TabStop = false;
            // 
            // labelCondicionesParticulares
            // 
            this.labelCondicionesParticulares.AutoSize = true;
            this.labelCondicionesParticulares.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.labelCondicionesParticulares.Location = new System.Drawing.Point(24, 16);
            this.labelCondicionesParticulares.Name = "labelCondicionesParticulares";
            this.labelCondicionesParticulares.Size = new System.Drawing.Size(188, 23);
            this.labelCondicionesParticulares.TabIndex = 10;
            this.labelCondicionesParticulares.Text = "Condiciones particulares";
            // 
            // txtCondicionesParticulares
            // 
            this.txtCondicionesParticulares.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCondicionesParticulares.Location = new System.Drawing.Point(28, 51);
            this.txtCondicionesParticulares.Multiline = true;
            this.txtCondicionesParticulares.Name = "txtCondicionesParticulares";
            this.txtCondicionesParticulares.Size = new System.Drawing.Size(400, 160);
            this.txtCondicionesParticulares.TabIndex = 13;
            // 
            // groupBoxFechaEjecucion
            // 
            this.groupBoxFechaEjecucion.Controls.Add(this.labelFechaEjecucion);
            this.groupBoxFechaEjecucion.Controls.Add(this.dateTimePickerFechaEjecucion);
            this.groupBoxFechaEjecucion.Location = new System.Drawing.Point(6, 33);
            this.groupBoxFechaEjecucion.Name = "groupBoxFechaEjecucion";
            this.groupBoxFechaEjecucion.Size = new System.Drawing.Size(360, 63);
            this.groupBoxFechaEjecucion.TabIndex = 16;
            this.groupBoxFechaEjecucion.TabStop = false;
            // 
            // labelFechaEjecucion
            // 
            this.labelFechaEjecucion.AutoSize = true;
            this.labelFechaEjecucion.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.labelFechaEjecucion.Location = new System.Drawing.Point(6, 16);
            this.labelFechaEjecucion.Name = "labelFechaEjecucion";
            this.labelFechaEjecucion.Size = new System.Drawing.Size(124, 23);
            this.labelFechaEjecucion.TabIndex = 10;
            this.labelFechaEjecucion.Text = "Fecha ejecución";
            // 
            // dateTimePickerFechaEjecucion
            // 
            this.dateTimePickerFechaEjecucion.Location = new System.Drawing.Point(150, 16);
            this.dateTimePickerFechaEjecucion.Name = "dateTimePickerFechaEjecucion";
            this.dateTimePickerFechaEjecucion.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaEjecucion.TabIndex = 11;
            // 
            // groupBoxEmpleado
            // 
            this.groupBoxEmpleado.Controls.Add(this.labelEjecutor);
            this.groupBoxEmpleado.Controls.Add(this.txtEjecutor);
            this.groupBoxEmpleado.Controls.Add(this.btnSeleccionarEmpleado);
            this.groupBoxEmpleado.Location = new System.Drawing.Point(407, 37);
            this.groupBoxEmpleado.Name = "groupBoxEmpleado";
            this.groupBoxEmpleado.Size = new System.Drawing.Size(318, 59);
            this.groupBoxEmpleado.TabIndex = 15;
            this.groupBoxEmpleado.TabStop = false;
            // 
            // labelEjecutor
            // 
            this.labelEjecutor.AutoSize = true;
            this.labelEjecutor.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.labelEjecutor.Location = new System.Drawing.Point(16, 16);
            this.labelEjecutor.Name = "labelEjecutor";
            this.labelEjecutor.Size = new System.Drawing.Size(73, 23);
            this.labelEjecutor.TabIndex = 10;
            this.labelEjecutor.Text = "Ejecutor";
            // 
            // txtEjecutor
            // 
            this.txtEjecutor.Location = new System.Drawing.Point(91, 17);
            this.txtEjecutor.Name = "txtEjecutor";
            this.txtEjecutor.Size = new System.Drawing.Size(112, 20);
            this.txtEjecutor.TabIndex = 14;
            // 
            // btnSeleccionarEmpleado
            // 
            this.btnSeleccionarEmpleado.Location = new System.Drawing.Point(223, 17);
            this.btnSeleccionarEmpleado.Name = "btnSeleccionarEmpleado";
            this.btnSeleccionarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarEmpleado.TabIndex = 10;
            this.btnSeleccionarEmpleado.Text = "Seleccionar";
            this.btnSeleccionarEmpleado.UseVisualStyleBackColor = true;
            this.btnSeleccionarEmpleado.Click += new System.EventHandler(this.btnSeleccionarEmpleado_Click);
            // 
            // groupBoxResiduo
            // 
            this.groupBoxResiduo.Controls.Add(this.radioBtnHayResiduo_NO);
            this.groupBoxResiduo.Controls.Add(this.radioBtnHayResiduo_SI);
            this.groupBoxResiduo.Location = new System.Drawing.Point(16, 144);
            this.groupBoxResiduo.Name = "groupBoxResiduo";
            this.groupBoxResiduo.Size = new System.Drawing.Size(200, 100);
            this.groupBoxResiduo.TabIndex = 12;
            this.groupBoxResiduo.TabStop = false;
            // 
            // radioBtnHayResiduo_NO
            // 
            this.radioBtnHayResiduo_NO.AutoSize = true;
            this.radioBtnHayResiduo_NO.Location = new System.Drawing.Point(21, 61);
            this.radioBtnHayResiduo_NO.Name = "radioBtnHayResiduo_NO";
            this.radioBtnHayResiduo_NO.Size = new System.Drawing.Size(39, 17);
            this.radioBtnHayResiduo_NO.TabIndex = 1;
            this.radioBtnHayResiduo_NO.TabStop = true;
            this.radioBtnHayResiduo_NO.Text = "No";
            this.radioBtnHayResiduo_NO.UseVisualStyleBackColor = true;
            // 
            // radioBtnHayResiduo_SI
            // 
            this.radioBtnHayResiduo_SI.AutoSize = true;
            this.radioBtnHayResiduo_SI.Location = new System.Drawing.Point(21, 28);
            this.radioBtnHayResiduo_SI.Name = "radioBtnHayResiduo_SI";
            this.radioBtnHayResiduo_SI.Size = new System.Drawing.Size(36, 17);
            this.radioBtnHayResiduo_SI.TabIndex = 0;
            this.radioBtnHayResiduo_SI.TabStop = true;
            this.radioBtnHayResiduo_SI.Text = "Sí";
            this.radioBtnHayResiduo_SI.UseVisualStyleBackColor = true;
            // 
            // labelResiduo
            // 
            this.labelResiduo.AutoSize = true;
            this.labelResiduo.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.labelResiduo.Location = new System.Drawing.Point(12, 118);
            this.labelResiduo.Name = "labelResiduo";
            this.labelResiduo.Size = new System.Drawing.Size(124, 23);
            this.labelResiduo.TabIndex = 10;
            this.labelResiduo.Text = "¿Hubo residuo?";
            // 
            // btnCambiarMuestra
            // 
            this.btnCambiarMuestra.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarMuestra.Location = new System.Drawing.Point(637, 124);
            this.btnCambiarMuestra.Name = "btnCambiarMuestra";
            this.btnCambiarMuestra.Size = new System.Drawing.Size(136, 32);
            this.btnCambiarMuestra.TabIndex = 10;
            this.btnCambiarMuestra.Text = "Cambiar Muestra";
            this.btnCambiarMuestra.UseVisualStyleBackColor = true;
            this.btnCambiarMuestra.Click += new System.EventHandler(this.btnCambiarMuestra_Click);
            // 
            // txtProyecto
            // 
            this.txtProyecto.Location = new System.Drawing.Point(109, 21);
            this.txtProyecto.Name = "txtProyecto";
            this.txtProyecto.Size = new System.Drawing.Size(239, 20);
            this.txtProyecto.TabIndex = 11;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(637, 229);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(136, 32);
            this.btnRegresar.TabIndex = 12;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Visible = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnConfirmarEnsayoMuestra
            // 
            this.btnConfirmarEnsayoMuestra.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarEnsayoMuestra.Location = new System.Drawing.Point(637, 175);
            this.btnConfirmarEnsayoMuestra.Name = "btnConfirmarEnsayoMuestra";
            this.btnConfirmarEnsayoMuestra.Size = new System.Drawing.Size(136, 32);
            this.btnConfirmarEnsayoMuestra.TabIndex = 13;
            this.btnConfirmarEnsayoMuestra.Text = "Confirmar";
            this.btnConfirmarEnsayoMuestra.UseVisualStyleBackColor = true;
            this.btnConfirmarEnsayoMuestra.Click += new System.EventHandler(this.btnConfirmarEnsayoMuestra_Click);
            // 
            // lblEstadoEnsayo
            // 
            this.lblEstadoEnsayo.AutoSize = true;
            this.lblEstadoEnsayo.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblEstadoEnsayo.Location = new System.Drawing.Point(22, 17);
            this.lblEstadoEnsayo.Name = "lblEstadoEnsayo";
            this.lblEstadoEnsayo.Size = new System.Drawing.Size(64, 23);
            this.lblEstadoEnsayo.TabIndex = 14;
            this.lblEstadoEnsayo.Text = "Estado:";
            // 
            // comboBoxEstadoEnsayo
            // 
            this.comboBoxEstadoEnsayo.FormattingEnabled = true;
            this.comboBoxEstadoEnsayo.Location = new System.Drawing.Point(101, 20);
            this.comboBoxEstadoEnsayo.Name = "comboBoxEstadoEnsayo";
            this.comboBoxEstadoEnsayo.Size = new System.Drawing.Size(153, 21);
            this.comboBoxEstadoEnsayo.TabIndex = 15;
            // 
            // groupBoxEstadoEnsayo
            // 
            this.groupBoxEstadoEnsayo.Controls.Add(this.comboBoxEstadoEnsayo);
            this.groupBoxEstadoEnsayo.Controls.Add(this.lblEstadoEnsayo);
            this.groupBoxEstadoEnsayo.Controls.Add(this.txtEstadoEnsayoReadOnly);
            this.groupBoxEstadoEnsayo.Location = new System.Drawing.Point(340, 212);
            this.groupBoxEstadoEnsayo.Name = "groupBoxEstadoEnsayo";
            this.groupBoxEstadoEnsayo.Size = new System.Drawing.Size(264, 57);
            this.groupBoxEstadoEnsayo.TabIndex = 18;
            this.groupBoxEstadoEnsayo.TabStop = false;
            // 
            // txtEstadoEnsayoReadOnly
            // 
            this.txtEstadoEnsayoReadOnly.Location = new System.Drawing.Point(101, 21);
            this.txtEstadoEnsayoReadOnly.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstadoEnsayoReadOnly.Name = "txtEstadoEnsayoReadOnly";
            this.txtEstadoEnsayoReadOnly.Size = new System.Drawing.Size(99, 20);
            this.txtEstadoEnsayoReadOnly.TabIndex = 16;
            // 
            // groupBoxTipoEnsayo
            // 
            this.groupBoxTipoEnsayo.Controls.Add(this.labelTipoEnsayo);
            this.groupBoxTipoEnsayo.Controls.Add(this.comboBoxTipoEnsayo);
            this.groupBoxTipoEnsayo.Controls.Add(this.textBoxReadOnlyTipoEnsayo);
            this.groupBoxTipoEnsayo.Location = new System.Drawing.Point(22, 202);
            this.groupBoxTipoEnsayo.Name = "groupBoxTipoEnsayo";
            this.groupBoxTipoEnsayo.Size = new System.Drawing.Size(309, 67);
            this.groupBoxTipoEnsayo.TabIndex = 19;
            this.groupBoxTipoEnsayo.TabStop = false;
            // 
            // textBoxReadOnlyTipoEnsayo
            // 
            this.textBoxReadOnlyTipoEnsayo.Location = new System.Drawing.Point(109, 24);
            this.textBoxReadOnlyTipoEnsayo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxReadOnlyTipoEnsayo.Name = "textBoxReadOnlyTipoEnsayo";
            this.textBoxReadOnlyTipoEnsayo.Size = new System.Drawing.Size(153, 20);
            this.textBoxReadOnlyTipoEnsayo.TabIndex = 9;
            // 
            // groupBoxParametrosMuestra
            // 
            this.groupBoxParametrosMuestra.Controls.Add(this.labeProyecto);
            this.groupBoxParametrosMuestra.Controls.Add(this.labelPerforacion);
            this.groupBoxParametrosMuestra.Controls.Add(this.labelMuestra);
            this.groupBoxParametrosMuestra.Controls.Add(this.txtPerforacion);
            this.groupBoxParametrosMuestra.Controls.Add(this.txtProyecto);
            this.groupBoxParametrosMuestra.Controls.Add(this.txtMuestra);
            this.groupBoxParametrosMuestra.Location = new System.Drawing.Point(22, 106);
            this.groupBoxParametrosMuestra.Name = "groupBoxParametrosMuestra";
            this.groupBoxParametrosMuestra.Size = new System.Drawing.Size(582, 101);
            this.groupBoxParametrosMuestra.TabIndex = 20;
            this.groupBoxParametrosMuestra.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(79)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.button16);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 100);
            this.panel1.TabIndex = 69;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(162, 77);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(122, 23);
            this.button16.TabIndex = 50;
            this.button16.Text = "Guardar cambios";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(38, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(674, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(227, 23);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(340, 33);
            this.label26.TabIndex = 6;
            this.label26.Text = "DETALLES DE LA MUESTRA";
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxParametrosMuestra);
            this.Controls.Add(this.groupBoxTipoEnsayo);
            this.Controls.Add(this.groupBoxEstadoEnsayo);
            this.Controls.Add(this.btnConfirmarEnsayoMuestra);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnCambiarMuestra);
            this.Controls.Add(this.groupBoxEnsayoMuestraRealizado);
            this.Name = "Form12";
            this.Text = "Form12";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form12_FormClosing);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button16;
    }
}