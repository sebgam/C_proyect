using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1=0, valor2=0;

            string cadena;

            Console.WriteLine("dame el primer valor");
            cadena = Console.ReadLine();
            valor1 = Convert.ToInt32(cadena);
            Console.WriteLine("dame el siguiente valor");
            cadena = Console.ReadLine();
            valor2 = Convert.ToInt32(cadena);

            
  
           if (valor1 <= valor2)
            {
                if (valor1 == valor2)
                {
                    Console.WriteLine("los valores son iguales");
                }else { 
                Console.WriteLine("el valor 2 es mayor o igual al valor 1");
                        }
             }

            else
            { 
                Console.WriteLine("el valor 1 es mayor que el valor 2");
            }
            Console.Read();



        }
    }
}
