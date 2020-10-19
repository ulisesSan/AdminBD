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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textNameSucs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textDirSucs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textTimeSucs = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textNumSucs = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoDataSet = new formulario.bancoDataSet();
            this.sucursalTableAdapter = new formulario.bancoDataSetTableAdapters.sucursalTableAdapter();
            this.bancoDataSet2 = new formulario.bancoDataSet2();
            this.sucursalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sucursalTableAdapter1 = new formulario.bancoDataSet2TableAdapters.sucursalTableAdapter();
            this.idsucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exitbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource1)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(41, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dirección";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textDirSucs
            // 
            this.textDirSucs.Location = new System.Drawing.Point(159, 69);
            this.textDirSucs.Name = "textDirSucs";
            this.textDirSucs.Size = new System.Drawing.Size(417, 20);
            this.textDirSucs.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Horario";
            // 
            // textTimeSucs
            // 
            this.textTimeSucs.Location = new System.Drawing.Point(159, 101);
            this.textTimeSucs.Name = "textTimeSucs";
            this.textTimeSucs.Size = new System.Drawing.Size(417, 20);
            this.textTimeSucs.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(607, 392);
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
            this.label4.Location = new System.Drawing.Point(41, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numero de sucursal";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textNumSucs
            // 
            this.textNumSucs.Location = new System.Drawing.Point(159, 135);
            this.textNumSucs.Name = "textNumSucs";
            this.textNumSucs.Size = new System.Drawing.Size(58, 20);
            this.textNumSucs.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsucursalDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.horarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sucursalBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 210);
            this.dataGridView1.TabIndex = 9;
            // 
            // sucursalBindingSource
            // 
            this.sucursalBindingSource.DataMember = "sucursal";
            this.sucursalBindingSource.DataSource = this.bancoDataSet;
            // 
            // bancoDataSet
            // 
            this.bancoDataSet.DataSetName = "bancoDataSet";
            this.bancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sucursalTableAdapter
            // 
            this.sucursalTableAdapter.ClearBeforeFill = true;
            // 
            // bancoDataSet2
            // 
            this.bancoDataSet2.DataSetName = "bancoDataSet2";
            this.bancoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sucursalBindingSource1
            // 
            this.sucursalBindingSource1.DataMember = "sucursal";
            this.sucursalBindingSource1.DataSource = this.bancoDataSet2;
            // 
            // sucursalTableAdapter1
            // 
            this.sucursalTableAdapter1.ClearBeforeFill = true;
            // 
            // idsucursalDataGridViewTextBoxColumn
            // 
            this.idsucursalDataGridViewTextBoxColumn.DataPropertyName = "id_sucursal";
            this.idsucursalDataGridViewTextBoxColumn.FillWeight = 50F;
            this.idsucursalDataGridViewTextBoxColumn.HeaderText = "Nº Sucursal";
            this.idsucursalDataGridViewTextBoxColumn.Name = "idsucursalDataGridViewTextBoxColumn";
            this.idsucursalDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsucursalDataGridViewTextBoxColumn.Width = 90;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.Width = 250;
            // 
            // horarioDataGridViewTextBoxColumn
            // 
            this.horarioDataGridViewTextBoxColumn.DataPropertyName = "horario";
            this.horarioDataGridViewTextBoxColumn.HeaderText = "Horario";
            this.horarioDataGridViewTextBoxColumn.Name = "horarioDataGridViewTextBoxColumn";
            this.horarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.horarioDataGridViewTextBoxColumn.Width = 250;
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(44, 392);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(138, 46);
            this.Exitbtn.TabIndex = 10;
            this.Exitbtn.Text = "Salir";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // AgrSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textNumSucs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.textTimeSucs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textDirSucs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNameSucs);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgrSucursales";
            this.Text = "AgrSucursales";
            this.Load += new System.EventHandler(this.AgrSucursales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private bancoDataSet bancoDataSet;
        private System.Windows.Forms.BindingSource sucursalBindingSource;
        private bancoDataSetTableAdapters.sucursalTableAdapter sucursalTableAdapter;
        private bancoDataSet2 bancoDataSet2;
        private System.Windows.Forms.BindingSource sucursalBindingSource1;
        private bancoDataSet2TableAdapters.sucursalTableAdapter sucursalTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Exitbtn;
    }
}