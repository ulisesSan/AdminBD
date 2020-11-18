using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Formulario_chingon
{
    class MysqlConection
    {
        public MySqlConnection conectMysql()//se crea un metodo de tipo MySqlConnection
        {
            string servidor = "localhost"; //Nombre o ip del servidor de MySQL
            string bd = "banco"; //Nombre de la base de datos
            string usuario = "root"; //Usuario de acceso a MySQL
            string password = "root"; //Contraseña de usuario de acceso a MySQL
            //string datos = null; //Variable para almacenar el resultado

            //Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; " +
                "User Id=" + usuario + "; Password=" + password + "";

            //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.

            try
            {

                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
                return conexionBD;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message); //Si existe un error aquí muestra el mensaje
                return null;
            }
        }
    }
}
