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
            txtCodigo.Focus();
            SendKeys.Send("{Tab}");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (btnGuardar.Text == "Guardar")
            {
                if (Validar())
                {
                    departamento.Codigo = txtCodigo.Text;
                    departamento.Nombre = txtNombre.Text;
                    departamento.Habilitado = chbHabilitado.Checked;
                    if (departamento.Guardar())
                    {
                        MessageBox.Show("Registro guardado correctamente", "Departamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(string.Format("Error\n{0}", departamento.Error.ToString()), "Departamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Se cancelo la edición");
                
            }
            limpiar();
        }
        private void limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            chbHabilitado.Checked = true;
            btnGuardar.Text = "Guardar";
            btnModificar.Enabled = false;
            txtCodigo.Enabled = true;
            txtCodigo.Focus();
        }
        private Boolean Validar()
        {
            Boolean r = true;
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Escriba el codigo del departamento", "Departamento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                r = false;
            }
            else if (txtNombre.Text == "")
            {
                MessageBox.Show("Escriba el nombre del departamento", "Departamento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                r = false;
            }
            else if (departamento.BuscarCodigo(txtCodigo.Text))
            {
                MessageBox.Show(string.Format("Ya existe el codigo del departamento\n{0}\t{1}", departamento.Codigo, departamento.Nombre));
                r = false;
            }
            else if (departamento.BuscarNombre(txtNombre.Text))
            {
                MessageBox.Show(string.Format("Ya existe el nombre del departamento\n{0}\t{1}", departamento.Codigo, departamento.Nombre));
                r = false;
            }
            else
                r = true;
            return r;
            
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (departamento.BuscarCodigo(txtCodigo.Text))
            {
                txtNombre.Text = departamento.Nombre;
                chbHabilitado.Checked = departamento.Habilitado;
                txtCodigo.Enabled = false;
                btnGuardar.Text = "Cancelar";
                btnModificar.Enabled = true;
            }
            else
            {
                txtCodigo.Enabled = true;
                btnGuardar.Text = "Guardar";
                btnModificar.Enabled = false;

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarModificar())
            {
                departamento.Codigo = txtCodigo.Text;
                departamento.Nombre = txtNombre.Text;
                departamento.Habilitado = chbHabilitado.Checked;
                if (departamento.Modificar())
                {
                    MessageBox.Show("Registro actulizado correctamente", "Departamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(string.Format("Error\n{0}", departamento.Error.ToString()), "Departamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                limpiar();
            }
            
        }
        private Boolean ValidarModificar()
        {
            Boolean r = true;
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Escriba el codigo del departamento", "Departamento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                r = false;
            }
            else if (txtNombre.Text == "")
            {
                MessageBox.Show("Escriba el nombre del departamento", "Departamento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                r = false;
            }
            else if (!departamento.BuscarCodigo(txtCodigo.Text))
            {
                MessageBox.Show(string.Format("No existe el codigo del departamento\n{0}\t{1}", departamento.Codigo, departamento.Nombre));
                r = false;
            }
            else if (departamento.BuscarNombre(txtNombre.Text))
            {
                if (MessageBox.Show(string.Format("Ya existe el nombre del departamento con este nombre\n{0}\t{1}\n¿Desea Continuar?", departamento.Codigo, departamento.Nombre), "Modificar Departamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    r = true;
                }
                else
                {
                    r = false;
                }
            }
            else
                r = true;
            return r;
        }

    }
}
