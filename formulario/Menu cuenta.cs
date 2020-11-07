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
    public partial class Menu_cliente3 : Form
    {
        public Menu_cliente3()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Form2 m = new Form2();
            m.Visible = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agregar_cliente m = new Agregar_cliente();
            m.Visible = true;
        }
    }
}
