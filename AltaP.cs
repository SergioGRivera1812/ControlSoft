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
    public partial class AltaP : Form
    {
        public AltaP()
        {
            InitializeComponent();
        }

        private void AltaP_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetProovedoresN.Proovedores' Puede moverla o quitarla según sea necesario.
            this.proovedoresTableAdapter.Fill(this.dataSetProovedoresN.Proovedores);

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (textCodigo.Text == String.Empty)
            {
                MessageBox.Show("Campo ID vacio , favor de llenarlo", "AVISO");
            }
            else
            {
                try
                {
                    this.proovedoresTableAdapter.GuardarP(textCodigo.Text, textEmpresa.Text,textGiro.Text,textTipoP.Text,textRFCP.Text,textNombreP.Text,textTelefonoP.Text,textCorreoP.Text);
                    this.Dispose();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("ID duplicado", "AVISO");
                }

            }
        }
    }
}
