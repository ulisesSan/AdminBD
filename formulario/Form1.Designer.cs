namespace formulario
{
    partial class Cliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.Prueba = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textSucursals = new System.Windows.Forms.TextBox();
            this.textBalance = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textTypeAccount = new System.Windows.Forms.TextBox();
            this.textAccount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textSex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textAP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textNumCli = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textDirection = new System.Windows.Forms.TextBox();
            this.btEMP = new System.Windows.Forms.Button();
            this.BtnTans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Prueba
            // 
            this.Prueba.AccessibleDescription = "Regustra a un nuevo cliente con su cuenta";
            this.Prueba.BackColor = System.Drawing.Color.Transparent;
            this.Prueba.BackgroundImage = global::formulario.Properties.Resources.button;
            this.Prueba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Prueba.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Prueba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prueba.ForeColor = System.Drawing.Color.Transparent;
            this.Prueba.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Prueba.Location = new System.Drawing.Point(222, 403);
            this.Prueba.Name = "Prueba";
            this.Prueba.Size = new System.Drawing.Size(154, 54);
            this.Prueba.TabIndex = 0;
            this.Prueba.Text = "Registrar";
            this.Prueba.UseVisualStyleBackColor = false;
            this.Prueba.Click += new System.EventHandler(this.Prueba_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(513, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "*Asegúrese de que la sucursal exista";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::formulario.Properties.Resources.button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(32, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sucursal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textSucursals
            // 
            this.textSucursals.Location = new System.Drawing.Point(641, 218);
            this.textSucursals.Name = "textSucursals";
            this.textSucursals.Size = new System.Drawing.Size(119, 20);
            this.textSucursals.TabIndex = 21;
            // 
            // textBalance
            // 
            this.textBalance.Location = new System.Drawing.Point(641, 162);
            this.textBalance.Name = "textBalance";
            this.textBalance.Size = new System.Drawing.Size(66, 20);
            this.textBalance.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(528, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Sucursal*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(528, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Saldo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(528, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tipo de cuenta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(528, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Numero de cuenta";
            // 
            // textTypeAccount
            // 
            this.textTypeAccount.Location = new System.Drawing.Point(641, 100);
            this.textTypeAccount.Name = "textTypeAccount";
            this.textTypeAccount.Size = new System.Drawing.Size(102, 20);
            this.textTypeAccount.TabIndex = 18;
            // 
            // textAccount
            // 
            this.textAccount.Location = new System.Drawing.Point(641, 39);
            this.textAccount.Name = "textAccount";
            this.textAccount.Size = new System.Drawing.Size(105, 20);
            this.textAccount.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(40, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(40, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sexo";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(108, 364);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(152, 20);
            this.textPhone.TabIndex = 16;
            // 
            // textSex
            // 
            this.textSex.Location = new System.Drawing.Point(94, 261);
            this.textSex.Name = "textSex";
            this.textSex.Size = new System.Drawing.Size(107, 20);
            this.textSex.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(40, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Correo.";
            // 
            // textMail
            // 
            this.textMail.Location = new System.Drawing.Point(93, 203);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(212, 20);
            this.textMail.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(40, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // textDate
            // 
            this.textDate.Location = new System.Drawing.Point(152, 148);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(108, 20);
            this.textDate.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(40, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellidos";
            // 
            // textAP
            // 
            this.textAP.Location = new System.Drawing.Point(118, 93);
            this.textAP.Name = "textAP";
            this.textAP.Size = new System.Drawing.Size(245, 20);
            this.textAP.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(40, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre(s)";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(119, 46);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(244, 20);
            this.textName.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(40, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Numero de cliente";
            // 
            // textNumCli
            // 
            this.textNumCli.Location = new System.Drawing.Point(148, 7);
            this.textNumCli.Name = "textNumCli";
            this.textNumCli.Size = new System.Drawing.Size(141, 20);
            this.textNumCli.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(29, 316);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Direccion";
            // 
            // textDirection
            // 
            this.textDirection.Location = new System.Drawing.Point(96, 310);
            this.textDirection.Name = "textDirection";
            this.textDirection.Size = new System.Drawing.Size(180, 20);
            this.textDirection.TabIndex = 27;
            // 
            // btEMP
            // 
            this.btEMP.BackColor = System.Drawing.Color.Transparent;
            this.btEMP.BackgroundImage = global::formulario.Properties.Resources.button;
            this.btEMP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEMP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEMP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEMP.Location = new System.Drawing.Point(435, 403);
            this.btEMP.Name = "btEMP";
            this.btEMP.Size = new System.Drawing.Size(127, 54);
            this.btEMP.TabIndex = 29;
            this.btEMP.Text = "Agregar empleado";
            this.btEMP.UseVisualStyleBackColor = false;
            this.btEMP.Click += new System.EventHandler(this.btEMP_Click_1);
            // 
            // BtnTans
            // 
            this.BtnTans.BackColor = System.Drawing.Color.Transparent;
            this.BtnTans.BackgroundImage = global::formulario.Properties.Resources.button;
            this.BtnTans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTans.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTans.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnTans.Location = new System.Drawing.Point(605, 402);
            this.BtnTans.Name = "BtnTans";
            this.BtnTans.Size = new System.Drawing.Size(125, 55);
            this.BtnTans.TabIndex = 30;
            this.BtnTans.Text = "Transacciones";
            this.BtnTans.UseVisualStyleBackColor = false;
            this.BtnTans.Click += new System.EventHandler(this.BtnTans_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::formulario.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(773, 470);
            this.Controls.Add(this.BtnTans);
            this.Controls.Add(this.btEMP);
            this.Controls.Add(this.textDirection);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textNumCli);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textSucursals);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBalance);
            this.Controls.Add(this.textTypeAccount);
            this.Controls.Add(this.textAccount);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textSex);
            this.Controls.Add(this.textMail);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.textAP);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Prueba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cliente";
            this.RightToLeftLayout = true;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Prueba;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textSucursals;
        private System.Windows.Forms.TextBox textBalance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textTypeAccount;
        private System.Windows.Forms.TextBox textAccount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textSex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textNumCli;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textDirection;
        private System.Windows.Forms.Button btEMP;
        private System.Windows.Forms.Button BtnTans;
    }
}

