﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Para estilizar DataGridView: https://www.youtube.com/watch?v=HDcdX2endE8

namespace WindowsFormsApplication2
{

    public partial class Form10 : Form
    {
        public int id_asignado { get; set; }
        public string nombre_asignado { get; set; }



        public void display()
        {
            try
            {
                DataTable dt = new DataTable();
                string query = "SELECT NombreProyecto, Estado FROM vw_idProyecto_nombreProyecto_estadoProyecto";
                MySqlCommand commandDatabase = new MySqlCommand(query, Program.databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                MySqlDataAdapter adpt = new MySqlDataAdapter(commandDatabase);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
            }
        }

        public Form10()
        {
            InitializeComponent();
            display();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "SELECT ID FROM vw_idProyecto_nombreProyecto_estadoProyecto ORDER BY ID LIMIT " + e.RowIndex.ToString() + " ,1;";
            try
            {
                MySqlCommand commandDatabase = new MySqlCommand(query, Program.databaseConnection);
                commandDatabase.CommandTimeout = 60;
                this.id_asignado = Int32.Parse(commandDatabase.ExecuteScalar().ToString());
                this.nombre_asignado = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.Close();
            }
            catch (Exception)
            {
                this.id_asignado = -1;
            }

        }
    }
}
