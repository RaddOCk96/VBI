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
    public partial class Editar_Animal : Form
    {
        byte[] imagenByte1;
        byte[] imagenByte2;
        int id_ecosistema;
        string EdTipo_Alimentacion;
        string EdTipo_reproduccion;
        string nombreOriginal;

        private int ecosistemaActual;

        public Editar_Animal(string nombreAnimal, int idEcosistemas)
        {
            InitializeComponent();

            nombreOriginal = nombreAnimal;

            ecosistemaActual = idEcosistemas;


            // Carga de opciones al iniciar
            cbEcosistema.Items.Add("Terrestres");
            cbEcosistema.Items.Add("Acuáticos");
            cbEcosistema.Items.Add("Aéreos");

            cbEdAlimentacion.Items.Add("Herbivoro");
            cbEdAlimentacion.Items.Add("Carnivoro");
            cbEdAlimentacion.Items.Add("Omnivoro");
            cbEdAlimentacion.Items.Add("Insectivoro");

            cbEdReproduccion.Items.Add("Viviparo");
            cbEdReproduccion.Items.Add("Oviparo");
            cbEdReproduccion.Items.Add("Ovoviviparo");

            CargarDatosAnimal(nombreAnimal);
        }

        private void Editar_Animal_Load(object sender, EventArgs e)
        {

        }

        private void CargarDatosAnimal(string nombre)
        {
            Conexion reconexion3 = new Conexion();
            MySqlConnection conn = reconexion3.EstablecerConexion(); //Se conecta a la base de datos

            string consultaCargar = "SELECT Nombre, NombreCientifico, Tipo_reproduccion, Reproduccion_carac, Tipo_alimentacion, Comida, Habitat, Caracteristicas, Imagen, Imagen2, id_ecosistema FROM animales WHERE Nombre = @nombre"; //Busca el nombre del animal en la base de datos


            //Carga toda la información almacenada en el formulario
            using (MySqlCommand cmd = new MySqlCommand(consultaCargar, conn))
            {
                cmd.Parameters.AddWithValue("@nombre", nombre);

                try
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtEdNombre.Text = reader["Nombre"].ToString();
                            txtEdCientifico.Text = reader["NombreCientifico"].ToString();
                            txtEdReDescripcion.Text = reader["Reproduccion_carac"].ToString();
                            txtEdAlDescripcion.Text = reader["Comida"].ToString();
                            txtEdHabitat.Text = reader["Habitat"].ToString();
                            txtEdCaracteristicas.Text = reader["Caracteristicas"].ToString();

                            cbEdReproduccion.Text = reader["Tipo_reproduccion"].ToString();
                            cbEdAlimentacion.Text = reader["Tipo_Alimentacion"].ToString();
                            id_ecosistema = Convert.ToInt32(reader["id_ecosistema"]);
                            cbEcosistema.SelectedIndex = id_ecosistema - 1;

                        }

                        if (reader["Imagen"] != DBNull.Value)
                        {
                            byte[] imagenBytes1 = (byte[])reader["Imagen"];

                            using (MemoryStream ms1 = new MemoryStream(imagenBytes1))
                            {
                                pbEdImagen1.Image = Image.FromStream(ms1);
                            }
                        }

                        if (reader["Imagen2"] != DBNull.Value)
                        {
                            byte[] imagenBytes2 = (byte[])reader["Imagen2"];

                            using (MemoryStream ms2 = new MemoryStream(imagenBytes2))
                            {
                                pbEdImagen2.Image = Image.FromStream(ms2);
                            }
                        }

                        else
                        {
                            MessageBox.Show("No se encontró el animal con ese nombre.", "Advertencia");
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al cargar el animal:\n" + ex.Message, "Error");
                }

                reconexion3.CerrarConexion();
            }
        }

        private void btnEdGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEdNombre.Text))
            {
                string nuevoNombre = txtEdNombre.Text.Trim();

                if (nuevoNombre != nombreOriginal && Validar.NombreAnimalExiste(nuevoNombre))
                {
                    MessageBox.Show("Ya existe otro animal con ese nombre. No se puede guardar.", "Nombre duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Conexion conexionGuardar = new Conexion();
                MySqlConnection conn = conexionGuardar.EstablecerConexion();

                string consultActualizar = @"UPDATE animales SET  
                     Nombre = @nuevoNombre,
                     NombreCientifico = @nuevoCientifico,
                     Tipo_reproduccion = @nuevoTrepro,
                     Reproduccion_carac = @nuevoReproCarac,
                     Tipo_alimentacion = @nuevoTAlimentacion,
                     Comida = @nuevaComida,
                     Habitat = @nuevaHabitat,
                     Caracteristicas = @nuevaCaracteristica,
                     Imagen = @nuevaImagen,
                     Imagen2 = @nuevaImagen2,
                     id_ecosistema = @nuevoIdEco
                     WHERE Nombre = @nombreOriginal"; //Actualiza la información

                //Se guardan todos los cambios
                using (MySqlCommand cmd = new MySqlCommand(consultActualizar, conn))
                {
                    cmd.Parameters.AddWithValue("@nuevoNombre", txtEdNombre.Text);
                    cmd.Parameters.AddWithValue("@nuevoCientifico", txtEdCientifico.Text);
                    cmd.Parameters.AddWithValue("@nuevoTrepro", EdTipo_reproduccion);
                    cmd.Parameters.AddWithValue("@nuevoReproCarac", txtEdReDescripcion.Text);
                    cmd.Parameters.AddWithValue("@nuevoTAlimentacion", EdTipo_Alimentacion);
                    cmd.Parameters.AddWithValue("@nuevaComida", txtEdAlDescripcion.Text);
                    cmd.Parameters.AddWithValue("@nuevaHabitat", txtEdHabitat.Text);
                    cmd.Parameters.AddWithValue("@nuevaCaracteristica", txtEdCaracteristicas.Text);
                    cmd.Parameters.AddWithValue("@nuevoIdEco", id_ecosistema);
                    cmd.Parameters.AddWithValue("@nombreOriginal", nombreOriginal);


                    //Imagen 1

                    //En caso de que el usuario no selecciona nada en imagen 1 se guardará el anterior registrado
                    if (imagenByte1 != null && imagenByte1.Length > 0)
                    {
                        cmd.Parameters.AddWithValue("@nuevaImagen", imagenByte1);
                    }

                    else if (pbEdImagen1.Image != null)
                    {
                        using (MemoryStream ms1 = new MemoryStream())
                        {
                            pbEdImagen1.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Png);
                            cmd.Parameters.AddWithValue("@nuevaImagen", ms1.ToArray());
                        }
                    }

                    else
                    {
                        cmd.Parameters.AddWithValue("@nuevaImagen", DBNull.Value);
                    }

                    //Imagen 2

                    //En caso de que el usuario no se seleccione nada en imagen 2, se guardará el anterior registrado
                    if (imagenByte2 != null && imagenByte2.Length > 0)
                    {
                        cmd.Parameters.AddWithValue("@nuevaImagen2", imagenByte2);
                    }

                    else if (pbEdImagen2.Image != null)
                    {
                        using (MemoryStream ms2 = new MemoryStream())
                        {
                            pbEdImagen2.Image.Save(ms2, System.Drawing.Imaging.ImageFormat.Png);
                            cmd.Parameters.AddWithValue("@nuevaImagen2", ms2.ToArray());
                        }
                    }

                    else
                    {
                        cmd.Parameters.AddWithValue("@nuevaImagen2", imagenByte2);
                    }


                        try
                        {
                            int resultado = cmd.ExecuteNonQuery();

                            if (resultado > 0)
                            {
                                MessageBox.Show("Animal actualizado correctamente.");
                            this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo actualizar el animal.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al actualizar el animal:\n" + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    conexionGuardar.CerrarConexion();
                }

            }

            else
            {
                MessageBox.Show("Completa los campos obligatorios.");
            }
        }

        //Cargar Imagen 1
        private void btnEdImagen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog selectorImagen1 = new OpenFileDialog();
                selectorImagen1.Title = "Seleccionar imagen";

                if (selectorImagen1.ShowDialog() == DialogResult.OK)
                {
                    pbEdImagen1.Image = Image.FromStream(selectorImagen1.OpenFile());
                    MemoryStream memoria1 = new MemoryStream();
                    pbEdImagen1.Image.Save(memoria1, System.Drawing.Imaging.ImageFormat.Png);

                    imagenByte1 = memoria1.ToArray();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar la imagen 1: \n" + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Cargar Imagen 2
        private void btnEdImagen2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog selectorImagen2 = new OpenFileDialog();
                selectorImagen2.Title = "Seleccionar imagen";

                if (selectorImagen2.ShowDialog() == DialogResult.OK)
                {
                    pbEdImagen2.Image = Image.FromStream(selectorImagen2.OpenFile());
                    MemoryStream memoria2 = new MemoryStream();
                    pbEdImagen2.Image.Save(memoria2, System.Drawing.Imaging.ImageFormat.Png);

                    imagenByte2 = memoria2.ToArray();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar la imagen 1: \n" + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //Botón para regresar a la sección de "Animales Terrestres"
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Lista_Animales_Terrestres ventanaA = new Lista_Animales_Terrestres(ecosistemaActual);
            ventanaA.StartPosition = this.StartPosition;
            ventanaA.Show();
            this.Close();
        }

       
        

        //Información de los tipos de alimentación
        private void cbAlimentacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbEdAlimentacion.Text)
            {
                case "Herbivoro":
                    EdTipo_Alimentacion = "Herbivoro";
                    break;
                case "Carnivoros":
                    EdTipo_Alimentacion = "Carnivoro";
                    break;
                case "Omnivoro":
                    EdTipo_Alimentacion = "Omnivoro";
                    break;
                case "Insectivoro":
                    EdTipo_Alimentacion = "Insectivoro";
                    break;
            }
        }

        //Información de tipos de reproducción
        private void cbReproduccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbEdReproduccion.Text)
            {
                case "Viviparo":
                    EdTipo_reproduccion = "Viviparo";
                    break;
                case "Oviparo":
                    EdTipo_reproduccion = "Oviparo";
                    break;
                case "Ovoviviparo":
                    EdTipo_reproduccion = "Ovoviviparo";
                    break;
            }
        }

        //Muestra la información en el comboBox de "Tipo de Reproducción"
        private void cbEdReproduccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            EdTipo_reproduccion = cbEdReproduccion.Text;
        }

        //Muestra la información en ek comboBox de "Tipo de Alimentación"
        private void cbEdAlimentacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            EdTipo_Alimentacion = cbEdAlimentacion.Text;
        }

        //Id de los ecosistemas y sus opciones
        private void cbEcosistema_SelectedIndexChanged_1(object sender, EventArgs e)
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
    }
}
