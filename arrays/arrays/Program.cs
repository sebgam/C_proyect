using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arreglo = new int[4];

            Console.WriteLine(" escriba numero a incrementar:");


            int cadena = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("resultado:");
            for (int i = 0; i < 4; i++)
            {
                arreglo[i] = cadena + i;
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(arreglo[i]);
            }

            Console.ReadKey();
        }
       }
    }

