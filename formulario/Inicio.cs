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
            string user = txtUser.Text;
            inicio = sqlConnection.InicioSystem(passwd,user);
            if (inicio == 0)
            {
                Cliente m = new Cliente();
                m.Visible = true;
                txtPasswd.Text = "";
                txtUser.Text = "";
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
            }
        }
    }
}
