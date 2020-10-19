using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace formulario
{
    public partial class AgrSucursales : Form
    {
        public AgrSucursales()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Nombre = textNameSucs.Text;
            string Direccion = textDirSucs.Text;
            string Horario = textTimeSucs.Text;
            string Numero = textNumSucs.Text;


            sqlConnection.agrSuc(Nombre,Direccion,Horario,Numero);

            // TODO: esta línea de código carga datos en la tabla 'bancoDataSet2.sucursal' Puede moverla o quitarla según sea necesario.
            this.sucursalTableAdapter1.Fill(this.bancoDataSet2.sucursal);
            // TODO: esta línea de código carga datos en la tabla 'bancoDataSet.sucursal' Puede moverla o quitarla según sea necesario.
            this.sucursalTableAdapter.Fill(this.bancoDataSet.sucursal);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AgrSucursales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bancoDataSet2.sucursal' Puede moverla o quitarla según sea necesario.
            this.sucursalTableAdapter1.Fill(this.bancoDataSet2.sucursal);
            // TODO: esta línea de código carga datos en la tabla 'bancoDataSet.sucursal' Puede moverla o quitarla según sea necesario.
            this.sucursalTableAdapter.Fill(this.bancoDataSet.sucursal);

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
