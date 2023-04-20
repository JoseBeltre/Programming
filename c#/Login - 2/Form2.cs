using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblNotAllowed.Text = "You're not allowed to use this option";
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 pantalla = new Form1();
            this.Hide();
            pantalla.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About pantalla = new About();
            pantalla.Show();
        }
    }
}
