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
        public Animales_Acuaticos()
        {
            InitializeComponent();
        }

        private void Animales_Acuaticos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idAnimalActual = 3;
            InformacionAnimalA ventanaS = new InformacionAnimalA(idAnimalActual);
            ventanaS.StartPosition = this.StartPosition;
            ventanaS.Show();
            
        }
    }
}
