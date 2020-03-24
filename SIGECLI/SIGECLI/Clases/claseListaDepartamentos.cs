using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace SIGECLI
{
    public class claseListaDepartamentos
    {
        private List<claseDepartamento> departamentos;
        private claseConexion conexion;
        private DataTable tabla;
        public claseListaDepartamentos()
        {
            departamentos = new List<claseDepartamento>();
            conexion = new claseConexion();
            tabla = new DataTable();
            Cargar_Datos();
        }
        public void Cargar_Datos()
        {
            conexion.conectar();
            tabla = conexion.consulta(string.Format("SELECT iddepartamento, codigoDepartamento, nombreDepartamento, habilitado FROM sigecli.departamentos"));
            foreach (DataRow f in tabla.Rows)
            {
                claseDepartamento d = new claseDepartamento();
                d.IdDepartamento = f.Field<int>(0);
                d.Codigo = f.Field<string>(1);
                d.Nombre = f.Field<string>(2);
                d.Habilitado = f.Field<Boolean>(3);
                departamentos.Add(d);
            }
        }
        public List<claseDepartamento> ListaDepartamentos
        {
            get
            {
                return ListaDepartamentos;
            }
        }
        public DataTable Tabla
        {
            get { return tabla; }
        }
        public DataTable SQL(string sql)
        {
            DataTable t = conexion.consulta(sql);
            return t;
        }
    }
}