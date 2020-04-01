using SIGECLI.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGECLI
{
    public partial class FLogin : Form
    {
        private claseUsuario usuario;
        public FLogin()
        {
            InitializeComponent();
            usuario = new claseUsuario();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" && txtPws.Text == "")
            {
                MessageBox.Show("Debe llenar los campos");
                txtLogin.Focus();
            }
            else
            {
                if (usuario.Login(txtLogin.Text, txtPws.Text))
                {
                    MessageBox.Show("Hola");
                    this.DialogResult = DialogResult.Yes;
                }                
                else
                    MessageBox.Show("El usuario no existe");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        public claseUsuario Usuario
        {
            get { return usuario; }
        }
    }
}
