using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Dapper;
using Repository.Data.Cliente;
using Repository.Data.ConfiguracionesDB;

namespace Repository.Data.Factura
{
    public class ClienteRepository : ICliente  
    {
        IDbConnection connection;
        public ClienteRepository(string connectionString)
        {
            connection = new ConnectionDB(connectionString).OpenConnection();
        }
        public bool add(ClienteModel clienteModel)
        {
            try
            {
                connection.Execute("INSERT INTO Cliente(Nombre, Apellido, Documento, Direccion, Mail, Celular, estado) " +
                    $"Values(@Nombre,@Apellido,@Documento,@Direccion,@Mail,@Celular,@estado )", clienteModel;
                    
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<ClienteModel> GetAll()
        {
            return connection.Query<ClienteModel>("Select * From clientes");
        }

        public bool delete(int id)
        {
            connection.Execute($"Delete From Cliente Where id={id}");
        }
        public bool update(ClienteModel clientemodel)
        {
            try
            {

                connection.Execute("UPDATE INTO cliente Set " +
                    "Nombre=@Nombre" +
                    "Apellido=@Apellido," +
                    "Cedula=@Cedula," +
                    "Documento@Documento," +
                    "Direccion@Direccion," +
                    "Mail@Mail," +
                    "Celular@Celular," +
                    "estado@estado" +
                    $"WERE id=@id", clientemodel);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }
    }
}
