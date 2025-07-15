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
                Conexion reconexion2 = new Conexion();

                String query = "select Nombre from animales";
                tablaAnimales.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, reconexion2.EstablecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaAnimales.DataSource = dt;
                reconexion2.CerrarConexion();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los datos de la base de datos, error" + ex.ToString());
            }

        }
    }
}
