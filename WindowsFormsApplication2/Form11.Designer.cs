﻿
namespace WindowsFormsApplication2
{
    partial class Form11
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
            this.labelTituloFijoProyecto = new System.Windows.Forms.Label();
            this.labelPerforacion = new System.Windows.Forms.Label();
            this.labelTipoEnsayo = new System.Windows.Forms.Label();
            this.labelMuestra = new System.Windows.Forms.Label();
            this.labelEstadoEnsayoMuestra = new System.Windows.Forms.Label();
            this.txtNombreProyectoSeleccionado = new System.Windows.Forms.TextBox();
            this.txtNombrePerforacionSeleccionada = new System.Windows.Forms.TextBox();
            this.txtNumeroMuestraSeleccionada = new System.Windows.Forms.TextBox();
            this.txtTipoEnsayoSeleccionado = new System.Windows.Forms.TextBox();
            this.txtEstadoEnsayoMuestraSeleccionado = new System.Windows.Forms.TextBox();
            this.btnMostrarDetalles = new System.Windows.Forms.Button();
            this.btnActualizaEnsayoMuestra = new System.Windows.Forms.Button();
            this.btnAgregarSinRealizar = new System.Windows.Forms.Button();
            this.btnAgregarEnsayoRealizado = new System.Windows.Forms.Button();
            this.btnSiguienteMuestra = new System.Windows.Forms.PictureBox();
            this.btnAnteriorEnsayo = new System.Windows.Forms.PictureBox();
            this.btnSiguienteEnsayo = new System.Windows.Forms.PictureBox();
            this.btnAnteriorMuestra = new System.Windows.Forms.PictureBox();
            this.btnAnteriorPerforacion = new System.Windows.Forms.PictureBox();
            this.btnSiguientePerforacion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguienteMuestra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnteriorEnsayo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguienteEnsayo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnteriorMuestra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnteriorPerforacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguientePerforacion)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTituloFijoProyecto
            // 
            this.labelTituloFijoProyecto.AutoSize = true;
            this.labelTituloFijoProyecto.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloFijoProyecto.Location = new System.Drawing.Point(12, 9);
            this.labelTituloFijoProyecto.Name = "labelTituloFijoProyecto";
            this.labelTituloFijoProyecto.Size = new System.Drawing.Size(75, 20);
            this.labelTituloFijoProyecto.TabIndex = 0;
            this.labelTituloFijoProyecto.Text = "Proyecto";
            // 
            // labelPerforacion
            // 
            this.labelPerforacion.AutoSize = true;
            this.labelPerforacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerforacion.Location = new System.Drawing.Point(12, 61);
            this.labelPerforacion.Name = "labelPerforacion";
            this.labelPerforacion.Size = new System.Drawing.Size(97, 20);
            this.labelPerforacion.TabIndex = 1;
            this.labelPerforacion.Text = "Perforación:";
            // 
            // labelTipoEnsayo
            // 
            this.labelTipoEnsayo.AutoSize = true;
            this.labelTipoEnsayo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoEnsayo.Location = new System.Drawing.Point(24, 140);
            this.labelTipoEnsayo.Name = "labelTipoEnsayo";
            this.labelTipoEnsayo.Size = new System.Drawing.Size(63, 20);
            this.labelTipoEnsayo.TabIndex = 2;
            this.labelTipoEnsayo.Text = "Ensayo:";
            // 
            // labelMuestra
            // 
            this.labelMuestra.AutoSize = true;
            this.labelMuestra.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMuestra.Location = new System.Drawing.Point(383, 61);
            this.labelMuestra.Name = "labelMuestra";
            this.labelMuestra.Size = new System.Drawing.Size(73, 20);
            this.labelMuestra.TabIndex = 3;
            this.labelMuestra.Text = "Muestra:";
            // 
            // labelEstadoEnsayoMuestra
            // 
            this.labelEstadoEnsayoMuestra.AutoSize = true;
            this.labelEstadoEnsayoMuestra.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoEnsayoMuestra.Location = new System.Drawing.Point(394, 142);
            this.labelEstadoEnsayoMuestra.Name = "labelEstadoEnsayoMuestra";
            this.labelEstadoEnsayoMuestra.Size = new System.Drawing.Size(62, 20);
            this.labelEstadoEnsayoMuestra.TabIndex = 4;
            this.labelEstadoEnsayoMuestra.Text = "Estado:";
            // 
            // txtNombreProyectoSeleccionado
            // 
            this.txtNombreProyectoSeleccionado.Location = new System.Drawing.Point(129, 12);
            this.txtNombreProyectoSeleccionado.Name = "txtNombreProyectoSeleccionado";
            this.txtNombreProyectoSeleccionado.Size = new System.Drawing.Size(151, 20);
            this.txtNombreProyectoSeleccionado.TabIndex = 7;
            // 
            // txtNombrePerforacionSeleccionada
            // 
            this.txtNombrePerforacionSeleccionada.Location = new System.Drawing.Point(174, 61);
            this.txtNombrePerforacionSeleccionada.Name = "txtNombrePerforacionSeleccionada";
            this.txtNombrePerforacionSeleccionada.Size = new System.Drawing.Size(151, 20);
            this.txtNombrePerforacionSeleccionada.TabIndex = 10;
            // 
            // txtNumeroMuestraSeleccionada
            // 
            this.txtNumeroMuestraSeleccionada.Location = new System.Drawing.Point(508, 63);
            this.txtNumeroMuestraSeleccionada.Name = "txtNumeroMuestraSeleccionada";
            this.txtNumeroMuestraSeleccionada.Size = new System.Drawing.Size(151, 20);
            this.txtNumeroMuestraSeleccionada.TabIndex = 13;
            // 
            // txtTipoEnsayoSeleccionado
            // 
            this.txtTipoEnsayoSeleccionado.Location = new System.Drawing.Point(159, 142);
            this.txtTipoEnsayoSeleccionado.Name = "txtTipoEnsayoSeleccionado";
            this.txtTipoEnsayoSeleccionado.Size = new System.Drawing.Size(151, 20);
            this.txtTipoEnsayoSeleccionado.TabIndex = 16;
            // 
            // txtEstadoEnsayoMuestraSeleccionado
            // 
            this.txtEstadoEnsayoMuestraSeleccionado.Location = new System.Drawing.Point(472, 144);
            this.txtEstadoEnsayoMuestraSeleccionado.Name = "txtEstadoEnsayoMuestraSeleccionado";
            this.txtEstadoEnsayoMuestraSeleccionado.Size = new System.Drawing.Size(151, 20);
            this.txtEstadoEnsayoMuestraSeleccionado.TabIndex = 19;
            // 
            // btnMostrarDetalles
            // 
            this.btnMostrarDetalles.Location = new System.Drawing.Point(540, 248);
            this.btnMostrarDetalles.Name = "btnMostrarDetalles";
            this.btnMostrarDetalles.Size = new System.Drawing.Size(119, 41);
            this.btnMostrarDetalles.TabIndex = 21;
            this.btnMostrarDetalles.Text = "Ver más detalles";
            this.btnMostrarDetalles.UseVisualStyleBackColor = true;
            this.btnMostrarDetalles.Click += new System.EventHandler(this.btnMostrarDetalles_Click);
            // 
            // btnActualizaEnsayoMuestra
            // 
            this.btnActualizaEnsayoMuestra.Location = new System.Drawing.Point(397, 257);
            this.btnActualizaEnsayoMuestra.Name = "btnActualizaEnsayoMuestra";
            this.btnActualizaEnsayoMuestra.Size = new System.Drawing.Size(75, 23);
            this.btnActualizaEnsayoMuestra.TabIndex = 22;
            this.btnActualizaEnsayoMuestra.Text = "Actualizar";
            this.btnActualizaEnsayoMuestra.UseVisualStyleBackColor = true;
            this.btnActualizaEnsayoMuestra.Click += new System.EventHandler(this.btnActualizaEnsayoMuestra_Click);
            // 
            // btnAgregarSinRealizar
            // 
            this.btnAgregarSinRealizar.Location = new System.Drawing.Point(207, 252);
            this.btnAgregarSinRealizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarSinRealizar.Name = "btnAgregarSinRealizar";
            this.btnAgregarSinRealizar.Size = new System.Drawing.Size(163, 32);
            this.btnAgregarSinRealizar.TabIndex = 23;
            this.btnAgregarSinRealizar.Text = "Agregar nuevo sin realizar";
            this.btnAgregarSinRealizar.UseVisualStyleBackColor = true;
            this.btnAgregarSinRealizar.Click += new System.EventHandler(this.btnAgregarSinRealizar_Click);
            // 
            // btnAgregarEnsayoRealizado
            // 
            this.btnAgregarEnsayoRealizado.Location = new System.Drawing.Point(60, 242);
            this.btnAgregarEnsayoRealizado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarEnsayoRealizado.Name = "btnAgregarEnsayoRealizado";
            this.btnAgregarEnsayoRealizado.Size = new System.Drawing.Size(106, 67);
            this.btnAgregarEnsayoRealizado.TabIndex = 24;
            this.btnAgregarEnsayoRealizado.Text = "Agregar uno ya hecho";
            this.btnAgregarEnsayoRealizado.UseVisualStyleBackColor = true;
            this.btnAgregarEnsayoRealizado.Click += new System.EventHandler(this.btnAgregarEnsayoRealizado_Click);
            // 
            // btnSiguienteMuestra
            // 
            this.btnSiguienteMuestra.Image = global::WindowsFormsApplication2.Properties.Resources.photo_2021_07_22_20_29_42;
            this.btnSiguienteMuestra.InitialImage = null;
            this.btnSiguienteMuestra.Location = new System.Drawing.Point(665, 63);
            this.btnSiguienteMuestra.Name = "btnSiguienteMuestra";
            this.btnSiguienteMuestra.Size = new System.Drawing.Size(24, 20);
            this.btnSiguienteMuestra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSiguienteMuestra.TabIndex = 20;
            this.btnSiguienteMuestra.TabStop = false;
            this.btnSiguienteMuestra.Click += new System.EventHandler(this.btnSiguienteMuestra_Click);
            // 
            // btnAnteriorEnsayo
            // 
            this.btnAnteriorEnsayo.Image = global::WindowsFormsApplication2.Properties.Resources.photo_2021_07_22_20_30_06;
            this.btnAnteriorEnsayo.InitialImage = null;
            this.btnAnteriorEnsayo.Location = new System.Drawing.Point(123, 139);
            this.btnAnteriorEnsayo.Name = "btnAnteriorEnsayo";
            this.btnAnteriorEnsayo.Size = new System.Drawing.Size(28, 23);
            this.btnAnteriorEnsayo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAnteriorEnsayo.TabIndex = 15;
            this.btnAnteriorEnsayo.TabStop = false;
            this.btnAnteriorEnsayo.Click += new System.EventHandler(this.btnAnteriorEnsayo_Click);
            // 
            // btnSiguienteEnsayo
            // 
            this.btnSiguienteEnsayo.Image = global::WindowsFormsApplication2.Properties.Resources.photo_2021_07_22_20_29_42;
            this.btnSiguienteEnsayo.InitialImage = null;
            this.btnSiguienteEnsayo.Location = new System.Drawing.Point(316, 142);
            this.btnSiguienteEnsayo.Name = "btnSiguienteEnsayo";
            this.btnSiguienteEnsayo.Size = new System.Drawing.Size(24, 20);
            this.btnSiguienteEnsayo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSiguienteEnsayo.TabIndex = 14;
            this.btnSiguienteEnsayo.TabStop = false;
            this.btnSiguienteEnsayo.Click += new System.EventHandler(this.btnSiguienteEnsayo_Click);
            // 
            // btnAnteriorMuestra
            // 
            this.btnAnteriorMuestra.Image = global::WindowsFormsApplication2.Properties.Resources.photo_2021_07_22_20_30_06;
            this.btnAnteriorMuestra.InitialImage = null;
            this.btnAnteriorMuestra.Location = new System.Drawing.Point(472, 60);
            this.btnAnteriorMuestra.Name = "btnAnteriorMuestra";
            this.btnAnteriorMuestra.Size = new System.Drawing.Size(28, 23);
            this.btnAnteriorMuestra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAnteriorMuestra.TabIndex = 12;
            this.btnAnteriorMuestra.TabStop = false;
            this.btnAnteriorMuestra.Click += new System.EventHandler(this.btnAnteriorMuestra_Click);
            // 
            // btnAnteriorPerforacion
            // 
            this.btnAnteriorPerforacion.Image = global::WindowsFormsApplication2.Properties.Resources.photo_2021_07_22_20_30_06;
            this.btnAnteriorPerforacion.InitialImage = null;
            this.btnAnteriorPerforacion.Location = new System.Drawing.Point(138, 58);
            this.btnAnteriorPerforacion.Name = "btnAnteriorPerforacion";
            this.btnAnteriorPerforacion.Size = new System.Drawing.Size(28, 23);
            this.btnAnteriorPerforacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAnteriorPerforacion.TabIndex = 9;
            this.btnAnteriorPerforacion.TabStop = false;
            this.btnAnteriorPerforacion.Click += new System.EventHandler(this.btnAnteriorPerforacion_Click);
            // 
            // btnSiguientePerforacion
            // 
            this.btnSiguientePerforacion.Image = global::WindowsFormsApplication2.Properties.Resources.photo_2021_07_22_20_29_42;
            this.btnSiguientePerforacion.InitialImage = null;
            this.btnSiguientePerforacion.Location = new System.Drawing.Point(331, 61);
            this.btnSiguientePerforacion.Name = "btnSiguientePerforacion";
            this.btnSiguientePerforacion.Size = new System.Drawing.Size(24, 20);
            this.btnSiguientePerforacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSiguientePerforacion.TabIndex = 8;
            this.btnSiguientePerforacion.TabStop = false;
            this.btnSiguientePerforacion.Click += new System.EventHandler(this.btnSiguientePerforacion_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarEnsayoRealizado);
            this.Controls.Add(this.btnAgregarSinRealizar);
            this.Controls.Add(this.btnActualizaEnsayoMuestra);
            this.Controls.Add(this.btnMostrarDetalles);
            this.Controls.Add(this.btnSiguienteMuestra);
            this.Controls.Add(this.txtEstadoEnsayoMuestraSeleccionado);
            this.Controls.Add(this.txtTipoEnsayoSeleccionado);
            this.Controls.Add(this.btnAnteriorEnsayo);
            this.Controls.Add(this.btnSiguienteEnsayo);
            this.Controls.Add(this.txtNumeroMuestraSeleccionada);
            this.Controls.Add(this.btnAnteriorMuestra);
            this.Controls.Add(this.txtNombrePerforacionSeleccionada);
            this.Controls.Add(this.btnAnteriorPerforacion);
            this.Controls.Add(this.btnSiguientePerforacion);
            this.Controls.Add(this.txtNombreProyectoSeleccionado);
            this.Controls.Add(this.labelEstadoEnsayoMuestra);
            this.Controls.Add(this.labelMuestra);
            this.Controls.Add(this.labelTipoEnsayo);
            this.Controls.Add(this.labelPerforacion);
            this.Controls.Add(this.labelTituloFijoProyecto);
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguienteMuestra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnteriorEnsayo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguienteEnsayo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnteriorMuestra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnteriorPerforacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguientePerforacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloFijoProyecto;
        private System.Windows.Forms.Label labelPerforacion;
        private System.Windows.Forms.Label labelTipoEnsayo;
        private System.Windows.Forms.Label labelMuestra;
        private System.Windows.Forms.Label labelEstadoEnsayoMuestra;
        private System.Windows.Forms.TextBox txtNombreProyectoSeleccionado;
        private System.Windows.Forms.TextBox txtNombrePerforacionSeleccionada;
        private System.Windows.Forms.PictureBox btnAnteriorPerforacion;
        private System.Windows.Forms.PictureBox btnSiguientePerforacion;
        private System.Windows.Forms.TextBox txtNumeroMuestraSeleccionada;
        private System.Windows.Forms.PictureBox btnAnteriorMuestra;
        private System.Windows.Forms.TextBox txtTipoEnsayoSeleccionado;
        private System.Windows.Forms.PictureBox btnAnteriorEnsayo;
        private System.Windows.Forms.PictureBox btnSiguienteEnsayo;
        private System.Windows.Forms.TextBox txtEstadoEnsayoMuestraSeleccionado;
        private System.Windows.Forms.PictureBox btnSiguienteMuestra;
        private System.Windows.Forms.Button btnMostrarDetalles;
        private System.Windows.Forms.Button btnActualizaEnsayoMuestra;
        private System.Windows.Forms.Button btnAgregarSinRealizar;
        private System.Windows.Forms.Button btnAgregarEnsayoRealizado;
    }
}