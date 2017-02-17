using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase
{
    class Program
    {
        static void Main(string[] args)
        {

            clsEmpleados empleado = new clsEmpleados();

            empleado.edad = 25;
            empleado.nombre = "sebastian";
            empleado.SueldoDiario = 25000;
          


            int diasLaborados = 30;
            decimal total;

            total = empleado.calculaSalario(diasLaborados);

            Console.WriteLine("el salario del señor " + empleado.nombre + " con " + empleado.edad + " años de edad por dia es de " + empleado.SueldoDiario + " por " + diasLaborados +
                " dias laborados es de $" + total);
            Console.ReadKey();



        }
    }
}


