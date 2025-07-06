using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace VBI.Clase
{
    internal class Conexion
    {
        MySqlConnection conexion = new MySqlConnection();   //Se crea un objeto para representar la conexion a la BD
        string CadenaConexion = "server = 127.0.0.1; user id =root; password = FRDKCU96; database = vbi"; //Contiene datos necesarios para conexion 

        public MySqlConnection EstablecerConexion()    //Crea un método para iniciar conexion 
        {
            try     //Intenta abrir una conexion a la base de datos
            {
                conexion.ConnectionString = CadenaConexion; //Asigna la cadena 
                conexion.Open();     //Abre la conexion 
            }
            catch (MySqlException ex) //Avisa del error
            {
                MessageBox.Show($"No fue posible conectarse a la base de datos, error: {ex}");
            }
            return conexion; //Retorna la conexion, abierta o no 

        }

        public void CerrarConexion()          //Cierra la conexion 
        {
            conexion.Close();
        }

    }
}
