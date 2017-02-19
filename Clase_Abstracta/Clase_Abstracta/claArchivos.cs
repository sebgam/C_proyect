using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Abstracta
{
    public class claArchivos:intSalidas
    {
        public void ImprimeCliente(clsAbsClinetes cliente)
        {
            StreamWriter ar = new StreamWriter(@"C:\Users\user\Downloads\Compressed\ArchivoVitacora.log",true);

            cliente.Nombre = "sebas";
            cliente.Clave = "clave123";


           ar.WriteLine("tu nombre es: " + cliente.Nombre);
           ar.WriteLine("y tu clave es: " + cliente.Clave);

            ar.Close();




        }

        public void ImprimeDireccion(clsDirecciones direccion)
        {

        }



    }
}
