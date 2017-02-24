using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goto
{
    class Program
    {
        static void Main(string[] args)
        {
            ventana ventana1 = new ventana();

            ventana1.cerrar();
            
            ventana1.minimizar();

            Console.ReadKey();
        }
    }


    class ventana
    {
        //atributos
        public int ancho,altura; 
        private string color;


        //constructor

        public ventana()
        {
            ancho = 20;
            altura = 50;
            color = "rojo";
        } 




        //metodos
        public void cerrar()
        {
            Console.WriteLine("la ventana se cerro y el color es " + color);
            

        }

        public void minimizar()
        {
            ancho = ancho * 2;
            Console.WriteLine("se minimizo y su ancho es " + ancho);
        }

        public void maximizar()
        {
            Console.WriteLine("se maximizo");
        }

        ~ventana()
        {
            System.Diagnostics.Trace.WriteLine("se destruyeron los recursos");
        }

    }







}
