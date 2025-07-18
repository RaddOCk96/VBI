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
    public partial class Catalogo : Form
    {
        public Catalogo()
        {
            InitializeComponent();

        }





        private void button2_Click(object sender, EventArgs e)
        {
            int id_ecosistema = 2;
            Animales_Acuaticos ventanaAA = new Animales_Acuaticos(id_ecosistema);
            ventanaAA.StartPosition = this.StartPosition;
            ventanaAA.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id_ecosistema = 1;
            Animales_Terrestres ventanaA = new Animales_Terrestres(id_ecosistema);
            ventanaA.StartPosition = this.StartPosition;
            ventanaA.Size = this.Size;
            ventanaA.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu ventana = new Menu();
            ventana.StartPosition = this.StartPosition;
            ventana.Size = this.Size;
            ventana.Show();
            this.Close();
        }

        private void catalogo_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id_ecosistema = 3;
            Animales_Aereos ventanaS = new Animales_Aereos(id_ecosistema);
            ventanaS.StartPosition = this.StartPosition;
            ventanaS.Show();
            this.Hide();
        }
    }
}
