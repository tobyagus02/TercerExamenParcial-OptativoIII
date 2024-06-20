using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Cliente
{
    public interface ICliente
    {
        bool add(ClienteModel clientemodel);
        bool update(ClienteModel clientesmodelo);
        bool delete(int id);
        IEnumerable<ClienteModel> GetAll();
    }
}
