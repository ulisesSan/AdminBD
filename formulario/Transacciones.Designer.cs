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
            this.bancoDataSet4 = new formulario.bancoDataSet4();
            this.transaccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaccionTableAdapter = new formulario.bancoDataSet4TableAdapters.transaccionTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcuentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcuentadestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipotransaccioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Transaccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cuenta de origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cuenta destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha (aaa-mm-dd)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo de transaccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
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
            this.btnTrans.Location = new System.Drawing.Point(634, 360);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(118, 38);
            this.btnTrans.TabIndex = 14;
            this.btnTrans.Text = "Aceptar";
            this.btnTrans.UseVisualStyleBackColor = true;
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(108, 360);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 37);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.idcuentaDataGridViewTextBoxColumn,
            this.idcuentadestDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.tipotransaccioDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transaccionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(286, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(745, 334);
            this.dataGridView1.TabIndex = 16;
            // 
            // bancoDataSet4
            // 
            this.bancoDataSet4.DataSetName = "bancoDataSet4";
            this.bancoDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transaccionBindingSource
            // 
            this.transaccionBindingSource.DataMember = "transaccion";
            this.transaccionBindingSource.DataSource = this.bancoDataSet4;
            // 
            // transaccionTableAdapter
            // 
            this.transaccionTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_transaaccion";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_transaaccion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idcuentaDataGridViewTextBoxColumn
            // 
            this.idcuentaDataGridViewTextBoxColumn.DataPropertyName = "id_cuenta";
            this.idcuentaDataGridViewTextBoxColumn.HeaderText = "id_cuenta";
            this.idcuentaDataGridViewTextBoxColumn.Name = "idcuentaDataGridViewTextBoxColumn";
            this.idcuentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idcuentadestDataGridViewTextBoxColumn
            // 
            this.idcuentadestDataGridViewTextBoxColumn.DataPropertyName = "id_cuenta_dest";
            this.idcuentadestDataGridViewTextBoxColumn.HeaderText = "id_cuenta_dest";
            this.idcuentadestDataGridViewTextBoxColumn.Name = "idcuentadestDataGridViewTextBoxColumn";
            this.idcuentadestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipotransaccioDataGridViewTextBoxColumn
            // 
            this.tipotransaccioDataGridViewTextBoxColumn.DataPropertyName = "tipo_transaccio";
            this.tipotransaccioDataGridViewTextBoxColumn.HeaderText = "tipo_transaccio";
            this.tipotransaccioDataGridViewTextBoxColumn.Name = "tipotransaccioDataGridViewTextBoxColumn";
            this.tipotransaccioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Transacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionBindingSource)).EndInit();
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
        private bancoDataSet4 bancoDataSet4;
        private System.Windows.Forms.BindingSource transaccionBindingSource;
        private bancoDataSet4TableAdapters.transaccionTableAdapter transaccionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcuentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcuentadestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipotransaccioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
    }
}