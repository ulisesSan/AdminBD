using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Formulario_chingon
{
    class CtrlTransaccion : MysqlConection
    {
        public List<object> lista_transaccion(string dato)
        {
            MySqlDataReader reader;

            List<object> lista = new List<object>();

            string sql;

            if (dato == null)
            {
                sql = "SELECT * FROM  transaccion;";
            }
            else
            {
                sql = "SELECT * FROM Transaccion WHERE id_transaaccion LIKE '%"+dato+ "%' OR tipo_transaccio LIKE '%" + dato + "%'";
            }

            try
            {
                MySqlConnection conexionBD = base.conectMysql();

                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);

                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    MapaTransaccion _mapa = new MapaTransaccion();
                    _mapa.Transaccion = int.Parse(reader.GetString(0));
                    _mapa.Cuenta = int.Parse(reader.GetString(1));
                    _mapa.Cliente = int.Parse(reader.GetString(2));
                    _mapa.Fecha = reader.GetString(3);
                    _mapa.Monto = decimal.Parse(reader.GetString(4));
                    _mapa.Tipo= reader.GetString(5);
                    lista.Add(_mapa);
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

            return lista;
        }

        public bool insertTransaccion(MapaTransaccion datos)
        {
            bool bandera = false;

            string sql = "INSERT INTO transaccion (id_cuenta,id_cliente,monto,tipo_transaccio)" +
                "values('" + datos.Cuenta + "', '" + datos.Cliente + "', '" + datos.Monto + "', '" + datos.Tipo + "')";

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

        public bool EditTransaccion(MapaTransaccion datos)
        {
            bool bandera = false;

            string sql = "UPDATE transaccion  set id_cuenta = '"+datos.Cuenta+"', id_cliente = '"+datos.Cliente+"', monto ='"+datos.Monto+"',tipo_transaccio = '"+datos.Tipo+"'" +
                " WHERE id_transaaccion = '"+datos.Transaccion+"'";

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

        public bool deleteTransaccion(int ID)
        {
            bool bandera = false;

            string sql = "DELETE FROM transaccion WHERE id_transaaccion = '" + ID + "' ";

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
