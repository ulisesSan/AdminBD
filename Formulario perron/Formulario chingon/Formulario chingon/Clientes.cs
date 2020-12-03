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

        private void bntGuardar_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            MapaCliente _cliente = new MapaCliente();

            _cliente.Nombre = txtNombre.Text;
            _cliente.Apellidos = txtApellidos.Text;
            _cliente.Fecha = txtFech_nac.Text;
            _cliente.Direccion = txtDireccion.Text;
            _cliente.Correo = txtCorreo.Text;
            _cliente.Sexo = txtSexo.Text;
            _cliente.Telefono = (int)Int64.Parse(txtTel.Text);

            CtrlCliente ctrl = new CtrlCliente();

            if(TxtId.Text != "")
            {
                _cliente.Id_cliente = int.Parse(TxtId.Text);
                bandera = ctrl.EditClientes(_cliente);
            }
            else
            {
                bandera = ctrl.insertClientes(_cliente);
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

        private void limpiar()
        {
            txtApellidos.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtFech_nac.Text = "";
            txtNombre.Text = "";
            txtSexo.Text = "";
            txtTel.Text = "";
            TxtId.Text = "";

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            TxtId.Text = dataGridView_Cliente.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dataGridView_Cliente.CurrentRow.Cells[1].Value.ToString();
            txtApellidos.Text = dataGridView_Cliente.CurrentRow.Cells[2].Value.ToString();
            txtFech_nac.Text = dataGridView_Cliente.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = dataGridView_Cliente.CurrentRow.Cells[4].Value.ToString();
            txtCorreo.Text = dataGridView_Cliente.CurrentRow.Cells[5].Value.ToString();
            txtSexo.Text = dataGridView_Cliente.CurrentRow.Cells[6].Value.ToString();
            txtTel.Text = dataGridView_Cliente.CurrentRow.Cells[7].Value.ToString();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar?", "Salir", MessageBoxButtons.YesNoCancel);

            if(resultado == DialogResult.Yes)
            {
                int id = int.Parse(dataGridView_Cliente.CurrentRow.Cells[0].Value.ToString());

                CtrlCliente _cliente = new CtrlCliente();

                _cliente.deleteClientes(id);

                tabla(null);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
