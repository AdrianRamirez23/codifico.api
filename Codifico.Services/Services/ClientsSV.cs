using Codifico.Models.RTO;
using Codifico.Services.Interfaces;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codifico.Services.Services
{
    
    public class ClientsSV: IClientsSV
    {
        private readonly IConfiguration _config;
        public ClientsSV(IConfiguration config) 
        {
            _config = config;
        }

        public List<Customer> SalesDatePrediction()
        {
            var sp = "dbo.getClients";
            List<Customer> result = null;
           
            using (var con = new SqlConnection(_config.GetConnectionString("ConnectionDB")))
            {
                result = con.Query<Customer>(sp,  commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        public List<ClientOrders> getClientsOrders(int id)
        {
            var sp = "dbo.GetClientOrders";
            List<ClientOrders> result = null;
            var parameters = new { id = id };
            using (var con = new SqlConnection(_config.GetConnectionString("ConnectionDB")))
            {
                result = con.Query<ClientOrders>(sp, parameters ,commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }

    }
}
