﻿namespace WindowsFormsApplication2
 {
     partial class Form7
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
             this.groupBox1 = new System.Windows.Forms.GroupBox();
             this.button4 = new System.Windows.Forms.Button();
             this.button3 = new System.Windows.Forms.Button();
             this.button2 = new System.Windows.Forms.Button();
             this.button1 = new System.Windows.Forms.Button();
             this.button5 = new System.Windows.Forms.Button();
             this.panel1 = new System.Windows.Forms.Panel();
             this.pictureBox1 = new System.Windows.Forms.PictureBox();
             this.label23 = new System.Windows.Forms.Label();
             this.groupBox1.SuspendLayout();
             this.panel1.SuspendLayout();
             ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
             this.SuspendLayout();
             // 
             // groupBox1
             // 
             this.groupBox1.BackColor = System.Drawing.Color.White;
             this.groupBox1.Controls.Add(this.button4);
             this.groupBox1.Controls.Add(this.button3);
             this.groupBox1.Controls.Add(this.button2);
             this.groupBox1.Controls.Add(this.button1);
             this.groupBox1.Location = new System.Drawing.Point(40, 120);
             this.groupBox1.Name = "groupBox1";
             this.groupBox1.Size = new System.Drawing.Size(302, 214);
             this.groupBox1.TabIndex = 1;
             this.groupBox1.TabStop = false;
             // 
             // button4
             // 
             this.button4.BackColor = System.Drawing.Color.Red;
             this.button4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
             this.button4.Location = new System.Drawing.Point(14, 73);
             this.button4.Name = "button4";
             this.button4.Size = new System.Drawing.Size(279, 32);
             this.button4.TabIndex = 3;
             this.button4.Text = "Ensayos a Muestras";
             this.button4.UseVisualStyleBackColor = false;
             // 
             // button3
             // 
             this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
             this.button3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
             this.button3.Location = new System.Drawing.Point(14, 163);
             this.button3.Name = "button3";
             this.button3.Size = new System.Drawing.Size(279, 32);
             this.button3.TabIndex = 2;
             this.button3.Text = "Tipos de ensayos";
             this.button3.UseVisualStyleBackColor = false;
             this.button3.Click += new System.EventHandler(this.button3_Click);
             // 
             // button2
             // 
             this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
             this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
             this.button2.Location = new System.Drawing.Point(15, 115);
             this.button2.Name = "button2";
             this.button2.Size = new System.Drawing.Size(279, 32);
             this.button2.TabIndex = 1;
             this.button2.Text = "Perforaciones - Muestras";
             this.button2.UseVisualStyleBackColor = false;
             this.button2.Click += new System.EventHandler(this.button2_Click);
             // 
             // button1
             // 
             this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
             this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
             this.button1.Location = new System.Drawing.Point(14, 33);
             this.button1.Name = "button1";
             this.button1.Size = new System.Drawing.Size(279, 32);
             this.button1.TabIndex = 0;
             this.button1.Text = "Archivo Resultado - Informe Final";
             this.button1.UseVisualStyleBackColor = false;
             this.button1.Click += new System.EventHandler(this.button1_Click);
             // 
             // button5
             // 
             this.button5.BackColor = System.Drawing.Color.White;
             this.button5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
             this.button5.Location = new System.Drawing.Point(108, 358);
             this.button5.Name = "button5";
             this.button5.Size = new System.Drawing.Size(142, 32);
             this.button5.TabIndex = 4;
             this.button5.Text = "Cerrar Sesión";
             this.button5.UseVisualStyleBackColor = false;
             this.button5.Click += new System.EventHandler(this.button5_Click);
             // 
             // panel1
             // 
             this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(79)))), ((int)(((byte)(138)))));
             this.panel1.Controls.Add(this.pictureBox1);
             this.panel1.Controls.Add(this.label23);
             this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
             this.panel1.Location = new System.Drawing.Point(0, 0);
             this.panel1.Name = "panel1";
             this.panel1.Size = new System.Drawing.Size(529, 100);
             this.panel1.TabIndex = 68;
             // 
             // pictureBox1
             // 
             //this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.logoEmpresa;
             //this.pictureBox1.InitialImage = global::WindowsFormsApplication2.Properties.Resources.logoEmpresa;
             this.pictureBox1.Location = new System.Drawing.Point(412, 3);
             this.pictureBox1.Name = "pictureBox1";
             this.pictureBox1.Size = new System.Drawing.Size(99, 94);
             this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
             this.pictureBox1.TabIndex = 7;
             this.pictureBox1.TabStop = false;
             // 
             // label23
             // 
             this.label23.AutoSize = true;
             this.label23.BackColor = System.Drawing.Color.Transparent;
             this.label23.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
             this.label23.ForeColor = System.Drawing.Color.White;
             this.label23.Location = new System.Drawing.Point(34, 34);
             this.label23.Name = "label23";
             this.label23.Size = new System.Drawing.Size(343, 33);
             this.label23.TabIndex = 6;
             this.label23.Text = "MENÚ DE LABORATORISTA";
             // 
             // Form7
             // 
             this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
             this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
             this.BackColor = System.Drawing.Color.White;
             this.ClientSize = new System.Drawing.Size(529, 432);
             this.Controls.Add(this.panel1);
             this.Controls.Add(this.button5);
             this.Controls.Add(this.groupBox1);
             this.Name = "Form7";
             this.Text = "Menu Laboratorista";
             this.groupBox1.ResumeLayout(false);
             this.panel1.ResumeLayout(false);
             this.panel1.PerformLayout();
             ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
             this.ResumeLayout(false);

         }

         #endregion
         private System.Windows.Forms.GroupBox groupBox1;
         private System.Windows.Forms.Button button4;
         private System.Windows.Forms.Button button3;
         private System.Windows.Forms.Button button2;
         private System.Windows.Forms.Button button1;
         private System.Windows.Forms.Button button5;
         private System.Windows.Forms.Panel panel1;
         private System.Windows.Forms.PictureBox pictureBox1;
         private System.Windows.Forms.Label label23;
     }
 }
