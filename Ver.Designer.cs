namespace ControlSoft
{
    partial class Ver
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
            this.label8 = new System.Windows.Forms.Label();
            this.textCodigoM = new System.Windows.Forms.TextBox();
            this.textEmpresaM = new System.Windows.Forms.TextBox();
            this.textGiroM = new System.Windows.Forms.TextBox();
            this.textRFCM = new System.Windows.Forms.TextBox();
            this.textNombreM = new System.Windows.Forms.TextBox();
            this.textTelefonoM = new System.Windows.Forms.TextBox();
            this.textCorreoM = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.checkBoxEliminar = new System.Windows.Forms.CheckBox();
            this.checkBoxModificar = new System.Windows.Forms.CheckBox();
            this.pictureSalir = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSetClientesN = new ControlSoft.DataSetClientesN();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new ControlSoft.DataSetClientesNTableAdapters.ClientesTableAdapter();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giroCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClientesN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Información del cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Empresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "RFC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nombre del contacto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Correo";
            // 
            // textCodigoM
            // 
            this.textCodigoM.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCodigoM.Location = new System.Drawing.Point(236, 101);
            this.textCodigoM.Name = "textCodigoM";
            this.textCodigoM.Size = new System.Drawing.Size(236, 26);
            this.textCodigoM.TabIndex = 8;
            // 
            // textEmpresaM
            // 
            this.textEmpresaM.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmpresaM.Location = new System.Drawing.Point(236, 139);
            this.textEmpresaM.Name = "textEmpresaM";
            this.textEmpresaM.Size = new System.Drawing.Size(236, 26);
            this.textEmpresaM.TabIndex = 9;
            // 
            // textGiroM
            // 
            this.textGiroM.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGiroM.Location = new System.Drawing.Point(236, 171);
            this.textGiroM.Name = "textGiroM";
            this.textGiroM.Size = new System.Drawing.Size(236, 26);
            this.textGiroM.TabIndex = 10;
            // 
            // textRFCM
            // 
            this.textRFCM.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRFCM.Location = new System.Drawing.Point(236, 205);
            this.textRFCM.Name = "textRFCM";
            this.textRFCM.Size = new System.Drawing.Size(236, 26);
            this.textRFCM.TabIndex = 11;
            // 
            // textNombreM
            // 
            this.textNombreM.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreM.Location = new System.Drawing.Point(236, 240);
            this.textNombreM.Name = "textNombreM";
            this.textNombreM.Size = new System.Drawing.Size(236, 26);
            this.textNombreM.TabIndex = 12;
            // 
            // textTelefonoM
            // 
            this.textTelefonoM.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelefonoM.Location = new System.Drawing.Point(236, 275);
            this.textTelefonoM.Name = "textTelefonoM";
            this.textTelefonoM.Size = new System.Drawing.Size(236, 26);
            this.textTelefonoM.TabIndex = 13;
            // 
            // textCorreoM
            // 
            this.textCorreoM.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCorreoM.Location = new System.Drawing.Point(236, 310);
            this.textCorreoM.Name = "textCorreoM";
            this.textCorreoM.Size = new System.Drawing.Size(236, 26);
            this.textCorreoM.TabIndex = 14;
            this.textCorreoM.TextChanged += new System.EventHandler(this.textCorreoM_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.checkBoxEliminar);
            this.groupBox1.Controls.Add(this.checkBoxModificar);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(154, 62);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 28);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Green;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(154, 28);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(116, 28);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // checkBoxEliminar
            // 
            this.checkBoxEliminar.AutoSize = true;
            this.checkBoxEliminar.Location = new System.Drawing.Point(16, 62);
            this.checkBoxEliminar.Name = "checkBoxEliminar";
            this.checkBoxEliminar.Size = new System.Drawing.Size(96, 26);
            this.checkBoxEliminar.TabIndex = 1;
            this.checkBoxEliminar.Text = "Eliminar";
            this.checkBoxEliminar.UseVisualStyleBackColor = true;
            this.checkBoxEliminar.CheckedChanged += new System.EventHandler(this.checkBoxEliminar_CheckedChanged);
            // 
            // checkBoxModificar
            // 
            this.checkBoxModificar.AutoSize = true;
            this.checkBoxModificar.Location = new System.Drawing.Point(16, 30);
            this.checkBoxModificar.Name = "checkBoxModificar";
            this.checkBoxModificar.Size = new System.Drawing.Size(114, 26);
            this.checkBoxModificar.TabIndex = 0;
            this.checkBoxModificar.Text = "Modificar";
            this.checkBoxModificar.UseVisualStyleBackColor = true;
            this.checkBoxModificar.CheckedChanged += new System.EventHandler(this.checkBoxModificar_CheckedChanged);
            // 
            // pictureSalir
            // 
            this.pictureSalir.Image = global::ControlSoft.Properties.Resources.salida;
            this.pictureSalir.Location = new System.Drawing.Point(449, 426);
            this.pictureSalir.Name = "pictureSalir";
            this.pictureSalir.Size = new System.Drawing.Size(49, 41);
            this.pictureSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSalir.TabIndex = 16;
            this.pictureSalir.TabStop = false;
            this.pictureSalir.Click += new System.EventHandler(this.pictureSalir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.empresaCDataGridViewTextBoxColumn,
            this.giroCDataGridViewTextBoxColumn,
            this.rFCCDataGridViewTextBoxColumn,
            this.nombreCDataGridViewTextBoxColumn,
            this.telefonoCDataGridViewTextBoxColumn,
            this.correoCDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 442);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(19, 12);
            this.dataGridView1.TabIndex = 17;
            // 
            // dataSetClientesN
            // 
            this.dataSetClientesN.DataSetName = "DataSetClientesN";
            this.dataSetClientesN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.dataSetClientesN;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // empresaCDataGridViewTextBoxColumn
            // 
            this.empresaCDataGridViewTextBoxColumn.DataPropertyName = "EmpresaC";
            this.empresaCDataGridViewTextBoxColumn.HeaderText = "EmpresaC";
            this.empresaCDataGridViewTextBoxColumn.Name = "empresaCDataGridViewTextBoxColumn";
            // 
            // giroCDataGridViewTextBoxColumn
            // 
            this.giroCDataGridViewTextBoxColumn.DataPropertyName = "GiroC";
            this.giroCDataGridViewTextBoxColumn.HeaderText = "GiroC";
            this.giroCDataGridViewTextBoxColumn.Name = "giroCDataGridViewTextBoxColumn";
            // 
            // rFCCDataGridViewTextBoxColumn
            // 
            this.rFCCDataGridViewTextBoxColumn.DataPropertyName = "RFCC";
            this.rFCCDataGridViewTextBoxColumn.HeaderText = "RFCC";
            this.rFCCDataGridViewTextBoxColumn.Name = "rFCCDataGridViewTextBoxColumn";
            // 
            // nombreCDataGridViewTextBoxColumn
            // 
            this.nombreCDataGridViewTextBoxColumn.DataPropertyName = "NombreC";
            this.nombreCDataGridViewTextBoxColumn.HeaderText = "NombreC";
            this.nombreCDataGridViewTextBoxColumn.Name = "nombreCDataGridViewTextBoxColumn";
            // 
            // telefonoCDataGridViewTextBoxColumn
            // 
            this.telefonoCDataGridViewTextBoxColumn.DataPropertyName = "TelefonoC";
            this.telefonoCDataGridViewTextBoxColumn.HeaderText = "TelefonoC";
            this.telefonoCDataGridViewTextBoxColumn.Name = "telefonoCDataGridViewTextBoxColumn";
            // 
            // correoCDataGridViewTextBoxColumn
            // 
            this.correoCDataGridViewTextBoxColumn.DataPropertyName = "CorreoC";
            this.correoCDataGridViewTextBoxColumn.HeaderText = "CorreoC";
            this.correoCDataGridViewTextBoxColumn.Name = "correoCDataGridViewTextBoxColumn";
            // 
            // Ver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(510, 476);
            this.Controls.Add(this.pictureSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textCorreoM);
            this.Controls.Add(this.textTelefonoM);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textNombreM);
            this.Controls.Add(this.textRFCM);
            this.Controls.Add(this.textGiroM);
            this.Controls.Add(this.textEmpresaM);
            this.Controls.Add(this.textCodigoM);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver";
            this.Load += new System.EventHandler(this.Ver_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClientesN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.CheckBox checkBoxModificar;
        private System.Windows.Forms.PictureBox pictureSalir;
        public System.Windows.Forms.TextBox textCodigoM;
        public System.Windows.Forms.TextBox textEmpresaM;
        public System.Windows.Forms.TextBox textGiroM;
        public System.Windows.Forms.TextBox textRFCM;
        public System.Windows.Forms.TextBox textNombreM;
        public System.Windows.Forms.TextBox textTelefonoM;
        public System.Windows.Forms.TextBox textCorreoM;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetClientesN dataSetClientesN;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DataSetClientesNTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giroCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoCDataGridViewTextBoxColumn;
        public System.Windows.Forms.CheckBox checkBoxEliminar;
    }
}