using Codifico.Bussiness.Interfaces;
using Codifico.Models.DTO;
using Codifico.Models.RTO;
using Codifico.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codifico.Bussiness.Bussiness
{
    public class ProductsBS: IProductsBS
    {
        private readonly IProductsSV products;
        public ProductsBS(IProductsSV productsSV)
        {
            products = productsSV;
        }
        public List<Product> GetProducts()
        {
            return products.GetProducts();
        }
        public void AddNewOrder(OrderNew orderNew)
        {
            products.AddNewOrder(orderNew);
        }
    }
}
