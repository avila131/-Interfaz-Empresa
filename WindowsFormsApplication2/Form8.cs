﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Program.closed_by_user = false;
            Program.MenSelection = new Form9();
            this.Close();

        }

        private void Form8_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Program.MenSelection = null;
        }

    }
}
