
namespace formulario
{
    partial class edita_cuenta
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
            this.textidCuenta = new System.Windows.Forms.TextBox();
            this.Buscar_cuenta = new System.Windows.Forms.Button();
            this.textTipocuenta = new System.Windows.Forms.TextBox();
            this.textSaldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Saldo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textidCuenta
            // 
            this.textidCuenta.Location = new System.Drawing.Point(113, 56);
            this.textidCuenta.Name = "textidCuenta";
            this.textidCuenta.Size = new System.Drawing.Size(100, 20);
            this.textidCuenta.TabIndex = 0;
            // 
            // Buscar_cuenta
            // 
            this.Buscar_cuenta.Location = new System.Drawing.Point(256, 54);
            this.Buscar_cuenta.Name = "Buscar_cuenta";
            this.Buscar_cuenta.Size = new System.Drawing.Size(75, 23);
            this.Buscar_cuenta.TabIndex = 1;
            this.Buscar_cuenta.Text = " Buscar";
            this.Buscar_cuenta.UseVisualStyleBackColor = true;
            this.Buscar_cuenta.Click += new System.EventHandler(this.Buscar_cuenta_Click);
            // 
            // textTipocuenta
            // 
            this.textTipocuenta.Location = new System.Drawing.Point(97, 117);
            this.textTipocuenta.Name = "textTipocuenta";
            this.textTipocuenta.Size = new System.Drawing.Size(100, 20);
            this.textTipocuenta.TabIndex = 2;
            // 
            // textSaldo
            // 
            this.textSaldo.Location = new System.Drawing.Point(97, 166);
            this.textSaldo.Name = "textSaldo";
            this.textSaldo.Size = new System.Drawing.Size(100, 20);
            this.textSaldo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de cuenta";
            // 
            // Saldo
            // 
            this.Saldo.AutoSize = true;
            this.Saldo.Location = new System.Drawing.Point(12, 173);
            this.Saldo.Name = "Saldo";
            this.Saldo.Size = new System.Drawing.Size(34, 13);
            this.Saldo.TabIndex = 5;
            this.Saldo.Text = "Saldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Buscar cuenta";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(256, 205);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 27);
            this.btnupdate.TabIndex = 7;
            this.btnupdate.Text = "Actualizar";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // edita_cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 270);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Saldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSaldo);
            this.Controls.Add(this.textTipocuenta);
            this.Controls.Add(this.Buscar_cuenta);
            this.Controls.Add(this.textidCuenta);
            this.Name = "edita_cuenta";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textidCuenta;
        private System.Windows.Forms.Button Buscar_cuenta;
        private System.Windows.Forms.TextBox textTipocuenta;
        private System.Windows.Forms.TextBox textSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Saldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnupdate;
    }
}