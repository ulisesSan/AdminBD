using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void btnclientecuenta_Click(object sender, EventArgs e)
        {
            Cliente_Menú m = new Cliente_Menú();
            m.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empleado_menu m = new Empleado_menu();
            m.Visible = true;
        }

        private void Transacciones_Click(object sender, EventArgs e)
        {
            Transacciones_menu m = new Transacciones_menu();
            m.Visible = true;

        }

        private void sucursales_Click(object sender, EventArgs e)
        {
            Menu_Sucursal m = new Menu_Sucursal();
            m.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_cliente3 m = new Menu_cliente3();
            m.Visible = true;
        }
    }
}
