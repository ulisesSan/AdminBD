using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Formulario_chingon
{
    public partial class Cuentas : Form
    {
        public Cuentas()
        {
            InitializeComponent();
            tabla(null);
        }

        private void tabla(string dato)
        {
            List<object> Lista = new List<object>();

            CtrlCuenta _cuenta = new CtrlCuenta();
            dataGridView_Cuentas.DataSource = _cuenta.lista_cuenta(dato);
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            string dato = txtCuenta.Text;

            tabla(dato);
        }
    }
}
