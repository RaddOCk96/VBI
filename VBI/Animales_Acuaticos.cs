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
    public partial class Animales_Acuaticos : Form
    {
        private int ecosistemaActual;
        public Animales_Acuaticos(int idEcosistemas)
        {
            InitializeComponent();

            ecosistemaActual = idEcosistemas;
        }

        private void Animales_Acuaticos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idAnimalActual = 3;
            InformacionAnimalA ventanaS = new InformacionAnimalA(idAnimalActual, ecosistemaActual);
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

        private void btnAnimalesAcua_Click(object sender, EventArgs e)
        {
            Lista_Animales_Terrestres ventanS = new Lista_Animales_Terrestres(ecosistemaActual);
            ventanS.StartPosition = this.StartPosition;
            ventanS.Show();
            this.Hide();
        }
    }
}

