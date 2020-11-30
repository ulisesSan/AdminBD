using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Formulario_chingon
{
    class CtrlSucursal : MysqlConection
    {
        public List<object> lista_suc(string dato)
        {
            MySqlDataReader reader;

            List<object> lista = new List<object>();

            string sql;

            if (dato == null)
            {
                sql = "SELECT * FROM sucursal;";
            }
            else
            {
                sql = "SELECT sucursal.id_sucursal,sucursal.nombre,sucursal.direccion,sucursal.horario FROM sucursal WHERE id_sucursal " +
                    "LIKE '%"+dato+ "%' OR nombre LIKE '%" + dato + "%' OR direccion LIKE '%" + dato + "%' " +
                    "OR horario LIKE '%" + dato + "%' OR";
            }

            try
            {
                MySqlConnection conexionBD = base.conectMysql();

                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);

                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    MapaSucursal _mapa = new MapaSucursal();
                    _mapa.Sucursal = int.Parse(reader.GetString(0));
                    _mapa.Nombre = reader.GetString(1);
                    _mapa.Direccion = reader.GetString(2);
                    _mapa.Horario= reader.GetString(3);
                    lista.Add(_mapa);
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

            return lista;
        }
        public bool deleteClientes(int ID)
        {
            bool bandera = false;

            string sql = "DELETE FROM clientes WHERE id_clientes = '" + ID + "' ";

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

        public bool Edit_Suc(MapaSucursal datos)
        {
            bool bandera = false;

            string sql = "UPDATE sucursal SEt nombre = '" + datos.Nombre + "',direccion = '"+datos.Direccion+"', horario = '"+datos.Horario+"' WHERE id_sucursal = '" + datos.Sucursal + "' ";

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

        public bool insertar_suc (MapaSucursal datos)
        {
            bool bandera = false;

            string sql = "INSERT INTO sucursal (nombre,direccion,horario)" +
                "values('" + datos.Nombre + "', '" + datos.Direccion + "', '" + datos.Horario + "')";

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
