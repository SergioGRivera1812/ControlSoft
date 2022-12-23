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
            // TODO: esta línea de código carga datos en la tabla 'dataSetProovedoresN.Proovedores' Puede moverla o quitarla según sea necesario.
            this.proovedoresTableAdapter1.Fill(this.dataSetProovedoresN.Proovedores);
            // TODO: esta línea de código carga datos en la tabla 'dataSetProovedores.Proovedores' Puede moverla o quitarla según sea necesario.
           // this.proovedoresTableAdapter.Fill(this.dataSetProovedores.Proovedores);

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
           
        }

       

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.proovedoresTableAdapter1.Fill(this.dataSetProovedoresN.Proovedores);
        }

        private void pictureAgregar_Click(object sender, EventArgs e)
        {
            AltaP p = new AltaP();
            p.Show();
        }
    }
}
