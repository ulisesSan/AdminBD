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
    public partial class edita_cuenta : Form
    {
        public edita_cuenta()
        {
            InitializeComponent();
        }

        private void Buscar_cuenta_Click(object sender, EventArgs e)
        {
            string cuenta = textidCuenta.Text;

            if (cuenta == "")
            {
                MessageBox.Show("Debe de llenar el cuadro de busqueda");
            }
            else
            {
                string[] datos = sqlConnection.consulta_cuenta(cuenta);
                textTipocuenta.Text = datos[3];
                textSaldo.Text = datos[4];
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string dato = textidCuenta.Text;
            string tipo = textTipocuenta.Text;
            String saldo = textSaldo.Text;

            if(dato == "" || tipo == "" || saldo == "")
            {
                MessageBox.Show("No debe de haber nungun campo vacio");
            }
            else
            {
                sqlConnection.edit_cuenta(dato, tipo, saldo);
            }
        }
    }
}
