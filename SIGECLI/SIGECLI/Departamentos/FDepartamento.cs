using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIGECLI.Departamentos;

namespace SIGECLI.Clientes
{
    public partial class FDepartamento : Form
    {
        private claseDepartamento departamento;
        public FDepartamento()
        {
            InitializeComponent();
            departamento = new claseDepartamento();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FFiltros buscar = new FFiltros();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                departamento = buscar.Departamento;
                Cargar_Datos();
            }
            else
            {
                MessageBox.Show("Se cancelo la busqueda");
            }
            buscar.Dispose();
        }
        private void Cargar_Datos()
        {
            txtCodigo.Text = departamento.Codigo;
            txtNombre.Text = departamento.Nombre;
            chbHabilitado.Checked = departamento.Habilitado;
        }
    }
}
