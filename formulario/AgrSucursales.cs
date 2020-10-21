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
            this.sucursalTableAdapter.Fill(this.bancoDataSet5.sucursal);
        }


        private void AgrSucursales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bancoDataSet5.sucursal' Puede moverla o quitarla según sea necesario.
            this.sucursalTableAdapter.Fill(this.bancoDataSet5.sucursal);

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
