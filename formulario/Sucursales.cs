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
    public partial class Sucursales : Form
    {
        public Sucursales()
        {
            InitializeComponent();
        }

        private void Sucursales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bancoDataSet3.sucursal' Puede moverla o quitarla según sea necesario.
            this.sucursalTableAdapter1.Fill(this.bancoDataSet3.sucursal);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgrSucursales m = new AgrSucursales();

            m.Visible = true;
        }
    }
}
