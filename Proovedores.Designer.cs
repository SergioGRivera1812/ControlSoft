namespace ControlSoft
{
    partial class Proovedores
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
            this.dataGridViewP = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proovedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProovedores = new ControlSoft.DataSetProovedores();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureAceptarM = new System.Windows.Forms.PictureBox();
            this.textTipoPM = new System.Windows.Forms.TextBox();
            this.textNombrePM = new System.Windows.Forms.TextBox();
            this.textCodigoPM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureAceptarB = new System.Windows.Forms.PictureBox();
            this.textCodigoPB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textCodigoPA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureAceptarA = new System.Windows.Forms.PictureBox();
            this.textTipoPA = new System.Windows.Forms.TextBox();
            this.textNombrePA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.proovedoresTableAdapter = new ControlSoft.DataSetProovedoresTableAdapters.ProovedoresTableAdapter();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proovedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proovedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProovedores)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAceptarM)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAceptarB)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAceptarA)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewP
            // 
            this.dataGridViewP.AllowUserToAddRows = false;
            this.dataGridViewP.AllowUserToDeleteRows = false;
            this.dataGridViewP.AutoGenerateColumns = false;
            this.dataGridViewP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.tipoProvDataGridViewTextBoxColumn});
            this.dataGridViewP.DataSource = this.proovedoresBindingSource;
            this.dataGridViewP.Location = new System.Drawing.Point(779, 100);
            this.dataGridViewP.Name = "dataGridViewP";
            this.dataGridViewP.ReadOnly = true;
            this.dataGridViewP.Size = new System.Drawing.Size(548, 557);
            this.dataGridViewP.TabIndex = 21;
            this.dataGridViewP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoProvDataGridViewTextBoxColumn
            // 
            this.tipoProvDataGridViewTextBoxColumn.DataPropertyName = "TipoProv";
            this.tipoProvDataGridViewTextBoxColumn.HeaderText = "TipoProv";
            this.tipoProvDataGridViewTextBoxColumn.Name = "tipoProvDataGridViewTextBoxColumn";
            this.tipoProvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proovedoresBindingSource
            // 
            this.proovedoresBindingSource.DataMember = "Proovedores";
            this.proovedoresBindingSource.DataSource = this.dataSetProovedores;
            // 
            // dataSetProovedores
            // 
            this.dataSetProovedores.DataSetName = "DataSetProovedores";
            this.dataSetProovedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(860, 61);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(248, 31);
            this.textBox4.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(774, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Filtrar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureAceptarM);
            this.groupBox3.Controls.Add(this.textTipoPM);
            this.groupBox3.Controls.Add(this.textNombrePM);
            this.groupBox3.Controls.Add(this.textCodigoPM);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(17, 416);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(449, 179);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modificar";
            // 
            // pictureAceptarM
            // 
            this.pictureAceptarM.Image = global::ControlSoft.Properties.Resources.cheque;
            this.pictureAceptarM.Location = new System.Drawing.Point(388, 136);
            this.pictureAceptarM.Name = "pictureAceptarM";
            this.pictureAceptarM.Size = new System.Drawing.Size(40, 34);
            this.pictureAceptarM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAceptarM.TabIndex = 6;
            this.pictureAceptarM.TabStop = false;
            this.pictureAceptarM.Click += new System.EventHandler(this.pictureAceptarM_Click);
            // 
            // textTipoPM
            // 
            this.textTipoPM.Location = new System.Drawing.Point(180, 101);
            this.textTipoPM.Name = "textTipoPM";
            this.textTipoPM.Size = new System.Drawing.Size(248, 29);
            this.textTipoPM.TabIndex = 5;
            // 
            // textNombrePM
            // 
            this.textNombrePM.Location = new System.Drawing.Point(180, 65);
            this.textNombrePM.Name = "textNombrePM";
            this.textNombrePM.Size = new System.Drawing.Size(248, 29);
            this.textNombrePM.TabIndex = 4;
            // 
            // textCodigoPM
            // 
            this.textCodigoPM.Location = new System.Drawing.Point(180, 30);
            this.textCodigoPM.Name = "textCodigoPM";
            this.textCodigoPM.Size = new System.Drawing.Size(248, 29);
            this.textCodigoPM.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tipo de proovedor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nombre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Codigo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureAceptarB);
            this.groupBox2.Controls.Add(this.textCodigoPB);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 113);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Baja";
            // 
            // pictureAceptarB
            // 
            this.pictureAceptarB.Image = global::ControlSoft.Properties.Resources.cheque;
            this.pictureAceptarB.Location = new System.Drawing.Point(388, 72);
            this.pictureAceptarB.Name = "pictureAceptarB";
            this.pictureAceptarB.Size = new System.Drawing.Size(40, 34);
            this.pictureAceptarB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAceptarB.TabIndex = 6;
            this.pictureAceptarB.TabStop = false;
            this.pictureAceptarB.Click += new System.EventHandler(this.pictureAceptarB_Click);
            // 
            // textCodigoPB
            // 
            this.textCodigoPB.Location = new System.Drawing.Point(180, 37);
            this.textCodigoPB.Name = "textCodigoPB";
            this.textCodigoPB.Size = new System.Drawing.Size(248, 29);
            this.textCodigoPB.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Codigo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textCodigoPA);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.pictureAceptarA);
            this.groupBox1.Controls.Add(this.textTipoPA);
            this.groupBox1.Controls.Add(this.textNombrePA);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 174);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta";
            // 
            // textCodigoPA
            // 
            this.textCodigoPA.Location = new System.Drawing.Point(180, 25);
            this.textCodigoPA.Name = "textCodigoPA";
            this.textCodigoPA.Size = new System.Drawing.Size(248, 29);
            this.textCodigoPA.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Codigo";
            // 
            // pictureAceptarA
            // 
            this.pictureAceptarA.Image = global::ControlSoft.Properties.Resources.cheque;
            this.pictureAceptarA.Location = new System.Drawing.Point(388, 132);
            this.pictureAceptarA.Name = "pictureAceptarA";
            this.pictureAceptarA.Size = new System.Drawing.Size(40, 34);
            this.pictureAceptarA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAceptarA.TabIndex = 6;
            this.pictureAceptarA.TabStop = false;
            this.pictureAceptarA.Click += new System.EventHandler(this.pictureAceptarA_Click);
            // 
            // textTipoPA
            // 
            this.textTipoPA.Location = new System.Drawing.Point(180, 97);
            this.textTipoPA.Name = "textTipoPA";
            this.textTipoPA.Size = new System.Drawing.Size(248, 29);
            this.textTipoPA.TabIndex = 5;
            // 
            // textNombrePA
            // 
            this.textNombrePA.Location = new System.Drawing.Point(180, 62);
            this.textNombrePA.Name = "textNombrePA";
            this.textNombrePA.Size = new System.Drawing.Size(248, 29);
            this.textNombrePA.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo de proovedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Proovedores";
            // 
            // proovedoresTableAdapter
            // 
            this.proovedoresTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip2.TabIndex = 23;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proovedoresToolStripMenuItem,
            this.ordenesDeCompraToolStripMenuItem,
            this.facturasToolStripMenuItem,
            this.cotizacionesToolStripMenuItem,
            this.atrasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // proovedoresToolStripMenuItem
            // 
            this.proovedoresToolStripMenuItem.Name = "proovedoresToolStripMenuItem";
            this.proovedoresToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.proovedoresToolStripMenuItem.Text = "Clientes";
            this.proovedoresToolStripMenuItem.Click += new System.EventHandler(this.proovedoresToolStripMenuItem_Click);
            // 
            // ordenesDeCompraToolStripMenuItem
            // 
            this.ordenesDeCompraToolStripMenuItem.Name = "ordenesDeCompraToolStripMenuItem";
            this.ordenesDeCompraToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ordenesDeCompraToolStripMenuItem.Text = "Ordenes de compra";
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.facturasToolStripMenuItem.Text = "Facturas";
            // 
            // cotizacionesToolStripMenuItem
            // 
            this.cotizacionesToolStripMenuItem.Name = "cotizacionesToolStripMenuItem";
            this.cotizacionesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cotizacionesToolStripMenuItem.Text = "Cotizaciones";
            // 
            // atrasToolStripMenuItem
            // 
            this.atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            this.atrasToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.atrasToolStripMenuItem.Text = "Atras";
            this.atrasToolStripMenuItem.Click += new System.EventHandler(this.atrasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ControlSoft.Properties.Resources.recargar;
            this.pictureBox5.Location = new System.Drawing.Point(1292, 63);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 29);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControlSoft.Properties.Resources.proovedor;
            this.pictureBox1.Location = new System.Drawing.Point(152, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(472, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 36);
            this.button1.TabIndex = 24;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Proovedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.dataGridViewP);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Proovedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proovedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Proovedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proovedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProovedores)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAceptarM)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAceptarB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAceptarA)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewP;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureAceptarM;
        private System.Windows.Forms.TextBox textTipoPM;
        private System.Windows.Forms.TextBox textNombrePM;
        private System.Windows.Forms.TextBox textCodigoPM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureAceptarB;
        private System.Windows.Forms.TextBox textCodigoPB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textCodigoPA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureAceptarA;
        private System.Windows.Forms.TextBox textTipoPA;
        private System.Windows.Forms.TextBox textNombrePA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private DataSetProovedores dataSetProovedores;
        private System.Windows.Forms.BindingSource proovedoresBindingSource;
        private DataSetProovedoresTableAdapters.ProovedoresTableAdapter proovedoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProvDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proovedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}