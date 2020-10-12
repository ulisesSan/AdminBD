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

namespace formulario
{
    public partial class AgrSucursales : Form
    {
        public AgrSucursales()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Nombre = textNameSucs.Text;
            string Direccion = textDirSucs.Text;
            string Horario = textTimeSucs.Text;
            string Numero = textNumSucs.Text;
            int conta =0;

            if(Nombre == "")
            {
                MessageBox.Show("Debe de llenar todos los campos");
                conta++;

            }

            if(Direccion == "" && conta == 0)
            {
                MessageBox.Show("Debe de llenar todos los campos");
            }

            if (Horario == "" && conta == 0)
            {
                MessageBox.Show("Debe de llenar todos los campos");
            }

            if (Numero == "" && conta == 0)
            {
                MessageBox.Show("Debe de llenar todos los campos");
            }

            else
            {
                string servidor = "localhost"; //Nombre o ip del servidor de MySQL
                string bd = "mysql"; //Nombre de la base de datos
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
                    string consulta = "use banco; insert into sucursal(id_sucursal,nombre,direccion,horario) values" +
                        " (" + Numero + ",'" + Nombre + "','" + Direccion + "','" + Horario + "')";//Introduce datos a la bd
                    MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                    comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                    conexionBD.Open(); //Abre la conexión
                    reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                    while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                    {
                        datos += reader.GetString(0) + "\n"; //Almacena cada registro con un salto de linea
                    }

                    MessageBox.Show("Agregado con exito!!"); //Imprime en cuadro de dialogo el resultado
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message); //Si existe un error aquí muestra el mensaje
                }
                finally
                {
                    conexionBD.Close(); //Cierra la conexión a MySQL
                }

                textNameSucs.Text = ("");
                textDirSucs.Text = ("");
                textTimeSucs.Text = ("");
                textNumSucs.Text = ("");
            }
        }
    }
}
