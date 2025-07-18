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
    public partial class Animales_Aereos : Form
    {
        private int ecosistemaActual;
        public Animales_Aereos(int idEcosistemas)
        {
            InitializeComponent();

            ecosistemaActual = idEcosistemas;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idAnimalActual = 4;
            InformacionAnimalAE ventanaS = new InformacionAnimalAE(idAnimalActual, ecosistemaActual);
            ventanaS.StartPosition = this.StartPosition;
            ventanaS.Show();
            this.Hide();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Catalogo ventanaA = new Catalogo();
            ventanaA.StartPosition = this.StartPosition;
            ventanaA.Show();
            this.Close();
        }

        private void btnListaAnimalesAe_Click(object sender, EventArgs e)
        {
            Lista_Animales_Terrestres ventanaS = new Lista_Animales_Terrestres(ecosistemaActual);
            ventanaS.StartPosition = this.StartPosition;
            ventanaS.Show();
            this.Hide();
        }
    }
}
