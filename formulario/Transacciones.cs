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
    public partial class Transacciones : Form
    {
        public Transacciones()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Transacciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bancoDataSet4.transaccion' Puede moverla o quitarla según sea necesario.
            this.transaccionTableAdapter.Fill(this.bancoDataSet4.transaccion);
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            string Transaction = txtNtrans.Text;
            string AccountOrg = txtAccountOrig.Text;
            string AccountDest = txtAccountDest.Text;
            string Date = txtdate.Text;
            string Money = txtMoney.Text;
            string typeTrans = txtTypeTrans.Text;
            string Description = txtDescript.Text;

            sqlConnection.agrtrans(Transaction,AccountOrg,AccountDest,Date,Money,typeTrans,Description);

            this.transaccionTableAdapter.Fill(this.bancoDataSet4.transaccion);

            txtDescript.Text = "";
            txtNtrans.Text="";
            txtAccountOrig.Text="";
            txtAccountDest.Text = "";
            txtdate.Text = "";
            txtMoney.Text = "";
            txtTypeTrans.Text = "";
        }
    }
}
