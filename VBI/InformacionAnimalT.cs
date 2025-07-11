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



    }
}
