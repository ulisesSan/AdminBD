namespace formulario
{
    partial class Inicio
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
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.lol = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iniBTN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(105, 239);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(156, 20);
            this.txtPasswd.TabIndex = 1;
            this.txtPasswd.UseSystemPasswordChar = true;
            // 
            // lol
            // 
            this.lol.AutoSize = true;
            this.lol.BackColor = System.Drawing.Color.Transparent;
            this.lol.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lol.ForeColor = System.Drawing.Color.DarkBlue;
            this.lol.Location = new System.Drawing.Point(160, 172);
            this.lol.Name = "lol";
            this.lol.Size = new System.Drawing.Size(49, 15);
            this.lol.TabIndex = 2;
            this.lol.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(151, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // iniBTN
            // 
            this.iniBTN.BackColor = System.Drawing.Color.Transparent;
            this.iniBTN.BackgroundImage = global::formulario.Properties.Resources.button;
            this.iniBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iniBTN.FlatAppearance.BorderSize = 0;
            this.iniBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iniBTN.ForeColor = System.Drawing.Color.Transparent;
            this.iniBTN.Location = new System.Drawing.Point(231, 265);
            this.iniBTN.Name = "iniBTN";
            this.iniBTN.Size = new System.Drawing.Size(69, 26);
            this.iniBTN.TabIndex = 4;
            this.iniBTN.Text = "Iniciar secion";
            this.iniBTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iniBTN.UseVisualStyleBackColor = false;
            this.iniBTN.Click += new System.EventHandler(this.iniBTN_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::formulario.Properties.Resources.button;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(68, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::formulario.Properties.Resources.Usuario;
            this.pictureBox1.Location = new System.Drawing.Point(105, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Items.AddRange(new object[] {
            "Administrador",
            "Gerente",
            "Empleado"});
            this.cmbUsuarios.Location = new System.Drawing.Point(105, 190);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(156, 21);
            this.cmbUsuarios.TabIndex = 7;
            this.cmbUsuarios.Text = "Usuario";
            this.cmbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cmbUsuarios_SelectedIndexChanged);
            // 
            // Inicio
            // 
            this.AcceptButton = this.iniBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::formulario.Properties.Resources.fondo;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(376, 317);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.iniBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lol);
            this.Controls.Add(this.txtPasswd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Label lol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button iniBTN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbUsuarios;
    }
}