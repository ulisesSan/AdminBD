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

        private void Deleteclie_Click(object sender, EventArgs e)
        {
            Form2 m = new Form2();
            m.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Editar_Cliente m = new Editar_Cliente();
            m.Visible = true;
        }
    }
}
