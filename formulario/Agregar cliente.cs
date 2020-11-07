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
    public partial class Agregar_cliente : Form
    {
        public Agregar_cliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string numCue = textnumcue.Text;
            string numClie = textnumclie.Text;
            String Sucur = textsuc.Text;
            String tip = texttipcue.Text;
            string saldo = textsaldo.Text;

            sqlConnection.agrcuenta(numCue, numClie, Sucur, tip, saldo);
        }
    }
}
