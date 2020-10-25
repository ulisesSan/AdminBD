namespace formulario
{
    partial class Transacciones
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNtrans = new System.Windows.Forms.TextBox();
            this.txtAccountOrig = new System.Windows.Forms.TextBox();
            this.txtAccountDest = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtTypeTrans = new System.Windows.Forms.TextBox();
            this.txtDescript = new System.Windows.Forms.TextBox();
            this.btnTrans = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.transaccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaccionesData = new formulario.TransaccionesData();
            this.transaccionTableAdapter = new formulario.TransaccionesDataTableAdapters.transaccionTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcuentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcuentadestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipotransaccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(38, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Transaccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(38, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cuenta de origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(38, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cuenta destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(38, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha (aaa-mm-dd)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(38, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(38, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo de transaccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(38, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Descripción";
            // 
            // txtNtrans
            // 
            this.txtNtrans.Location = new System.Drawing.Point(144, 40);
            this.txtNtrans.Name = "txtNtrans";
            this.txtNtrans.Size = new System.Drawing.Size(64, 20);
            this.txtNtrans.TabIndex = 7;
            // 
            // txtAccountOrig
            // 
            this.txtAccountOrig.Location = new System.Drawing.Point(144, 71);
            this.txtAccountOrig.Name = "txtAccountOrig";
            this.txtAccountOrig.Size = new System.Drawing.Size(64, 20);
            this.txtAccountOrig.TabIndex = 8;
            // 
            // txtAccountDest
            // 
            this.txtAccountDest.Location = new System.Drawing.Point(144, 112);
            this.txtAccountDest.Name = "txtAccountDest";
            this.txtAccountDest.Size = new System.Drawing.Size(62, 20);
            this.txtAccountDest.TabIndex = 9;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(144, 148);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(91, 20);
            this.txtdate.TabIndex = 10;
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(144, 189);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(104, 20);
            this.txtMoney.TabIndex = 11;
            // 
            // txtTypeTrans
            // 
            this.txtTypeTrans.Location = new System.Drawing.Point(144, 228);
            this.txtTypeTrans.Name = "txtTypeTrans";
            this.txtTypeTrans.Size = new System.Drawing.Size(123, 20);
            this.txtTypeTrans.TabIndex = 12;
            // 
            // txtDescript
            // 
            this.txtDescript.Location = new System.Drawing.Point(144, 257);
            this.txtDescript.Name = "txtDescript";
            this.txtDescript.Size = new System.Drawing.Size(123, 20);
            this.txtDescript.TabIndex = 13;
            // 
            // btnTrans
            // 
            this.btnTrans.BackColor = System.Drawing.Color.Transparent;
            this.btnTrans.BackgroundImage = global::formulario.Properties.Resources.button;
            this.btnTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrans.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrans.Location = new System.Drawing.Point(634, 360);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(118, 38);
            this.btnTrans.TabIndex = 14;
            this.btnTrans.Text = "Aceptar";
            this.btnTrans.UseVisualStyleBackColor = false;
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::formulario.Properties.Resources.button;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(108, 360);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 37);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.idcuentaDataGridViewTextBoxColumn,
            this.idcuentadestDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.tipotransaccionDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transaccionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(293, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(738, 342);
            this.dataGridView1.TabIndex = 16;
            // 
            // transaccionBindingSource
            // 
            this.transaccionBindingSource.DataMember = "transaccion";
            this.transaccionBindingSource.DataSource = this.transaccionesData;
            // 
            // transaccionesData
            // 
            this.transaccionesData.DataSetName = "TransaccionesData";
            this.transaccionesData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transaccionTableAdapter
            // 
            this.transaccionTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_transaaccion";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nº detransaaccion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // idcuentaDataGridViewTextBoxColumn
            // 
            this.idcuentaDataGridViewTextBoxColumn.DataPropertyName = "id_cuenta";
            this.idcuentaDataGridViewTextBoxColumn.HeaderText = "Nº de cuenta origen";
            this.idcuentaDataGridViewTextBoxColumn.Name = "idcuentaDataGridViewTextBoxColumn";
            this.idcuentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcuentaDataGridViewTextBoxColumn.Width = 90;
            // 
            // idcuentadestDataGridViewTextBoxColumn
            // 
            this.idcuentadestDataGridViewTextBoxColumn.DataPropertyName = "id_cuenta_dest";
            this.idcuentadestDataGridViewTextBoxColumn.FillWeight = 90F;
            this.idcuentadestDataGridViewTextBoxColumn.HeaderText = "Nº de cuenta destino";
            this.idcuentadestDataGridViewTextBoxColumn.Name = "idcuentadestDataGridViewTextBoxColumn";
            this.idcuentadestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 90;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            this.montoDataGridViewTextBoxColumn.Width = 90;
            // 
            // tipotransaccionDataGridViewTextBoxColumn
            // 
            this.tipotransaccionDataGridViewTextBoxColumn.DataPropertyName = "tipo_transaccion";
            this.tipotransaccionDataGridViewTextBoxColumn.HeaderText = "Tipo de transaccion";
            this.tipotransaccionDataGridViewTextBoxColumn.Name = "tipotransaccionDataGridViewTextBoxColumn";
            this.tipotransaccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipotransaccionDataGridViewTextBoxColumn.Width = 150;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 200;
            // 
            // Transacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::formulario.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(1032, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTrans);
            this.Controls.Add(this.txtDescript);
            this.Controls.Add(this.txtTypeTrans);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtAccountDest);
            this.Controls.Add(this.txtAccountOrig);
            this.Controls.Add(this.txtNtrans);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Transacciones";
            this.Text = "Transacciones";
            this.Load += new System.EventHandler(this.Transacciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNtrans;
        private System.Windows.Forms.TextBox txtAccountOrig;
        private System.Windows.Forms.TextBox txtAccountDest;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtTypeTrans;
        private System.Windows.Forms.TextBox txtDescript;
        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtransaaccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TransaccionesData transaccionesData;
        private System.Windows.Forms.BindingSource transaccionBindingSource;
        private TransaccionesDataTableAdapters.transaccionTableAdapter transaccionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcuentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcuentadestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipotransaccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
    }
}