using System;
using System.Collections.Generic;
using System.Text;

namespace Formulario_chingon
{
    class MapaEmpleados
    {
        private int iD;
        private string nombre;
        private string apellidos;
        private string fech_nac;
        private string correo;
        private string telefono;
        private int sucursal;

        public int ID { get => iD; set => iD = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Fech_nac { get => fech_nac; set => fech_nac = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Sucursal { get => sucursal; set => sucursal = value; }
    }
}
