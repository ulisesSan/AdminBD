using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Formulario_chingon
{
    class CtrlEmpleados : MysqlConection
    {
        public List<object> lista_emp(string dato)
        {

            DateTime fecha;
            MySqlDataReader reader;

            List<object> lista = new List<object>();

            string sql;

            if (dato == null)
            {
                sql = "SELECT * FROM personal;";
            }
            else
            {
                sql = "SELECT * FROM personal " +
                    "WHERE id_persona LIKE '%" + dato + "%' OR nombre LIKE '%" + dato + "%' OR apellidos LIKE '%" + dato + "%' OR correo LIKE '%" + dato + "%'";
            }

            try
            {
                MySqlConnection conexionBD = base.conectMysql();

                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);

                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    MapaEmpleados _mapa = new MapaEmpleados();
                    _mapa.ID = int.Parse(reader.GetString(0));
                    _mapa.Nombre = reader.GetString(1);
                    _mapa.Apellidos = reader.GetString(2);
                    fecha = Convert.ToDateTime(reader.GetString(3));
                    _mapa.Fech_nac = fecha.ToString("dd/MM/yyy");
                    //_mapa.Fech_nac = reader.GetString(3);
                    _mapa.Correo = reader.GetString(4);
                    _mapa.Telefono = reader.GetString(5);
                    _mapa.Sucursal = int.Parse(reader.GetString(6));
                    lista.Add(_mapa);
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }

            return lista;
        }

        public bool Edit_Emp(MapaEmpleados datos)
        {
            bool bandera = false;

            string sql = "UPDATE personal SET nombre = '" + datos.Nombre + "',Apellidos = '" + datos.Apellidos + "', fech_nac = '" + datos.Fech_nac + "',correo = '" + datos.Correo + "'" +
                ", telefono = '" + datos.Telefono + "' WHERE id_persona = '" + datos.ID + "' ";

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

        public bool insertar_Emp(MapaEmpleados datos)
        {
            bool bandera = false;

            string sql = "call InsertarEmpleado('" + datos.Nombre + "','" + datos.Apellidos + "','" + datos.Fech_nac + "','" + datos.Correo + "'" +
                ",'" + datos.Telefono + "','" + datos.Sucursal + "')";
            /*string sql = "INSERT INTO personal (nombre,Apellidos,fech_nac,correo,telefono,id_sucursal)" +
                "VALUES(nombre = '" + datos.Nombre + "',Apellidos = '" + datos.Apellidos + "', fech_nac = '" + datos.Fech_nac + "',correo = '" + datos.Correo + "'" +
                ", telefono = '" + datos.Telefono + "', id_sucursal = '"+datos.Sucursal+"')";*/

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

        public bool EliminarEmp(int ID)
        {

            bool bandera = false;

            string sql = "DELETE FROM personal WHERE id_persona = '" + ID + "' ";

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
