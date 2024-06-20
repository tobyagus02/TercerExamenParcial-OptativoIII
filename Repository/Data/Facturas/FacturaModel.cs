using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Facturas
{
    public class FacturaModel
    {
        public int Id { get; set; }
        public string Nro_Factura { get; set; }
        public DateTime Fecha_Hora { get; set; }
        public string Total { get; set; }
        public string Total_iva5 { get; set; }
        public string Total_iva10 { get; set; }
        public string Total_iva { get; set; }
        public string Total_letras { get; set; }
        public string Sucursal { get; set; }

    }
}
