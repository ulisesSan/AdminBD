using System;
using System.Collections.Generic;
using System.Text;

namespace Formulario_chingon
{
    class MapaCuentas
    {
        private int id_cuenta;
        private string nombre;
        private string apellido;
        private string tipo_cuenta;
        private float saldo;

        public int Id_cuenta { get => id_cuenta; set => id_cuenta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Tipo_cuenta { get => tipo_cuenta; set => tipo_cuenta = value; }
        public float Saldo { get => saldo; set => saldo = value; }
      
    }
}
