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
            Agregar_Animal ventanaAA = new Agregar_Animal(); //Crea un objeto
            ventanaAA.StartPosition = this.StartPosition;  //Adquiere la posicion y tamaño de la ventana actual
            ventanaAA.Size = this.Size;
            ventanaAA.Show();       //Muestra el forms
            this.Hide();           //Esconde el forms actual
        }
    }
}
