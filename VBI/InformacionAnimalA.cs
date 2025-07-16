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
    public partial class InformacionAnimalA : Form
    {
        private int idAnimalActual;

        public InformacionAnimalA(int id)
        {
            InitializeComponent();
            idAnimalActual = id;
            this.Load += new EventHandler(InformacionAnimalA_Load);

        }


        private void InformacionAnimalA_Load(object sender, EventArgs e)     //Cambia todos los valores en cuanto se inicia 
        {
            ActualizarNombreAnimal(idAnimalActual);
            ActualizarNombreCientifico(idAnimalActual);
            MostrarImagen(idAnimalActual);
            MostrarImagen2(idAnimalActual);
            AgregarHabitat(idAnimalActual);
            AgregarAlimentacion(idAnimalActual);
            AgregarReproduccion(idAnimalActual);
            AgregarCaracteristicas(idAnimalActual);
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Animales_Acuaticos ventanaA = new Animales_Acuaticos();
            ventanaA.StartPosition = this.StartPosition;
            ventanaA.Show();
            this.Close();
        }
        private void ActualizarNombreAnimal(int id)
        {
            try
            {
                Conexion Rconexion = new Conexion();                                 //Crea un objeto y el metodo para establecer conexion 
                using (MySqlConnection conexion = Rconexion.EstablecerConexion())
                {
                    string consulta = "SELECT Nombre FROM animales WHERE ID_animal = @id";    //Se almacena la consulta dentro de una variable 
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))      //Se envian de parametros la consulta y la conexion 
                    {
                        comando.Parameters.AddWithValue("@id", id);

                        using (MySqlDataReader reader = comando.ExecuteReader())          //Lee la información de la base de datos 
                        {
                            if (reader.Read())
                            {
                                label1.Text = reader["Nombre"].ToString();             //Agrega el texto leido al label 
                            }
                            else
                            {
                                label1.Text = "Animal no encontrado.";               //Sustituye el label en caso de no encontrar el animal 
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el nombre: " + ex.Message);         //Muestra un error 
            }
        }
        private void ActualizarNombreCientifico(int id)
        {
            try
            {
                Conexion Rconexion = new Conexion();
                using (MySqlConnection conexion = Rconexion.EstablecerConexion())     //Crea un objeto y lo guarda en una variable para la conexion 
                {
                    string consulta = "SELECT NombreCientifico FROM animales WHERE ID_animal =@id";    //Se guarda la consulta en una variable
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", id);                            //Se realiza la consulta 
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                label2.Text = reader["NombreCientifico"].ToString();         //Se reemplaza el texto del label 
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
                                    pbImagen.Image = Image.FromStream(ms); // Asignar imagen al PictureBox
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
        private void MostrarImagen2(int idAnimal)     //Método para mostrar la segunda imagen
        {
            try
            {
                Conexion Rconexion = new Conexion();
                using (MySqlConnection conexion = Rconexion.EstablecerConexion())
                {
                    string consulta = "SELECT Imagen2 FROM animales WHERE ID_animal = @id";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", idAnimal);
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read() && reader["Imagen2"] != DBNull.Value)
                            {
                                byte[] datosImagen = (byte[])reader["Imagen2"];
                                using (MemoryStream ms = new MemoryStream(datosImagen))
                                {
                                    pbImagen2.Image = Image.FromStream(ms); // Asignar imagen al PictureBox
                                }
                            }
                            else
                            {
                                pbImagen2.Image = null;
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
        private void AgregarHabitat(int id)
        {
            try
            {
                Conexion Rconexion = new Conexion();
                using (MySqlConnection conexion = Rconexion.EstablecerConexion())     //Crea un objeto y lo guarda en una variable para la conexion 
                {
                    string consulta = "SELECT Habitat FROM animales WHERE ID_animal =@id";    //Se guarda la consulta en una variable
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", id);                            //Se realiza la consulta 
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                label4.Text = reader["Habitat"].ToString();         //Se reemplaza el texto del label 
                            }
                            else
                            {
                                label4.Text = "Animal no encontrado";
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }
        private void AgregarAlimentacion(int id)
        {
            try
            {
                Conexion Rconexion = new Conexion();
                using (MySqlConnection conexion = Rconexion.EstablecerConexion())     //Crea un objeto y lo guarda en una variable para la conexion 
                {
                    string consulta = "SELECT Comida FROM animales WHERE ID_animal =@id";    //Se guarda la consulta en una variable
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", id);                            //Se realiza la consulta 
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                label5.Text = reader["Comida"].ToString();         //Se reemplaza el texto del label 
                            }
                            else
                            {
                                label5.Text = "Animal no encontrado";
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }
        private void AgregarReproduccion(int id)
        {
            try
            {
                Conexion Rconexion = new Conexion();
                using (MySqlConnection conexion = Rconexion.EstablecerConexion())     //Crea un objeto y lo guarda en una variable para la conexion 
                {
                    string consulta = "SELECT Reproduccion_carac FROM animales WHERE ID_animal =@id";    //Se guarda la consulta en una variable
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", id);                            //Se realiza la consulta 
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                label8.Text = reader["Reproduccion_carac"].ToString();         //Se reemplaza el texto del label 
                            }
                            else
                            {
                                label8.Text = "Animal no encontrado";
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void AgregarCaracteristicas(int id)
        {
            try
            {
                Conexion Rconexion = new Conexion();
                using (MySqlConnection conexion = Rconexion.EstablecerConexion())     //Crea un objeto y lo guarda en una variable para la conexion 
                {
                    string consulta = "SELECT Caracteristicas FROM animales WHERE ID_animal =@id";    //Se guarda la consulta en una variable
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", id);                            //Se realiza la consulta 
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                label10.Text = reader["Caracteristicas"].ToString();         //Se reemplaza el texto del label 
                            }
                            else
                            {
                                label10.Text = "Animal no encontrado";
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            ActualizarNombreAnimal(idAnimalActual);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ActualizarNombreCientifico(idAnimalActual);
        }

        private void pbImagen_Click(object sender, EventArgs e)
        {
            MostrarImagen(idAnimalActual);
        }

        private void pbImagen2_Click(object sender, EventArgs e)
        {
            MostrarImagen2(idAnimalActual);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AgregarHabitat(idAnimalActual);
        }
        private void label5_Click(object sender, EventArgs e)
        {
            AgregarAlimentacion(idAnimalActual);

        }

        private void label8_Click(object sender, EventArgs e)
        {
            AgregarReproduccion(idAnimalActual);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            AgregarCaracteristicas(idAnimalActual);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void InformacionAnimalA_Load_1(object sender, EventArgs e)
        {

        }
    }
}
