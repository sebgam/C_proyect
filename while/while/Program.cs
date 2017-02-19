using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_1
{
    class Program
    {
        static void Main(string[] args)
        {
            claArchivos archivo = new claArchivos();
            clsClientesConContacto cliente = new clsClientesConContacto();
            clsDirecciones direccion = new clsDirecciones();
            clsImpresion imprimir = new clsImpresion();

            Console.WriteLine("presiona 1 para crear archivo y 2 para verlo en pantalla:");
            string comando = Console.ReadLine();

            if (comando == "1")
            {
                archivo.ImprimeCliente(cliente);
            }
            else
            {
                imprimir.ImprimeCliente(cliente);
                imprimir.ImprimeDireccion(direccion);
            }


        }
    }
}
