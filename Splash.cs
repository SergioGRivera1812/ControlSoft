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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = "Admin";
            string pass = "control";

            if (textUsuario.Text == usuario && textpass.Text == "control"){
                Inicio i = new Inicio();
                i.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos", "AVISO");
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
    }
}
