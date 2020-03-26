using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGECLI.Departamentos
{
    public partial class FFiltros : Form
    {
        private claseListaDepartamentos departamentos;
        private claseDepartamento departamento;
        public FFiltros()
        {
            InitializeComponent();
            departamentos = new claseListaDepartamentos();
            departamento = new claseDepartamento();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltro.Text != "")
            {
                Cargar_Datos();
            }
        }
        private void Cargar_Datos()
        {
            string sql = "";
            if (rabHabilitado.Checked)
            {
                sql = string.Format("SELECT iddepartamento, codigoDepartamento, nombreDepartamento, habilitado FROM sigecli.departamentos where habilitado={0} and (codigoDepartamento like '%{1}%' or nombreDepartamento like '%{1}%')", true, txtFiltro.Text);
            }
            else if (rabDeshabilitado.Checked)
            {
                sql = string.Format("SELECT iddepartamento, codigoDepartamento, nombreDepartamento, habilitado FROM sigecli.departamentos where habilitado={0} and (codigoDepartamento like '%{1}%' or nombreDepartamento like '%{1}%')", false, txtFiltro.Text);
            }
            else
            {
                sql = string.Format("SELECT iddepartamento, codigoDepartamento, nombreDepartamento, habilitado FROM sigecli.departamentos where codigoDepartamento like '%{0}%' or nombreDepartamento like '%{0}%'", txtFiltro.Text);
            }
            DataTable t1 = departamentos.SQL(sql);
            dgvDepartamentos.DataSource = null;
            dgvDepartamentos.DataSource = t1;
            dgvDepartamentos.Refresh();
        }

        private void rabHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            Cargar_Datos();
        }

        private void rabDeshabilitado_CheckedChanged(object sender, EventArgs e)
        {
            Cargar_Datos();
        }

        private void rabTodos_CheckedChanged(object sender, EventArgs e)
        {
            Cargar_Datos();
        }

        private void dgvDepartamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            departamento.IdDepartamento = Convert.ToInt32( dgvDepartamentos.CurrentRow.Cells[0].Value);
            departamento.Codigo = dgvDepartamentos.CurrentRow.Cells[1].Value.ToString();
            departamento.Nombre = dgvDepartamentos.CurrentRow.Cells[2].Value.ToString();
            departamento.Habilitado = Convert.ToBoolean( dgvDepartamentos.CurrentRow.Cells[3].Value);
            this.DialogResult = DialogResult.OK;
        }
        public claseDepartamento Departamento
        {
            get { return departamento; }
        }
    }
}
