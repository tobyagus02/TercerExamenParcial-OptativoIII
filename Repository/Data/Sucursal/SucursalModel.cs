﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Sucursal
{
    public class SucursalModel
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Whatsapp { get; set; }
        public string Mail { get; set; }
        public string Estado { get; set; }

    }
}
