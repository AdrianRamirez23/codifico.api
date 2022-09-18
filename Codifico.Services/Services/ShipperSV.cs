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
    public class ShipperSV: IShipperSV
    {
        private readonly IConfiguration _config;
        public ShipperSV(IConfiguration config)
        {
            _config = config;
        }
        public List<Shippers> GetShippers()
        {
            var sp = "dbo.GetShipper";
            List<Shippers> result = null;

            using (var con = new SqlConnection(_config.GetConnectionString("ConnectionDB")))
            {
                result = con.Query<Shippers>(sp, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
    }
}
