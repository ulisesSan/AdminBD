namespace formulario
{
    partial class Empleado_menu
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
            this.btnAgrEmp = new System.Windows.Forms.Button();
            this.btnDeleteEmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgrEmp
            // 
            this.btnAgrEmp.Location = new System.Drawing.Point(52, 56);
            this.btnAgrEmp.Name = "btnAgrEmp";
            this.btnAgrEmp.Size = new System.Drawing.Size(102, 54);
            this.btnAgrEmp.TabIndex = 0;
            this.btnAgrEmp.Text = "Agregar Empleado";
            this.btnAgrEmp.UseVisualStyleBackColor = true;
            this.btnAgrEmp.Click += new System.EventHandler(this.btnAgrEmp_Click);
            // 
            // btnDeleteEmp
            // 
            this.btnDeleteEmp.Location = new System.Drawing.Point(244, 56);
            this.btnDeleteEmp.Name = "btnDeleteEmp";
            this.btnDeleteEmp.Size = new System.Drawing.Size(102, 54);
            this.btnDeleteEmp.TabIndex = 1;
            this.btnDeleteEmp.Text = "Eliminar Empleado";
            this.btnDeleteEmp.UseVisualStyleBackColor = true;
            // 
            // Empleado_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::formulario.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(408, 170);
            this.Controls.Add(this.btnDeleteEmp);
            this.Controls.Add(this.btnAgrEmp);
            this.Name = "Empleado_menu";
            this.Text = "Empleado_menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgrEmp;
        private System.Windows.Forms.Button btnDeleteEmp;
    }
}