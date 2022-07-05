using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemas_de_inventarios
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connection.Connect();
            MessageBox.Show("You are now connected to the database");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            ServicioUsuarios servicioUsuarios = new ServicioUsuarios();
            Usuario usuario = servicioUsuarios.GetUsuario(txtUsername.Text, txtPassword.Text);

            MessageBox.Show(usuario.name);

        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsername.Clear();
        }
    }
}
