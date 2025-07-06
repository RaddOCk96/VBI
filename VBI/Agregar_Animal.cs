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
        //Se agregan variables que almacenan imagenes en arreglos bytes 

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

        private void btnAgImagen2_Click(object sender, EventArgs e)   //permite ingresar la segunda imagen
        {
            OpenFileDialog selectorImagen2 = new OpenFileDialog();     //Crea un cuadro de dialogo para seleccionar una imagen 
            selectorImagen2.Title = "Seleccionar imagen";

            if (selectorImagen2.ShowDialog() == DialogResult.OK)      //Abre un dialogo y espera el archivo del usuario
            {
                pbAgImagen2.Image = Image.FromStream(selectorImagen2.OpenFile());         //Carga la imagen en el picturebox

                MemoryStream memoria = new MemoryStream();
                pbAgImagen2.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Png);   //Se crea un objeto para convertir
                imagenByte2 = memoria.ToArray();                                          // la imagen en un arreglo de bytes
            }
        }

        private void btnAgGuardar_Click(object sender, EventArgs e)     //Botón para guardar todo y enviar a la BD
        {
            Conexion Rconexion = new Conexion();                             //Se crea un objeto para la conexión
            using (MySqlConnection conexion = Rconexion.EstablecerConexion())   //Se inicia la conexión 
            {
                try
                {
                    //Concatena los valores en una variable donde se envían a la tabla 
                    string consultaI = @"INSERT INTO animales_terrestres
                     (Nombre, NombreCientifico, Reproduccion, Alimentacion, Habitat, Caracteristicas, Imagen, Imagen2)
                     VALUES 
                     (@Nombre, @NombreCientifico, @Reproduccion, @Alimentacion, @Habitat, @Caracteristicas, @Imagen, @Imagen2)";


                    using (MySqlCommand comando = new MySqlCommand(consultaI, conexion))
                    {
                        //Se asignan los valores de los TextBox
                        comando.Parameters.AddWithValue("@Nombre", txtAgNombre.Text);
                        comando.Parameters.AddWithValue("@NombreCientifico", txtAgCientifico.Text);
                        comando.Parameters.AddWithValue("@Reproduccion", txtAgReDescripcion.Text);
                        comando.Parameters.AddWithValue("@Alimentacion", txtAgAlDescripcion.Text);
                        comando.Parameters.AddWithValue("@Habitat", txtAgHaDescripcion.Text);
                        comando.Parameters.AddWithValue("@Caracteristicas", txtAgCaracteristicas.Text);
                        comando.Parameters.AddWithValue("@Imagen", imagenByte1 ?? new byte[0]);   //En caso que no se seleccione una imagen
                        comando.Parameters.AddWithValue("@Imagen2", imagenByte2 ?? new byte[0]);   //Crea un arreglo vacio para no generar errores

                        //Ejecuga la consulta y devulve el número de filas afectadas 
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




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAgImagen1_Click(object sender, EventArgs e) //Permite agregar la primera imagen
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();  //Se crea un cuadro de dialogo 
            selectorImagen.Title = "Seleccionar imagen";

            if (selectorImagen.ShowDialog() == DialogResult.OK)    //Abre el cuadro y espera archivo
            {

                pbAgImagen1.Image = Image.FromStream(selectorImagen.OpenFile()); //Envia la imagen a la PB


                //Convierte el la imagen en un arreglo de bytes
                MemoryStream memoria = new MemoryStream();
                pbAgImagen1.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Png);
                imagenByte1 = memoria.ToArray();
            }

        }

        private void txtAgCientifico_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbAgImagen1_Click(object sender, EventArgs e)
        {

        }

        private void pbAgImagen2_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar()  //Metodo que limpia todos los campos de la textbox y picturebox
        {
            txtAgNombre.Clear();
            txtAgCientifico.Clear();
            txtAgReDescripcion.Clear();
            txtAgHaDescripcion.Clear();
            txtAgCaracteristicas.Clear();
            pbAgImagen1.Image = null;
            pbAgImagen2.Image = null;
            imagenByte1 = null;
            imagenByte2 = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Animales_Terrestres ventanaA = new Animales_Terrestres(); //Se crea un objeto 
            ventanaA.StartPosition = this.StartPosition;             //Adquiere la posicion 
            ventanaA.Size = this.Size;                              //Y tamaño de la pantalla anterior
            ventanaA.Show();               //Muestra la pantalla
            this.Close();                 //Cierra la pantalla
        }
    }
}
