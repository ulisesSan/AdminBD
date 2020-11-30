using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Formulario_chingon
{
    public partial class Sucursal : Form
    {
        public Sucursal()
        {
            InitializeComponent();
            tabla(null);
        }

        private void tabla (string dato)
        {
            List<object> _lista = new List<object>();

            CtrlSucursal _sucursal = new CtrlSucursal();

            dataGridViewSucursal.DataSource = _sucursal.lista_suc(dato);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sucursal = textBuscar.Text;

            tabla(sucursal);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtID.Text = dataGridViewSucursal.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dataGridViewSucursal.CurrentRow.Cells[1].Value.ToString();
            txtdir.Text = dataGridViewSucursal.CurrentRow.Cells[2].Value.ToString();
            txthorario.Text = dataGridViewSucursal.CurrentRow.Cells[3].Value.ToString();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar?", "Salir", MessageBoxButtons.YesNoCancel);

            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(dataGridViewSucursal.CurrentRow.Cells[0].Value.ToString());

                CtrlCliente _sucursal = new CtrlCliente();

                _sucursal.deleteClientes(id);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            MapaSucursal _sucursal = new MapaSucursal();

            _sucursal.Nombre = txtNombre.Text;
            _sucursal.Direccion = txtdir.Text;
            _sucursal.Horario = txthorario.Text;
 

            CtrlSucursal ctrl = new CtrlSucursal();

            if (txtID.Text != "")
            {
                _sucursal.Sucursal = int.Parse(txtID.Text);
                bandera = ctrl.Edit_Suc(_sucursal);
            }
            else
            {
                bandera = ctrl.insertar_suc(_sucursal);
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtNombre.Text = "";
            txtdir.Text = "";
            txthorario.Text = "";
            txtID.Text = "";
        }
    }
}
