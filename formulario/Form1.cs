using System;
using System.Windows.Forms;


namespace formulario
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }
    

        private void Prueba_Click(object sender, EventArgs e)
        {
            //Variables provenientes de las cajas de texto
            string Name = textName.Text;
            string AP = textAP.Text; 
            String Date = textDate.Text; 
            String Mail = textMail.Text; 
            String Sex = textSex.Text; string Numclie = textNumCli.Text;
            String Phone = textPhone.Text; string Direction = textDirection.Text;
            //Variables provenientes de las cajas de texto

            //contador para verificar si ya se paso por algún if

            //Seccion de condicionales, para verificar que no quede algún dato sin llenar
            if (Name == ""|| AP == ""|| Date == ""|| Mail == ""|| Sex == ""|| Phone == ""|| Direction == "")
            {
              MessageBox.Show("Debe de llenar todos los campos");
            }

            //Fin del area de condicionales

            else
            {
                sqlConnection.AgrClient(Name,AP,Date,Mail,Sex,Numclie,Phone,Direction);
            }

            //Se borra el contenido de las cajas de texto
            textName.Text = (""); 
            textAP.Text = (""); 
            textDate.Text = ("");
            textMail.Text = ("");
            textSex.Text = (""); textNumCli.Text = ("");
            textPhone.Text = (""); textDirection.Text = ("");

        }

        private void label11_Click(object sender, EventArgs e)
        {
                    }

        private void Prueba_Click_1(object sender, EventArgs e)
        {
            //Variables provenientes de las cajas de texto
            string Name = textName.Text;
            string AP = textAP.Text;
            String Date = textDate.Text;
            String Mail = textMail.Text;
            String Sex = textSex.Text; string Numclie = textNumCli.Text;
            String Phone = textPhone.Text; string Direction = textDirection.Text;
            //Variables provenientes de las cajas de texto

            //contador para verificar si ya se paso por algún if

            //Seccion de condicionales, para verificar que no quede algún dato sin llenar
            if (Name == "" || AP == "" || Date == "" || Mail == "" || Sex == "" || Phone == "" || Direction == "")
            {
                MessageBox.Show("Debe de llenar todos los campos");
            }

            //Fin del area de condicionales

            else
            {
                sqlConnection.AgrClient(Name, AP, Date, Mail, Sex, Numclie, Phone, Direction);
            }

            //Se borra el contenido de las cajas de texto
            textName.Text = ("");
            textAP.Text = ("");
            textDate.Text = ("");
            textMail.Text = ("");
            textSex.Text = (""); textNumCli.Text = ("");
            textPhone.Text = (""); textDirection.Text = ("");
        }
    }
}
