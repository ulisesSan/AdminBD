using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Formulario_chingon
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            tabla(null);
        }

        private void tabla (string dato)
        {
            List<object> Lista = new List<object>();

            CtrlCliente _Cliente = new CtrlCliente();
            dataGridView_Cliente.DataSource = _Cliente.lista_cliente(dato);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dato = textBuscar.Text;
            tabla(dato);
        }
    }
}
