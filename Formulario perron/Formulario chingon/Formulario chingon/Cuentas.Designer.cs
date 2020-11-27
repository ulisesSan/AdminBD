
namespace Formulario_chingon
{
    partial class Cuentas
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
            this.dataGridView_Cuentas = new System.Windows.Forms.DataGridView();
            this.btnCuenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cuenta = new System.Windows.Forms.Label();
            this.txtTipCuenta = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cuentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Cuentas
            // 
            this.dataGridView_Cuentas.AllowUserToAddRows = false;
            this.dataGridView_Cuentas.AllowUserToDeleteRows = false;
            this.dataGridView_Cuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cuentas.Location = new System.Drawing.Point(12, 125);
            this.dataGridView_Cuentas.Name = "dataGridView_Cuentas";
            this.dataGridView_Cuentas.ReadOnly = true;
            this.dataGridView_Cuentas.RowTemplate.Height = 25;
            this.dataGridView_Cuentas.Size = new System.Drawing.Size(789, 338);
            this.dataGridView_Cuentas.TabIndex = 0;
            // 
            // btnCuenta
            // 
            this.btnCuenta.Location = new System.Drawing.Point(400, 63);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(75, 23);
            this.btnCuenta.TabIndex = 1;
            this.btnCuenta.Text = "Buscar";
            this.btnCuenta.UseVisualStyleBackColor = true;
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cuenta";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(118, 64);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(246, 23);
            this.txtCuenta.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Limpiar);
            this.groupBox1.Controls.Add(this.Guardar);
            this.groupBox1.Controls.Add(this.txtTipCuenta);
            this.groupBox1.Controls.Add(this.Cuenta);
            this.groupBox1.Location = new System.Drawing.Point(846, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 338);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuentas";
            // 
            // Cuenta
            // 
            this.Cuenta.AutoSize = true;
            this.Cuenta.Location = new System.Drawing.Point(25, 65);
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.Size = new System.Drawing.Size(85, 15);
            this.Cuenta.TabIndex = 0;
            this.Cuenta.Text = "Tipo de cuenta";
            // 
            // txtTipCuenta
            // 
            this.txtTipCuenta.Location = new System.Drawing.Point(116, 62);
            this.txtTipCuenta.Name = "txtTipCuenta";
            this.txtTipCuenta.Size = new System.Drawing.Size(117, 23);
            this.txtTipCuenta.TabIndex = 1;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(11, 309);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 2;
            this.Guardar.Text = "button1";
            this.Guardar.UseVisualStyleBackColor = true;
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(212, 309);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 3;
            this.Limpiar.Text = "button2";
            this.Limpiar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Saldo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 23);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(46, 23);
            this.textBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID Cuenta";
            // 
            // Cuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1183, 560);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCuenta);
            this.Controls.Add(this.dataGridView_Cuentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cuentas";
            this.Text = "Cuentas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cuentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Cuentas;
        private System.Windows.Forms.Button btnCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.TextBox txtTipCuenta;
        private System.Windows.Forms.Label Cuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
    }
}