using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIGECLI
{
    public class claseCliente
    {
        private int idcliente;
        private string identidad;
        private string nombre;
        private DateTime fechanacimiento;
        private string genero;
        private string estadocivil;
        private string direccion;
        private int ciudad;
        private int departamento;
        private string nombredepartamento;
        private string nombreciudad;

        public claseCliente()
        {
            idcliente = 0;
            identidad = "";
            nombre = "";
            fechanacimiento = DateTime.Today;
            genero = "";
            estadocivil = "";
            direccion = "";
            ciudad = 0;
            departamento = 0;
            nombredepartamento = "";
            nombreciudad = "";
        }

        public claseCliente(string ide, string nom, DateTime fec, string gen, string est, string dir, int ciu,int dep)
        {
            idcliente = 0;
            identidad = ide;
            nombre = nom;
            fechanacimiento = fec;
            genero = gen;
            estadocivil = est;
            direccion = dir;
            ciudad = ciu;
            departamento = dep;
            nombredepartamento = "";
            nombreciudad = "";
        }

        public int IdCliente
        {
            get => idcliente;
        }

        public string Identidad
        {
            get => identidad;
            set
            {
                identidad = value;
            }
        }

        public string Nombre
        {
            get => nombre;
            set
            {
                nombre = value;
            }
        }

        public DateTime FechaNacimento
        {
            get => fechanacimiento;
            set
            {
                fechanacimiento = value;
            }
        }

        public string Genero
        {
            get => genero;
            set
            {
                genero = value;
            }
        }

        public string EstadoCivil
        {
            get => estadocivil;
            set
            {
                estadocivil = value;
            }
        }

        public string Direccion
        {
            get => direccion;
            set
            {
                direccion = value;
            }
        }

        public int IdCiudad
        {
            get => ciudad;
            set
            {
                ciudad = value;
            }
        }

        public int IdDepartamento
        {
            get => departamento;
            set
            {
                departamento = value;
            }
        }

        public string NombreDepartamento
        {
            get => nombredepartamento;
        }

        public string NombreCiudad
        {
            get => nombreciudad;
            
        }

        public void Guardar()
        {
            throw new System.NotImplementedException();
        }

        public void Eliminar()
        {
            throw new System.NotImplementedException();
        }

        public void BuscarID()
        {
            throw new System.NotImplementedException();
        }

        public void BuscarNombre()
        {
            throw new System.NotImplementedException();
        }

        public void Actualizar()
        {
            throw new System.NotImplementedException();
        }
    }
}