namespace formulario
{
    partial class Sucursales
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
            this.sucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoDataSet = new formulario.bancoDataSet();
            this.sucursalTableAdapter = new formulario.bancoDataSetTableAdapters.sucursalTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.DtgrSucursales = new System.Windows.Forms.DataGridView();
            this.sucursalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bancoDataSet3 = new formulario.bancoDataSet3();
            this.sucursalTableAdapter1 = new formulario.bancoDataSet3TableAdapters.sucursalTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgrSucursales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet3)).BeginInit();
            this.SuspendLayout();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar sucursal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DtgrSucursales
            // 
            this.DtgrSucursales.AllowUserToAddRows = false;
            this.DtgrSucursales.AllowUserToDeleteRows = false;
            this.DtgrSucursales.AutoGenerateColumns = false;
            this.DtgrSucursales.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.DtgrSucursales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.horarioDataGridViewTextBoxColumn});
            this.DtgrSucursales.DataSource = this.sucursalBindingSource1;
            this.DtgrSucursales.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DtgrSucursales.Location = new System.Drawing.Point(5, 44);
            this.DtgrSucursales.Name = "DtgrSucursales";
            this.DtgrSucursales.ReadOnly = true;
            this.DtgrSucursales.Size = new System.Drawing.Size(747, 240);
            this.DtgrSucursales.TabIndex = 2;
            // 
            // sucursalBindingSource1
            // 
            this.sucursalBindingSource1.DataMember = "sucursal";
            this.sucursalBindingSource1.DataSource = this.bancoDataSet3;
            // 
            // bancoDataSet3
            // 
            this.bancoDataSet3.DataSetName = "bancoDataSet3";
            this.bancoDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sucursalTableAdapter1
            // 
            this.sucursalTableAdapter1.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_sucursal";
            this.Column1.HeaderText = "Nº Sucursal";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 250;
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
            // 
            // Sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(755, 386);
            this.Controls.Add(this.DtgrSucursales);
            this.Controls.Add(this.button1);
            this.Name = "Sucursales";
            this.Text = "Sucursales";
            this.Load += new System.EventHandler(this.Sucursales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgrSucursales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private bancoDataSet bancoDataSet;
        private System.Windows.Forms.BindingSource sucursalBindingSource;
        private bancoDataSetTableAdapters.sucursalTableAdapter sucursalTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DtgrSucursales;
        private bancoDataSet3 bancoDataSet3;
        private System.Windows.Forms.BindingSource sucursalBindingSource1;
        private bancoDataSet3TableAdapters.sucursalTableAdapter sucursalTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioDataGridViewTextBoxColumn;
    }
}