﻿using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace formulario
{
    class sqlConnection : classConsultas
    {
        public static int AgrClient(string Name, string AP, String Date,
            String Mail, String Sex, String NumCli, String Phone,
            string Direction)
        {

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
                    + Phone + ");"; //Consulta a MySQL (Introduce datos a la bd)
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
                    //string insertar = " insert into personal (nombre,Apellidos,fech_nac,correo,telefono,id_sucursal) values ('" + nombre + "','" + AP + "','" + fech + "','" + correo + "','" + telefono + "','" + suc + "')"; //Consulta a MySQL (Introduce datos a la bd)
                    string insertar = "call verif_exits_sucs('" + nombre + "','" + AP + "','" + fech + "','" + correo + "','" + telefono + "','" + suc + "')";
                    MySqlCommand comando = new MySqlCommand(insertar); //Declaración SQL para ejecutar contra una base de datos MySQL
                    comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                    conexionBD.Open(); //Abre la conexión
                    reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader
                    while (reader.Read())
                    {
                        datos += reader.GetString(0);
                    }
                    if (datos != null)
                    {
                        MessageBox.Show(datos);

                    }
                    else
                    {
                        MessageBox.Show("Empleado agregado");//Imprime en cuadro de dialogo el resultado

                    }
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
            if (Nombre == "" || Direccion == "" || Horario == "" || Numero == "")
            {
                MessageBox.Show("Debe de llenar todos los campos");
            }

            else
            {
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

        public static void agrtrans(string Transaction, string AccountOrg, string AccountDest, string Date,
            string Money, string typeTrans, string Description)
        {
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
                string consulta = "call verif_exis('" + Transaction + "','" + AccountOrg + "','" + AccountDest + "','" + Date + "','" + Money + "','" + typeTrans + "','" + Description + "')";
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
                if (datos == null)
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

        public static void InicioSystem(string passwd, string user)
        {
            //contra = passwd;
            string servidor = "localhost"; //Nombre o ip del servidor de MySQL
            string bd = "Solosoyyo12"; //Nombre de la base de datos
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
                    //Imprime en cuadro de dialogo el resultado
                }
                else
                {

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            finally
            {
                conexionBD.Close(); //Cierra la conexión a MySQL
            }
            //return 1;
        }

        public static int agrcuenta(string numCue, string numClie, string Sucur, string tip, string saldo)
        {
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
                string consulta = "call Agregar_cuenta(" + numCue + "," + numClie + "," + Sucur + "," + tip + "," + saldo + ")"; //Consulta a MySQL (Introduce datos a la bd)
                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {
                    datos += reader.GetString(0) + "\n"; //Almacena cada registro con un salto de linea
                }

                MessageBox.Show(datos);
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

        public static int delete_cli(string num_cli, String nombre)
        {
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
                string consulta = "delete from cliente where id_cliente = " + num_cli + " and nombre = '" + nombre + "';"; //Consulta a MySQL (Introduce datos a la bd)
                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {
                    datos += reader.GetString(0) + "\n"; //Almacena cada registro con un salto de linea
                }

                MessageBox.Show(datos);
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

        public static void delete_Cuenta(string cuenta)
        {
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
                string consulta = "delete from cuenta where id_cuenta = " + cuenta + ";"; //Consulta a MySQL (Introduce datos a la bd)
                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {
                    datos += reader.GetString(0) + "\n"; //Almacena cada registro con un salto de linea
                }

                MessageBox.Show(datos);
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

        public static void eliminar_trans(string id)
        {
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
                string consulta = "delete from transaccion where id_transaaccion = " + id + ";"; //Consulta a MySQL (Introduce datos a la bd)
                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {
                    datos += reader.GetString(0) + "\n"; //Almacena cada registro con un salto de linea
                }

                MessageBox.Show(datos);
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

        /*public static string Consulta_clie(String numClie)
        {
            string servidor = "localhost"; //Nombre o ip del servidor de MySQL
            string bd = "banco"; //Nombre de la base de datos
            string usuario = "ulises"; //Usuario de acceso a MySQL
            string password = "Solosoyyo12"; //Contraseña de usuario de acceso a MySQL
            string datos=null; //Variable para almacenar el resultado
            int i = 0;


            //Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            //Instancia para conexión a MySQL, recibe la cadena de conexión
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            MySqlDataReader reader = null; //Variable para leer el resultado de la consulta

            //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.

            try
            {
                string consulta = "SELECT cliente.id_cliente, cliente.id_cuenta FROM cliente where id_cliente = '"+ numClie +"'"; //Consulta a MySQL (Introduce datos a la bd)
                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                int contador = reader.FieldCount;
                //datos = new string[contador];
                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {
                    
                    datos += reader.GetString(0);
                    i++;
                    MessageBox.Show(datos);
                }

                
                //MessageBox.Show("Registro echo con exito!!"); //Imprime en cuadro de dialogo el resultado
                return datos;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                
                return null;
            }
            finally
            {
                conexionBD.Close(); //Cierra la conexión a MySQL
            }
        }*/

        /*public static List<object> Cliente(string dato)
        {
            MySqlDataReader reader;

            List<object> lista = new List<object>();
            string sql = "SELECT * FROM cliente WHERE id_cliente = '"+ dato +"';";

            try
            {
                MySqlConnection conexionBD = base.connetDB();
                conexionBD.Open();
                MySqlCommand comand = new MySqlCommand(sql, conexionBD);

                reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    Mapa_Cliente _mapa = new Mapa_Cliente();
                    _mapa.Num_cliente = int.Parse(reader.GetString(0)); 
                    _mapa.Num_cuenta = int.Parse(reader.GetString(1));
                    _mapa.Nombre = reader.GetString(2);
                    _mapa.Apellidos = reader.GetString(3);
                    _mapa.Fecha_nac = reader.GetString(4);
                    _mapa.Direccion = reader.GetString(5);
                    _mapa.Correo = reader.GetString(6);
                    _mapa.Sexo = reader.GetString(7);
                    _mapa.Telefono = int.Parse(reader.GetString(8));

                    lista.Add(_mapa);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

            return lista;
        }*/

        public static string[] Consulta_cliente(string dato)
        {
            string servidor = "localhost"; //Nombre o ip del servidor de MySQL
            string bd = "banco"; //Nombre de la base de datos
            string usuario = "ulises"; //Usuario de acceso a MySQL
            string password = "Solosoyyo12"; //Contraseña de usuario de acceso a MySQL
            string[] datos = null;//Variable para almacenar el resultado


            //Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            //Instancia para conexión a MySQL, recibe la cadena de conexión
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            MySqlDataReader reader = null; //Variable para leer el resultado de la consulta

            //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.
            try
            {
                string consulta = "call consulta_clientex2 (" + dato + ")"; //Consulta a MySQL (Introduce datos a la bd)
                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader
                int contador = reader.FieldCount;//obtiene el tamaño del reader
                datos = new string[contador];

                while (reader.Read())
                {

                    datos[0] += reader.GetString(0);//Almacena cada registro
                    datos[1] += reader.GetString(1);
                    datos[2] += reader.GetString(2);
                    datos[3] += reader.GetString(3);
                    datos[4] += reader.GetString(4);
                    datos[5] += reader.GetString(5);
                    datos[6] += reader.GetString(6);
                    datos[7] += reader.GetString(7);
                    datos[8] += reader.GetString(8);

                }
                return datos;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conexionBD.Close(); //Cierra la conexión a MySQL
            }

        }
        public static void edit_cliente(String dato, string Nombre, String Apellido, String fecha, String Direccion, string correo, String sexo, string telefono)
        {

            string servidor = "localhost"; //Nombre o ip del servidor de MySQL
            string bd = "banco"; //Nombre de la base de datos
            string usuario = "ulises"; //Usuario de acceso a MySQL
            string password = "Solosoyyo12"; //Contraseña de usuario de acceso a MySQL
            string[] datos = null;//Variable para almacenar el resultado


            //Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            //Instancia para conexión a MySQL, recibe la cadena de conexión
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            MySqlDataReader reader = null; //Variable para leer el resultado de la consulta

            //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.
            try
            {
                string consulta = "call edit_cliente ('" + dato + "','" + Nombre + "','" + Apellido + "','" + Direccion + "','" + correo + "','" + sexo + "','" + telefono + "')"; //Consulta a MySQL (Introduce datos a la bd)
                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader
                int contador = reader.FieldCount;//obtiene el tamaño del reader
                datos = new string[contador];
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

        public static string[] consulta_cuenta(string dato)
        {
            string servidor = "localhost"; //Nombre o ip del servidor de MySQL
            string bd = "banco"; //Nombre de la base de datos
            string usuario = "ulises"; //Usuario de acceso a MySQL
            string password = "Solosoyyo12"; //Contraseña de usuario de acceso a MySQL
            string[] datos = null;//Variable para almacenar el resultado


            //Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            //Instancia para conexión a MySQL, recibe la cadena de conexión
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            MySqlDataReader reader = null; //Variable para leer el resultado de la consulta

            //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.
            try
            {
                string consulta = "call consulta_cuenta (" + dato + ")"; //Consulta a MySQL (Introduce datos a la bd)
                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader
                int contador = reader.FieldCount;//obtiene el tamaño del reader
                datos = new string[contador];

                while (reader.Read())
                {

                    datos[0] += reader.GetString(0);//Almacena cada registro
                    datos[1] += reader.GetString(1);
                    datos[2] += reader.GetString(2);
                    datos[3] += reader.GetString(3);
                    datos[4] += reader.GetString(4);


                }
                return datos;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conexionBD.Close(); //Cierra la conexión a MySQL
            }
        }

        public static void edit_cuenta(string dato, string tipo, string saldo)
        {
            string servidor = "localhost"; //Nombre o ip del servidor de MySQL
            string bd = "banco"; //Nombre de la base de datos
            string usuario = "ulises"; //Usuario de acceso a MySQL
            string password = "Solosoyyo12"; //Contraseña de usuario de acceso a MySQL
            string[] datos = null;//Variable para almacenar el resultado


            //Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            //Instancia para conexión a MySQL, recibe la cadena de conexión
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            MySqlDataReader reader = null; //Variable para leer el resultado de la consulta

            //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.
            try
            {
                string consulta = "update cuenta set tipo_de_cuenta = '"+tipo+"',saldo = '"+saldo+"' where id_cuenta = "+dato+""; //Consulta a MySQL (Introduce datos a la bd)
                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader
                int contador = reader.FieldCount;//obtiene el tamaño del reader
                datos = new string[contador];
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
}
