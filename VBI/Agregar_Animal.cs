﻿using System;
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
        int id_ecosistema;
        string Tipo_reproduccion;
        string Tipo_alimentacion;

        private int ecosistemaActual;

        public Agregar_Animal(int idEcosistemas)
        {
            InitializeComponent();

            ecosistemaActual = idEcosistemas;

            cbEcosistema.Items.Add("Terrestres");
            cbEcosistema.Items.Add("Acuáticos");
            cbEcosistema.Items.Add("Aéreos");

            cbAlimentacion.Items.Add("Herbivoro");
            cbAlimentacion.Items.Add("Carnivoro");
            cbAlimentacion.Items.Add("Omnivoro");
            cbAlimentacion.Items.Add("Insectivoro");

            cbReproduccion.Items.Add("Viviparo");
            cbReproduccion.Items.Add("Oviparo");
            cbReproduccion.Items.Add("Ovoviviparo");

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
            Conexion Rconexion = new Conexion();                             //Se crea un objeto para la conexión
            using (MySqlConnection conexion = Rconexion.EstablecerConexion())   //Se inicia la conexión 
            {


                if (!string.IsNullOrWhiteSpace(txtAgAlDescripcion.Text) &&
                  !string.IsNullOrWhiteSpace(cbAlimentacion.Text) &&
                  !string.IsNullOrWhiteSpace(txtAgCaracteristicas.Text) &&
                  !string.IsNullOrWhiteSpace(txtAgCientifico.Text) &&      //Si todos los campos seleccionados están llenados
                  !string.IsNullOrWhiteSpace(txtAgHaDescripcion.Text) &&   //procede con el registro
                  !string.IsNullOrWhiteSpace(txtAgNombre.Text) &&
                  !string.IsNullOrWhiteSpace(cbEcosistema.Text) &&
                  !string.IsNullOrWhiteSpace(cbReproduccion.Text) &&
                  !string.IsNullOrWhiteSpace(txtAgReDescripcion.Text) &&
                   id_ecosistema != 0)
                {
                    string nombreAnimal = txtAgNombre.Text.Trim();

                    if (Clase.Validar.NombreAnimalExiste(nombreAnimal))
                    {
                        MessageBox.Show("Ya existe un animal con ese nombre. No se puede registrar.", "Nombre duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    try
                    {
                        //Concatena los valores en una variable donde se envían a la tabla 
                        string consultaI = @"INSERT INTO animales
                     (Nombre, NombreCientifico, Tipo_reproduccion, Reproduccion_carac, Tipo_alimentacion, Comida, Habitat, Caracteristicas, Imagen, Imagen2, id_ecosistema)
                     VALUES 
                     (@Nombre, @NombreCientifico, @Tipo_reproduccion, @Reproduccion_carac, @Tipo_alimentacion, @Comida, @Habitat, @Caracteristicas, @Imagen, @Imagen2, @id_ecosistema)";


                        using (MySqlCommand comando = new MySqlCommand(consultaI, conexion))
                        {

                            //Se asignan los valores de los TextBox
                            comando.Parameters.AddWithValue("@Nombre", txtAgNombre.Text);
                            comando.Parameters.AddWithValue("@NombreCientifico", txtAgCientifico.Text);
                            comando.Parameters.AddWithValue("@Tipo_Reproduccion", Tipo_reproduccion);
                            comando.Parameters.AddWithValue("@Reproduccion_carac", txtAgReDescripcion.Text);
                            comando.Parameters.AddWithValue("@Tipo_alimentacion", Tipo_alimentacion);
                            comando.Parameters.AddWithValue("@Comida", txtAgAlDescripcion.Text);
                            comando.Parameters.AddWithValue("@Habitat", txtAgHaDescripcion.Text);
                            comando.Parameters.AddWithValue("@Caracteristicas", txtAgCaracteristicas.Text);
                            comando.Parameters.AddWithValue("@id_ecosistema", id_ecosistema);
                            comando.Parameters.AddWithValue("@Imagen", imagenByte1 ?? new byte[0]);   //En caso que no se seleccione una imagen
                            comando.Parameters.AddWithValue("@Imagen2", imagenByte2 ?? new byte[0]);   //Crea un arreglo vacio para no generar errores

                            //Ejecuta la consulta y devulve el número de filas afectadas 
                            int resultado = comando.ExecuteNonQuery();
                            if (resultado > 0) //1 si todo está bien
                            {
                                MessageBox.Show("Animal registrado");
                                Limpiar();  //Limpia todos los campos 
                            }
                            else
                            {
                                MessageBox.Show("No se pudo registrar el animal"); //Mensaje de error
                            }
                        }
                    }


                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar    Error:{ex}");
                    }
                }



                else
                {
                    MessageBox.Show("Completa los campos obligatorios");
                }
            }


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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Limpiar()  //Metodo que limpia todos los campos de la textbox y picturebox
        {
            txtAgNombre.Clear();
            txtAgCientifico.Clear();
            txtAgReDescripcion.Clear();
            txtAgHaDescripcion.Clear();
            txtAgAlDescripcion.Clear();
            txtAgCaracteristicas.Clear();
            cbEcosistema.Items.Clear();
            cbAlimentacion.Items.Clear();
            cbReproduccion.Items.Clear();
            pbAgImagen1.Image = null;
            pbAgImagen2.Image = null;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cbEcosistema_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbEcosistema.Text)
            {
                case "Terrestres":
                    id_ecosistema = 1;
                    break;
                case "Acuáticos":
                    id_ecosistema = 2;
                    break;
                case "Aéreos":
                    id_ecosistema = 3;
                    break;
                default:
                    id_ecosistema = 0;
                    break;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cbAlimentacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbAlimentacion.Text)
            {
                case "Herbivoro":
                    Tipo_alimentacion = "Herbivoro";
                    break;
                case "Carnivoros":
                    Tipo_alimentacion = "Carnivoro";
                    break;
                case "Omnivoro":
                    Tipo_alimentacion = "Omnivoro";
                    break;
                case "Insectivoro":
                    Tipo_alimentacion = "Insectivoro";
                    break;
            }
        }

        private void cbReproduccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbReproduccion.Text)
            {
                case "Viviparo":
                    Tipo_reproduccion = "Viviparo";
                    break;
                case "Oviparo":
                    Tipo_reproduccion = "Oviparo";
                    break;
                case "Ovoviviparo":
                    Tipo_reproduccion = "Ovoviviparo";
                    break;
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Lista_Animales_Terrestres ventanaA = new Lista_Animales_Terrestres(ecosistemaActual);
            ventanaA.StartPosition = this.StartPosition;
            ventanaA.Show();
            this.Close();
        }
    }
}
