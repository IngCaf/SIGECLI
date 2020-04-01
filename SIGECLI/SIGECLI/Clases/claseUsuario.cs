using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGECLI.Clases
{
    public class claseUsuario
    {
        private int id;
        private string login;
        private string pws;
        private string nombre;
        public claseUsuario()
        {
            id = 0;
            login = "Admin";
            pws = "Admin";
            nombre = "Carlos F";
        }
        public Boolean Login(string l, string p)
        {
            if (l == "Admin" && p == "Admin")
                return true;
            else
                return false;
        }
        public int Id
        {
            get { return id; }
        }
        public string ULogin
        {
            get 
            {
                return login;
            }
            set
            {
                login = value;
            }
        }
        public string Contrasena
        {
            get 
            {
                return pws;
            }
            set
            {
                pws = value;
            }
        }
        public string Nombre
        {
            get { return nombre; }
        }
    }
}
