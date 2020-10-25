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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int back;

            string nombre = tBNomEmp.Text;
            string AP = tBAP.Text;
            string fech = tBFech.Text;
            string correo = tBEmpMail.Text;
            string phone = tBPhone.Text;
            string idsusc = tBIDSUC.Text;

            sqlConnection.agremp(nombre,AP,fech,correo,phone,idsusc);
            
                tBNomEmp.Text = "";
                tBAP.Text = "";
                tBFech.Text = "";
                tBEmpMail.Text = "";
                tBPhone.Text = "";
                tBIDSUC.Text = "";
            
            
        }
    }
}
