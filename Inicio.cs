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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            Fecha.Text = DateTime.Now.ToString("d");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string v = DateTime.Now.ToString("t");
            Hora.Text = v;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();
            c.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proovedores p = new Proovedores();
            p.Show();
            this.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
}
