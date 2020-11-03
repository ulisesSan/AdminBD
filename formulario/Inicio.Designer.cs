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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
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
            resources.ApplyResources(this.txtPasswd, "txtPasswd");
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.UseSystemPasswordChar = true;
            // 
            // lol
            // 
            resources.ApplyResources(this.lol, "lol");
            this.lol.BackColor = System.Drawing.Color.Transparent;
            this.lol.ForeColor = System.Drawing.Color.DarkBlue;
            this.lol.Name = "lol";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Name = "label2";
            // 
            // iniBTN
            // 
            this.iniBTN.BackColor = System.Drawing.Color.Transparent;
            this.iniBTN.BackgroundImage = global::formulario.Properties.Resources.button;
            resources.ApplyResources(this.iniBTN, "iniBTN");
            this.iniBTN.FlatAppearance.BorderSize = 0;
            this.iniBTN.ForeColor = System.Drawing.Color.Transparent;
            this.iniBTN.Name = "iniBTN";
            this.iniBTN.UseVisualStyleBackColor = false;
            this.iniBTN.Click += new System.EventHandler(this.iniBTN_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::formulario.Properties.Resources.button;
            resources.ApplyResources(this.button2, "button2");
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::formulario.Properties.Resources.Usuario;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Items.AddRange(new object[] {
            resources.GetString("cmbUsuarios.Items"),
            resources.GetString("cmbUsuarios.Items1"),
            resources.GetString("cmbUsuarios.Items2")});
            resources.ApplyResources(this.cmbUsuarios, "cmbUsuarios");
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cmbUsuarios_SelectedIndexChanged);
            // 
            // Inicio
            // 
            this.AcceptButton = this.iniBTN;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::formulario.Properties.Resources.fondo;
            this.CancelButton = this.button2;
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