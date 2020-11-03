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
    public partial class Inicio : Form
    {
        int i= -1;
        
        public Inicio()
        {
            InitializeComponent();
            //Cliente m = new Cliente();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iniBTN_Click(object sender, EventArgs e)
        {
            int inicio;
            string passwd = txtPasswd.Text;

            inicio = i;

            switch (inicio)
            {
                case 0 :
                    Administrador m = new Administrador();
                    m.Visible = true;
                    break;

                case 1:
                    break;

                case 2:
                    break;

                default:
                    MessageBox.Show("Algo salió mal. \n Porfavor contacte al administrador");
                    break;
            }
        }

        private int cmbUsuarios_SelectedIndexChanged()
        {
            throw new NotImplementedException();
        }

        private void cmbUsuarios_SelectedIndexChanged(object sender,EventArgs e)
        {
            i = cmbUsuarios.SelectedIndex;

            lol.Text = i.ToString();

           
        }
    }
}
