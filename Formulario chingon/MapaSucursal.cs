using System;
using System.Collections.Generic;
using System.Text;

namespace Formulario_chingon
{
    class MapaSucursal
    {
        private int sucursal;
        private string nombre;
        private string direccion;
        private string horario;

        public int Sucursal { get => sucursal; set => sucursal = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Horario { get => horario; set => horario = value; }
    }
}
