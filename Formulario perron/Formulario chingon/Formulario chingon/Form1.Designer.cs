
namespace Formulario_chingon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSupp = new System.Windows.Forms.Panel();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.izquierda = new System.Windows.Forms.Panel();
            this.btnCuentas = new System.Windows.Forms.Button();
            this.formCliente = new System.Windows.Forms.Button();
            this.Derecha = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelSupp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            this.izquierda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSupp
            // 
            this.panelSupp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSupp.Controls.Add(this.Minimizar);
            this.panelSupp.Controls.Add(this.Cerrar);
            this.panelSupp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSupp.Location = new System.Drawing.Point(0, 0);
            this.panelSupp.Name = "panelSupp";
            this.panelSupp.Size = new System.Drawing.Size(1383, 31);
            this.panelSupp.TabIndex = 0;
            this.panelSupp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSupp_MouseDown);
            // 
            // Minimizar
            // 
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(1318, 3);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(26, 22);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 0;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.Location = new System.Drawing.Point(1350, 3);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(25, 22);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cerrar.TabIndex = 0;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // izquierda
            // 
            this.izquierda.Controls.Add(this.button1);
            this.izquierda.Controls.Add(this.btnCuentas);
            this.izquierda.Controls.Add(this.formCliente);
            this.izquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.izquierda.Location = new System.Drawing.Point(0, 31);
            this.izquierda.Name = "izquierda";
            this.izquierda.Size = new System.Drawing.Size(200, 560);
            this.izquierda.TabIndex = 0;
            // 
            // btnCuentas
            // 
            this.btnCuentas.Location = new System.Drawing.Point(12, 194);
            this.btnCuentas.Name = "btnCuentas";
            this.btnCuentas.Size = new System.Drawing.Size(182, 55);
            this.btnCuentas.TabIndex = 0;
            this.btnCuentas.Text = "Cuentas";
            this.btnCuentas.UseVisualStyleBackColor = true;
            this.btnCuentas.Click += new System.EventHandler(this.btnCuentas_Click);
            // 
            // formCliente
            // 
            this.formCliente.Location = new System.Drawing.Point(12, 80);
            this.formCliente.Name = "formCliente";
            this.formCliente.Size = new System.Drawing.Size(182, 55);
            this.formCliente.TabIndex = 0;
            this.formCliente.Text = "Clientes";
            this.formCliente.UseVisualStyleBackColor = true;
            this.formCliente.Click += new System.EventHandler(this.formCliente_Click);
            // 
            // Derecha
            // 
            this.Derecha.BackColor = System.Drawing.Color.MistyRose;
            this.Derecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Derecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Derecha.Location = new System.Drawing.Point(200, 31);
            this.Derecha.Name = "Derecha";
            this.Derecha.Size = new System.Drawing.Size(1183, 560);
            this.Derecha.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sucursales";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 591);
            this.Controls.Add(this.Derecha);
            this.Controls.Add(this.izquierda);
            this.Controls.Add(this.panelSupp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSupp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            this.izquierda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSupp;
        private System.Windows.Forms.Panel izquierda;
        private System.Windows.Forms.Panel Derecha;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.Button formCliente;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.Button btnCuentas;
        private System.Windows.Forms.Button button1;
    }
}

