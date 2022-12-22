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
            // TODO: esta línea de código carga datos en la tabla 'dataSetClientesN.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter1.Fill(this.dataSetClientesN.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'dataSetClientes.Clientes' Puede moverla o quitarla según sea necesario.
           // this.clientesTableAdapter.Fill(this.dataSetClientes.Clientes);

        }

        private void pictureAceptarA_Click(object sender, EventArgs e)
        {
           /* if (textCodigoA.Text == String.Empty)
            {
                MessageBox.Show("Campo ID vacio , favor de llenarlo", "AVISO");
            }
            else
            {
                try
                {

                    this.clientesTableAdapter.GuardarC(textCodigoA.Text, textNombreA.Text, textGiroA.Text, textRFCA.Text);
                    this.clientesTableAdapter.Fill(this.dataSetClientes.Clientes);
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("ID duplicado", "AVISO");
                }

            }*/
           
        }

        private void pictureAceptarB_Click(object sender, EventArgs e)
        {
            /*//ELIMINAR
            this.clientesTableAdapter.EliminarC(textCodigoB.Text);
            this.clientesTableAdapter.Fill(this.dataSetClientes.Clientes);
            MessageBox.Show("Cliente Eliminado", "AVISO");*/
        }

        private void pictureAceptarM_Click(object sender, EventArgs e)
        {
            //MODIFICAR
            /*this.clientesTableAdapter.ModificarC(textCodigoM.Text,textNombreM.Text, textGiroM.Text, textRFCM.Text,textCodigoM.Text);
            this.clientesTableAdapter.Fill(this.dataSetClientes.Clientes);
            MessageBox.Show("Cliente Modificado", "AVISO");*/

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
            if (dataGridViewC.Columns[e.ColumnIndex].Name == "Ver")
            {


                string cod = this.dataGridViewC.SelectedRows[0].Cells[0].Value.ToString();
                string emp = this.dataGridViewC.SelectedRows[0].Cells[1].Value.ToString();
                string gir = this.dataGridViewC.SelectedRows[0].Cells[2].Value.ToString();
                string rfc = this.dataGridViewC.SelectedRows[0].Cells[3].Value.ToString();
                string nomb = this.dataGridViewC.SelectedRows[0].Cells[4].Value.ToString();
                string tel = this.dataGridViewC.SelectedRows[0].Cells[5].Value.ToString();
                string corr = this.dataGridViewC.SelectedRows[0].Cells[6].Value.ToString();


                Ver v = new Ver();
                v.Show();
                v.textCodigoM.Text = cod;
                v.textEmpresaM.Text = emp;
                v.textGiroM.Text = gir;
                v.textRFCM.Text = rfc;
                v.textNombreM.Text = nomb;
                v.textTelefonoM.Text = tel;
                v.textCorreoM.Text = corr;
                
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
    /*        textCodigoA.Text = "";
            textNombreA.Text = "";
            textGiroA.Text = "";
            textRFCA.Text = "";
            textCodigoM.Text = "";
            textNombreM.Text = "";
            textGiroM.Text = "";
            textRFCM.Text = "";
            textCodigoB.Text = "";
    */
        }

        private void pictureAgregar_Click(object sender, EventArgs e)
        {
            Alta a = new Alta();
            a.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.clientesTableAdapter1.Fill(this.dataSetClientesN.Clientes);
        }
    }
}
