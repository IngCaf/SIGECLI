using System;
using System.Collections.Generic;
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
        public claseDepartamento()
        {
            iddepartamento = 0;
            codigodepartamento = "";
            nombredepartamento = "";
            habilitado = true;
        }
        public claseDepartamento(string c, string n)
        {
            iddepartamento = 0;
            codigodepartamento = c;
            nombredepartamento = n;
            habilitado = true;
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