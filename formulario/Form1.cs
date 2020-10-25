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

         private void button1_Click(object sender, EventArgs e)
         {
                AgrSucursales m = new AgrSucursales();

                m.Visible = true;
         }


            private void Cliente_Load(object sender, EventArgs e)
            {
                // TODO: esta línea de código carga datos en la tabla 'bancoDataSet2.cliente' Puede moverla o quitarla según sea necesario.
                // this.clienteTableAdapter1.Fill(this.bancoDataSet2.cliente);
                // TODO: esta línea de código carga datos en la tabla 'bancoDataSet1.cliente' Puede moverla o quitarla según sea necesario.
                // this.clienteTableAdapter.Fill(this.bancoDataSet1.cliente);

            }

            private void btnVerfSucs_Click(object sender, EventArgs e)
            {
            }

        private void btEMP_Click(object sender, EventArgs e)
        {
            Empleados m = new Empleados();

            m.Visible = true;
        }

        private void BtnTans_Click(object sender, EventArgs e)
        {
            Transacciones m = new Transacciones();
            m.Visible = true;
        }

        private void btEMP_Click_1(object sender, EventArgs e)
        {
            Empleados m = new Empleados();
            m.Visible = true;
        }
    }
}
