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
    public partial class FPanel : Form
    {
        private claseUsuario usuario;

        public FPanel()
        {
            InitializeComponent();
            usuario = new claseUsuario();
        }

        private void FPanel_Load(object sender, EventArgs e)
        {
            FLogin fl = new FLogin();
            if (fl.ShowDialog() == DialogResult.Yes)
            {
                MessageBox.Show("Entro");
                usuario = fl.Usuario;
                lblNombreUsuario.Text = usuario.Nombre;
            }
            else
            {
                MessageBox.Show("Se cancelo la operación");
                this.Close();
            }
            fl.Dispose();
        }
    }
}
