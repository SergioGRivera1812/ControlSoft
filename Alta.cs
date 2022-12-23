using System;
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
            if (textCodigoP.Text == String.Empty)
             {
                 MessageBox.Show("Campo ID vacio , favor de llenarlo", "AVISO");
             }
             else
             {
                 try
                 {
                    this.clientesTableAdapter.GuardarC(textCodigoP.Text, textEmpresa.Text, textGiro.Text, textRFCC.Text, textNombreC.Text, textTelefonoC.Text, textCorreoC.Text);
                    this.Dispose();
                }
                 catch (System.Data.SqlClient.SqlException)
                 {
                     MessageBox.Show("ID duplicado", "AVISO");
                 }

             }
            
        }

        private void pictureSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
