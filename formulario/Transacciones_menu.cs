using System;
using System.Windows.Forms;

namespace formulario
{
    public partial class Transacciones_menu : Form
    {
        public Transacciones_menu()
        {
            InitializeComponent();
        }

        private void btntrans_Click(object sender, EventArgs e)
        {
            Transacciones m = new Transacciones();
            m.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Eliminar_Transaccion m = new Eliminar_Transaccion();
            m.Visible = true;
        }
    }
}
