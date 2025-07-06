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
        byte[] imagenByte1;
        byte[] imagenByte2;

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
            try
            {

                OpenFileDialog selectorImagen2 = new OpenFileDialog();
                selectorImagen2.Title = "Seleccionar imagen";

                if (selectorImagen2.ShowDialog() == DialogResult.OK)
                {
                    pbAgImagen2.Image = Image.FromStream(selectorImagen2.OpenFile());
                    MemoryStream memoria2 = new MemoryStream();
                    pbAgImagen2.Image.Save(memoria2, System.Drawing.Imaging.ImageFormat.Png);

                    imagenByte2 = memoria2.ToArray();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar la imagen 2: \n" + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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

        private void btnAgImagen1_Click(object sender, EventArgs e)
        {
            try
            {


                OpenFileDialog selectorImagen1 = new OpenFileDialog();
                selectorImagen1.Title = "Seleccionar imagen";

                if (selectorImagen1.ShowDialog() == DialogResult.OK)
                {
                    pbAgImagen1.Image = Image.FromStream(selectorImagen1.OpenFile());
                    MemoryStream memoria1 = new MemoryStream();
                    pbAgImagen1.Image.Save(memoria1, System.Drawing.Imaging.ImageFormat.Png);

                    imagenByte1 = memoria1.ToArray();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar la imagen 1: \n" + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtAgCientifico_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAgReproduccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
