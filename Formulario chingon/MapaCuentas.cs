using System;
using System.Collections.Generic;
using System.Text;

namespace Formulario_chingon
{
    class MapaCuentas
    {
        private int id_cuenta;
        private int id_cliente;
        private string nombre;
        private string apellido;
        private string tipo_cuenta;
        private decimal saldo;

        public int Id_cuenta { get => Id_cuenta1; set => Id_cuenta1 = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Tipo_cuenta { get => tipo_cuenta; set => tipo_cuenta = value; }
        public decimal Saldo { get => saldo; set => saldo = value; }
        public int Id_cuenta1 { get => id_cuenta; set => id_cuenta = value; }
    }
}
