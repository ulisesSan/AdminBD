using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Formulario_chingon
{
    class CtrlCliente : MysqlConection
    {
        public List<object> lista_cliente(string dato)
        {
            MySqlDataReader reader;

            List<object> lista = new List<object>();

            string sql;
            
            if(dato== null)
            {
                sql = "SELECT cliente.id_cliente, cliente.nombre, cliente.apellidos, cliente.fecha_nac,cliente.direccion,cliente.correo,cliente.sexo,cliente.telefono FROM  cliente;";
            }
            else
            {
                sql = "SELECT cliente.id_cliente, cliente.nombre, cliente.apellidos, cliente.fecha_nac,cliente.direccion,cliente.correo,cliente.sexo,cliente.telefono FROM cliente WHERE id_cliente LIKE '%" + dato + "%' OR nombre LIKE '%" + dato + "%' OR apellidos LIKE '%" + dato + "%' OR fecha_nac LIKE '%" + dato + "%' " +
                    "OR direccion LIKE '%" + dato + "%' OR correo LIKE '%" + dato + "%' OR sexo LIKE '%" + dato + "%' OR telefono LIKE '%" + dato + "%'";
            }

            try
            {
                MySqlConnection conexionBD = base.conectMysql();

                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);

                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    MapaCliente _mapa = new MapaCliente();
                    _mapa.Id_cliente = int.Parse(reader.GetString(0));
                    _mapa.Nombre = reader.GetString(1);
                    _mapa.Apellidos = reader.GetString(2);
                    _mapa.Fecha = reader.GetString(3);
                    _mapa.Direccion = reader.GetString(4);
                    _mapa.Correo = reader.GetString(5);
                    _mapa.Sexo = reader.GetString(6);
                    _mapa.Telefono = int.Parse(reader.GetString(7));
                    lista.Add(_mapa);
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

            return lista;
        }

        public bool insertClientes(MapaCliente datos)
        {
            bool bandera = false;

            string sql = "INSERT INTO cliente (nombre,apellidos,fecha_nac,direccion,correo,sexo,telefono)" +
                "values('"+datos.Nombre+ "', '" + datos.Apellidos + "', '" + datos.Fecha + "', '" + datos.Direccion + "', '" + datos.Correo + "', '" + datos.Sexo + "', '" + datos.Telefono + "')";

            try
            {
                MySqlConnection conexionBD = base.conectMysql();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                bandera = true;
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Error"+ex.Message);
                bandera = false;
            }

            return bandera;
        }

        public bool EditClientes(MapaCliente datos)
        {
            bool bandera = false;

            string sql = "UPDATE cliente  set nombre = '" + datos.Nombre + "',apellidos = '" + datos.Apellidos + "',fecha_nac = '" + datos.Fecha + "',direccion = '" + datos.Direccion + "' " +
                ",correo = '" + datos.Correo + "',sexo = '" + datos.Sexo + "',telefono = '" + datos.Telefono + "' WHERE id_cliente = '" + datos.Id_cliente + "' ";

            try
            {
                MySqlConnection conexionBD = base.conectMysql();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                bandera = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error" + ex.Message);
                bandera = false;
            }

            return bandera;
        }

        public bool deleteClientes(int ID)
        {
            bool bandera = false;

            string sql = "DELETE FROM cliente WHERE id_cliente = '" + ID + "' ";

            try
            {
                MySqlConnection conexionBD = base.conectMysql();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                bandera = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error" + ex.Message);
                bandera = false;
            }

            return bandera;
        }
    }
}
