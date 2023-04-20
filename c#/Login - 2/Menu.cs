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
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }

        private void lblWho_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
