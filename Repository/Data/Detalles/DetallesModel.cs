using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Detalles
{
    public class DetallesModel
    {
        public string id_modelo { get; set; }
        public string id_factura { get; set; }
        public string id_producto { get; set; }
        public string cantidad_producto { get; set; }
        public string subtotal { get; set; }

    }
}
