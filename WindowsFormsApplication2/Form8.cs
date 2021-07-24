using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
﻿using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Imagenes\\logoEmpresa.png"));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.closed_by_user = false;
            Program.MenSelection = new Form1();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.closed_by_user = false;
            Program.MenSelection = new Form5();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.closed_by_user = false;
            Program.MenSelection = new Form6();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.closed_by_user = false;
            Program.MenSelection = new Form3();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Program.closed_by_user = false;
            Program.MenSelection = new Form4();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Program.databaseConnection != null)
            {
                Program.databaseConnection.Close();
            }
            Program.closed_by_user = true;
            Program.loop_logueo = true;
            this.Close();

        }

        private void Form8_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Program.MenSelection = null;
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Program.closed_by_user = false;
            Program.MenSelection = new Form14();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.closed_by_user = false;
            String[] arg = new String[3];
            MySqlDataReader mr = null;
            string query = "SELECT pro_idProyecto, mue_idMuestra, per_idPerforacion FROM " +
                "Perforacion NATURAL JOIN Muestra LIMIT 1;";
            MySqlCommand cmd = Program.getNewMySqlCommand(query);
            try
            {
                mr = cmd.ExecuteReader();
                if (mr.HasRows)
                {
                    mr.Read();
                    arg[0] = mr.GetString(0);
                    arg[1] = mr.GetString(1);
                    arg[2] = mr.GetString(2);
                    Program.closed_by_user = false;
                    Program.MenSelection = new Form11(arg[1],arg[2],arg[0]);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No hay registros de muestras");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No fue posible iniciar el formulario");
                MessageBox.Show(ex.Message);
            }
            finally { if (mr != null)mr.Close(); }
            
        }
    }
}
