using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Formulario_chingon
{
    public partial class Form1 : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelSupp_MouseDown(object sender, MouseEventArgs e)
        {
            //Para poder mover con el panel superior
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void formCliente_Click(object sender, EventArgs e)
        {
            newWindow(new Clientes());
        }

        private void newWindow(object formhija)
        {
            if (this.Derecha.Controls.Count > 0)
            {
                this.Derecha.Controls.RemoveAt(0);
            }

            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Derecha.Controls.Add(fh);
            this.Derecha.Tag = fh;
            fh.Show();
        }

        private void btnCuentas_Click(object sender, EventArgs e)
        {
            newWindow(new Cuentas());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newWindow(new Sucursal());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newWindow(new Empleados());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Derecha_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTranasccion_Click(object sender, EventArgs e)
        {
            newWindow(new Tansacciones());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
