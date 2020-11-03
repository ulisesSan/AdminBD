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
    public partial class Cliente_Menú : Form
    {
        public Cliente_Menú()
        {
            InitializeComponent();
        }

        private void Agrclie_Click(object sender, EventArgs e)
        {
            Cliente m = new Cliente();
            m.Visible = true;
        }
    }
}
