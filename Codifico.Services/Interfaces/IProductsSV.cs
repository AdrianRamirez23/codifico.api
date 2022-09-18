using Codifico.Models.DTO;
using Codifico.Models.RTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codifico.Services.Interfaces
{
    public interface IProductsSV
    {
        List<Product> GetProducts();
        void AddNewOrder(OrderNew orderNew);
    }
}
