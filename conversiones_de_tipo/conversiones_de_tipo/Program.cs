using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversiones_de_tipo
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 10;
            decimal x = 12.2m;
            bool bandera = true;
            string cadena = "hola putos";
            DateTime fecha = DateTime.MinValue;
            i = Convert.ToInt32(bandera);
            Console.WriteLine("el valor de i es: {0}", i);
            Console.WriteLine("el valor de x es: $"+ x);
            Console.WriteLine("el valor de bandera es : " + bandera.ToString());
            Console.WriteLine("el valor de cadena es : " + cadena);
            Console.WriteLine("el valo dela fecha es: " + fecha.ToShortDateString());
            Console.Read(); 



        }
    }
}
