using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_1
{
    class clsMostrarArrayList
    {
        ArrayList lista;

        public clsMostrarArrayList()
        {
            lista = new ArrayList();

        }

        public void CapturaDatos()
        {
            string cadena;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("dame el dato: " + (i + 1));
                cadena = Console.ReadLine();
                lista.Add(cadena);
            }

            lista.Add(1);
            lista.Add(2);

        }

        public void ImpremDatos()
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }





    }
}
