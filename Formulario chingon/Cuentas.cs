using System;
using System.Collections.Generic;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            MapaCuentas _cuenta = new MapaCuentas();

            _cuenta.Tipo_cuenta = txtTipCuenta.Text;
            _cuenta.Saldo = decimal.Parse(txtSaldo.Text);
            _cuenta.Id_cliente = int.Parse(txtCliente.Text);

            CtrlCuenta ctrl = new CtrlCuenta();

            if (txtCuentas.Text != "")
            {
                int ID = int.Parse(txtCuentas.Text); 
                _cuenta.Id_cuenta1 = ID;
                bandera = ctrl.EditCuentas(_cuenta);
            }
            else
            {
                bandera = ctrl.insert_cuenta(_cuenta);
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

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
            txtCliente.Text = "";
            txtCuentas.Text = "";
            txtCuenta.Text = "";
            txtSaldo.Text = "";
            txtTipCuenta.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            txtCuentas.Text = dataGridView_Cuentas.CurrentRow.Cells[0].Value.ToString();
            txtCliente.Text = dataGridView_Cuentas.CurrentRow.Cells[1].Value.ToString();
            txtSaldo.Text = dataGridView_Cuentas.CurrentRow.Cells[5].Value.ToString();
            txtTipCuenta.Text = dataGridView_Cuentas.CurrentRow.Cells[4].Value.ToString();
          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar?", "Salir", MessageBoxButtons.YesNoCancel);

            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(dataGridView_Cuentas.CurrentRow.Cells[0].Value.ToString());

                CtrlCuenta _cliente = new CtrlCuenta();

                _cliente.deleteCuenta(id);
            }

            tabla(null);
        }
    }
}
