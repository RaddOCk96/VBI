using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using VBI.Clase;

namespace VBI
{
    public partial class Agregar_Animal : Form
    {
        public Agregar_Animal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Agregar_Animal_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAgNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgImagen2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgGuardar_Click(object sender, EventArgs e)
        {
            Conexion Rconexion = new Conexion();
            string nombreAnimal = txtAgNombre.Text;
            string nombreCientifico = txtAgCientifico.Text;
            string ecosistema =



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
