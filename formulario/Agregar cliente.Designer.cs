namespace formulario
{
    partial class Agregar_cliente
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
            this.textnumcue = new System.Windows.Forms.TextBox();
            this.textnumclie = new System.Windows.Forms.TextBox();
            this.textsuc = new System.Windows.Forms.TextBox();
            this.texttipcue = new System.Windows.Forms.TextBox();
            this.textsaldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textnumcue
            // 
            this.textnumcue.Location = new System.Drawing.Point(148, 26);
            this.textnumcue.Name = "textnumcue";
            this.textnumcue.Size = new System.Drawing.Size(74, 20);
            this.textnumcue.TabIndex = 0;
            // 
            // textnumclie
            // 
            this.textnumclie.Location = new System.Drawing.Point(148, 73);
            this.textnumclie.Name = "textnumclie";
            this.textnumclie.Size = new System.Drawing.Size(74, 20);
            this.textnumclie.TabIndex = 1;
            // 
            // textsuc
            // 
            this.textsuc.Location = new System.Drawing.Point(148, 125);
            this.textsuc.Name = "textsuc";
            this.textsuc.Size = new System.Drawing.Size(74, 20);
            this.textsuc.TabIndex = 2;
            // 
            // texttipcue
            // 
            this.texttipcue.Location = new System.Drawing.Point(148, 176);
            this.texttipcue.Name = "texttipcue";
            this.texttipcue.Size = new System.Drawing.Size(74, 20);
            this.texttipcue.TabIndex = 3;
            // 
            // textsaldo
            // 
            this.textsaldo.Location = new System.Drawing.Point(148, 223);
            this.textsaldo.Name = "textsaldo";
            this.textsaldo.Size = new System.Drawing.Size(74, 20);
            this.textsaldo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numero de cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numero de cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sucursal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo de cuenta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Saldo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(296, 215);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(69, 35);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Agregar_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 295);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textsaldo);
            this.Controls.Add(this.texttipcue);
            this.Controls.Add(this.textsuc);
            this.Controls.Add(this.textnumclie);
            this.Controls.Add(this.textnumcue);
            this.Name = "Agregar_cliente";
            this.Text = "Agregar_cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textnumcue;
        private System.Windows.Forms.TextBox textnumclie;
        private System.Windows.Forms.TextBox textsuc;
        private System.Windows.Forms.TextBox texttipcue;
        private System.Windows.Forms.TextBox textsaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar;
    }
}