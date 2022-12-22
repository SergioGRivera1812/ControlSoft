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
    public partial class Proovedores : Form
    {
        public Proovedores()
        {
            InitializeComponent();
        }

        private void Proovedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetProovedores.Proovedores' Puede moverla o quitarla según sea necesario.
            this.proovedoresTableAdapter.Fill(this.dataSetProovedores.Proovedores);

        }

        private void pictureAceptarA_Click(object sender, EventArgs e)
        {
            //ALTA
            if (textCodigoPA.Text == String.Empty)
            {
                MessageBox.Show("Campo ID vacio , favor de llenarlo", "AVISO");
            }
            else
            {
                try
                {
                    this.proovedoresTableAdapter.GuardarP(textCodigoPA.Text, textNombrePA.Text, textTipoPA.Text);
                    this.proovedoresTableAdapter.Fill(this.dataSetProovedores.Proovedores);

                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("ID duplicado", "AVISO");
                }

            }
            

        }

        private void pictureAceptarB_Click(object sender, EventArgs e)
        {
            //ELIMINAR
            this.proovedoresTableAdapter.EliminarP(textCodigoPB.Text);
            this.proovedoresTableAdapter.Fill(this.dataSetProovedores.Proovedores);
            MessageBox.Show("Proovedor Eliminado", "AVISO");
        }

        private void pictureAceptarM_Click(object sender, EventArgs e)
        {
            //MODIFICAR
            this.proovedoresTableAdapter.ModificarP(textCodigoPA.Text, textNombrePA.Text, textTipoPA.Text,textCodigoPM.Text);
            this.proovedoresTableAdapter.Fill(this.dataSetProovedores.Proovedores);
            MessageBox.Show("Proovedor Modificado", "AVISO");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void proovedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();
            c.Show();
            this.Visible = false;
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio i = new Inicio();
            i.Show();
            this.Visible = false;
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string cod = this.dataGridViewP.SelectedRows[0].Cells[0].Value.ToString();
                string nom = this.dataGridViewP.SelectedRows[0].Cells[1].Value.ToString();
                string tp = this.dataGridViewP.SelectedRows[0].Cells[2].Value.ToString();
                


                textCodigoPM.Text = cod;
                textNombrePM.Text = nom;
                textTipoPM.Text = tp;


            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Favor de seleccionar la primera columna para continuar", "AVISO");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textCodigoPA.Text = "";
            textNombrePA.Text = "";
            textTipoPA.Text = "";
            textCodigoPM.Text = "";
            textNombrePM.Text = "";
            textTipoPM.Text = "";
            textCodigoPB.Text = "";

        }
    }
}
