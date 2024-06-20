using Npgsql;
using Dapper;
using Repository.Data.Factura;
using Repository.Data.ConfiguracionesDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Repository.Data.Facturas
{
    
    public class FacturaRepository
    {
        IDbConnection connection;
        public FacturaRepository(string connectionString)
        {
            connection = new ConnectionDB(connectionString).OpenConnection();
        }

        public bool add(FacturaModel facturaModel)
        {
            try
            {
                
                connection.Execute("INSERT INTO Factura(nro_factura, fecha_hora, total, total_iva5, total_iva10, total_iva, total_letras, sucursal) " +
                    $"Values(@nro_factura,@fecha_hora,@total,@total_iva5,@total_iva10,@total_iva,@total_letras,@sucursal)", facturaModel);
                    
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<FacturaModel> GetAll()
        {
            return connection.Query<FacturaModel>("SELECT * FROM persona");
        }
        public bool delete(int id)
        {
            connection.Execute($"DELETE FROM factura WHERE id ={id}");
            return true;
        }

        public bool update(FacturaModel facturaModel)
        {
            try
            {
                connection.Execute("UPDATE facturas SET" +
                    " @id_cliente," +
                    " @nro_factura," +
                    " @fecha_hora," +
                    " @total," +
                    " @total_iva5, " +
                    " @total_iva ," +
                    " @total_letras ," +
                    " @sucursal" +
                    $"WHERE id = @id", facturaModel;

                return true;
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }
    }
}


