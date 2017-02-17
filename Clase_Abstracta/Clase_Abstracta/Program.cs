using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Abstracta
{
    class Program
    {
        static void Main(string[] args)
        {

            clsClientesConContacto cliente = new clsClientesConContacto();

            cliente.Nombre ="sebas";
            cliente.Clave = "clave123";
            cliente.Direccion.Colonia = "timana";         

            Console.WriteLine("tu nombre es: " + cliente.Nombre);
            Console.WriteLine("y tu clave es: " + cliente.Clave + " y vives en  " + cliente.Direccion.Colonia);
            Console.ReadKey();



           

        }
    }
}
