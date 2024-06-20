﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Productos
{
    public class ProductoModel
    {
        public int id { get; set; }
        public string descripccion { get; set; }
        public string cantidad_minima { get; set; }
        public string cantidad_stock { get; set; }
        public string precio_compra { get; set; }
        public string precio_venta { get; set; }
        public string categoria { get; set; }
        public string marca { get; set; }
        public string estado { get; set; }

    }
}
