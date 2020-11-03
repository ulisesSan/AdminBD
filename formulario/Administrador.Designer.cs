namespace formulario
{
    partial class Administrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnclientecuenta = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sucursales = new System.Windows.Forms.Button();
            this.Transacciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnclientecuenta
            // 
            this.btnclientecuenta.AutoSize = true;
            this.btnclientecuenta.BackColor = System.Drawing.Color.Transparent;
            this.btnclientecuenta.BackgroundImage = global::formulario.Properties.Resources.button;
            this.btnclientecuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnclientecuenta.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnclientecuenta.FlatAppearance.BorderSize = 0;
            this.btnclientecuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientecuenta.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientecuenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclientecuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclientecuenta.Location = new System.Drawing.Point(52, 68);
            this.btnclientecuenta.Name = "btnclientecuenta";
            this.btnclientecuenta.Size = new System.Drawing.Size(168, 64);
            this.btnclientecuenta.TabIndex = 0;
            this.btnclientecuenta.Text = "Cliente-Cuenta";
            this.btnclientecuenta.UseVisualStyleBackColor = false;
            this.btnclientecuenta.Click += new System.EventHandler(this.btnclientecuenta_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::formulario.Properties.Resources.button;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(428, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 64);
            this.button2.TabIndex = 1;
            this.button2.Text = "Empleado";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sucursales
            // 
            this.sucursales.Location = new System.Drawing.Point(428, 219);
            this.sucursales.Name = "sucursales";
            this.sucursales.Size = new System.Drawing.Size(168, 64);
            this.sucursales.TabIndex = 2;
            this.sucursales.Text = "Sucursal";
            this.sucursales.UseVisualStyleBackColor = true;
            this.sucursales.Click += new System.EventHandler(this.sucursales_Click);
            // 
            // Transacciones
            // 
            this.Transacciones.Location = new System.Drawing.Point(52, 219);
            this.Transacciones.Name = "Transacciones";
            this.Transacciones.Size = new System.Drawing.Size(168, 64);
            this.Transacciones.TabIndex = 3;
            this.Transacciones.Text = "Transacciones";
            this.Transacciones.UseVisualStyleBackColor = true;
            this.Transacciones.Click += new System.EventHandler(this.Transacciones_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::formulario.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(643, 356);
            this.Controls.Add(this.Transacciones);
            this.Controls.Add(this.sucursales);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnclientecuenta);
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclientecuenta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button sucursales;
        private System.Windows.Forms.Button Transacciones;
    }
}