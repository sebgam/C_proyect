using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_1
{
    public class clsClientesConContacto: clsClientesBase
    {
        public clsClientesConContacto()
        {
            _direccion = new clsDirecciones();
        }

        public clsClientesConContacto(int pId, string pNombre, string pClave, string pRFC, int pTipoRegimen, string pNombreContacto, string pTelefono1, string 
            pTelefono2, string pEmail, string PCalle, string pNumeroExterior, string pNumeroInterior, string pColonia,string pMunicipio, string pEstado, string pCodigoPostal)
        {
            Id = pId;
            Nombre = pNombre;
            Clave = pClave;
            RFC = pRFC;
            TipoRegimen = pTipoRegimen;
            NombreContacto = pNombreContacto;
            telefono1 = pTelefono1;
            telefono2 = pTelefono2;
            email = pEmail;
            Direccion.Calle = PCalle;
            Direccion.NumeroExterior = pNumeroExterior;
            Direccion.NumeroInterior = pNumeroInterior;
            Direccion.Colonia = pColonia;
            Direccion.Municipio = pMunicipio;
            Direccion.Estado = pEstado;
            Direccion.CP = pCodigoPostal;



        }



        public string telefono1 { get; set; }
        public string telefono2 { get; set; }
        public string email { get; set; }

        

        private clsDirecciones _direccion;
        internal clsDirecciones Direccion
        {
            get
            {
                return _direccion;
            }

            set
            {
                _direccion = value;
            }
        }

    }
}
