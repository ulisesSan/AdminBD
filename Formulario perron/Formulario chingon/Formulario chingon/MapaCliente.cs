using System;
using System.Collections.Generic;
using System.Text;

namespace Formulario_chingon
{
    class MapaCliente
    {
        private int id_cliente;
        private string nombre;
        private string apellidos;
        private string fecha;
        private string direccion;
        private string correo;
        private string sexo;
        private int telefono;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Telefono { get => telefono; set => telefono = value; }   
    }
}
