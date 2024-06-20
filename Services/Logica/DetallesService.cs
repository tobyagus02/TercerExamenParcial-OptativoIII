using Repository.Data.Detalles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Logica
{
    public class DetallesService
    {
        private DetallesRepository detallesRepository;
        public DetallesService(string connectionString)
        {
            detallesRepository = new DetallesRepository(connectionString);
        }

        public bool add(DetallesModel detalle)
        {
            return Validardatosdetalle(detalle) ? detallesRepository.add(detalle) : throw new Exception("Error de datos Corroborar");


        }
        public IEnumerable<DetallesModel> GetAll()
        {
            return detallesRepository.GetAll();
        }
        public bool delete(int id)
        {
            return id > 0 ? detallesRepository.delete(id) : false;
        }

        public bool update(DetallesModel detallemodel)
        {
            return Validardatosdetalle(detallemodel) ? detallesRepository.update(detallemodel) : throw new Exception("Error de Validacion de datos corroborar");
        }


        private bool Validardatosdetalle(DetallesModel detalle)
        {

            if (string.IsNullOrEmpty(detalle.id_factura)) return false;
            if (string.IsNullOrEmpty(detalle.id_producto)) return false;
            if (string.IsNullOrEmpty(detalle.cantidad_producto)) return false;
            if (string.IsNullOrEmpty(detalle.subtotal)) return false;


            return true;
        }
    }
}

