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
    public partial class Menu_Sucursal : Form
    {
        public Menu_Sucursal()
        {
            InitializeComponent();
        }

        private void btnSucus_Click(object sender, EventArgs e)
        {
            AgrSucursales m = new AgrSucursales();
            m.Visible = true;
        }
    }
}
