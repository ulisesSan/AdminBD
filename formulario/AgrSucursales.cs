﻿using System;
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
         
        }
    }
}
