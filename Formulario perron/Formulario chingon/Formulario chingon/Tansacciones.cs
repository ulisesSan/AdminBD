using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Formulario_chingon
{
    public partial class Tansacciones : Form
    {
        public Tansacciones()
        {
            InitializeComponent();
            tabla(null);
        }

        private void tabla(string dato)
        {
            List<object> lista = new List<object>();

            CtrlTransaccion _transaccion = new CtrlTransaccion();

            dataGridView1.DataSource = _transaccion.lista_transaccion(dato);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dato = txtBuscar.Text;

            tabla(dato);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            MapaTransaccion _transaccion = new MapaTransaccion();

            _transaccion.Cuenta = int.Parse(txtCuenta.Text);
            _transaccion.Cliente = int.Parse(txtCliente.Text);
            _transaccion.Monto = Decimal.Parse(txtMonto.Text);
            _transaccion.Tipo = txtTransaccion.Text;

            CtrlTransaccion ctrl = new CtrlTransaccion();

            if (txtID.Text != "")
            {
                _transaccion.Transaccion = int.Parse(txtID.Text);
                bandera = ctrl.EditTransaccion(_transaccion);
            }
            else
            {
                bandera = ctrl.insertTransaccion(_transaccion);
            }

            if (bandera)
            {
                MessageBox.Show("Registro guardado con exito");
                limpiar();
                tabla(null);
            }
            else
            {
                MessageBox.Show("Hubo un error");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtCuenta.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtCliente.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtMonto.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtTransaccion.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void limpiar()
        {
            txtCuenta.Text = "";
            txtCliente.Text = "";
            txtMonto.Text = "";
            txtTransaccion.Text = "";
            txtID.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar?", "Salir", MessageBoxButtons.YesNoCancel);

            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                CtrlTransaccion _cliente = new CtrlTransaccion();

                _cliente.deleteTransaccion(id);
            }

            tabla(null);
        }
    }
}
