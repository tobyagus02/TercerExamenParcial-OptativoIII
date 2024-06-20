using Repository.Sucursal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Logica
{
    public class SucursalService
    {

        private SucursalService sucursalRepository;
        public SucursalService(String connectionString)
        {
            sucursalRepository = new SucursalService(connectionString);

        }

        public bool add(SucursalModel sucursal)
        {
            if (validarDatos(sucursal))
                return sucursalRepository.add(sucursal);
            else
                throw new Exception("Error en la validación de sucursal, favor corrobore");
        }

        private bool validarDatos(SucursalModel sucursal)
        {
            if (sucursal == null)
                return false;
            if (string.IsNullOrEmpty(sucursal.Descripcion))
                return false;
            if (string.IsNullOrEmpty(sucursal.Direccion))
                return false;
            if (string.IsNullOrEmpty(sucursal.Telefono))
                return false;
            if (string.IsNullOrEmpty(sucursal.Whatsapp))
                return false;
            if (string.IsNullOrEmpty(sucursal.Mail))
                return false;
            if (string.IsNullOrEmpty(sucursal.Estado))
                return false;

            return true;
        }
    }
}
