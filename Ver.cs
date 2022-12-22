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
    public partial class Ver : Form
    {
        public Ver()
        {
            InitializeComponent();
        }

        private void checkBoxModificar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxModificar.Checked)
            {
                btnModificar.Visible = true;
            }
            else
            {
                btnModificar.Visible = false;
            }
        }

        private void checkBoxEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEliminar.Checked)
            {
                btnEliminar.Visible = true;
            }
            else
            {
                btnEliminar.Visible = false;

            }
        }

        private void pictureSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textCorreoM_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //MODIFICAR
            this.clientesTableAdapter.ModificarC(textCodigoM.Text, textEmpresaM.Text, textGiroM.Text, textRFCM.Text, 
                textNombreM.Text, textTelefonoM.Text, textCorreoM.Text,textCodigoM.Text);
            MessageBox.Show("Cliente Modificado", "AVISO");
        }

        private void Ver_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetClientesN.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.dataSetClientesN.Clientes);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //ELIMINAR
            this.clientesTableAdapter.EliminarC(textCodigoM.Text);
        }
    }
}
