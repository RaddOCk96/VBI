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
    public partial class Animales_Terrestres : Form
    {
        public Animales_Terrestres()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lista_Animales_Terrestres ventanaS = new Lista_Animales_Terrestres();
            ventanaS.StartPosition = this.StartPosition;
            ventanaS.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idSeleccionado = 1;
            InformacionAnimalT ventanaIA = new InformacionAnimalT(idSeleccionado);
            ventanaIA.StartPosition = this.StartPosition;
            ventanaIA.Show();
            this.Hide();

        }



        private void button3_Click_1(object sender, EventArgs e)
        {
            int idSeleccionado = 2;
            InformacionAnimalT ventanaIA = new InformacionAnimalT(idSeleccionado);
            ventanaIA.StartPosition = this.StartPosition;
            ventanaIA.Show();
            this.Hide();
        }

        private void Animales_Terrestres_Load(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Catalogo ventanaA = new Catalogo();
            ventanaA.StartPosition = this.StartPosition;
            ventanaA.Show();
            this.Close();
        }
    }
}
