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
            string Name = textName.Text; String Account = textAccount.Text;
            string AP = textAP.Text; string AccountType = textTypeAccount.Text;
            String Date = textDate.Text; String Balance = textBalance.Text;
            String Mail = textMail.Text; String Sucursal = textSucursals.Text;
            String Sex = textSex.Text; String NumCli = textNumCli.Text;
            String Phone = textPhone.Text; string Direction = textDirection.Text;
            //Variables provenientes de las cajas de texto

            //contador para verificar si ya se paso por algún if

            //Seccion de condicionales, para verificar que no quede algún dato sin llenar
            if (Name == ""|| AP == ""|| Date == ""|| Mail == ""|| Sex == ""|| Phone == ""|| AccountType == ""|| Balance == ""|| Sucursal == ""|| NumCli == ""|| Direction == "")
            {
              MessageBox.Show("Debe de llenar todos los campos");
            }

            //Fin del area de condicionales

            else
            {
                sqlConnection.AgrClient(Name,AP,AccountType,Date,Balance,Mail,Sucursal,Sex,
                NumCli,Phone,Account,Direction);
            }

            //Se borra el contenido de las cajas de texto
            textName.Text = (""); textAccount.Text = ("");
            textAP.Text = (""); textTypeAccount.Text = ("");
            textDate.Text = (""); textBalance.Text = ("");
            textMail.Text = (""); textSucursals.Text = ("");
            textSex.Text = (""); textNumCli.Text = ("");
            textPhone.Text = (""); textDirection.Text = ("");

        }

    }
}
