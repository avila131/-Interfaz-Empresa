using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            Program.MenSelection = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.MenSelection = new Form6();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.MenSelection = new Form3();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.MenSelection = new Form5();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Program.databaseConnection != null)
            {
                Program.databaseConnection.Close();
            }
            Program.MenSelection = new Form9();
            this.Close();
        }
    }
}
