using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_1
{
    public class clsMuestraHasMap
    {
        Hashtable tabla;

        public clsMuestraHasMap()
        {
            tabla = new Hashtable();
        }

        public void agregarDatos()
        {
            tabla.Add("c001", "producto 1 ");
            tabla.Add("c002", "producto 2 ");
            tabla.Add("c003", "producto 3 ");
            tabla.Add("c004", "producto 4 ");
        }

        public void imprimirDatos()
        {
            Console.WriteLine("existen {0} elementos clave:", tabla.Count);
            string cadena = Console.ReadLine();
            if(tabla[cadena] == null)
            {
                Console.WriteLine("no existe valor");
            }else
            {
                Console.WriteLine("el elemento encontrado es: ");
                Console.WriteLine(tabla[cadena]);
            }
           
            Console.ReadKey();
        }

        public void eliminar(string key)
        {
            tabla.Remove(key);
        }

    }
}
