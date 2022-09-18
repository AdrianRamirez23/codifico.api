using Codifico.Models.DTO;
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
    public class ProductsSV: IProductsSV
    {
        private readonly IConfiguration _config;
        public ProductsSV(IConfiguration config)
        {
            _config = config;
        }
        public List<Product> GetProducts()
        {
            var sp = "dbo.GetProducts";
            List<Product> result = null;

            using (var con = new SqlConnection(_config.GetConnectionString("ConnectionDB")))
            {
                result = con.Query<Product>(sp, commandType: CommandType.StoredProcedure).ToList();
            }
            return result;
        }
        public void AddNewOrder(OrderNew orderNew)
        {
            var sp = "dbo.AddNewOrder";
        
            var parameters = new {
                CustId = orderNew.CustID,
                Empid = orderNew.Empid,
                OrderDate = orderNew.OrderDate,
                RequiredDate = orderNew.RequiredDate,
                Shippeddate = orderNew.Shippeddate,
                ShipperId = orderNew.ShipperId,
                Freight = orderNew.Freigth,
                Shipname = orderNew.Shipname,
                Shipaddress = orderNew.Shipaddress,
                Shipcity = orderNew.Shipcity,
                Shiregion = orderNew.Shiregion,
                Shipppostalcode = orderNew.Shipppostalcode,
                Shipcountry = orderNew.Shipcountry,
                ProductId = orderNew.ProductId,
                UnitPrice = orderNew.UnitPrice,
                qty = orderNew.qty,
                discount = orderNew.discount
            };
            try
            {
                using (var con = new SqlConnection(_config.GetConnectionString("ConnectionDB")))
                {
                    con.Execute(sp, parameters, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {

               
            }
          
           
        }
    }
}
