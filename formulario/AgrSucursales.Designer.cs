namespace formulario
{
    partial class AgrSucursales
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
            this.label1 = new System.Windows.Forms.Label();
            this.textNameSucs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textDirSucs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textTimeSucs = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textNumSucs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la sucursal";
            // 
            // textNameSucs
            // 
            this.textNameSucs.Location = new System.Drawing.Point(159, 39);
            this.textNameSucs.Name = "textNameSucs";
            this.textNameSucs.Size = new System.Drawing.Size(417, 20);
            this.textNameSucs.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dirección";
            // 
            // textDirSucs
            // 
            this.textDirSucs.Location = new System.Drawing.Point(159, 95);
            this.textDirSucs.Name = "textDirSucs";
            this.textDirSucs.Size = new System.Drawing.Size(417, 20);
            this.textDirSucs.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Horario";
            // 
            // textTimeSucs
            // 
            this.textTimeSucs.Location = new System.Drawing.Point(159, 157);
            this.textTimeSucs.Name = "textTimeSucs";
            this.textTimeSucs.Size = new System.Drawing.Size(417, 20);
            this.textTimeSucs.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(531, 310);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(163, 46);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numero de sucursal";
            // 
            // textNumSucs
            // 
            this.textNumSucs.Location = new System.Drawing.Point(174, 211);
            this.textNumSucs.Name = "textNumSucs";
            this.textNumSucs.Size = new System.Drawing.Size(58, 20);
            this.textNumSucs.TabIndex = 8;
            // 
            // AgrSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textNumSucs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.textTimeSucs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textDirSucs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNameSucs);
            this.Controls.Add(this.label1);
            this.Name = "AgrSucursales";
            this.Text = "AgrSucursales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNameSucs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDirSucs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTimeSucs;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNumSucs;
    }
}