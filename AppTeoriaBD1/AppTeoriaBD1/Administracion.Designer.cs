namespace AppTeoriaBD1
{
    partial class Administracion
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pyTBD1 = new AppTeoriaBD1.PyTBD1();
            this.aFILIADOSCUENTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aFILIADOS_CUENTASTableAdapter = new AppTeoriaBD1.PyTBD1TableAdapters.AFILIADOS_CUENTASTableAdapter();
            this.dbGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pyTBD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aFILIADOSCUENTASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(325, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(65, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar ";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(396, 12);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 1;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(478, 11);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(560, 11);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pyTBD1
            // 
            this.pyTBD1.DataSetName = "PyTBD1";
            this.pyTBD1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aFILIADOSCUENTASBindingSource
            // 
            this.aFILIADOSCUENTASBindingSource.DataMember = "AFILIADOS_CUENTAS";
            this.aFILIADOSCUENTASBindingSource.DataSource = this.pyTBD1;
            // 
            // aFILIADOS_CUENTASTableAdapter
            // 
            this.aFILIADOS_CUENTASTableAdapter.ClearBeforeFill = true;
            // 
            // dbGrid
            // 
            this.dbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGrid.Location = new System.Drawing.Point(12, 58);
            this.dbGrid.Name = "dbGrid";
            this.dbGrid.Size = new System.Drawing.Size(644, 315);
            this.dbGrid.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "AFILIADOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 397);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbGrid);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Administracion";
            this.Text = "Administracion";
            this.Load += new System.EventHandler(this.Administracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pyTBD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aFILIADOSCUENTASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private PyTBD1 pyTBD1;
        private System.Windows.Forms.BindingSource aFILIADOSCUENTASBindingSource;
        private PyTBD1TableAdapters.AFILIADOS_CUENTASTableAdapter aFILIADOS_CUENTASTableAdapter;
        private System.Windows.Forms.DataGridView dbGrid;
        private System.Windows.Forms.Label label1;
    }
}