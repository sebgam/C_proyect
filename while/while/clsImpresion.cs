using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_1
{
    public class clsImpresion : intSalidas
    {

        public void ImprimeCliente(clsAbsClinetes cliente)
        {
           
            cliente.Nombre = "sebas";
            cliente.Clave = "clave123";
            

            Console.WriteLine("tu nombre es: " + cliente.Nombre);
            Console.WriteLine("y tu clave es: " + cliente.Clave);
           


        }


        public void ImprimeDireccion(clsDirecciones direccion)
        {

            direccion.Colonia = "timana";
            direccion.Estado = "huila";
            Console.WriteLine("tu casa esta en el municipio de: " + direccion.Colonia);
            Console.WriteLine(" y vives en el departamento del " + direccion.Estado);
            Console.ReadKey();


        }

    }
}
