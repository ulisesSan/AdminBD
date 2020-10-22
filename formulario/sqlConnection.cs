using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Security.Policy;

namespace formulario
{
    class sqlConnection
    {
        public datos()
        {
            String contra;
            string usa;
        }
        public static int AgrClient(string Name, string AP, string AccountType, String Date,
            String Balance, String Mail, string Sucursal, String Sex, String NumCli, String Phone,
            string Account, string Direction)
        { 

            string servidor = "localhost"; //Nombre o ip del servidor de MySQL
            string bd = "banco"; //Nombre de la base de datos
            string usuario = "ulises"; //Usuario de acceso a MySQL
            string password = "a"; //Contraseña de usuario de acceso a MySQL
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

        public static void agremp(string nombre, string AP, string fech, string correo, string telefono,
            string suc)
        {
            if (nombre == "" || AP == "" || fech == "" || correo == "" || telefono == "")
            {
                MessageBox.Show("Debe de llenar todos los campos");
            }
            else
            {
                string servidor = "localhost"; //Nombre o ip del servidor de MySQL
                string bd = "banco"; //Nombre de la base de datos
                string usuario = "ulises"; //Usuario de acceso a MySQL
                string password = "a"; //Contraseña de usuario de acceso a MySQL
                string datos = null; //Variable para almacenar el resultado

                //Crearemos la cadena de conexión concatenando las variables
                string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

                //Instancia para conexión a MySQL, recibe la cadena de conexión
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
                MySqlDataReader reader = null; //Variable para leer el resultado de la consulta

                //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.

                try
                {
                    //string insertar = "call in_emp('" + nombre + "','" + AP + "','" + fech + "','" + correo + "','" + telefono + "','" + suc + "')";
                    string insertar = " insert into personal (nombre,Apellidos,fech_nac,correo,telefono,id_sucursal) values ('" + nombre + "','" + AP + "','" + fech + "','" + correo + "','" + telefono + "','" + suc + "')"; //Consulta a MySQL (Introduce datos a la bd)
                    MySqlCommand comando = new MySqlCommand(insertar); //Declaración SQL para ejecutar contra una base de datos MySQL
                    comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                    conexionBD.Open(); //Abre la conexión
                    reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                    MessageBox.Show("Empleado agregado");
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
            }
        }

        public static void agrSuc(string Nombre, string Direccion, string Horario, string Numero)
        {
            ;

            if (Nombre == "" || Direccion == "" || Horario == ""  || Numero == "")
            {
                MessageBox.Show("Debe de llenar todos los campos");
            }

            else
            {
                string servidor = "localhost"; //Nombre o ip del servidor de MySQL
                string bd = "banco"; //Nombre de la base de datos
                string usuario = "ulises"; //Usuario de acceso a MySQL
                string password = "a"; //Contraseña de usuario de acceso a MySQL
                string datos = null; //Variable para almacenar el resultado

                //Crearemos la cadena de conexión concatenando las variables
                string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

                //Instancia para conexión a MySQL, recibe la cadena de conexión
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
                MySqlDataReader reader = null; //Variable para leer el resultado de la consulta

                //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.

                try
                {
                    string consulta = "insert into sucursal(id_sucursal,nombre,direccion,horario) values" +
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
            }
        }

        public static void agrtrans(string Transaction,string AccountOrg,string AccountDest,string Date,
            string Money,string typeTrans,string Description)
        {
            string servidor = "localhost"; //Nombre o ip del servidor de MySQL
            string bd = "banco"; //Nombre de la base de datos
            string usuario = "ulises"; //Usuario de acceso a MySQL
            string password = "a"; //Contraseña de usuario de acceso a MySQL
            string datos = null; //Variable para almacenar el resultado

            //Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            //Instancia para conexión a MySQL, recibe la cadena de conexión
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            MySqlDataReader reader = null; //Variable para leer el resultado de la consulta

            //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.

            try
            {
                string consulta = "call verif_exis('"+Transaction+"','"+AccountOrg+"','"+AccountDest+"','"+Date+"','"+Money+"','"+typeTrans+"','"+Description+"')";
                //string consulta = "insert into transaccion(id_transaaccion,id_cuenta,id_cuenta_dest,fecha,monto,tipo_transaccio,descripcion)" +
                //    "values('"+Transaction+"','"+AccountOrg+ "','"+AccountDest+ "','"+Date+ "','"+Money+ "','"+typeTrans+ "','"+Descriprion+"')";//Introduce datos a la bd
                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {
                    datos += reader.GetString(0) + "\n"; //Almacena cada registro con un salto de linea
                }
                if(datos == null)
                {
                    MessageBox.Show("Agregado con exito!!");//Imprime en cuadro de dialogo el resultado
                }
                else
                {
                    MessageBox.Show(datos);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message); //Si existe un error aquí muestra el mensaje
            }
            finally
            {
                conexionBD.Close(); //Cierra la conexión a MySQL
            }
        }

        public static int InicioSystem(string passwd, string user)
        {
            contra = passwd;
            string servidor = "localhost"; //Nombre o ip del servidor de MySQL
            string bd = "banco"; //Nombre de la base de datos
            string usuario = user; //Usuario de acceso a MySQL
            string password = passwd; //Contraseña de usuario de acceso a MySQL
            string datos = null; //Variable para almacenar el resultado

            //Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            //Instancia para conexión a MySQL, recibe la cadena de conexión
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            MySqlDataReader reader = null; //Variable para leer el resultado de la consulta

            //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.

            try
            {
                string consulta = "show tables";
                //string consulta = "insert into transaccion(id_transaaccion,id_cuenta,id_cuenta_dest,fecha,monto,tipo_transaccio,descripcion)" +
                //    "values('"+Transaction+"','"+AccountOrg+ "','"+AccountDest+ "','"+Date+ "','"+Money+ "','"+typeTrans+ "','"+Descriprion+"')";//Introduce datos a la bd
                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {
                    datos += reader.GetString(0) + "\n"; //Almacena cada registro con un salto de linea
                }
                if (datos != null)
                {
                    return 0;//Imprime en cuadro de dialogo el resultado
                }
                else
                {
                    return 1;
                }
            }
            catch (MySqlException ex)
            {
                return 1;
            }
            finally
            {
                conexionBD.Close(); //Cierra la conexión a MySQL
            }
             //return 1;
        }
    }
}
