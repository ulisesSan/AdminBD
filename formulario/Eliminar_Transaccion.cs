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
    public partial class Eliminar_Transaccion : Form
    {
        public Eliminar_Transaccion()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = TextIdtrans.Text;

            sqlConnection.eliminar_trans(id);        
        }
    }
}
