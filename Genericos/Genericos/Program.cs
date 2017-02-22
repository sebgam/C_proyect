using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "";
            List<clsClientesBase> clientes;
            clientes = new List<clsClientesBase>();


            while (opcion !="s")
            {
                Console.WriteLine("Opciones");
                Console.WriteLine("1. agreagr a la lista");
                Console.WriteLine("2.quitar de la lista");
                Console.WriteLine("3. imprimir lista");
                Console.WriteLine();
                Console.WriteLine("s -> salir");

                opcion = Console.ReadLine();

                if (opcion =="a")
                {
                    string cadena = Console.ReadLine();
                    clsClientesBase cliente = new clsClientesBase();
                    cliente.Id = clientes.Count + 1;
                    cliente.Nombre = cadena;
                    clientes.Add(cliente);
                }
                else if (opcion == "b")
                {
                    string cadena = Console.ReadLine();
                    clientes.RemoveAt(Convert.ToInt32(cadena));
                }
                else if(opcion =="c")
                {
                    foreach (clsClientesBase item in clientes)
                    {
                        Console.WriteLine("los datos del cliente sin:");
                        Console.WriteLine(item.Id.ToString() + " " + item.Nombre);
                    }
                }
            }


        }
    }
}
