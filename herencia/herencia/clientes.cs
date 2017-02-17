using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    public class clientes
    {
        private int _idCliente;
        private string _nombres;
        private string _apellidos;

        public int IdCliente
        {
            get
            {
                return _idCliente;
            }

            set
            {
                _idCliente = value + 100 ;
            }
        }

        public string Nombres
        {
            get
            {
                return _nombres;
            }

            set
            {
                _nombres = "eres " + value  ;
            }
        }

        public string Apellidos
        {
            get
            {
                return _apellidos;
            }

            set
            {
                _apellidos = value;
            }
        }
    }
}
