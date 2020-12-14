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
                sql = "SELECT cuenta.id_cuenta,clientes.id_clientes,clientes.nombre,clientes.apellidos,cuenta.tipo_de_cuenta,cuenta.saldo " +
                    "FROM clientes,cuenta WHERE cuenta.id_cliente = clientes.id_clientes ";
            }
            else
            {
                sql = "SELECT distinct cuenta.id_cuenta,clientes.id_clientes,clientes.nombre,clientes.apellidos,cuenta.tipo_de_cuenta,cuenta.saldo " +
                    "FROM cuenta LEFT JOIN clientes ON clientes.id_clientes = cuenta.id_cliente where clientes.nombre LIKE '%" + dato+ "%' OR " +
                    "clientes.apellidos LIKE '%" + dato + "%' OR clientes.id_clientes LIKE '%" + dato + "%'";
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
                    _mapa.Id_cliente = int.Parse(reader.GetString(1));
                    _mapa.Nombre = reader.GetString(2);
                    _mapa.Apellido = reader.GetString(3);
                    _mapa.Tipo_cuenta = reader.GetString(4);
                    _mapa.Saldo = decimal.Parse(reader.GetString(5));
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

            string sql = "INSERT INTO cuenta (id_cliente,tipo_de_cuenta,saldo)" +
                "values('"+datos.Id_cliente+"','" + datos.Tipo_cuenta + "','" + datos.Saldo + "')";

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
        public bool EditCuentas(MapaCuentas datos)
        {
            bool bandera = false;

            string sql = "UPDATE cuenta set tipo_de_cuenta = '" + datos.Tipo_cuenta + "',saldo = '" + datos.Saldo + "'" +
                " WHERE id_cuenta = '"+datos.Id_cuenta+"' ";

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

        public bool deleteCuenta(int ID)
        {
            bool bandera = false;

            string sql = "DELETE FROM cuenta WHERE id_cuenta = '" + ID + "' ";

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
