using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Formulario_chingon
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
            tabla(null);
        }

        private void tabla (string dato)
        {
            List<object> _lista = new List<object>();

            CtrlEmpleados _empleado = new CtrlEmpleados();

            dataGridView1_empleado.DataSource = _empleado.lista_emp(dato);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string Empleado = txtEmpleado.Text;

            tabla(Empleado);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            MapaEmpleados _empleados = new MapaEmpleados();

            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            DateTime fecha = Convert.ToDateTime(txtFecha.Text); string fecha2 = fecha.ToString("yyy/MM/dd");
            string correo = txtCorreo.Text;
            string telefono = txtTel.Text;
            int sucur = int.Parse(txtIDSucs.Text);

            _empleados.Nombre = nombre;
            _empleados.Apellidos = apellidos;
            _empleados.Fech_nac = fecha2;
            _empleados.Correo = correo;
            _empleados.Telefono = telefono;
            _empleados.Sucursal = sucur;


            CtrlEmpleados ctrl = new CtrlEmpleados();

            if (txtID.Text != "")
            {
                _empleados.ID = int.Parse(txtID.Text);
                bandera = ctrl.Edit_Emp(_empleados);
            }
            else
            {
                bandera = ctrl.insertar_Emp(_empleados);
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
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtFecha.Text = "";
            txtCorreo.Text = "";
            txtIDSucs.Text = "";
            txtTel.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtID.Text = dataGridView1_empleado.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dataGridView1_empleado.CurrentRow.Cells[1].Value.ToString();
            txtApellidos.Text = dataGridView1_empleado.CurrentRow.Cells[2].Value.ToString();
            txtFecha.Text = dataGridView1_empleado.CurrentRow.Cells[3].Value.ToString();
            txtCorreo.Text = dataGridView1_empleado.CurrentRow.Cells[4].Value.ToString();
            txtTel.Text = dataGridView1_empleado.CurrentRow.Cells[5].Value.ToString();
            txtIDSucs.Text = dataGridView1_empleado.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar?", "Salir", MessageBoxButtons.YesNoCancel);

            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(dataGridView1_empleado.CurrentRow.Cells[0].Value.ToString());

                CtrlEmpleados _empleados = new CtrlEmpleados();

                _empleados.EliminarEmp(id);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
