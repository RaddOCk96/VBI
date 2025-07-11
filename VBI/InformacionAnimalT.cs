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
    public partial class InformacionAnimalT : Form
    {

        private int idAnimalActual;

        public InformacionAnimalT(int id)
        {
            InitializeComponent();
            idAnimalActual = id;

        }


        private void label1_Click(object sender, EventArgs e)
        {
            ActualizarNombreAnimal(idAnimalActual);
        }

        private void ActualizarNombreAnimal(int id)
        {
            try
            {
                Conexion Rconexion = new Conexion();
                using (MySqlConnection conexion = Rconexion.EstablecerConexion())
                {
                    string consulta = "SELECT Nombre FROM animales WHERE ID_animal = @id";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", id);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                label1.Text = reader["Nombre"].ToString();
                            }
                            else
                            {
                                label1.Text = "Animal no encontrado.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el nombre: " + ex.Message);
            }
        }



        private void ActualizarNombreCientifico(int id)
        {
            try
            {
                Conexion Rconexion = new Conexion();
                using (MySqlConnection conexion = Rconexion.EstablecerConexion())
                {
                    string consulta = "SELECT NombreCientifico FROM animales WHERE ID_animal =@id";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", id);
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                label2.Text = reader["NombreCientifico"].ToString();
                            }
                            else
                            {
                                label2.Text = "Animal no encontrado";
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void InformacionAnimalT_Load(object sender, EventArgs e)
        {
            ActualizarNombreAnimal(idAnimalActual);
            ActualizarNombreCientifico(idAnimalActual);

        }

        private void label2_Click(object sender, EventArgs e)
        {
            ActualizarNombreCientifico(idAnimalActual);
        }
        private void MostrarImagen(int idAnimal)
        {
            try
            {
                Conexion Rconexion = new Conexion();
                using (MySqlConnection conexion = Rconexion.EstablecerConexion())
                {
                    string consulta = "SELECT Imagen FROM animales WHERE ID_animal = @id";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", idAnimal);
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read() && reader["Imagen"] != DBNull.Value)
                            {
                                byte[] datosImagen = (byte[])reader["Imagen"];
                                using (MemoryStream ms = new MemoryStream(datosImagen))
                                {
                                    pbImagen.Image = Image.FromStream(ms); // ✅ Asignar imagen al PictureBox
                                }
                            }
                            else
                            {
                                pbImagen.Image = null;
                                MessageBox.Show("No se encontró imagen para este animal.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }
        }


        private void pbImagen_Click(object sender, EventArgs e)
        {
            MostrarImagen(idAnimalActual);
        }
    }
}
