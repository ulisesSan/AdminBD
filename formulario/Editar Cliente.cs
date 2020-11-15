using System;
using System.Windows.Forms;

namespace formulario
{
    public partial class Editar_Cliente : Form
    {
        public Editar_Cliente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string idCliente = textCliente.Text;
            //string datos;//= new string[8];
            if(idCliente == "")
            {
                MessageBox.Show("debe de ingresar un dato");
            }
            else
            {
                String[] datos = sqlConnection.Consulta_cliente(idCliente);
                textNombre.Text = datos[2];
                textApellidos.Text = datos[3];
                textFech.Text = datos[4];
                textDir.Text = datos[5];
                textMail.Text = datos[6];
                textSex.Text = datos[7];
                textEl.Text = datos[8];
            }
            
            
        }

        
    }
}
