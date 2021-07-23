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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
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
            this.btnSiguienteMuestra = new System.Windows.Forms.PictureBox();
            this.btnAnteriorEnsayo = new System.Windows.Forms.PictureBox();
            this.btnSiguienteEnsayo = new System.Windows.Forms.PictureBox();
            this.btnAnteriorMuestra = new System.Windows.Forms.PictureBox();
            this.btnAnteriorPerforacion = new System.Windows.Forms.PictureBox();
            this.btnSiguientePerforacion = new System.Windows.Forms.PictureBox();
            this.btnActualizaEnsayoMuestra = new System.Windows.Forms.Button();
            this.btnAgregarSinRealizar = new System.Windows.Forms.Button();
            this.btnAgregarEnsayoRealizado = new System.Windows.Forms.Button();
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
            this.labelTituloFijoProyecto.Location = new System.Drawing.Point(18, 14);
            this.labelTituloFijoProyecto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloFijoProyecto.Name = "labelTituloFijoProyecto";
            this.labelTituloFijoProyecto.Size = new System.Drawing.Size(112, 30);
            this.labelTituloFijoProyecto.TabIndex = 0;
            this.labelTituloFijoProyecto.Text = "Proyecto";
            // 
            // labelPerforacion
            // 
            this.labelPerforacion.AutoSize = true;
            this.labelPerforacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerforacion.Location = new System.Drawing.Point(18, 94);
            this.labelPerforacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPerforacion.Name = "labelPerforacion";
            this.labelPerforacion.Size = new System.Drawing.Size(147, 30);
            this.labelPerforacion.TabIndex = 1;
            this.labelPerforacion.Text = "Perforación:";
            // 
            // labelTipoEnsayo
            // 
            this.labelTipoEnsayo.AutoSize = true;
            this.labelTipoEnsayo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoEnsayo.Location = new System.Drawing.Point(36, 215);
            this.labelTipoEnsayo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipoEnsayo.Name = "labelTipoEnsayo";
            this.labelTipoEnsayo.Size = new System.Drawing.Size(97, 30);
            this.labelTipoEnsayo.TabIndex = 2;
            this.labelTipoEnsayo.Text = "Ensayo:";
            // 
            // labelMuestra
            // 
            this.labelMuestra.AutoSize = true;
            this.labelMuestra.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMuestra.Location = new System.Drawing.Point(574, 94);
            this.labelMuestra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMuestra.Name = "labelMuestra";
            this.labelMuestra.Size = new System.Drawing.Size(110, 30);
            this.labelMuestra.TabIndex = 3;
            this.labelMuestra.Text = "Muestra:";
            // 
            // labelEstadoEnsayoMuestra
            // 
            this.labelEstadoEnsayoMuestra.AutoSize = true;
            this.labelEstadoEnsayoMuestra.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoEnsayoMuestra.Location = new System.Drawing.Point(591, 218);
            this.labelEstadoEnsayoMuestra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEstadoEnsayoMuestra.Name = "labelEstadoEnsayoMuestra";
            this.labelEstadoEnsayoMuestra.Size = new System.Drawing.Size(95, 30);
            this.labelEstadoEnsayoMuestra.TabIndex = 4;
            this.labelEstadoEnsayoMuestra.Text = "Estado:";
            // 
            // txtNombreProyectoSeleccionado
            // 
            this.txtNombreProyectoSeleccionado.Location = new System.Drawing.Point(194, 18);
            this.txtNombreProyectoSeleccionado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreProyectoSeleccionado.Name = "txtNombreProyectoSeleccionado";
            this.txtNombreProyectoSeleccionado.Size = new System.Drawing.Size(224, 26);
            this.txtNombreProyectoSeleccionado.TabIndex = 7;
            // 
            // txtNombrePerforacionSeleccionada
            // 
            this.txtNombrePerforacionSeleccionada.Location = new System.Drawing.Point(261, 94);
            this.txtNombrePerforacionSeleccionada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombrePerforacionSeleccionada.Name = "txtNombrePerforacionSeleccionada";
            this.txtNombrePerforacionSeleccionada.Size = new System.Drawing.Size(224, 26);
            this.txtNombrePerforacionSeleccionada.TabIndex = 10;
            // 
            // txtNumeroMuestraSeleccionada
            // 
            this.txtNumeroMuestraSeleccionada.Location = new System.Drawing.Point(762, 97);
            this.txtNumeroMuestraSeleccionada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumeroMuestraSeleccionada.Name = "txtNumeroMuestraSeleccionada";
            this.txtNumeroMuestraSeleccionada.Size = new System.Drawing.Size(224, 26);
            this.txtNumeroMuestraSeleccionada.TabIndex = 13;
            // 
            // txtTipoEnsayoSeleccionado
            // 
            this.txtTipoEnsayoSeleccionado.Location = new System.Drawing.Point(238, 218);
            this.txtTipoEnsayoSeleccionado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTipoEnsayoSeleccionado.Name = "txtTipoEnsayoSeleccionado";
            this.txtTipoEnsayoSeleccionado.Size = new System.Drawing.Size(224, 26);
            this.txtTipoEnsayoSeleccionado.TabIndex = 16;
            // 
            // txtEstadoEnsayoMuestraSeleccionado
            // 
            this.txtEstadoEnsayoMuestraSeleccionado.Location = new System.Drawing.Point(708, 222);
            this.txtEstadoEnsayoMuestraSeleccionado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEstadoEnsayoMuestraSeleccionado.Name = "txtEstadoEnsayoMuestraSeleccionado";
            this.txtEstadoEnsayoMuestraSeleccionado.Size = new System.Drawing.Size(224, 26);
            this.txtEstadoEnsayoMuestraSeleccionado.TabIndex = 19;
            // 
            // btnMostrarDetalles
            // 
            this.btnMostrarDetalles.Location = new System.Drawing.Point(810, 382);
            this.btnMostrarDetalles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMostrarDetalles.Name = "btnMostrarDetalles";
            this.btnMostrarDetalles.Size = new System.Drawing.Size(178, 63);
            this.btnMostrarDetalles.TabIndex = 21;
            this.btnMostrarDetalles.Text = "Ver más detalles";
            this.btnMostrarDetalles.UseVisualStyleBackColor = true;
            this.btnMostrarDetalles.Click += new System.EventHandler(this.btnMostrarDetalles_Click);
            // 
            // btnSiguienteMuestra
            // 
            this.btnSiguienteMuestra.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguienteMuestra.Image")));
            this.btnSiguienteMuestra.InitialImage = null;
            this.btnSiguienteMuestra.Location = new System.Drawing.Point(998, 97);
            this.btnSiguienteMuestra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSiguienteMuestra.Name = "btnSiguienteMuestra";
            this.btnSiguienteMuestra.Size = new System.Drawing.Size(36, 31);
            this.btnSiguienteMuestra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSiguienteMuestra.TabIndex = 20;
            this.btnSiguienteMuestra.TabStop = false;
            this.btnSiguienteMuestra.Click += new System.EventHandler(this.btnSiguienteMuestra_Click);
            // 
            // btnAnteriorEnsayo
            // 
            this.btnAnteriorEnsayo.Image = ((System.Drawing.Image)(resources.GetObject("btnAnteriorEnsayo.Image")));
            this.btnAnteriorEnsayo.InitialImage = null;
            this.btnAnteriorEnsayo.Location = new System.Drawing.Point(184, 214);
            this.btnAnteriorEnsayo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnteriorEnsayo.Name = "btnAnteriorEnsayo";
            this.btnAnteriorEnsayo.Size = new System.Drawing.Size(42, 35);
            this.btnAnteriorEnsayo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAnteriorEnsayo.TabIndex = 15;
            this.btnAnteriorEnsayo.TabStop = false;
            this.btnAnteriorEnsayo.Click += new System.EventHandler(this.btnAnteriorEnsayo_Click);
            // 
            // btnSiguienteEnsayo
            // 
            this.btnSiguienteEnsayo.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguienteEnsayo.Image")));
            this.btnSiguienteEnsayo.InitialImage = null;
            this.btnSiguienteEnsayo.Location = new System.Drawing.Point(474, 218);
            this.btnSiguienteEnsayo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSiguienteEnsayo.Name = "btnSiguienteEnsayo";
            this.btnSiguienteEnsayo.Size = new System.Drawing.Size(36, 31);
            this.btnSiguienteEnsayo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSiguienteEnsayo.TabIndex = 14;
            this.btnSiguienteEnsayo.TabStop = false;
            this.btnSiguienteEnsayo.Click += new System.EventHandler(this.btnSiguienteEnsayo_Click);
            // 
            // btnAnteriorMuestra
            // 
            this.btnAnteriorMuestra.Image = ((System.Drawing.Image)(resources.GetObject("btnAnteriorMuestra.Image")));
            this.btnAnteriorMuestra.InitialImage = null;
            this.btnAnteriorMuestra.Location = new System.Drawing.Point(708, 92);
            this.btnAnteriorMuestra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnteriorMuestra.Name = "btnAnteriorMuestra";
            this.btnAnteriorMuestra.Size = new System.Drawing.Size(42, 35);
            this.btnAnteriorMuestra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAnteriorMuestra.TabIndex = 12;
            this.btnAnteriorMuestra.TabStop = false;
            this.btnAnteriorMuestra.Click += new System.EventHandler(this.btnAnteriorMuestra_Click);
            // 
            // btnAnteriorPerforacion
            // 
            this.btnAnteriorPerforacion.Image = ((System.Drawing.Image)(resources.GetObject("btnAnteriorPerforacion.Image")));
            this.btnAnteriorPerforacion.InitialImage = null;
            this.btnAnteriorPerforacion.Location = new System.Drawing.Point(207, 89);
            this.btnAnteriorPerforacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnteriorPerforacion.Name = "btnAnteriorPerforacion";
            this.btnAnteriorPerforacion.Size = new System.Drawing.Size(42, 35);
            this.btnAnteriorPerforacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAnteriorPerforacion.TabIndex = 9;
            this.btnAnteriorPerforacion.TabStop = false;
            this.btnAnteriorPerforacion.Click += new System.EventHandler(this.btnAnteriorPerforacion_Click);
            // 
            // btnSiguientePerforacion
            // 
            this.btnSiguientePerforacion.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguientePerforacion.Image")));
            this.btnSiguientePerforacion.InitialImage = null;
            this.btnSiguientePerforacion.Location = new System.Drawing.Point(496, 94);
            this.btnSiguientePerforacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSiguientePerforacion.Name = "btnSiguientePerforacion";
            this.btnSiguientePerforacion.Size = new System.Drawing.Size(36, 31);
            this.btnSiguientePerforacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSiguientePerforacion.TabIndex = 8;
            this.btnSiguientePerforacion.TabStop = false;
            this.btnSiguientePerforacion.Click += new System.EventHandler(this.btnSiguientePerforacion_Click);
            // 
            // btnActualizaEnsayoMuestra
            // 
            this.btnActualizaEnsayoMuestra.Location = new System.Drawing.Point(596, 396);
            this.btnActualizaEnsayoMuestra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizaEnsayoMuestra.Name = "btnActualizaEnsayoMuestra";
            this.btnActualizaEnsayoMuestra.Size = new System.Drawing.Size(112, 35);
            this.btnActualizaEnsayoMuestra.TabIndex = 22;
            this.btnActualizaEnsayoMuestra.Text = "Actualizar";
            this.btnActualizaEnsayoMuestra.UseVisualStyleBackColor = true;
            this.btnActualizaEnsayoMuestra.Click += new System.EventHandler(this.btnActualizaEnsayoMuestra_Click);
            // 
            // btnAgregarSinRealizar
            // 
            this.btnAgregarSinRealizar.Location = new System.Drawing.Point(311, 388);
            this.btnAgregarSinRealizar.Name = "btnAgregarSinRealizar";
            this.btnAgregarSinRealizar.Size = new System.Drawing.Size(245, 50);
            this.btnAgregarSinRealizar.TabIndex = 23;
            this.btnAgregarSinRealizar.Text = "Agregar nuevo sin realizar";
            this.btnAgregarSinRealizar.UseVisualStyleBackColor = true;
            this.btnAgregarSinRealizar.Click += new System.EventHandler(this.btnAgregarSinRealizar_Click);
            // 
            // btnAgregarEnsayoRealizado
            // 
            this.btnAgregarEnsayoRealizado.Location = new System.Drawing.Point(90, 372);
            this.btnAgregarEnsayoRealizado.Name = "btnAgregarEnsayoRealizado";
            this.btnAgregarEnsayoRealizado.Size = new System.Drawing.Size(159, 103);
            this.btnAgregarEnsayoRealizado.TabIndex = 24;
            this.btnAgregarEnsayoRealizado.Text = "Agregar uno ya hecho";
            this.btnAgregarEnsayoRealizado.UseVisualStyleBackColor = true;
            this.btnAgregarEnsayoRealizado.Click += new System.EventHandler(this.btnAgregarEnsayoRealizado_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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