using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Formulario_chingon
{
    class CtrlCuenta : MysqlConection
    {
        public List<object> lista_cuenta(string dato)
        {
            MySqlDataReader reader;

            List<object> lista = new List<object>();

            string sql;

            if (dato == null)
            {
                sql = "SELECT cuenta.id_cuenta,clientes.nombre,clientes.apellidos,cuenta.tipo_de_cuenta,cuenta.saldo FROM clientes,cuenta WHERE cuenta.id_cliente = clientes.id_clientes ";
            }
            else
            {
                sql = "SELECT cuenta.id_cuenta,clientes.nombre,clientes.apellidos,cuenta.tipo_de_cuenta,cuenta.saldo FROM clientes,cuenta WHERE cuenta.id_cliente = clientes.id_clientes ";
            }

            try
            {
                MySqlConnection conexionBD = base.conectMysql();

                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);

                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    MapaCuentas _mapa = new MapaCuentas();
                    _mapa.Id_cuenta= int.Parse(reader.GetString(0));
                    _mapa.Nombre = reader.GetString(1);
                    _mapa.Apellido = reader.GetString(2);
                    _mapa.Tipo_cuenta = reader.GetString(3);
                    _mapa.Saldo = float.Parse(reader.GetString(4));
                    lista.Add(_mapa);
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

            return lista;
        }

        public bool insert_cuenta(MapaCuentas datos)
        {
            bool bandera = false;

            string sql = "INSERT INTO cliente (nombre,apellidos,fecha_nac,direccion,correo,sexo,telefono)" +
                "values('" + datos.Tipo_cuenta + "', '" + datos.Saldo + "' ";

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
