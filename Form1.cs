using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTP2
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            label1.Text = "Bienvenido, " + Environment.UserName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        clsUsuario usuario = new clsUsuario();
        private void button4_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text.ToString();
            string pass = textBox2.Text.ToString();

            usuario.ValidarUsuario(user, pass);

            if (usuario.estadoConexion == "Usuario EXISTE")
            {
                MessageBox.Show("Inicio de sesión exitoso.");

                usuario.RegistroLogInicioSesion();
            }
            else
            {
                Console.WriteLine(usuario.estadoConexion);
            }
        }
    }
}
