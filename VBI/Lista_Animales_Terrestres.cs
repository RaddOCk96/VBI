using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VBI
{
    public partial class Lista_Animales_Terrestres : Form
    {
        public Lista_Animales_Terrestres()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Animales_Terrestres ventanaA = new Animales_Terrestres();
            ventanaA.StartPosition = this.StartPosition;
            ventanaA.Show();
            this.Close();
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            Agregar_Animal ventanaS = new Agregar_Animal();
            ventanaS.StartPosition = this.StartPosition;
            ventanaS.Show();
            this.Hide();
        }
    }
}
