namespace ControlSoft
{
    partial class AltaP
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giroPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proovedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProovedoresN = new ControlSoft.DataSetProovedoresN();
            this.btnAlta = new System.Windows.Forms.Button();
            this.textCorreoP = new System.Windows.Forms.TextBox();
            this.textTelefonoP = new System.Windows.Forms.TextBox();
            this.textNombreP = new System.Windows.Forms.TextBox();
            this.textRFCP = new System.Windows.Forms.TextBox();
            this.textGiro = new System.Windows.Forms.TextBox();
            this.textEmpresa = new System.Windows.Forms.TextBox();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureSalir = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.proovedoresTableAdapter = new ControlSoft.DataSetProovedoresNTableAdapters.ProovedoresTableAdapter();
            this.textTipoP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proovedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProovedoresN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 73);
            this.panel1.TabIndex = 51;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoPDataGridViewTextBoxColumn,
            this.empresaPDataGridViewTextBoxColumn,
            this.giroPDataGridViewTextBoxColumn,
            this.tipoProvDataGridViewTextBoxColumn,
            this.rFCPDataGridViewTextBoxColumn,
            this.nombrePDataGridViewTextBoxColumn,
            this.telefonoPDataGridViewTextBoxColumn,
            this.correoPDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proovedoresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 389);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(10, 10);
            this.dataGridView1.TabIndex = 50;
            // 
            // codigoPDataGridViewTextBoxColumn
            // 
            this.codigoPDataGridViewTextBoxColumn.DataPropertyName = "CodigoP";
            this.codigoPDataGridViewTextBoxColumn.HeaderText = "CodigoP";
            this.codigoPDataGridViewTextBoxColumn.Name = "codigoPDataGridViewTextBoxColumn";
            // 
            // empresaPDataGridViewTextBoxColumn
            // 
            this.empresaPDataGridViewTextBoxColumn.DataPropertyName = "EmpresaP";
            this.empresaPDataGridViewTextBoxColumn.HeaderText = "EmpresaP";
            this.empresaPDataGridViewTextBoxColumn.Name = "empresaPDataGridViewTextBoxColumn";
            // 
            // giroPDataGridViewTextBoxColumn
            // 
            this.giroPDataGridViewTextBoxColumn.DataPropertyName = "GiroP";
            this.giroPDataGridViewTextBoxColumn.HeaderText = "GiroP";
            this.giroPDataGridViewTextBoxColumn.Name = "giroPDataGridViewTextBoxColumn";
            // 
            // tipoProvDataGridViewTextBoxColumn
            // 
            this.tipoProvDataGridViewTextBoxColumn.DataPropertyName = "TipoProv";
            this.tipoProvDataGridViewTextBoxColumn.HeaderText = "TipoProv";
            this.tipoProvDataGridViewTextBoxColumn.Name = "tipoProvDataGridViewTextBoxColumn";
            // 
            // rFCPDataGridViewTextBoxColumn
            // 
            this.rFCPDataGridViewTextBoxColumn.DataPropertyName = "RFCP";
            this.rFCPDataGridViewTextBoxColumn.HeaderText = "RFCP";
            this.rFCPDataGridViewTextBoxColumn.Name = "rFCPDataGridViewTextBoxColumn";
            // 
            // nombrePDataGridViewTextBoxColumn
            // 
            this.nombrePDataGridViewTextBoxColumn.DataPropertyName = "NombreP";
            this.nombrePDataGridViewTextBoxColumn.HeaderText = "NombreP";
            this.nombrePDataGridViewTextBoxColumn.Name = "nombrePDataGridViewTextBoxColumn";
            // 
            // telefonoPDataGridViewTextBoxColumn
            // 
            this.telefonoPDataGridViewTextBoxColumn.DataPropertyName = "TelefonoP";
            this.telefonoPDataGridViewTextBoxColumn.HeaderText = "TelefonoP";
            this.telefonoPDataGridViewTextBoxColumn.Name = "telefonoPDataGridViewTextBoxColumn";
            // 
            // correoPDataGridViewTextBoxColumn
            // 
            this.correoPDataGridViewTextBoxColumn.DataPropertyName = "CorreoP";
            this.correoPDataGridViewTextBoxColumn.HeaderText = "CorreoP";
            this.correoPDataGridViewTextBoxColumn.Name = "correoPDataGridViewTextBoxColumn";
            // 
            // proovedoresBindingSource
            // 
            this.proovedoresBindingSource.DataMember = "Proovedores";
            this.proovedoresBindingSource.DataSource = this.dataSetProovedoresN;
            // 
            // dataSetProovedoresN
            // 
            this.dataSetProovedoresN.DataSetName = "DataSetProovedoresN";
            this.dataSetProovedoresN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.Green;
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.ForeColor = System.Drawing.Color.White;
            this.btnAlta.Location = new System.Drawing.Point(201, 390);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(116, 28);
            this.btnAlta.TabIndex = 49;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // textCorreoP
            // 
            this.textCorreoP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCorreoP.Location = new System.Drawing.Point(236, 342);
            this.textCorreoP.Name = "textCorreoP";
            this.textCorreoP.Size = new System.Drawing.Size(236, 26);
            this.textCorreoP.TabIndex = 48;
            // 
            // textTelefonoP
            // 
            this.textTelefonoP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelefonoP.Location = new System.Drawing.Point(236, 307);
            this.textTelefonoP.Name = "textTelefonoP";
            this.textTelefonoP.Size = new System.Drawing.Size(236, 26);
            this.textTelefonoP.TabIndex = 47;
            // 
            // textNombreP
            // 
            this.textNombreP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreP.Location = new System.Drawing.Point(236, 272);
            this.textNombreP.Name = "textNombreP";
            this.textNombreP.Size = new System.Drawing.Size(236, 26);
            this.textNombreP.TabIndex = 46;
            // 
            // textRFCP
            // 
            this.textRFCP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRFCP.Location = new System.Drawing.Point(236, 237);
            this.textRFCP.Name = "textRFCP";
            this.textRFCP.Size = new System.Drawing.Size(236, 26);
            this.textRFCP.TabIndex = 45;
            // 
            // textGiro
            // 
            this.textGiro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGiro.Location = new System.Drawing.Point(236, 170);
            this.textGiro.Name = "textGiro";
            this.textGiro.Size = new System.Drawing.Size(236, 26);
            this.textGiro.TabIndex = 44;
            // 
            // textEmpresa
            // 
            this.textEmpresa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmpresa.Location = new System.Drawing.Point(236, 138);
            this.textEmpresa.Name = "textEmpresa";
            this.textEmpresa.Size = new System.Drawing.Size(236, 26);
            this.textEmpresa.TabIndex = 43;
            // 
            // textCodigo
            // 
            this.textCodigo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCodigo.Location = new System.Drawing.Point(236, 100);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(236, 26);
            this.textCodigo.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 22);
            this.label8.TabIndex = 41;
            this.label8.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 22);
            this.label6.TabIndex = 40;
            this.label6.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 22);
            this.label7.TabIndex = 39;
            this.label7.Text = "Nombre del contacto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 22);
            this.label4.TabIndex = 38;
            this.label4.Text = "RFC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 22);
            this.label5.TabIndex = 37;
            this.label5.Text = "Giro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 36;
            this.label3.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 35;
            this.label2.Text = "Codigo";
            // 
            // pictureSalir
            // 
            this.pictureSalir.Image = global::ControlSoft.Properties.Resources.salida;
            this.pictureSalir.Location = new System.Drawing.Point(449, 422);
            this.pictureSalir.Name = "pictureSalir";
            this.pictureSalir.Size = new System.Drawing.Size(49, 41);
            this.pictureSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSalir.TabIndex = 52;
            this.pictureSalir.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControlSoft.Properties.Resources.expediente;
            this.pictureBox1.Location = new System.Drawing.Point(275, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 22);
            this.label1.TabIndex = 53;
            this.label1.Text = "Información del proovedor";
            // 
            // proovedoresTableAdapter
            // 
            this.proovedoresTableAdapter.ClearBeforeFill = true;
            // 
            // textTipoP
            // 
            this.textTipoP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTipoP.Location = new System.Drawing.Point(236, 205);
            this.textTipoP.Name = "textTipoP";
            this.textTipoP.Size = new System.Drawing.Size(236, 26);
            this.textTipoP.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 22);
            this.label9.TabIndex = 55;
            this.label9.Text = "Tipo Proovedor";
            // 
            // AltaP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(510, 476);
            this.Controls.Add(this.textTipoP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.textCorreoP);
            this.Controls.Add(this.textTelefonoP);
            this.Controls.Add(this.textNombreP);
            this.Controls.Add(this.textRFCP);
            this.Controls.Add(this.textGiro);
            this.Controls.Add(this.textEmpresa);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AltaP";
            this.Text = "AltaP";
            this.Load += new System.EventHandler(this.AltaP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proovedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProovedoresN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.TextBox textCorreoP;
        private System.Windows.Forms.TextBox textTelefonoP;
        private System.Windows.Forms.TextBox textNombreP;
        private System.Windows.Forms.TextBox textRFCP;
        private System.Windows.Forms.TextBox textGiro;
        private System.Windows.Forms.TextBox textEmpresa;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private DataSetProovedoresN dataSetProovedoresN;
        private System.Windows.Forms.BindingSource proovedoresBindingSource;
        private DataSetProovedoresNTableAdapters.ProovedoresTableAdapter proovedoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giroPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoPDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textTipoP;
        private System.Windows.Forms.Label label9;
    }
}