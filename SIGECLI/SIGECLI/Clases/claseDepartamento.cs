using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SIGECLI
{
    public class claseDepartamento
    {
        private int iddepartamento;
        private string codigodepartamento;
        private string nombredepartamento;
        private Boolean habilitado;
        private claseConexion conexion;
        private MySqlException error;
        public claseDepartamento()
        {
            iddepartamento = 0;
            codigodepartamento = "";
            nombredepartamento = "";
            habilitado = true;
            conexion = new claseConexion();
        }
        public claseDepartamento(string c, string n)
        {
            iddepartamento = 0;
            codigodepartamento = c;
            nombredepartamento = n;
            habilitado = true;
            conexion = new claseConexion();
        }
        public Boolean BuscarCodigo(string co)
        {
            DataTable t1 = conexion.consulta(string.Format("SELECT iddepartamento, codigoDepartamento, nombreDepartamento, habilitado FROM sigecli.departamentos where codigoDepartamento='{0}'", co));
            if (t1.Rows.Count > 0)
            {
                iddepartamento = Convert.ToInt32(t1.Rows[0][0].ToString());
                codigodepartamento = t1.Rows[0][1].ToString();
                nombredepartamento = t1.Rows[0][2].ToString();
                habilitado = Convert.ToBoolean(t1.Rows[0][3].ToString());
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean BuscarNombre(string no)
        {
            DataTable t1 = conexion.consulta(string.Format("SELECT iddepartamento, codigoDepartamento, nombreDepartamento, habilitado FROM sigecli.departamentos where nombreDepartamento='{0}'", no));
            if (t1.Rows.Count > 0)
            {
                iddepartamento = Convert.ToInt32(t1.Rows[0][0].ToString());
                codigodepartamento = t1.Rows[0][1].ToString();
                nombredepartamento = t1.Rows[0][2].ToString();
                habilitado = Convert.ToBoolean(t1.Rows[0][3].ToString());
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean BuscarID(int id)
        {
            DataTable t1 = conexion.consulta(string.Format("SELECT iddepartamento, codigoDepartamento, nombreDepartamento, habilitado FROM sigecli.departamentos where iddepartamento={0}", id));
            if (t1.Rows.Count > 0)
            {
                iddepartamento = Convert.ToInt32(t1.Rows[0][0].ToString());
                codigodepartamento = t1.Rows[0][1].ToString();
                nombredepartamento = t1.Rows[0][2].ToString();
                habilitado = Convert.ToBoolean(t1.Rows[0][3].ToString());
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean Guardar()
        {
            if (conexion.IUD(string.Format("INSERT INTO departamentos (codigoDepartamento, nombreDepartamento, habilitado) value('{0}','{1}', {2})", Codigo, Nombre, habilitado)))
            {
                return true;
            }
            else
            {
                error = conexion.Error;
                return false;
            }
        }
        public Boolean Modificar()
        {
            if (conexion.IUD(string.Format("UPDATE departamentos SET nombreDepartamento='{0}', habilitado={1}  WHERE iddepartamento={2}", Nombre, habilitado, iddepartamento)))
            {
                return true;
            }
            else
            {
                error = conexion.Error;
                return false;
            }
        }
        public MySqlException Error
        {
            get { return error; }
        }
        public string Codigo
        {
            get
            {
                return codigodepartamento;
            }
            set {
                codigodepartamento = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombredepartamento;
            }
            set
            {
                nombredepartamento = value;
            }
        }
        public int IdDepartamento
        {
            get
            {
                return iddepartamento;
            }
            set {
                iddepartamento = value;
            }
        }
        public Boolean Habilitado
        {
            get
            {
                return habilitado;
            }
            set
            {
                habilitado = value;
            }
        }
    }
}