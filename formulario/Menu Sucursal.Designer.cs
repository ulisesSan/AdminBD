namespace formulario
{
    partial class Menu_Sucursal
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
            this.btnDeleteSucs = new System.Windows.Forms.Button();
            this.btnSucus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeleteSucs
            // 
            this.btnDeleteSucs.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteSucs.BackgroundImage = global::formulario.Properties.Resources.button;
            this.btnDeleteSucs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteSucs.FlatAppearance.BorderSize = 0;
            this.btnDeleteSucs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSucs.Location = new System.Drawing.Point(234, 63);
            this.btnDeleteSucs.Name = "btnDeleteSucs";
            this.btnDeleteSucs.Size = new System.Drawing.Size(101, 50);
            this.btnDeleteSucs.TabIndex = 0;
            this.btnDeleteSucs.Text = "Eliminar Sucursal";
            this.btnDeleteSucs.UseVisualStyleBackColor = false;
            // 
            // btnSucus
            // 
            this.btnSucus.BackColor = System.Drawing.Color.Transparent;
            this.btnSucus.BackgroundImage = global::formulario.Properties.Resources.button;
            this.btnSucus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSucus.FlatAppearance.BorderSize = 0;
            this.btnSucus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSucus.Location = new System.Drawing.Point(29, 63);
            this.btnSucus.Name = "btnSucus";
            this.btnSucus.Size = new System.Drawing.Size(101, 50);
            this.btnSucus.TabIndex = 1;
            this.btnSucus.Text = "Agregrar Sucursal";
            this.btnSucus.UseVisualStyleBackColor = false;
            this.btnSucus.Click += new System.EventHandler(this.btnSucus_Click);
            // 
            // Menu_Sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::formulario.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(370, 178);
            this.Controls.Add(this.btnSucus);
            this.Controls.Add(this.btnDeleteSucs);
            this.Name = "Menu_Sucursal";
            this.Text = "Menu_Sucursal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteSucs;
        private System.Windows.Forms.Button btnSucus;
    }
}