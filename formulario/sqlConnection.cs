using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace formulario
{
    class sqlConnection
    {
        public static int AgrClient(string Name, string AP, string AccountType, String Date,
            String Balance, String Mail, string Sucursal, String Sex, String NumCli, String Phone, 
            string Account, string Direction)
        {
            //Variables provenientes de las cajas de texto
            
            //Variables provenientes de las cajas de texto

            //int contador = 0;//contador para verificar si ya se paso por algún 

            //Seccion de condicionales, para verificar que no quede algún dato sin llenar

            //Fin del area de condicionales


            
            
                string servidor = "localhost"; //Nombre o ip del servidor de MySQL
                string bd = "banco"; //Nombre de la base de datos
                string usuario = "ulises"; //Usuario de acceso a MySQL
                string password = "Solosoyyo12"; //Contraseña de usuario de acceso a MySQL
                string datos = null; //Variable para almacenar el resultado

                //Crearemos la cadena de conexión concatenando las variables
                string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

                //Instancia para conexión a MySQL, recibe la cadena de conexión
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
                MySqlDataReader reader = null; //Variable para leer el resultado de la consulta

                //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.

                try
                {
                    string consulta = "insert into cliente" +
                        "(id_cliente,nombre,apellidos,fecha_nac,direccion,correo,sexo,telefono) values" +
                        "(" + NumCli + ",'" + Name + "','" + AP + "','" + Date + "','" + Direction + "','" + Mail + "','" + Sex + "',"
                        + Phone + ");" +
                        "insert into cuenta (id_cuenta,id_cliente,id_sucursal,tipo_de_cuenta,saldo)" +
                        "values(" + Account + "," + NumCli + "," + Sucursal + ",'" + AccountType + "','" + Balance + "');" +
                        "update cliente set id_cuenta = " + Account + " where id_cliente = " + NumCli + ";" +
                        "update cuenta set id_cliente = " + NumCli + " where id_cuenta = " + Account + ";"; //Consulta a MySQL (Introduce datos a la bd)
                    MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                    comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                    conexionBD.Open(); //Abre la conexión
                    reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                    while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                    {
                        datos += reader.GetString(0) + "\n"; //Almacena cada registro con un salto de linea
                    }

                MessageBox.Show("Cliente agregado");
                    //MessageBox.Show("Registro echo con exito!!"); //Imprime en cuadro de dialogo el resultado
                }
                catch (MySqlException ex)
                {
                MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexionBD.Close(); //Cierra la conexión a MySQL
                }
                return 0;
           
        }
    }
}
