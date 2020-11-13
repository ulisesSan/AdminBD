using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulario
{
    class Mapa_Cliente
    {
        private int num_cliente;
        private int num_cuenta;
        private string nombre;
        private string apellidos;
        private string fecha_nac;
        private string direccion;
        private string correo;
        private string sexo;
        private int telefono;

        public int Num_cliente { get => num_cliente; set => num_cliente = value; }
        public int Num_cuenta { get => num_cuenta; set => num_cuenta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Fecha_nac { get => fecha_nac; set => fecha_nac = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Telefono { get => telefono; set => telefono = value; }
    }
}
