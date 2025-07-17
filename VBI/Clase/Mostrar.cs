using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace VBI.Clase
{
    internal class Mostrar
    {
        public void MostrarAnimales(DataGridView tablaAnimales)
        {
            try
            {
                Conexion conexionMostrar = new Conexion();

                String consultaNombre = "select Nombre from animales";
                tablaAnimales.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(consultaNombre, conexionMostrar.EstablecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaAnimales.DataSource = dt;
                conexionMostrar.CerrarConexion();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los datos de la base de datos, error" + ex.ToString());
            }

        }

        public void MostrarNombresEcosistemas(DataGridView tablaAnimales, int idEcosistemas)
        {
            try
            {
                Conexion conexionEco = new Conexion();

                String consulIdEco = "SELECT Nombre FROM animales WHERE id_ecosistema = @id";
                tablaAnimales.DataSource = null;

                using (MySqlCommand cmd = new MySqlCommand(consulIdEco, conexionEco.EstablecerConexion()))
                {
                    cmd.Parameters.AddWithValue("@id", idEcosistemas);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    tablaAnimales.DataSource = dt;
                }

                conexionEco.CerrarConexion();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar animales por ecosistema:\n" + ex.ToString());
            }
        }

    }
}
