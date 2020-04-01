using SIGECLI.Clientes;
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
    public partial class Form1 : Form
    {
        claseConexion c;
        private claseListaDepartamentos departamentos;
        //BindingSource origen;
        public Form1()
        {
            InitializeComponent();
            c = new claseConexion();
            departamentos = new claseListaDepartamentos();
            //origen = new BindingSource();
            //origen.DataSource = departamentos;
            //dataGridView1.AutoGenerateColumns = false;
            //dataGridView1.DataSource = ;
            //dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.conectar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable t = c.consulta(string.Format("SELECT iddepartamento, codigoDepartamento, nombreDepartamento, habilitado FROM sigecli.departamentos;"));
            if (t.Rows.Count > 0)
            {
                MessageBox.Show("Si hay");
            }
            else 
            {
                MessageBox.Show("No hay");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c.IUD(string.Format("insert into departamentos (codigoDepartamento, nombreDepartamento) value('01', 'ATLANTIDA')"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable t1 = departamentos.SQL(String.Format("SELECT iddepartamento, codigoDepartamento, nombreDepartamento, habilitado FROM sigecli.departamentos"));
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = t1;
            dataGridView1.Refresh();
            

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            comboBox1.Text = "";
            comboBox1.DataSource = null;
            DataTable t2 = departamentos.SQL(String.Format("SELECT idciudad,idDepartamento, nombreCiudad, habilitado FROM sigecli.ciudades where idDepartamento={0}", dataGridView1.CurrentRow.Cells[0].Value));
            if (t2.Rows.Count > 0)
            {
                comboBox1.DataSource = t2;
                comboBox1.DisplayMember = "nombreCiudad";
                comboBox1.ValueMember = "idciudad";
            }
            else
            {
                MessageBox.Show("No existen ciudades en este departamento");
            }
            
        }

        private void btnFormulario_Click(object sender, EventArgs e)
        {
            
        }
    }
}
