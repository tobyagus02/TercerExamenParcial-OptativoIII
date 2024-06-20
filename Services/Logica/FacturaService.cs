using Repository.Data.Facturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Logica
{
    public class SucursalService
    {

        private SucursalService facturaRepository;
        public SucursalService(String connectionString)
        {
            facturaRepository = new FacturaService(connectionString);
            
        }

        public bool add(FacturaModel factura) 
        {
            if (validarDatos(factura))
                return facturaRepository.add(factura);
            else
                throw new Exception("Error en la validación de factura, favor corrobore");
        }

        private bool validarDatos(FacturaModel factura) 
        {
            if (factura == null)
                return false;
            if (string.IsNullOrEmpty(factura.Nro_Factura))
                return false;
            if (string.IsNullOrEmpty(factura.Total))
                return false;
            if (string.IsNullOrEmpty(factura.Total_iva5))
                return false;
            if (string.IsNullOrEmpty(factura.Total_iva10))
                return false;
            if (string.IsNullOrEmpty(factura.Total_iva))
                return false;
            if (string.IsNullOrEmpty(factura.Total_letras)) 
                return false;
            if (string.IsNullOrEmpty(factura.Sucursal))
                return false;

            return true;
        }
    }
}
