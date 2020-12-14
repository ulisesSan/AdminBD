using System;
using System.Collections.Generic;
using System.Text;

namespace Formulario_chingon
{
    class MapaTransaccion
    {
        private int transaccion;
        private int cuenta;
        private int cliente;
        private string fecha;
        private decimal monto;
        private string tipo;

        public int Transaccion { get => transaccion; set => transaccion = value; }
        public int Cuenta { get => cuenta; set => cuenta = value; }
        public int Cliente { get => cliente; set => cliente = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public decimal Monto { get => monto; set => monto = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
