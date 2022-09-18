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
    public class EmploySV: IEmploySV
    {
        private readonly IConfiguration _config;
        public EmploySV(IConfiguration config)
        {
            _config = config;
        }
        public List<Employ> GetEmployees()
        {
            var sp = "dbo.GetEmployees";
            List<Employ> result = null;

            using (var con = new SqlConnection(_config.GetConnectionString("ConnectionDB")))
            {
                result = con.Query<Employ>(sp, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
    }
}
