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
    public partial class catalogo : Form
    {
        public catalogo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animales_Terrestres ventanaA = new Animales_Terrestres();
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
    }
}
