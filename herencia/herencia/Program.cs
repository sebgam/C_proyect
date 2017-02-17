using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClientesVentas cliente = new clsClientesVentas();
            cliente.Nombres = "sebastian";
            cliente.IdCliente = 100;
            cliente.Apellidos = "gamboa";
            cliente.Direccion = "pantanos";
            cliente.Colonia = "timana";
            cliente.EsCredito = false;

            string credito;

            if(cliente.EsCredito == true)
            {
                 credito = "si tienes credito";
            }
            else
            {
                credito = "no tienes credito";
            }

            Console.WriteLine(cliente.Nombres + " tu ide es " + cliente.IdCliente + " y actuelamente "+ credito);
            Console.ReadKey();



        }
    }
}


