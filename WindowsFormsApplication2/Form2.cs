﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public MySqlDataReader reader;
        private int projectIndexSelected;

        public Form2()
        {
            InitializeComponent();
            projectIndexSelected = -1;
            setProyectos("");
        }

        private void setProyectos(string filtro)
        {
            string query = "SELECT * FROM vw_proyecto_lab WHERE pro_nombreProyecto LIKE "
                + " '%" + filtro + "%'";
            MySqlCommand commandDatabase = new MySqlCommand(query, Program.databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                comboBox1.Items.Clear();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        String[] row = {
                                           (!reader.IsDBNull(0))?reader.GetString(0):"",
                                           (!reader.IsDBNull(1))?reader.GetString(1):""
                                       };
                        int index = Int32.Parse(row[0]);

                        ComboboxItem nuevo = new ComboboxItem();
                        nuevo.Text = row[1];
                        nuevo.Value = index;

                        comboBox1.Items.Add(nuevo);
                    }
                    reader.Close();
                }
                else
                {
                    reader.Close();
                }
            }
            catch (MySqlException e)
            {
                if (reader != null) reader.Close();
                MessageBox.Show(e.Message);
            }
            comboBox1.SelectedIndex = -1;
            comboBox1.ResetText();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            groupBox1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            int valor = comboBox2.SelectedIndex;
            switch (valor)
            {
                case 0:
                    groupBox1.Visible = false;
                    break;
                case 1:
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    groupBox1.Text = "Empleado";
                    break;
                case 2:
                    textBox6.Visible = true;
                    label11.Visible = true;
                    groupBox1.Text = "Tipo Ensayo";
                    break;
                case 3:
                    textBox7.Visible = true;
                    textBox8.Visible = true;
                    textBox9.Visible = true;
                    textBox10.Visible = true;
                    textBox11.Visible = true;
                    textBox12.Visible = true;
                    label12.Visible = true;
                    label13.Visible = true;
                    label14.Visible = true;
                    label16.Visible = true;
                    label17.Visible = true;
                    label18.Visible = true;
                    groupBox1.Text = "Muestra";
                    break;
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            setProyectos(textBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxItem item = (comboBox1.SelectedItem as ComboboxItem);
            if (item == null)
            {
                projectIndexSelected = -1;
            }
            else
            {
                projectIndexSelected = item.Value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Program.MenSelection = null;
        }
    }
}
