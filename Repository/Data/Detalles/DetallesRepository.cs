using Dapper;
using Repository.Data.ConfiguracionesDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Detalles
{
    public class DetallesRepository : IDetalles
    {
        IDbConnection connection;

        public DetallesRepository(string connectionString)
        {

            connection = new ConnectionDB(connectionString).OpenConnection();
        }
        public bool add(DetallesModel detallemodelo)
        {
            try
            {
                connection.Execute("INSERT INTO detalles_factura (id_factura, id_producto, cantidad_producto, subtotal)" +
                    $"Values(@id_factura, @id_producto, @cantidad_producto, @subtotal)", detallemodelo);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<DetallesModel> GetAll()
        {
            return connection.Query<DetallesModel>("SELECT * FROM productos");
        }

        public bool delete(int id)
        {
            connection.Execute($"DELETE FROM detalle_factura WHERE id= {id}");

        }

        public bool update(DetallesModel detallemodel)
        {
            try
            {
                connection.Execute("UPDATE detalle_factura SET " +
                "@id_factura," +
                    " @id_producto, " +
                    " @cantidad_producto," +
                    " @subtotal) " +
                    $"WHERE id = @id", detallemodel);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
