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
        public Form1()
        {
            InitializeComponent();
            c = new claseConexion();
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
    }
}
