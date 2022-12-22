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
