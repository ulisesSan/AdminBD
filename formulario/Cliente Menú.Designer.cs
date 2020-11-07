namespace formulario
{
    partial class Cliente_Menú
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
            this.Agrclie = new System.Windows.Forms.Button();
            this.Deleteclie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Agrclie
            // 
            this.Agrclie.Location = new System.Drawing.Point(12, 57);
            this.Agrclie.Name = "Agrclie";
            this.Agrclie.Size = new System.Drawing.Size(103, 56);
            this.Agrclie.TabIndex = 0;
            this.Agrclie.Text = "Agregar Cliente";
            this.Agrclie.UseVisualStyleBackColor = true;
            this.Agrclie.Click += new System.EventHandler(this.Agrclie_Click);
            // 
            // Deleteclie
            // 
            this.Deleteclie.Location = new System.Drawing.Point(189, 57);
            this.Deleteclie.Name = "Deleteclie";
            this.Deleteclie.Size = new System.Drawing.Size(103, 56);
            this.Deleteclie.TabIndex = 1;
            this.Deleteclie.Text = "Eliminar cliente";
            this.Deleteclie.UseVisualStyleBackColor = true;
            this.Deleteclie.Click += new System.EventHandler(this.Deleteclie_Click);
            // 
            // Cliente_Menú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::formulario.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(306, 134);
            this.Controls.Add(this.Deleteclie);
            this.Controls.Add(this.Agrclie);
            this.Name = "Cliente_Menú";
            this.Text = "Cliente_Menú";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Agrclie;
        private System.Windows.Forms.Button Deleteclie;
    }
}