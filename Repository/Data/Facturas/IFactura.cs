using Repository.Data.Cliente;
using Repository.Data.Facturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Facturas
{
    public interface IFacturas
    {
        bool add(FacturaModel facturamodel);
        bool update(FacturaModel facturamodel);
        bool delete(int id);
        IEnumerable<FacturaModel> GetAll();
    }
}
