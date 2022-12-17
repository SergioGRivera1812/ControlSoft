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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetClientes.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.dataSetClientes.Clientes);

        }

        private void pictureAceptarA_Click(object sender, EventArgs e)
        {
            this.clientesTableAdapter.GuardarC(textCodigoA.Text, textNombreA.Text, textGiroA.Text, textRFCA.Text);
            this.clientesTableAdapter.Fill(this.dataSetClientes.Clientes);
        }

        private void pictureAceptarB_Click(object sender, EventArgs e)
        {
            //ELIMINAR
            this.clientesTableAdapter.EliminarC(textCodigoB.Text);
            this.clientesTableAdapter.Fill(this.dataSetClientes.Clientes);
            MessageBox.Show("Cliente Eliminado", "AVISO");
        }

        private void pictureAceptarM_Click(object sender, EventArgs e)
        {
            //MODIFICAR
            this.clientesTableAdapter.ModificarC(textCodigoM.Text,textNombreM.Text, textGiroM.Text, textRFCM.Text,textCodigoM.Text);
            this.clientesTableAdapter.Fill(this.dataSetClientes.Clientes);
            MessageBox.Show("Cliente Modificado", "AVISO");

        }

        private void proovedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proovedores p = new Proovedores();
            p.Show();
            this.Visible=false;
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio i = new Inicio();
            i.Show();
            this.Visible = false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string cod = this.dataGridViewC.SelectedRows[0].Cells[0].Value.ToString();
                string nom = this.dataGridViewC.SelectedRows[0].Cells[1].Value.ToString();
                string gir = this.dataGridViewC.SelectedRows[0].Cells[2].Value.ToString();
                string rfc = this.dataGridViewC.SelectedRows[0].Cells[3].Value.ToString();
                

                textCodigoM.Text = cod;
                textNombreM.Text = nom;
                textGiroM.Text = gir;
                textRFCM.Text = rfc;
                

            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Favor de seleccionar la primera columna para continuar", "AVISO");

            }
        }
    }
}
