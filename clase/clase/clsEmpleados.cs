using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase
{
    public class clsEmpleados
    {

        public clsEmpleados()
        {
            nombre = "";
            SueldoDiario = 0.0m;
            edad = 0;
        }

        private string _nombre;
        public decimal SueldoDiario;
        public int edad;

        public string nombre
        {
            get {return _nombre;}
            set{_nombre = value;}
        }


        

        public decimal calculaSalario(int numeroDias)
        {

            return SueldoDiario * numeroDias;

        }


    }
}
