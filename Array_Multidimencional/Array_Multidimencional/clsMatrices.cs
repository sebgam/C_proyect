using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Multidimencional
{
    public class clsMatrices
    {
        private int[,] matriz;

        public clsMatrices()
        {
            matriz = new int[4, 2];
        }

        public void InicializaMatriz()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matriz[i, j] = i+1;
                }
            }
        }

        public void imprimirMatriz()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0} ", matriz[i,j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

    }

}
