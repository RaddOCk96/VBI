using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace VBI.Clase
{
    internal class Validar
    {
        public static bool NombreAnimalExiste(string nombre)
        {
            Conexion Rconexion = new Conexion();
            using (MySqlConnection conexion = Rconexion.EstablecerConexion())
            {
                string consulta = "SELECT COUNT(*) FROM animales WHERE Nombre = @nombre";
                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    int cantidad = Convert.ToInt32(comando.ExecuteScalar());
                    return cantidad > 0;
                }
            }
        }
    }
}
