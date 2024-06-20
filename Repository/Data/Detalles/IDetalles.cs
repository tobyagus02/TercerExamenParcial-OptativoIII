using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Detalles
{
    internal interface IDetalles
    {
        bool add(DetallesModel detallemodel);
        bool update(DetallesModel detallemodel);
        bool delete(int id);
        IEnumerable<DetallesModel> GetALL();



    }
}
