﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlSoft
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void Alta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetClientesN.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.dataSetClientesN.Clientes);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           this.clientesTableAdapter.GuardarC(textCodigo.Text, textEmpresa.Text, textGiro.Text, textRFCC.Text, textNombreC.Text, textTelefonoC.Text, textCorreoC.Text);
            this.Dispose(); 
        }

       
    }
}